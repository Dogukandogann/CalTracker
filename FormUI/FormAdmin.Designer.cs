using Krypton.Toolkit;

namespace FormUI
{
    partial class FormAdmin
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
            txt_FoodName = new KryptonTextBox();
            kryptonLabel1 = new KryptonLabel();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            kryptonLabel4 = new KryptonLabel();
            kryptonLabel5 = new KryptonLabel();
            kryptonLabel6 = new KryptonLabel();
            kryptonLabel7 = new KryptonLabel();
            pb_FoodPicture = new PictureBox();
            kryptonLabel8 = new KryptonLabel();
            cmb_FoodCategory = new KryptonComboBox();
            nud_Calorie = new KryptonNumericUpDown();
            nud_Protein = new KryptonNumericUpDown();
            nud_Fat = new KryptonNumericUpDown();
            nud_Carbonhidrate = new KryptonNumericUpDown();
            nud_Gram = new KryptonNumericUpDown();
            txt_PictureUrl = new KryptonTextBox();
            btn_Save = new KryptonButton();
            btn_SelectPicture = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pb_FoodPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmb_FoodCategory).BeginInit();
            SuspendLayout();
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(125, 47);
            txt_FoodName.Margin = new Padding(3, 4, 3, 4);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.PaletteMode = PaletteMode.Office365Silver;
            txt_FoodName.Size = new Size(137, 25);
            txt_FoodName.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_FoodName.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(74, 47);
            kryptonLabel1.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel1.Size = new Size(39, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Isim";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(65, 165);
            kryptonLabel2.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel2.Size = new Size(50, 24);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Kalori";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(55, 227);
            kryptonLabel3.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel3.Size = new Size(60, 24);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Protein";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(74, 293);
            kryptonLabel4.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel4.Size = new Size(37, 24);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Yag";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(22, 359);
            kryptonLabel5.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel5.Size = new Size(101, 24);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "Karbonhidrat";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(66, 425);
            kryptonLabel6.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel6.Size = new Size(49, 24);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Gram";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(389, 133);
            kryptonLabel7.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel7.Size = new Size(52, 24);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Resim";
            // 
            // pb_FoodPicture
            // 
            pb_FoodPicture.BackColor = Color.Transparent;
            pb_FoodPicture.Location = new Point(329, 168);
            pb_FoodPicture.Margin = new Padding(3, 4, 3, 4);
            pb_FoodPicture.Name = "pb_FoodPicture";
            pb_FoodPicture.Size = new Size(174, 152);
            pb_FoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_FoodPicture.TabIndex = 2;
            pb_FoodPicture.TabStop = false;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(55, 106);
            kryptonLabel8.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.PaletteMode = PaletteMode.Office365Silver;
            kryptonLabel8.Size = new Size(69, 24);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 1;
            kryptonLabel8.Values.Text = "Kategori";
            // 
            // cmb_FoodCategory
            // 
            cmb_FoodCategory.CornerRoundingRadius = -1F;
            cmb_FoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_FoodCategory.DropDownWidth = 121;
            cmb_FoodCategory.IntegralHeight = false;
            cmb_FoodCategory.Location = new Point(125, 105);
            cmb_FoodCategory.Margin = new Padding(3, 4, 3, 4);
            cmb_FoodCategory.Name = "cmb_FoodCategory";
            cmb_FoodCategory.PaletteMode = PaletteMode.Office365Silver;
            cmb_FoodCategory.Size = new Size(138, 25);
            cmb_FoodCategory.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            cmb_FoodCategory.StateCommon.Item.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_FoodCategory.TabIndex = 4;
            // 
            // nud_Calorie
            // 
            nud_Calorie.Location = new Point(125, 163);
            nud_Calorie.Margin = new Padding(3, 4, 3, 4);
            nud_Calorie.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Calorie.Name = "nud_Calorie";
            nud_Calorie.PaletteMode = PaletteMode.Office365Silver;
            nud_Calorie.Size = new Size(137, 24);
            nud_Calorie.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Calorie.TabIndex = 5;
            // 
            // nud_Protein
            // 
            nud_Protein.Location = new Point(125, 224);
            nud_Protein.Margin = new Padding(3, 4, 3, 4);
            nud_Protein.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Protein.Name = "nud_Protein";
            nud_Protein.PaletteMode = PaletteMode.Office365Silver;
            nud_Protein.Size = new Size(137, 24);
            nud_Protein.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Protein.TabIndex = 5;
            // 
            // nud_Fat
            // 
            nud_Fat.Location = new Point(125, 291);
            nud_Fat.Margin = new Padding(3, 4, 3, 4);
            nud_Fat.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Fat.Name = "nud_Fat";
            nud_Fat.PaletteMode = PaletteMode.Office365Silver;
            nud_Fat.Size = new Size(137, 24);
            nud_Fat.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Fat.TabIndex = 5;
            // 
            // nud_Carbonhidrate
            // 
            nud_Carbonhidrate.Location = new Point(122, 359);
            nud_Carbonhidrate.Margin = new Padding(3, 4, 3, 4);
            nud_Carbonhidrate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Carbonhidrate.Name = "nud_Carbonhidrate";
            nud_Carbonhidrate.PaletteMode = PaletteMode.Office365Silver;
            nud_Carbonhidrate.Size = new Size(137, 24);
            nud_Carbonhidrate.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Carbonhidrate.TabIndex = 5;
            // 
            // nud_Gram
            // 
            nud_Gram.Location = new Point(122, 421);
            nud_Gram.Margin = new Padding(3, 4, 3, 4);
            nud_Gram.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_Gram.Name = "nud_Gram";
            nud_Gram.PaletteMode = PaletteMode.Office365Silver;
            nud_Gram.Size = new Size(137, 24);
            nud_Gram.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            nud_Gram.TabIndex = 5;
            // 
            // txt_PictureUrl
            // 
            txt_PictureUrl.Location = new Point(329, 395);
            txt_PictureUrl.Margin = new Padding(3, 4, 3, 4);
            txt_PictureUrl.Name = "txt_PictureUrl";
            txt_PictureUrl.PaletteMode = PaletteMode.Office365Silver;
            txt_PictureUrl.Size = new Size(174, 25);
            txt_PictureUrl.StateCommon.Content.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PictureUrl.TabIndex = 0;
            // 
            // btn_Save
            // 
            btn_Save.CornerRoundingRadius = 40F;
            btn_Save.Location = new Point(192, 481);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.OverrideDefault.Back.Color1 = Color.White;
            btn_Save.OverrideDefault.Back.ImageStyle = PaletteImageStyle.Stretch;
            btn_Save.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_Save.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_Save.Size = new Size(197, 84);
            btn_Save.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_Save.StateCommon.Border.Rounding = 40F;
            btn_Save.StateCommon.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.StateDisabled.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.StateNormal.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_Save.StateNormal.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_Save.StateNormal.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.StatePressed.Back.Color1 = Color.FromArgb(128, 255, 128);
            btn_Save.StatePressed.Back.Color2 = Color.FromArgb(32, 191, 107);
            btn_Save.StatePressed.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_Save.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_Save.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_Save.StateTracking.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.TabIndex = 6;
            btn_Save.TabStop = false;
            btn_Save.Values.Text = "Kaydet";
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_SelectPicture
            // 
            btn_SelectPicture.CornerRoundingRadius = 40F;
            btn_SelectPicture.Location = new Point(343, 336);
            btn_SelectPicture.Margin = new Padding(3, 4, 3, 4);
            btn_SelectPicture.Name = "btn_SelectPicture";
            btn_SelectPicture.OverrideDefault.Back.Color1 = Color.White;
            btn_SelectPicture.OverrideDefault.Back.ImageStyle = PaletteImageStyle.Stretch;
            btn_SelectPicture.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_SelectPicture.OverrideFocus.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_SelectPicture.Size = new Size(160, 47);
            btn_SelectPicture.StateCommon.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_SelectPicture.StateCommon.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_SelectPicture.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_SelectPicture.StateCommon.Border.Rounding = 40F;
            btn_SelectPicture.StateCommon.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SelectPicture.StateDisabled.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SelectPicture.StateNormal.Back.Color1 = Color.FromArgb(32, 191, 107);
            btn_SelectPicture.StateNormal.Back.Color2 = Color.FromArgb(128, 255, 128);
            btn_SelectPicture.StateNormal.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SelectPicture.StatePressed.Back.Color1 = Color.FromArgb(128, 255, 128);
            btn_SelectPicture.StatePressed.Back.Color2 = Color.FromArgb(32, 191, 107);
            btn_SelectPicture.StatePressed.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SelectPicture.StateTracking.Border.Color1 = Color.DarkGreen;
            btn_SelectPicture.StateTracking.Border.Color2 = Color.DarkGreen;
            btn_SelectPicture.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            btn_SelectPicture.StateTracking.Content.ShortText.Font = new Font("Nirmala UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SelectPicture.TabIndex = 7;
            btn_SelectPicture.TabStop = false;
            btn_SelectPicture.Values.Text = "Resim Ekle";
            btn_SelectPicture.Click += btn_SelectPicture_Click_1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(553, 600);
            Controls.Add(btn_SelectPicture);
            Controls.Add(btn_Save);
            Controls.Add(nud_Gram);
            Controls.Add(nud_Carbonhidrate);
            Controls.Add(nud_Fat);
            Controls.Add(nud_Protein);
            Controls.Add(nud_Calorie);
            Controls.Add(cmb_FoodCategory);
            Controls.Add(pb_FoodPicture);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel1);
            Controls.Add(txt_PictureUrl);
            Controls.Add(txt_FoodName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormAdmin";
            Text = "FormAdmin";
            FormClosing += FormAdmin_FormClosing;
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pb_FoodPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmb_FoodCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonTextBox txt_FoodName;
        private KryptonLabel kryptonLabel1;
        private KryptonTextBox kryptonTextBox2;
        private KryptonLabel kryptonLabel2;
        private KryptonTextBox kryptonTextBox3;
        private KryptonLabel kryptonLabel3;
        private KryptonTextBox kryptonTextBox4;
        private KryptonLabel kryptonLabel4;
        private KryptonTextBox kryptonTextBox5;
        private KryptonLabel kryptonLabel5;
        private KryptonTextBox kryptonTextBox6;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel7;
        private PictureBox pb_FoodPicture;
        private PictureBox pictureBox1;
        private KryptonButton kryptonButton1;
        private KryptonLabel kryptonLabel8;
        private KryptonComboBox cmb_FoodCategory;
        private KryptonNumericUpDown nud_Calorie;
        private KryptonNumericUpDown nud_Protein;
        private KryptonNumericUpDown nud_Fat;
        private KryptonNumericUpDown nud_Carbonhidrate;
        private KryptonNumericUpDown nud_Gram;
        private KryptonTextBox txt_PictureUrl;
        private KryptonButton btn_Save;
        private KryptonButton btn_SelectPicture;
    }
}