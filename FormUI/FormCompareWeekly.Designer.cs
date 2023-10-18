namespace FormUI
{
    partial class FormCompareWeekly
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmb_Categories = new Krypton.Toolkit.KryptonComboBox();
            lbl_Breakfast = new Label();
            lbl_lunch = new Label();
            lbl_Dinner = new Label();
            lbl_Snack = new Label();
            lbl_OthersBreakfast = new Label();
            lbl_OthersLunch = new Label();
            lbl_OthersDinner = new Label();
            lbl_OthersSnack = new Label();
            lbl_Total = new Label();
            lbl_OthersTotal = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 246);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 1;
            label1.Text = "Siz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 310);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Diger Kullanicilar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 171);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 1;
            label3.Text = "Kahvalti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(354, 171);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 1;
            label4.Text = "Oglen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(429, 171);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 1;
            label5.Text = "Aksam";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(495, 171);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 1;
            label6.Text = "Aperatif";
            // 
            // cmb_Categories
            // 
            cmb_Categories.CornerRoundingRadius = -1F;
            cmb_Categories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categories.DropDownWidth = 121;
            cmb_Categories.IntegralHeight = false;
            cmb_Categories.Location = new Point(661, 171);
            cmb_Categories.Margin = new Padding(3, 4, 3, 4);
            cmb_Categories.Name = "cmb_Categories";
            cmb_Categories.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            cmb_Categories.Size = new Size(138, 25);
            cmb_Categories.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Categories.StateCommon.Item.Content.ShortText.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Categories.TabIndex = 2;
            cmb_Categories.SelectedIndexChanged += cmb_Categories_SelectedIndexChanged;
            // 
            // lbl_Breakfast
            // 
            lbl_Breakfast.AutoSize = true;
            lbl_Breakfast.BackColor = Color.Transparent;
            lbl_Breakfast.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Breakfast.Location = new Point(274, 246);
            lbl_Breakfast.Name = "lbl_Breakfast";
            lbl_Breakfast.Size = new Size(22, 25);
            lbl_Breakfast.TabIndex = 1;
            lbl_Breakfast.Text = "0";
            // 
            // lbl_lunch
            // 
            lbl_lunch.AutoSize = true;
            lbl_lunch.BackColor = Color.Transparent;
            lbl_lunch.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lunch.Location = new Point(359, 246);
            lbl_lunch.Name = "lbl_lunch";
            lbl_lunch.Size = new Size(22, 25);
            lbl_lunch.TabIndex = 1;
            lbl_lunch.Text = "0";
            // 
            // lbl_Dinner
            // 
            lbl_Dinner.AutoSize = true;
            lbl_Dinner.BackColor = Color.Transparent;
            lbl_Dinner.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Dinner.Location = new Point(434, 246);
            lbl_Dinner.Name = "lbl_Dinner";
            lbl_Dinner.Size = new Size(22, 25);
            lbl_Dinner.TabIndex = 1;
            lbl_Dinner.Text = "0";
            // 
            // lbl_Snack
            // 
            lbl_Snack.AutoSize = true;
            lbl_Snack.BackColor = Color.Transparent;
            lbl_Snack.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Snack.Location = new Point(505, 246);
            lbl_Snack.Name = "lbl_Snack";
            lbl_Snack.Size = new Size(22, 25);
            lbl_Snack.TabIndex = 1;
            lbl_Snack.Text = "0";
            // 
            // lbl_OthersBreakfast
            // 
            lbl_OthersBreakfast.AutoSize = true;
            lbl_OthersBreakfast.BackColor = Color.Transparent;
            lbl_OthersBreakfast.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersBreakfast.Location = new Point(274, 310);
            lbl_OthersBreakfast.Name = "lbl_OthersBreakfast";
            lbl_OthersBreakfast.Size = new Size(22, 25);
            lbl_OthersBreakfast.TabIndex = 1;
            lbl_OthersBreakfast.Text = "0";
            // 
            // lbl_OthersLunch
            // 
            lbl_OthersLunch.AutoSize = true;
            lbl_OthersLunch.BackColor = Color.Transparent;
            lbl_OthersLunch.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersLunch.Location = new Point(359, 310);
            lbl_OthersLunch.Name = "lbl_OthersLunch";
            lbl_OthersLunch.Size = new Size(22, 25);
            lbl_OthersLunch.TabIndex = 1;
            lbl_OthersLunch.Text = "0";
            // 
            // lbl_OthersDinner
            // 
            lbl_OthersDinner.AutoSize = true;
            lbl_OthersDinner.BackColor = Color.Transparent;
            lbl_OthersDinner.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersDinner.Location = new Point(434, 310);
            lbl_OthersDinner.Name = "lbl_OthersDinner";
            lbl_OthersDinner.Size = new Size(22, 25);
            lbl_OthersDinner.TabIndex = 1;
            lbl_OthersDinner.Text = "0";
            // 
            // lbl_OthersSnack
            // 
            lbl_OthersSnack.AutoSize = true;
            lbl_OthersSnack.BackColor = Color.Transparent;
            lbl_OthersSnack.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersSnack.Location = new Point(505, 310);
            lbl_OthersSnack.Name = "lbl_OthersSnack";
            lbl_OthersSnack.Size = new Size(22, 25);
            lbl_OthersSnack.TabIndex = 1;
            lbl_OthersSnack.Text = "0";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.BackColor = Color.Transparent;
            lbl_Total.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.Location = new Point(628, 246);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(22, 25);
            lbl_Total.TabIndex = 1;
            lbl_Total.Text = "0";
            // 
            // lbl_OthersTotal
            // 
            lbl_OthersTotal.AutoSize = true;
            lbl_OthersTotal.BackColor = Color.Transparent;
            lbl_OthersTotal.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersTotal.Location = new Point(628, 310);
            lbl_OthersTotal.Name = "lbl_OthersTotal";
            lbl_OthersTotal.Size = new Size(22, 25);
            lbl_OthersTotal.TabIndex = 1;
            lbl_OthersTotal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(585, 171);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 1;
            label7.Text = "Toplam";
            // 
            // FormCompareWeekly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 546);
            Controls.Add(cmb_Categories);
            Controls.Add(label2);
            Controls.Add(lbl_OthersTotal);
            Controls.Add(lbl_OthersSnack);
            Controls.Add(lbl_OthersDinner);
            Controls.Add(lbl_Total);
            Controls.Add(lbl_Snack);
            Controls.Add(lbl_Dinner);
            Controls.Add(lbl_OthersLunch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lbl_lunch);
            Controls.Add(lbl_OthersBreakfast);
            Controls.Add(label5);
            Controls.Add(lbl_Breakfast);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCompareWeekly";
            StartPosition = FormStartPosition.Manual;
            Text = "FormCompare";
            Load += FormCompareWeekly_Load;
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonComboBox cmb_Categories;
        private Label lbl_Breakfast;
        private Label lbl_lunch;
        private Label lbl_Dinner;
        private Label lbl_Snack;
        private Label lbl_OthersBreakfast;
        private Label lbl_OthersLunch;
        private Label lbl_OthersDinner;
        private Label lbl_OthersSnack;
        private Label lbl_Total;
        private Label lbl_OthersTotal;
        private Label label7;
    }
}