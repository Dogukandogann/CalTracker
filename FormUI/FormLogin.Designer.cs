namespace FormUI
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_CreateAccount = new Label();
            lbl_DontHaveAccount = new Label();
            btn_Clear = new Button();
            btn_Login = new Button();
            chckbox_ShowPassword = new CheckBox();
            lbl_Password = new Label();
            txt_Username = new TextBox();
            lbl_Email = new Label();
            lbl_GetStarted = new Label();
            txt_Password = new TextBox();
            btn_CloseWindow = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // lbl_CreateAccount
            // 
            lbl_CreateAccount.AutoSize = true;
            lbl_CreateAccount.Cursor = Cursors.Hand;
            lbl_CreateAccount.ForeColor = Color.FromArgb(165, 177, 194);
            lbl_CreateAccount.Location = new Point(83, 430);
            lbl_CreateAccount.Name = "lbl_CreateAccount";
            lbl_CreateAccount.Size = new Size(132, 23);
            lbl_CreateAccount.TabIndex = 19;
            lbl_CreateAccount.Text = "Create Account";
            lbl_CreateAccount.Click += lbl_CreateAccount_Click;
            // 
            // lbl_DontHaveAccount
            // 
            lbl_DontHaveAccount.AutoSize = true;
            lbl_DontHaveAccount.Location = new Point(60, 391);
            lbl_DontHaveAccount.Name = "lbl_DontHaveAccount";
            lbl_DontHaveAccount.Size = new Size(189, 23);
            lbl_DontHaveAccount.TabIndex = 20;
            lbl_DontHaveAccount.Text = "Dont Have an Account";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.White;
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.BorderSize = 2;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.ForeColor = Color.FromArgb(32, 191, 107);
            btn_Clear.Location = new Point(42, 333);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(218, 34);
            btn_Clear.TabIndex = 4;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += clearButton_Click;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(32, 191, 107);
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(42, 287);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(218, 28);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += loginButton_Click;
            // 
            // chckbox_ShowPassword
            // 
            chckbox_ShowPassword.AutoSize = true;
            chckbox_ShowPassword.Cursor = Cursors.Hand;
            chckbox_ShowPassword.FlatStyle = FlatStyle.Flat;
            chckbox_ShowPassword.Location = new Point(130, 232);
            chckbox_ShowPassword.Name = "chckbox_ShowPassword";
            chckbox_ShowPassword.Size = new Size(151, 27);
            chckbox_ShowPassword.TabIndex = 2;
            chckbox_ShowPassword.Text = "Show Password";
            chckbox_ShowPassword.UseVisualStyleBackColor = true;
            chckbox_ShowPassword.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(39, 150);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(84, 23);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            txt_Username.BackColor = Color.FromArgb(230, 231, 233);
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Username.Location = new Point(42, 104);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(218, 24);
            txt_Username.TabIndex = 0;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(39, 74);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(54, 23);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "Email";
            // 
            // lbl_GetStarted
            // 
            lbl_GetStarted.AutoSize = true;
            lbl_GetStarted.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_GetStarted.ForeColor = Color.FromArgb(32, 191, 107);
            lbl_GetStarted.Location = new Point(37, 21);
            lbl_GetStarted.Name = "lbl_GetStarted";
            lbl_GetStarted.Size = new Size(194, 34);
            lbl_GetStarted.TabIndex = 6;
            lbl_GetStarted.Text = "Get Started";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(230, 231, 233);
            txt_Password.BorderStyle = BorderStyle.None;
            txt_Password.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(42, 179);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(218, 24);
            txt_Password.TabIndex = 1;
            // 
            // btn_CloseWindow
            // 
            btn_CloseWindow.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btn_CloseWindow.CornerRoundingRadius = -1F;
            btn_CloseWindow.Location = new Point(260, 2);
            btn_CloseWindow.Name = "btn_CloseWindow";
            btn_CloseWindow.Size = new Size(28, 25);
            btn_CloseWindow.StatePressed.Back.Color1 = Color.Red;
            btn_CloseWindow.StatePressed.Back.Color2 = Color.Red;
            btn_CloseWindow.StateTracking.Back.Color1 = Color.FromArgb(255, 128, 128);
            btn_CloseWindow.StateTracking.Back.Color2 = Color.FromArgb(255, 128, 128);
            btn_CloseWindow.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 128);
            btn_CloseWindow.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 128);
            btn_CloseWindow.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btn_CloseWindow.StateTracking.Border.ColorAngle = 1F;
            btn_CloseWindow.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_CloseWindow.TabIndex = 21;
            btn_CloseWindow.Values.Text = "X";
            btn_CloseWindow.Click += btn_CloseWindow_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 477);
            ControlBox = false;
            Controls.Add(btn_CloseWindow);
            Controls.Add(lbl_CreateAccount);
            Controls.Add(lbl_DontHaveAccount);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Login);
            Controls.Add(chckbox_ShowPassword);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Username);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_GetStarted);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CreateAccount;
        private Label lbl_DontHaveAccount;
        private Button btn_Clear;
        private Button btn_Login;
        private CheckBox chckbox_ShowPassword;
        private Label lbl_Password;
        private TextBox txt_Username;
        private Label lbl_Email;
        private Label lbl_GetStarted;
        private TextBox txt_Password;
        private Krypton.Toolkit.KryptonButton btn_CloseWindow;
    }
}