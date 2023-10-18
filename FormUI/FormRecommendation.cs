using Entities.Concrete;
using Entities.Enums;
using Repositories.Context;
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

    public partial class FormRecommendation : Form
    {
        private readonly IUserService _userService = new UserManager();
        private readonly IUserMealService _userMealService = new UserMealManager();
        private readonly User _user;
        private readonly int _userıd;
        KaloriTakipDbContext db = new KaloriTakipDbContext();

        public FormRecommendation(int userıd)
        {
            _user = db.Users.Find(userıd);
            InitializeComponent();

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
        }

        private void FormRecommendation_Load(object sender, EventArgs e)
        {
            cmb_Activitiy.DataSource = Enum.GetValues(typeof(Entities.Enums.ActivitiyStatus));


        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            ActivitiyStatus selectedActivity = (ActivitiyStatus)Enum.Parse(typeof(ActivitiyStatus), cmb_Activitiy.Text);
            int recomendedCalorie = _userService.RecomendedCalorie(_user.Id, _user.Weight, selectedActivity);
            double dailyCalorie = _userMealService.GetUserMealsByUserIdAndMealDate(_user.Id, DateTime.Now).Select(um => um.Calorie).FirstOrDefault();
            lbl_RecomendedCalorie.Text = _userService.RecomendedCalorie(_user.Id, _user.Weight, selectedActivity).ToString();
            lbl_DailyCalorie.Text = Math.Round((recomendedCalorie - dailyCalorie),3).ToString();


        }
    }
}
