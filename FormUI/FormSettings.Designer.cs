namespace FormUI
{
    partial class FormSettings
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
            txt_Firstname = new TextBox();
            txt_Lastname = new TextBox();
            nud_Height = new NumericUpDown();
            nud_Weight = new NumericUpDown();
            cmb_Aim = new ComboBox();
            groupBox1 = new GroupBox();
            btn_Save = new Krypton.Toolkit.KryptonButton();
            groupBox2 = new GroupBox();
            btn_aimSave = new Krypton.Toolkit.KryptonButton();
            groupBox3 = new GroupBox();
            btn_HeightWeightSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)nud_Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Weight).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Firstname
            // 
            txt_Firstname.Location = new Point(15, 37);
            txt_Firstname.Name = "txt_Firstname";
            txt_Firstname.Size = new Size(125, 27);
            txt_Firstname.TabIndex = 0;
            // 
            // txt_Lastname
            // 
            txt_Lastname.Location = new Point(15, 70);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(125, 27);
            txt_Lastname.TabIndex = 0;
            // 
            // nud_Height
            // 
            nud_Height.Location = new Point(15, 37);
            nud_Height.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nud_Height.Name = "nud_Height";
            nud_Height.Size = new Size(150, 27);
            nud_Height.TabIndex = 1;
            // 
            // nud_Weight
            // 
            nud_Weight.Location = new Point(15, 82);
            nud_Weight.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nud_Weight.Name = "nud_Weight";
            nud_Weight.Size = new Size(150, 27);
            nud_Weight.TabIndex = 1;
            // 
            // cmb_Aim
            // 
            cmb_Aim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Aim.FormattingEnabled = true;
            cmb_Aim.Location = new Point(6, 37);
            cmb_Aim.Name = "cmb_Aim";
            cmb_Aim.Size = new Size(151, 28);
            cmb_Aim.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(txt_Firstname);
            groupBox1.Controls.Add(txt_Lastname);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 111);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "İsim Soyisim Değişikliği";
            // 
            // btn_Save
            // 
            btn_Save.CornerRoundingRadius = 40F;
            btn_Save.Location = new Point(174, 46);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.OverrideDefault.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.OverrideDefault.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Save.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.OverrideFocus.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.OverrideFocus.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.Size = new Size(125, 42);
            btn_Save.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.StateCommon.Border.Rounding = 40F;
            btn_Save.StatePressed.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StatePressed.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateTracking.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StateTracking.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_Save.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_Save.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Save.TabIndex = 9;
            btn_Save.TabStop = false;
            btn_Save.Values.Text = "Kaydet";
            btn_Save.Click += btn_Save_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_aimSave);
            groupBox2.Controls.Add(cmb_Aim);
            groupBox2.Location = new Point(12, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 87);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hedef Değişikliği";
            // 
            // btn_aimSave
            // 
            btn_aimSave.CornerRoundingRadius = 40F;
            btn_aimSave.Location = new Point(174, 27);
            btn_aimSave.Margin = new Padding(3, 4, 3, 4);
            btn_aimSave.Name = "btn_aimSave";
            btn_aimSave.OverrideDefault.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_aimSave.OverrideDefault.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_aimSave.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_aimSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_aimSave.OverrideFocus.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_aimSave.OverrideFocus.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_aimSave.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_aimSave.Size = new Size(125, 42);
            btn_aimSave.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_aimSave.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_aimSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_aimSave.StateCommon.Border.Rounding = 40F;
            btn_aimSave.StatePressed.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_aimSave.StatePressed.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_aimSave.StateTracking.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_aimSave.StateTracking.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_aimSave.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_aimSave.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_aimSave.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_aimSave.TabIndex = 9;
            btn_aimSave.TabStop = false;
            btn_aimSave.Values.Text = "Kaydet";
            btn_aimSave.Click += btn_aimSave_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_HeightWeightSave);
            groupBox3.Controls.Add(nud_Height);
            groupBox3.Controls.Add(nud_Weight);
            groupBox3.Location = new Point(12, 222);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 127);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Boy Kilo Değişikliği";
            // 
            // btn_HeightWeightSave
            // 
            btn_HeightWeightSave.CornerRoundingRadius = 40F;
            btn_HeightWeightSave.Location = new Point(174, 47);
            btn_HeightWeightSave.Margin = new Padding(3, 4, 3, 4);
            btn_HeightWeightSave.Name = "btn_HeightWeightSave";
            btn_HeightWeightSave.OverrideDefault.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_HeightWeightSave.OverrideDefault.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_HeightWeightSave.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_HeightWeightSave.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_HeightWeightSave.OverrideFocus.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_HeightWeightSave.OverrideFocus.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_HeightWeightSave.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_HeightWeightSave.Size = new Size(125, 42);
            btn_HeightWeightSave.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_HeightWeightSave.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_HeightWeightSave.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_HeightWeightSave.StateCommon.Border.Rounding = 40F;
            btn_HeightWeightSave.StatePressed.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_HeightWeightSave.StatePressed.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_HeightWeightSave.StateTracking.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_HeightWeightSave.StateTracking.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_HeightWeightSave.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_HeightWeightSave.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_HeightWeightSave.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_HeightWeightSave.TabIndex = 9;
            btn_HeightWeightSave.TabStop = false;
            btn_HeightWeightSave.Values.Text = "Kaydet";
            btn_HeightWeightSave.Click += btn_HeightWeightSave_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 366);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSettings";
            FormClosing += FormSettings_FormClosing;
            Load += FormSettings_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Weight).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_Firstname;
        private TextBox txt_Lastname;
        private NumericUpDown nud_Height;
        private NumericUpDown nud_Weight;
        private ComboBox cmb_Aim;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Krypton.Toolkit.KryptonButton btn_Save;
        private Krypton.Toolkit.KryptonButton btn_aimSave;
        private Krypton.Toolkit.KryptonButton btn_HeightWeightSave;
    }
}