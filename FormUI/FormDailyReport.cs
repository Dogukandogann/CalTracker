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
using Services.Abstract;
using Services.Concrete;
using Entities.Enums;

namespace FormUI
{
    public partial class FormDailyReport : Form
    {
        private readonly int _userId;
        private readonly IUserMealService _userMealService = new UserMealManager();
        public FormDailyReport(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void FormDailyReport_Load(object sender, EventArgs e)
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
            var userMeals = _userMealService.GetUserMealsByUserIdAndMealDate(_userId, DateTime.Now).ToList();

            var breakFast = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Breakfast);
            var dinner = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Dinner);
            var lunch = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Lunch);
            var snack = userMeals.FirstOrDefault(um => um.MealTime == MealTimes.Snack);



            lbl_BreakfastCalorie.Text = breakFast?.Calorie.ToString();
            lbl_BreakfastCarbonhidrate.Text = breakFast?.Carbonhidrate.ToString();
            lbl_BreakfastFat.Text = breakFast?.Fat.ToString();
            lbl_BreakfastProtein.Text = breakFast?.Protein.ToString();

            lbl_LunchCalorie.Text = lunch?.Calorie.ToString();
            lbl_LunchCarbonhidrate.Text = lunch?.Carbonhidrate.ToString();
            lbl_LunchFat.Text = lunch?.Fat.ToString();
            lbl_LunchProtein.Text = lunch?.Protein.ToString();

            lbl_DinnerCalorie.Text = dinner?.Calorie.ToString();
            lbl_DinnerCarbonhidrate.Text = dinner?.Carbonhidrate.ToString();
            lbl_DinnerFat.Text = dinner?.Fat.ToString();
            lbl_DinnerProtein.Text = dinner?.Protein.ToString();

            lbl_SnackCalorie.Text = snack?.Calorie.ToString();
            lbl_SnackCarbonhidrate.Text = snack?.Carbonhidrate.ToString();
            lbl_SnackFat.Text = snack?.Fat.ToString();
            lbl_SnackProtein.Text = snack?.Protein.ToString();

        }
    }
}
