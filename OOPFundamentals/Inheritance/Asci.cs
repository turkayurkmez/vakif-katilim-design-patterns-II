namespace Inheritance
{
    public class Asci
    {
        public string Ad { get; set; }
        public void Pisir(Yemek yemek)
        {
            yemek.Pisir();
            yemek.SunumYap();
        }

        public void Hazirla(Yemek yemek)
        {

        }
    }
}
