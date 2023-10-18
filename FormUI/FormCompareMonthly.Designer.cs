namespace FormUI
{
    partial class FormCompareMonthly
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
            cmb_Categories = new Krypton.Toolkit.KryptonComboBox();
            label2 = new Label();
            lbl_OthersTotal = new Label();
            lbl_OthersSnack = new Label();
            lbl_OthersDinner = new Label();
            lbl_Total = new Label();
            lbl_Snack = new Label();
            lbl_Dinner = new Label();
            lbl_OthersLunch = new Label();
            label6 = new Label();
            lbl_lunch = new Label();
            lbl_OthersBreakfast = new Label();
            label5 = new Label();
            lbl_Breakfast = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).BeginInit();
            SuspendLayout();
            // 
            // cmb_Categories
            // 
            cmb_Categories.CornerRoundingRadius = -1F;
            cmb_Categories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Categories.DropDownWidth = 121;
            cmb_Categories.IntegralHeight = false;
            cmb_Categories.Location = new Point(670, 169);
            cmb_Categories.Margin = new Padding(3, 4, 3, 4);
            cmb_Categories.Name = "cmb_Categories";
            cmb_Categories.Size = new Size(138, 25);
            cmb_Categories.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmb_Categories.TabIndex = 21;
            cmb_Categories.SelectedIndexChanged += cmb_Categories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 319);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 19;
            label2.Text = "Diger Kullanicilar";
            // 
            // lbl_OthersTotal
            // 
            lbl_OthersTotal.AutoSize = true;
            lbl_OthersTotal.BackColor = Color.Transparent;
            lbl_OthersTotal.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersTotal.Location = new Point(646, 319);
            lbl_OthersTotal.Name = "lbl_OthersTotal";
            lbl_OthersTotal.Size = new Size(22, 25);
            lbl_OthersTotal.TabIndex = 18;
            lbl_OthersTotal.Text = "0";
            // 
            // lbl_OthersSnack
            // 
            lbl_OthersSnack.AutoSize = true;
            lbl_OthersSnack.BackColor = Color.Transparent;
            lbl_OthersSnack.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersSnack.Location = new Point(515, 319);
            lbl_OthersSnack.Name = "lbl_OthersSnack";
            lbl_OthersSnack.Size = new Size(22, 25);
            lbl_OthersSnack.TabIndex = 17;
            lbl_OthersSnack.Text = "0";
            // 
            // lbl_OthersDinner
            // 
            lbl_OthersDinner.AutoSize = true;
            lbl_OthersDinner.BackColor = Color.Transparent;
            lbl_OthersDinner.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersDinner.Location = new Point(432, 319);
            lbl_OthersDinner.Name = "lbl_OthersDinner";
            lbl_OthersDinner.Size = new Size(22, 25);
            lbl_OthersDinner.TabIndex = 16;
            lbl_OthersDinner.Text = "0";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.BackColor = Color.Transparent;
            lbl_Total.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.Location = new Point(646, 247);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(22, 25);
            lbl_Total.TabIndex = 15;
            lbl_Total.Text = "0";
            // 
            // lbl_Snack
            // 
            lbl_Snack.AutoSize = true;
            lbl_Snack.BackColor = Color.Transparent;
            lbl_Snack.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Snack.Location = new Point(515, 247);
            lbl_Snack.Name = "lbl_Snack";
            lbl_Snack.Size = new Size(22, 25);
            lbl_Snack.TabIndex = 14;
            lbl_Snack.Text = "0";
            // 
            // lbl_Dinner
            // 
            lbl_Dinner.AutoSize = true;
            lbl_Dinner.BackColor = Color.Transparent;
            lbl_Dinner.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Dinner.Location = new Point(432, 247);
            lbl_Dinner.Name = "lbl_Dinner";
            lbl_Dinner.Size = new Size(22, 25);
            lbl_Dinner.TabIndex = 13;
            lbl_Dinner.Text = "0";
            // 
            // lbl_OthersLunch
            // 
            lbl_OthersLunch.AutoSize = true;
            lbl_OthersLunch.BackColor = Color.Transparent;
            lbl_OthersLunch.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersLunch.Location = new Point(353, 319);
            lbl_OthersLunch.Name = "lbl_OthersLunch";
            lbl_OthersLunch.Size = new Size(22, 25);
            lbl_OthersLunch.TabIndex = 20;
            lbl_OthersLunch.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(504, 169);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 12;
            label6.Text = "Aperatif";
            // 
            // lbl_lunch
            // 
            lbl_lunch.AutoSize = true;
            lbl_lunch.BackColor = Color.Transparent;
            lbl_lunch.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lunch.Location = new Point(353, 247);
            lbl_lunch.Name = "lbl_lunch";
            lbl_lunch.Size = new Size(22, 25);
            lbl_lunch.TabIndex = 11;
            lbl_lunch.Text = "0";
            // 
            // lbl_OthersBreakfast
            // 
            lbl_OthersBreakfast.AutoSize = true;
            lbl_OthersBreakfast.BackColor = Color.Transparent;
            lbl_OthersBreakfast.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_OthersBreakfast.Location = new Point(265, 319);
            lbl_OthersBreakfast.Name = "lbl_OthersBreakfast";
            lbl_OthersBreakfast.Size = new Size(22, 25);
            lbl_OthersBreakfast.TabIndex = 10;
            lbl_OthersBreakfast.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(422, 169);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 9;
            label5.Text = "Aksam";
            // 
            // lbl_Breakfast
            // 
            lbl_Breakfast.AutoSize = true;
            lbl_Breakfast.BackColor = Color.Transparent;
            lbl_Breakfast.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Breakfast.Location = new Point(265, 247);
            lbl_Breakfast.Name = "lbl_Breakfast";
            lbl_Breakfast.Size = new Size(22, 25);
            lbl_Breakfast.TabIndex = 8;
            lbl_Breakfast.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(341, 169);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 7;
            label4.Text = "Oglen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 169);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 6;
            label3.Text = "Kahvalti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 247);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 5;
            label1.Text = "Siz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(598, 169);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 12;
            label7.Text = "Toplam";
            // 
            // FormCompareMonthly
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
            Name = "FormCompareMonthly";
            StartPosition = FormStartPosition.Manual;
            Text = "FormCompareMonthly";
            Load += FormCompareMonthly_Load;
            ((System.ComponentModel.ISupportInitialize)cmb_Categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cmb_Categories;
        private Label label2;
        private Label lbl_OthersTotal;
        private Label lbl_OthersSnack;
        private Label lbl_OthersDinner;
        private Label lbl_Total;
        private Label lbl_Snack;
        private Label lbl_Dinner;
        private Label lbl_OthersLunch;
        private Label label6;
        private Label lbl_lunch;
        private Label lbl_OthersBreakfast;
        private Label label5;
        private Label lbl_Breakfast;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label7;
    }
}