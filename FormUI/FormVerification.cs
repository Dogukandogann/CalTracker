using Entities.Concrete;
using Services;
using Services.Concrete;

namespace FormUI
{
    public partial class FormVerification : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        private readonly User _user;
        private readonly int _userId;
        public FormVerification(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            try
            {
                _authService.Verify(_user.Id, txt_Verification.Text);
                MessageBox.Show("Verification successful");
                new FormMainPage(_user).Show();
                this.Hide();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Verification code was wrong");
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormVerification_Load(object sender, EventArgs e)
        {

        }
    }
}
