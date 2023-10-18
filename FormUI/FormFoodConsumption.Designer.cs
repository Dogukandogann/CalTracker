namespace FormUI
{
    partial class FormFoodConsumption
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
            dgv_FoodConsumption = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_FoodConsumption).BeginInit();
            SuspendLayout();
            // 
            // dgv_FoodConsumption
            // 
            dgv_FoodConsumption.AllowUserToAddRows = false;
            dgv_FoodConsumption.AllowUserToDeleteRows = false;
            dgv_FoodConsumption.AllowUserToResizeRows = false;
            dgv_FoodConsumption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_FoodConsumption.ColumnHeadersHeight = 36;
            dgv_FoodConsumption.Location = new Point(96, 93);
            dgv_FoodConsumption.MultiSelect = false;
            dgv_FoodConsumption.Name = "dgv_FoodConsumption";
            dgv_FoodConsumption.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Silver;
            dgv_FoodConsumption.RowHeadersVisible = false;
            dgv_FoodConsumption.RowHeadersWidth = 51;
            dgv_FoodConsumption.RowTemplate.Height = 29;
            dgv_FoodConsumption.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_FoodConsumption.Size = new Size(717, 361);
            dgv_FoodConsumption.StateCommon.Background.Color1 = Color.Transparent;
            dgv_FoodConsumption.StateCommon.Background.Color2 = Color.Transparent;
            dgv_FoodConsumption.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgv_FoodConsumption.StateCommon.DataCell.Content.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_FoodConsumption.StateNormal.Background.Color1 = Color.Transparent;
            dgv_FoodConsumption.StateNormal.Background.Color2 = Color.Transparent;
            dgv_FoodConsumption.StateNormal.DataCell.Back.Color1 = Color.Transparent;
            dgv_FoodConsumption.StateNormal.DataCell.Back.Color2 = Color.Transparent;
            dgv_FoodConsumption.StateNormal.HeaderColumn.Back.Color1 = Color.ForestGreen;
            dgv_FoodConsumption.StateNormal.HeaderColumn.Back.Color2 = Color.ForestGreen;
            dgv_FoodConsumption.StateNormal.HeaderColumn.Content.Color1 = Color.Honeydew;
            dgv_FoodConsumption.StateNormal.HeaderColumn.Content.Color2 = Color.Honeydew;
            dgv_FoodConsumption.StateSelected.DataCell.Back.Color1 = Color.LightGreen;
            dgv_FoodConsumption.StateSelected.DataCell.Back.Color2 = Color.LightGreen;
            dgv_FoodConsumption.StateSelected.HeaderRow.Back.Color1 = Color.LightGreen;
            dgv_FoodConsumption.StateSelected.HeaderRow.Back.Color2 = Color.LightGreen;
            dgv_FoodConsumption.StateTracking.HeaderColumn.Back.Color1 = Color.ForestGreen;
            dgv_FoodConsumption.StateTracking.HeaderColumn.Back.Color2 = Color.ForestGreen;
            dgv_FoodConsumption.StateTracking.HeaderRow.Back.Color1 = Color.FromArgb(32, 191, 107);
            dgv_FoodConsumption.StateTracking.HeaderRow.Back.Color2 = Color.FromArgb(128, 255, 128);
            dgv_FoodConsumption.StateTracking.HeaderRow.Border.Color1 = Color.DarkGreen;
            dgv_FoodConsumption.StateTracking.HeaderRow.Border.Color2 = Color.DarkGreen;
            dgv_FoodConsumption.StateTracking.HeaderRow.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dgv_FoodConsumption.TabIndex = 0;
            // 
            // FormFoodConsumption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 546);
            Controls.Add(dgv_FoodConsumption);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFoodConsumption";
            StartPosition = FormStartPosition.Manual;
            Text = "FormFoodConsumption";
            Load += FormFoodConsumption_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_FoodConsumption).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgv_FoodConsumption;
    }
}