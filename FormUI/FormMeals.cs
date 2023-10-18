using Entities.Dtos;
using Entities.Enums;
using Krypton.Toolkit;
using Microsoft.EntityFrameworkCore;
using Services.Abstract;
using Services.Concrete;
using System.Data;
using System.Drawing.Drawing2D;

namespace FormUI
{
    public partial class FormMeals : Form
    {

        private static MealTimes selectedMealTime;
        private readonly IFoodService _foodService = new FoodManager();
        private readonly IUserMealService _userMealService = new UserMealManager();
        private readonly IFoodAmountService _foodAmountService = new FoodAmountManager();
        private readonly int _userId;
        private List<MealItemDto> _mealItemToDelete = new List<MealItemDto>();
        private List<MealItemDto> _mealItemToAdd = new List<MealItemDto>();
        private List<FoodNutrionals> _dataSource = new();
        private readonly int _userMealId;

        public FormMeals(int user)
        {
            _userId = user;
            InitializeComponent();
        }

        private void FormMeals_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(32, 191, 107);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(32, 191, 107),
                Color.FromArgb(50, 210, 255),
                360f
            );
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            };
            btn_Search.Enabled = false;
            btn_Save.Enabled = false;
            dgv_SelectedMealList.AllowUserToAddRows = false;
            dgv_SelectedMealList.ReadOnly = true;
            dgv_MealList.ReadOnly = true;
            dgv_MealList.AllowUserToAddRows = false;
            dgv_MealList.AllowUserToAddRows = false;

        }

        private void btn_Breakfast_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Breakfast;
            SetDgvContent();
            ButtonActivities(btn);

        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Lunch;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Dinner;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Snack_Click(object sender, EventArgs e)
        {
            SetButtonStates();
            KryptonButton btn = sender as KryptonButton;
            selectedMealTime = MealTimes.Snack;
            SetDgvContent();
            ButtonActivities(btn);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var data = _foodService.GetFoodNamesContains(txt_Meal_Search.Text.Trim());
            dgv_MealList.DataSource = data.Select(f => new { İsim = f }).ToList();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {

                var userMealId = _userMealService.CreateUserMeal(_userId, selectedMealTime, DateTime.Now);

                if (_mealItemToAdd.Count > 0)
                    _foodAmountService.AddRangeMealItems(_mealItemToAdd, userMealId);

                if (_mealItemToDelete.Count > 0)
                    _foodAmountService.RemoveRangeMealItems(_mealItemToDelete, userMealId);

                _mealItemToDelete.Clear();
                _mealItemToAdd.Clear();

                SetDgvContent();
                dgv_SelectedMealList.Enabled = true;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("You cant add duplicate");
                _mealItemToDelete.Clear();
                _mealItemToAdd.Clear();
                SetDgvContent();
                if (dgv_SelectedMealList.RowCount > 0)
                    dgv_SelectedMealList.Enabled = true;
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dgv_SelectedMealList.Enabled = false;

            if (dgv_MealList.SelectedRows.Count > 0 && dgv_MealList.SelectedRows[0].Cells[0].Value != null)
            {
                var selectedFoodName = dgv_MealList.SelectedRows[0].Cells[0].Value.ToString();

                var foodWithNutrionals = _foodService.GetFoodNutrionals(selectedFoodName, Convert.ToInt32(nud_Amount.Value));

                if (_mealItemToAdd.Any(mi => mi.FoodName == selectedFoodName))
                {
                    MessageBox.Show("You cant add duplicate");
                    return;
                }

                _dataSource.Add(foodWithNutrionals);
                dgv_SelectedMealList.DataSource = null;
                dgv_SelectedMealList.DataSource = _dataSource;

                _mealItemToAdd.Add(new MealItemDto()
                {
                    UserId = _userId,
                    FoodName = selectedFoodName,
                    Gram = Convert.ToInt32(nud_Amount.Value)
                });
            }

            else
                MessageBox.Show("Lütfen Eklenecek  Besini Seçiniz");

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            if (dgv_SelectedMealList.SelectedRows.Count > 0 && dgv_SelectedMealList.SelectedRows[0].Cells[0].Value != null)
            {
                var selectedFoodName = dgv_SelectedMealList.SelectedRows[0].Cells[0].Value.ToString();
                var selectedFoodGram = Convert.ToInt32(dgv_SelectedMealList.SelectedRows[0].Cells[1].Value);
                var itemToDelete = _dataSource.Find(x => x.FoodName == selectedFoodName && x.Gram == selectedFoodGram);

                _dataSource.Remove(itemToDelete);
                dgv_SelectedMealList.DataSource = null;
                dgv_SelectedMealList.DataSource = _dataSource;

                _mealItemToDelete.Add(new MealItemDto()
                {
                    UserId = _userId,
                    FoodName = selectedFoodName,
                    Gram = Convert.ToInt32(nud_Amount.Value)
                });

            }
            else
                MessageBox.Show("Lütfen Silinecek Besini Seçiniz");

        }

        private void ButtonActivities(KryptonButton btn)
        {
            foreach (Control item in this.Controls)
            {
                if (item is KryptonButton)
                    ((KryptonButton)item).Enabled = true;

            }
            btn.Enabled = false;
        }

        private void SetButtonStates()
        {
            if (btn_Search.Enabled.Equals(false))
                btn_Search.Enabled = true;

            btn_Save.Enabled = true;
        }

        private void SetDgvContent()
        {
            _dataSource = _userMealService.GetUserMeals(_userId, DateTime.Now, selectedMealTime).ToList();
            dgv_SelectedMealList.DataSource = _dataSource;
        }

        private void dgv_MealList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_MealList.SelectedRows.Count > 0 && dgv_MealList.SelectedRows[0].Cells[0].Value != null)
            {
                var selectedFoodName = dgv_MealList.SelectedRows[0].Cells[0].Value.ToString();
                var image = _foodService.GetFoodImageByFoodName(selectedFoodName);

                if (image is not null)
                    pb_Food.Load(image);

            }

        }
    }
}