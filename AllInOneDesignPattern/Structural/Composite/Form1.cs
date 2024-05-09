namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Composite<Category> categories = new Composite<Category>()
            {
                Node = new Category() { Name = "Kategoriler" }
            };
                
            var elektronik = categories.Add(new Category { Name = "Elektronik" });
            var bilgisayar = elektronik.Add(new Category { Name = "Bilgisayar" });
            var laptop = bilgisayar.Add(new Category { Name = "Laptop" });
            var desktop = bilgisayar.Add(new Category { Name = "Desktop" });
            var sesSistemi = elektronik.Add(new Category { Name = "Ses sistemi" });

            Composite<Category>.Show(1, categories, treeViewCategories);
        }
    }
}
