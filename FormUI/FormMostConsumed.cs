using Services.Abstract;
using Services.Concrete;
using System.Drawing.Drawing2D;
using Entities.Enums;


namespace FormUI
{
    public partial class FormMostConsumed : Form
    {
        private readonly IUserMealService _userMealService = new UserMealManager();

        public FormMostConsumed()
        {
            InitializeComponent();
        }

        private void FormMostConsumed_Load(object sender, EventArgs e)
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




            var x = _userMealService.GetMostConsumed();



            lbl_Breakfast.Text = x.SingleOrDefault(x => x.MealTime == MealTimes.Breakfast)?.FoodName;
            lbl_Lunch.Text = x.SingleOrDefault(x => x.MealTime == MealTimes.Lunch)?.FoodName;
            lbl_Dinner.Text = x.SingleOrDefault(x => x.MealTime == MealTimes.Dinner)?.FoodName;
            lbl_Snack.Text = x.SingleOrDefault(x => x.MealTime == MealTimes.Snack)?.FoodName;




        }
    }
}
