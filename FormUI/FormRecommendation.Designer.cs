namespace FormUI
{
    partial class FormRecommendation
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
            label1 = new Label();
            cmb_Activitiy = new ComboBox();
            label3 = new Label();
            lbl_RecomendedCalorie = new Label();
            btn_Calculate = new Krypton.Toolkit.KryptonButton();
            lbl_DailyCalorie = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Aktivite Durumu";
            // 
            // cmb_Activitiy
            // 
            cmb_Activitiy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Activitiy.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Activitiy.FormattingEnabled = true;
            cmb_Activitiy.Location = new Point(146, 22);
            cmb_Activitiy.Margin = new Padding(3, 4, 3, 4);
            cmb_Activitiy.Name = "cmb_Activitiy";
            cmb_Activitiy.Size = new Size(138, 28);
            cmb_Activitiy.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 220);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 0;
            label3.Text = "Günlük Kalori İhtiyacı";
            // 
            // lbl_RecomendedCalorie
            // 
            lbl_RecomendedCalorie.AutoSize = true;
            lbl_RecomendedCalorie.BackColor = Color.Transparent;
            lbl_RecomendedCalorie.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RecomendedCalorie.Location = new Point(209, 220);
            lbl_RecomendedCalorie.Name = "lbl_RecomendedCalorie";
            lbl_RecomendedCalorie.Size = new Size(48, 20);
            lbl_RecomendedCalorie.TabIndex = 0;
            lbl_RecomendedCalorie.Text = "Kalori";
            // 
            // btn_Calculate
            // 
            btn_Calculate.CornerRoundingRadius = 40F;
            btn_Calculate.Location = new Point(75, 93);
            btn_Calculate.Margin = new Padding(3, 4, 3, 4);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.OverrideDefault.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.OverrideDefault.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btn_Calculate.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.OverrideFocus.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.OverrideFocus.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.OverrideFocus.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.Size = new Size(166, 53);
            btn_Calculate.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.StateCommon.Border.Rounding = 40F;
            btn_Calculate.StatePressed.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.StatePressed.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.StateTracking.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Calculate.StateTracking.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Calculate.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_Calculate.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_Calculate.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btn_Calculate.TabIndex = 9;
            btn_Calculate.TabStop = false;
            btn_Calculate.Values.Text = "Hesapla";
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // lbl_DailyCalorie
            // 
            lbl_DailyCalorie.AutoSize = true;
            lbl_DailyCalorie.BackColor = Color.Transparent;
            lbl_DailyCalorie.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DailyCalorie.Location = new Point(209, 256);
            lbl_DailyCalorie.Name = "lbl_DailyCalorie";
            lbl_DailyCalorie.Size = new Size(48, 20);
            lbl_DailyCalorie.TabIndex = 0;
            lbl_DailyCalorie.Text = "Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 256);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Kalan Kalori";
            // 
            // FormRecommendation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 364);
            Controls.Add(btn_Calculate);
            Controls.Add(cmb_Activitiy);
            Controls.Add(lbl_DailyCalorie);
            Controls.Add(lbl_RecomendedCalorie);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormRecommendation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRecommendation";
            Load += FormRecommendation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_Activitiy;
        private Label label3;
        private Label label5;
        private Label lbl_RecomendedCalorie;
        private Krypton.Toolkit.KryptonButton btn_Calculate;
        private Label lbl_DailyCalorie;
        private Label label2;
    }
}