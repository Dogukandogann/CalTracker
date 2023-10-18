using Entities.Concrete;
using Entities.Enums;
using Entities.Exceptions;
using FluentValidation;
using FormUI.Utilities;
using Services;
using Services.Abstract;
using Services.Concrete;

namespace FormUI
{

    public partial class FormRegister : Form
    {
        private readonly IAuthService _authService = new AuthManager();
        private readonly IAimService _aimService = new AimManager();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            FormHelpers.Clear(this.Controls);
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbox_ShowPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
                txt_ComPassword.PasswordChar = '\0';

            }
            else
            {
                txt_Password.PasswordChar = '*';
                txt_ComPassword.PasswordChar = '*';
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            cmb_Aim.DataSource = _aimService.GetAll();
            cmb_Aim.DisplayMember = "Name";
            cmb_Aim.ValueMember = "Id";
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            User user;
            var userToRegister = new Entities.Dtos.UserForRegisterDto
            {
                FirstName = txt_Firstname.Text,
                LastName = txt_Lastname.Text,
                Email = txt_Username.Text,
                Password = txt_Password.Text,
                Height = Convert.ToDouble(num_Height.Value),
                Weight = Convert.ToDouble(num_Weight.Value),
                AimId = Convert.ToInt32(cmb_Aim.SelectedValue),
                UserAccess = UserAccess.Standard
            };

            try
            {
                user = _authService.Register(userToRegister);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }

            catch (UserAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message);

                return;
            }

            FormVerification verification = new FormVerification(user);
            verification.Owner = this;//
            verification.Show();//
            this.Hide();

        }

        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
