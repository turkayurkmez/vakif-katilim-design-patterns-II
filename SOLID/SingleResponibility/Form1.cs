namespace SingleResponibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
* Bir nesne, sadece bir sorumluluğa sahip olmalıdır.
* 
* Bir nesne içinde (işlevsel) değişiklik ya da ek yapmak birden farklı sebebiniz varsa, prensibi ihlal ediyorsunuz demektir.
* 
* 
*/
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var productService = new ProductService();
            productService.AddProduct(name, price);

            new NotificationService().SendInfoMail("info@products.com", "Mail'in içeriği...");

        }

        private void buttonChangeBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
