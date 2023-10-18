using Entities.Dtos;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormCompareWeekly : Form
    {
        private readonly IUserMealService _userMealService = new UserMealManager();
        private readonly ICategoryService _categoryService = new CategoryManager();
        private readonly int _userId;
        private int selectedCategoryId;
        public FormCompareWeekly(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void FormCompareWeekly_Load(object sender, EventArgs e)
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
            cmb_Categories.DataSource = _categoryService.GetCategoryNames().ToList();
            var userPeriodic = _userMealService.GetUserNutrionalsByUserIdAndDateRange(_userId, DateTime.Now.AddDays(-7), DateTime.Now, cmb_Categories.SelectedIndex+1);
            var othersPeriodic = _userMealService.GetUserNutrionalsAllByDateRange(DateTime.Now.AddDays(-7), DateTime.Now, cmb_Categories.SelectedIndex);

            FillLabels(userPeriodic, othersPeriodic);

        }

        private void FillLabels(PeriodicCalories userPeriodic, PeriodicCalories othersPeriodic)
        {

            lbl_Breakfast.Text = userPeriodic.Breakfast.ToString();
            lbl_lunch.Text = userPeriodic.Lunch.ToString();
            lbl_Dinner.Text = userPeriodic.Dinner.ToString();
            lbl_Snack.Text = userPeriodic.Snack.ToString();
            lbl_Total.Text = (userPeriodic.Breakfast + userPeriodic.Lunch + userPeriodic.Dinner + userPeriodic.Snack).ToString() + " kcal";

            lbl_OthersBreakfast.Text = othersPeriodic.Breakfast.ToString();
            lbl_OthersLunch.Text = othersPeriodic.Lunch.ToString();
            lbl_OthersDinner.Text = othersPeriodic.Dinner.ToString();
            lbl_OthersSnack.Text = othersPeriodic.Snack.ToString();
            lbl_OthersTotal.Text = (othersPeriodic.Breakfast + othersPeriodic.Lunch + othersPeriodic.Dinner + othersPeriodic.Snack).ToString() + " kcal";

        }

        private void cmb_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                selectedCategoryId = cmb_Categories.SelectedIndex;

                var userPeriodic = _userMealService.GetUserNutrionalsByUserIdAndDateRange(_userId, DateTime.Now.AddDays(-30), DateTime.Now, selectedCategoryId);
                var othersPeriodic = _userMealService.GetUserNutrionalsAllByDateRange(DateTime.Now.AddDays(-30), DateTime.Now, selectedCategoryId);
                FillLabels(userPeriodic, othersPeriodic);
        }
    }
}
