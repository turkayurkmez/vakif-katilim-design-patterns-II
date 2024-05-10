using srvTcKimlik;

namespace ProxyWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            KPSPublicSoapClient kPSPublicSoapClient = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = await kPSPublicSoapClient.TCKimlikNoDogrulaAsync(111, "Türkay", "Ürkmez", 1980);
            if (result.Body.TCKimlikNoDogrulaResult)
            {
                MessageBox.Show("true");
            }


        }
    }
}
