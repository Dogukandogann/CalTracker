using Services.Abstract;
using Services.Concrete;
using System.Drawing.Drawing2D;


namespace FormUI
{
    public partial class FormFoodConsumption : Form
    {
        private readonly IUserMealService _userMealService = new UserMealManager();
        public FormFoodConsumption()
        {
            InitializeComponent();
        }

        private void FormFoodConsumption_Load(object sender, EventArgs e)
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

            dgv_FoodConsumption.DataSource = _userMealService.GetFoodConsumptionForAllTimes();

        }
    }
}
