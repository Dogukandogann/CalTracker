using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class FormReports : Form
    {
        private readonly int _userId;
        public FormReports(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(32, 191, 107);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(32, 191, 107),
                Color.FromArgb(50, 210, 255),
                360f
            );
            this.Paint += (sender, e) =>
            {
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            };

            var daily = new FormDailyReport(_userId);
            daily.MdiParent = this;
            daily.Show();
        }

        private void gunlukRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormDailyReport(_userId);

            CloseOtherChildForms(form);

        }

        private void yemekRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMostConsumed();

            CloseOtherChildForms(form);

        }

        private void CloseOtherChildForms(Form form)
        {
            if (ActiveMdiChild != null)
            {
                foreach (Form item in this.MdiChildren)
                {
                    item.Close();
                }
                form.MdiParent = this;
                form.Show();
            }
        }

        private void enCokYenenYemeklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMostConsumed();

            CloseOtherChildForms(form);
        }

        private void yemekBazliTuketimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFoodConsumption();

            CloseOtherChildForms(form);
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompareMonthly(_userId);

            CloseOtherChildForms(form);

        }

        private void haftalıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompareWeekly(_userId);

            CloseOtherChildForms(form);
        }
    }
}
