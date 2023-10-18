using Entities.Concrete;
using Repositories.Context;
using Services.Abstract;
using Services.Concrete;
using System.Drawing.Drawing2D;


namespace FormUI
{
    public partial class FormMainPage : Form
    {
        private readonly User _user;

        private readonly IUserService _userService = new UserManager();


        public FormMainPage(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void FormMainPage_Load(object sender, EventArgs e)
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
            lbl_Welcome.Text = $"Hoşgeldin :  {_user.FirstName} {_user.LastName} ";
            lbl_BmiStatus.Text = $"Bmi İndeksiniz : {_userService.CalculateBmi(_user.Id, _user.Height, _user.Weight)}";
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            new FormSettings(_user).Show();
            this.Close();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            new FormReports(_user.Id).Show();
        }

        private void btn_CalorieTrack_Click(object sender, EventArgs e)
        {
            new FormMeals(_user.Id).Show();
        }
        private void btn_CalorieAims_Click(object sender, EventArgs e)
        {
            new FormRecommendation(_user.Id).Show();
        }

        private void btn_exitApplication_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                Application.ExitThread();
        }
    }
}



