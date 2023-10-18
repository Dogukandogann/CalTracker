namespace FormUI
{
    partial class FormVerification
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
            lbl_Verification = new Label();
            btn_Verify = new Button();
            btn_Close = new Krypton.Toolkit.KryptonButton();
            txt_Verification = new TextBox();
            textBox2 = new TextBox();
            lbl_VerificationCode = new Label();
            SuspendLayout();
            // 
            // lbl_Verification
            // 
            lbl_Verification.AutoSize = true;
            lbl_Verification.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Verification.ForeColor = Color.FromArgb(32, 191, 107);
            lbl_Verification.Location = new Point(33, 3);
            lbl_Verification.Name = "lbl_Verification";
            lbl_Verification.Size = new Size(188, 34);
            lbl_Verification.TabIndex = 0;
            lbl_Verification.Text = "Verification";
            // 
            // btn_Verify
            // 
            btn_Verify.BackColor = Color.FromArgb(32, 191, 107);
            btn_Verify.Cursor = Cursors.Hand;
            btn_Verify.FlatAppearance.BorderSize = 0;
            btn_Verify.FlatStyle = FlatStyle.Flat;
            btn_Verify.ForeColor = Color.White;
            btn_Verify.Location = new Point(34, 179);
            btn_Verify.Name = "btn_Verify";
            btn_Verify.Size = new Size(218, 28);
            btn_Verify.TabIndex = 4;
            btn_Verify.Text = "VERIFY";
            btn_Verify.UseVisualStyleBackColor = false;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // btn_Close
            // 
            btn_Close.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            btn_Close.CornerRoundingRadius = -1F;
            btn_Close.Location = new Point(250, 3);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(28, 25);
            btn_Close.StatePressed.Back.Color1 = Color.Red;
            btn_Close.StatePressed.Back.Color2 = Color.Red;
            btn_Close.StateTracking.Back.Color1 = Color.FromArgb(255, 128, 128);
            btn_Close.StateTracking.Back.Color2 = Color.FromArgb(255, 128, 128);
            btn_Close.StateTracking.Border.Color1 = Color.FromArgb(255, 128, 128);
            btn_Close.StateTracking.Border.Color2 = Color.FromArgb(255, 128, 128);
            btn_Close.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btn_Close.StateTracking.Border.ColorAngle = 1F;
            btn_Close.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Close.TabIndex = 22;
            btn_Close.Values.Text = "X";
            btn_Close.Click += btn_Close_Click;
            // 
            // txt_Verification
            // 
            txt_Verification.BackColor = Color.FromArgb(230, 231, 233);
            txt_Verification.BorderStyle = BorderStyle.None;
            txt_Verification.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Verification.Location = new Point(36, 115);
            txt_Verification.Multiline = true;
            txt_Verification.Name = "txt_Verification";
            txt_Verification.PasswordChar = '*';
            txt_Verification.Size = new Size(218, 28);
            txt_Verification.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(230, 231, 233);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(36, 115);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 28);
            textBox2.TabIndex = 30;
            // 
            // lbl_VerificationCode
            // 
            lbl_VerificationCode.AutoSize = true;
            lbl_VerificationCode.Location = new Point(33, 85);
            lbl_VerificationCode.Name = "lbl_VerificationCode";
            lbl_VerificationCode.Size = new Size(148, 23);
            lbl_VerificationCode.TabIndex = 29;
            lbl_VerificationCode.Text = "Verification Code";
            // 
            // FormVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 239);
            ControlBox = false;
            Controls.Add(txt_Verification);
            Controls.Add(textBox2);
            Controls.Add(lbl_VerificationCode);
            Controls.Add(btn_Close);
            Controls.Add(btn_Verify);
            Controls.Add(lbl_Verification);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "FormVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormVerification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Verification;
        private Button btn_Verify;
        private Krypton.Toolkit.KryptonButton btn_Close;
        private TextBox txt_Verification;
        private TextBox textBox2;
        private Label lbl_VerificationCode;
    }
}