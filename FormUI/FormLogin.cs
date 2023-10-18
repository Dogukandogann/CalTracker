using Entities.Exceptions;
using FormUI.Utilities;
using Services;
using Services.Concrete;

namespace FormUI
{
    public partial class FormLogin : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbl_CreateAccount_Click(object sender, EventArgs e)
        {

            FormRegister register = new FormRegister();
            register.Owner = this;
            register.Show();
            this.Hide();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FormHelpers.Clear(this.Controls);
            txt_Username.Focus();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var userToLogin = new Entities.Dtos.UserForLoginDto
            {
                Email = txt_Username.Text,
                Password = txt_Password.Text
            };

            try
            {
                var user = _authService.Login(userToLogin);
                MessageBox.Show("Logged in Successfuly!");
                this.Hide();
                if (user.UserAccess is Entities.Enums.UserAccess.Standard)
                {
                    FormMainPage mainPag = new FormMainPage(user);
                    mainPag.Owner = this;
                    mainPag.Show();
                }
                else
                    new FormAdmin().Show();

            }
            catch (WrongCredentialsException)
            {
                MessageBox.Show("Wrong email or password.");
            }

            catch (UserNotVerifiedException ex)
            {
                MessageBox.Show("Please complete the verification process");

                var formVerification = new FormVerification(ex.User);
                formVerification.Show();
                this.Hide();
            }
            catch (UserNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';

            }
        }

        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
