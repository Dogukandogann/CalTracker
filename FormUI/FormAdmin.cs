using Entities.Concrete;
using FormUI.Utilities;
using Microsoft.IdentityModel.Tokens;
using Services.Abstract;
using Services.Concrete;
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
    public partial class FormAdmin : Form
    {
        private readonly IFoodService _foodService = new FoodManager();
        private readonly ICategoryService _categoryService = new CategoryManager();
        private string? _foodPicPath;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!txt_FoodName.Text.IsNullOrEmpty() && cmb_FoodCategory.SelectedIndex > -1)
            {
                Food food = new Food()
                {
                    Name = txt_FoodName.Text,
                    Calorie = (double)nud_Calorie.Value,
                    Fat = (double)nud_Fat.Value,
                    Protein = (double)nud_Protein.Value,
                    Carbonhidrate = (double)nud_Carbonhidrate.Value,
                    FoodCategoryId = cmb_FoodCategory.SelectedIndex + 1,
                    ImagePath = _foodPicPath,
                    Gram = (int)nud_Gram.Value
                };

                _foodService.AddNewFood(food);
                FormHelpers.Clear(this.Controls);
                MessageBox.Show("Food added");
            }
            else
                MessageBox.Show("Isim ve Kategori Bos Gecilemez");
        }

        private void btn_SelectPicture_Click(object sender, EventArgs e)
        {
            pb_FoodPicture.ImageLocation = _foodPicPath = txt_PictureUrl.Text;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
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

            cmb_FoodCategory.DataSource = _categoryService.GetCategoryNames().ToList();
        }


        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                Application.ExitThread();
        }

        private void btn_SelectPicture_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_PictureUrl.Text))
            {
                pb_FoodPicture.ImageLocation = txt_PictureUrl.Text;
                pb_FoodPicture.Load();

            }

            else
                pb_FoodPicture.ImageLocation = null;

        }
    }
}
