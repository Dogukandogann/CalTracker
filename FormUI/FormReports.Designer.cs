namespace FormUI
{
    partial class FormReports
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
            menuStrip1 = new MenuStrip();
            gunlukRaporToolStripMenuItem = new ToolStripMenuItem();
            kiyasRaporuToolStripMenuItem = new ToolStripMenuItem();
            aylıkRaporToolStripMenuItem = new ToolStripMenuItem();
            haftalıkRaporToolStripMenuItem = new ToolStripMenuItem();
            yemekRaporuToolStripMenuItem = new ToolStripMenuItem();
            enÇokYenenYemeklerToolStripMenuItem = new ToolStripMenuItem();
            yemekBazlıTüketimToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gunlukRaporToolStripMenuItem, kiyasRaporuToolStripMenuItem, yemekRaporuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(916, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gunlukRaporToolStripMenuItem
            // 
            gunlukRaporToolStripMenuItem.Name = "gunlukRaporToolStripMenuItem";
            gunlukRaporToolStripMenuItem.Size = new Size(112, 24);
            gunlukRaporToolStripMenuItem.Text = "Günlük Rapor";
            gunlukRaporToolStripMenuItem.Click += gunlukRaporToolStripMenuItem_Click;
            // 
            // kiyasRaporuToolStripMenuItem
            // 
            kiyasRaporuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aylıkRaporToolStripMenuItem, haftalıkRaporToolStripMenuItem });
            kiyasRaporuToolStripMenuItem.Name = "kiyasRaporuToolStripMenuItem";
            kiyasRaporuToolStripMenuItem.Size = new Size(109, 24);
            kiyasRaporuToolStripMenuItem.Text = "Kıyas Raporu";
            // 
            // aylıkRaporToolStripMenuItem
            // 
            aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            aylıkRaporToolStripMenuItem.Size = new Size(188, 26);
            aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            aylıkRaporToolStripMenuItem.Click += aylıkRaporToolStripMenuItem_Click;
            // 
            // haftalıkRaporToolStripMenuItem
            // 
            haftalıkRaporToolStripMenuItem.Name = "haftalıkRaporToolStripMenuItem";
            haftalıkRaporToolStripMenuItem.Size = new Size(188, 26);
            haftalıkRaporToolStripMenuItem.Text = "Haftalık Rapor";
            haftalıkRaporToolStripMenuItem.Click += haftalıkRaporToolStripMenuItem_Click;
            // 
            // yemekRaporuToolStripMenuItem
            // 
            yemekRaporuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enÇokYenenYemeklerToolStripMenuItem, yemekBazlıTüketimToolStripMenuItem });
            yemekRaporuToolStripMenuItem.Name = "yemekRaporuToolStripMenuItem";
            yemekRaporuToolStripMenuItem.Size = new Size(118, 24);
            yemekRaporuToolStripMenuItem.Text = "Yemek Raporu";
            // 
            // enÇokYenenYemeklerToolStripMenuItem
            // 
            enÇokYenenYemeklerToolStripMenuItem.Name = "enÇokYenenYemeklerToolStripMenuItem";
            enÇokYenenYemeklerToolStripMenuItem.Size = new Size(244, 26);
            enÇokYenenYemeklerToolStripMenuItem.Text = "En Çok Yenen Yemekler";
            enÇokYenenYemeklerToolStripMenuItem.Click += enCokYenenYemeklerToolStripMenuItem_Click;
            // 
            // yemekBazlıTüketimToolStripMenuItem
            // 
            yemekBazlıTüketimToolStripMenuItem.Name = "yemekBazlıTüketimToolStripMenuItem";
            yemekBazlıTüketimToolStripMenuItem.Size = new Size(244, 26);
            yemekBazlıTüketimToolStripMenuItem.Text = "Yemek Bazlı Tüketim";
            yemekBazlıTüketimToolStripMenuItem.Click += yemekBazliTuketimToolStripMenuItem_Click;
            // 
            // FormReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 580);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReports";
            Load += FormReports_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gunlukRaporToolStripMenuItem;
        private ToolStripMenuItem kiyasRaporuToolStripMenuItem;
        private ToolStripMenuItem yemekRaporuToolStripMenuItem;
        private ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private ToolStripMenuItem haftalıkRaporToolStripMenuItem;
        private ToolStripMenuItem enÇokYenenYemeklerToolStripMenuItem;
        private ToolStripMenuItem yemekBazlıTüketimToolStripMenuItem;
    }
}