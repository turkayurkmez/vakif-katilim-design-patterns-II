namespace Encapsulation
{
    public class Product
    {
        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new Exception("Ürün fiyatı negatif olamaz");
            }
            this.price = value;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        private string name = string.Empty;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Ürün adı en az 3 harf olmalı");
                }
                name = value;
            }
        }

        public string Description { get; set; }

        public int Stock { get; private set; }

        public void IncreaseStock(int value) => Stock += value;




    }
}
