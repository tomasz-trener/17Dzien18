using Newtonsoft.Json;
using P03AplikacjaPogodaClientAPI.Models.CityModel;
using P03AplikacjaPogodaClientAPI.ViewModels.ProductViewModel;
using P05Sklep.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P03AplikacjaPogodaClientAPI
{
    /// <summary>
    /// Interaction logic for ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        public ShopWindow()
        {
            InitializeComponent();
            shopPanel.DataContext = new ProdcutWindowVM();
        }

        private async void btnShopApiTest_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://localhost:7140";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var result= await client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("api/weatherforecast");

                string m= string.Join(' ',result.Select(x=>x.Summary).ToArray());
                MessageBox.Show(m);
            }

            //using (HttpClient client = new HttpClient())
            //{
            //    var response = await client.GetAsync(url);
            //    string json = await response.Content.ReadAsStringAsync();

            //    City[]? cities = JsonConvert.DeserializeObject<City[]>(json);
            //    return cities;
            //}


        }
    }
}
