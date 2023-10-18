namespace FormUI
{
    partial class FormRegister
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
            lbl_Registration = new Label();
            label1 = new Label();
            txt_Username = new TextBox();
            label2 = new Label();
            txt_Password = new TextBox();
            label4 = new Label();
            txt_ComPassword = new TextBox();
            chckbox_ShowPassword = new CheckBox();
            label5 = new Label();
            lbl_Login = new Label();
            btn_CloseWindow = new Krypton.Toolkit.KryptonButton();
            txt_Lastname = new TextBox();
            txt_Firstname = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cmb_Aim = new Krypton.Toolkit.KryptonComboBox();
            num_Weight = new Krypton.Toolkit.KryptonNumericUpDown();
            num_Height = new Krypton.Toolkit.KryptonNumericUpDown();
            btn_Register = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)cmb_Aim).BeginInit();
            SuspendLayout();
            // 
            // lbl_Registration
            // 
            lbl_Registration.AutoSize = true;
            lbl_Registration.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Registration.ForeColor = Color.FromArgb(32, 191, 107);
            lbl_Registration.Location = new Point(186, 3);
            lbl_Registration.Name = "lbl_Registration";
            lbl_Registration.Size = new Size(197, 34);
            lbl_Registration.TabIndex = 0;
            lbl_Registration.Text = "Registration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txt_Username
            // 
            txt_Username.BackColor = Color.FromArgb(230, 231, 233);
            txt_Username.BorderStyle = BorderStyle.None;
            txt_Username.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Username.Location = new Point(27, 113);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(218, 27);
            txt_Username.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 155);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(230, 231, 233);
            txt_Password.BorderStyle = BorderStyle.None;
            txt_Password.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(27, 185);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(218, 27);
            txt_Password.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 232);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 1;
            label4.Text = "Confirm Password";
            // 
            // txt_ComPassword
            // 
            txt_ComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txt_ComPassword.BorderStyle = BorderStyle.None;
            txt_ComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ComPassword.Location = new Point(24, 258);
            txt_ComPassword.Name = "txt_ComPassword";
            txt_ComPassword.PasswordChar = '*';
            txt_ComPassword.Size = new Size(218, 27);
            txt_ComPassword.TabIndex = 2;
            // 
            // chckbox_ShowPassword
            // 
            chckbox_ShowPassword.AutoSize = true;
            chckbox_ShowPassword.Cursor = Cursors.Hand;
            chckbox_ShowPassword.FlatStyle = FlatStyle.Flat;
            chckbox_ShowPassword.Location = new Point(46, 313);
            chckbox_ShowPassword.Name = "chckbox_ShowPassword";
            chckbox_ShowPassword.Size = new Size(151, 27);
            chckbox_ShowPassword.TabIndex = 3;
            chckbox_ShowPassword.Text = "Show Password";
            chckbox_ShowPassword.UseVisualStyleBackColor = true;
            chckbox_ShowPassword.CheckedChanged += checkboxShowPass_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 455);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 5;
            label5.Text = "Already have an Account";
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Cursor = Cursors.Hand;
            lbl_Login.ForeColor = Color.FromArgb(165, 177, 194);
            lbl_Login.Location = new Point(218, 481);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(126, 23);
            lbl_Login.TabIndex = 5;
            lbl_Login.Text = "Back to LOGIN";
            lbl_Login.Click += lbl_Login_Click;
            // 
            // btn_CloseWindow
            // 
            btn_CloseWindow.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btn_CloseWindow.CornerRoundingRadius = -1F;
            btn_CloseWindow.Location = new Point(546, 3);
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
            btn_CloseWindow.TabIndex = 22;
            btn_CloseWindow.Values.Text = "X";
            btn_CloseWindow.Click += btn_CloseWindow_Click;
            // 
            // txt_Lastname
            // 
            txt_Lastname.BackColor = Color.FromArgb(230, 231, 233);
            txt_Lastname.BorderStyle = BorderStyle.None;
            txt_Lastname.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Lastname.Location = new Point(311, 185);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(218, 27);
            txt_Lastname.TabIndex = 41;
            // 
            // txt_Firstname
            // 
            txt_Firstname.BackColor = Color.FromArgb(230, 231, 233);
            txt_Firstname.BorderStyle = BorderStyle.None;
            txt_Firstname.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Firstname.Location = new Point(311, 113);
            txt_Firstname.Name = "txt_Firstname";
            txt_Firstname.Size = new Size(218, 27);
            txt_Firstname.TabIndex = 42;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(230, 231, 233);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(311, 185);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 28);
            textBox4.TabIndex = 45;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(230, 231, 233);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(311, 113);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 28);
            textBox5.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(308, 155);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 43;
            label8.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 83);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 44;
            label7.Text = "First Name";
            // 
            // cmb_Aim
            // 
            cmb_Aim.CornerRoundingRadius = -1F;
            cmb_Aim.DropDownWidth = 120;
            cmb_Aim.IntegralHeight = false;
            cmb_Aim.Location = new Point(410, 242);
            cmb_Aim.Name = "cmb_Aim";
            cmb_Aim.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            cmb_Aim.Size = new Size(120, 25);
            cmb_Aim.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Aim.TabIndex = 40;
            cmb_Aim.Text = "Aim";
            // 
            // num_Weight
            // 
            num_Weight.Location = new Point(409, 324);
            num_Weight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            num_Weight.Name = "num_Weight";
            num_Weight.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            num_Weight.Size = new Size(120, 21);
            num_Weight.StateActive.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_Weight.StateDisabled.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_Weight.StateNormal.Content.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            num_Weight.TabIndex = 38;
            // 
            // num_Height
            // 
            num_Height.Location = new Point(409, 284);
            num_Height.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            num_Height.Name = "num_Height";
            num_Height.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            num_Height.Size = new Size(120, 21);
            num_Height.StateActive.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_Height.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_Height.StateDisabled.Content.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_Height.TabIndex = 39;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(32, 191, 107);
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(30, 380);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(221, 39);
            btn_Register.TabIndex = 35;
            btn_Register.Text = "REGISTER";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += registrationButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(301, 324);
            label11.Name = "label11";
            label11.Size = new Size(102, 23);
            label11.TabIndex = 31;
            label11.Text = "Weight(kg)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(301, 284);
            label12.Name = "label12";
            label12.Size = new Size(101, 23);
            label12.TabIndex = 32;
            label12.Text = "Heigth(cm)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(301, 244);
            label13.Name = "label13";
            label13.Size = new Size(43, 23);
            label13.TabIndex = 33;
            label13.Text = "Aim";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.White;
            btn_Clear.Cursor = Cursors.Hand;
            btn_Clear.FlatAppearance.BorderSize = 2;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.ForeColor = Color.FromArgb(32, 191, 107);
            btn_Clear.Location = new Point(308, 380);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(221, 39);
            btn_Clear.TabIndex = 47;
            btn_Clear.Text = "CLEAR";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(586, 513);
            ControlBox = false;
            Controls.Add(btn_Clear);
            Controls.Add(txt_Lastname);
            Controls.Add(txt_Firstname);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmb_Aim);
            Controls.Add(num_Weight);
            Controls.Add(num_Height);
            Controls.Add(btn_Register);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btn_CloseWindow);
            Controls.Add(lbl_Login);
            Controls.Add(label5);
            Controls.Add(chckbox_ShowPassword);
            Controls.Add(txt_ComPassword);
            Controls.Add(txt_Password);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_Username);
            Controls.Add(label1);
            Controls.Add(lbl_Registration);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)cmb_Aim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Registration;
        private Label label1;
        private TextBox txt_Username;
        private Label label2;
        private TextBox txt_Password;
        private Label label4;
        private TextBox txt_ComPassword;
        private CheckBox chckbox_ShowPassword;
        private Label label5;
        private Label lbl_Login;
        private Krypton.Toolkit.KryptonButton btn_CloseWindow;
        private TextBox txt_Lastname;
        private TextBox txt_Firstname;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private Krypton.Toolkit.KryptonComboBox cmb_Aim;
        private Krypton.Toolkit.KryptonNumericUpDown num_Weight;
        private Krypton.Toolkit.KryptonNumericUpDown num_Height;
        private Button btn_Register;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btn_Clear;
    }



}
