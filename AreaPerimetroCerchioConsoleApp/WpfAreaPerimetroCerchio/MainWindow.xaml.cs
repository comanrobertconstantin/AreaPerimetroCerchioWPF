using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAreaPerimetroCerchio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnAreaAndPerimeter_Click(object sender, RoutedEventArgs e)
        {
            double risArea = 0;
            double risPerimeter = 0;

            double raggio = Convert.ToDouble(txtRadius.Text);

            HttpClient client = new HttpClient();

            string urlArea = "https://localhost:44327/api/Operations/GetArea?raggio={raggio}";
            string urlPerimeter = "https://localhost:44327/api/Operations/GetPerimeter?raggio={raggio}";

            HttpResponseMessage responseArea = await client.GetAsync(urlArea);
            HttpResponseMessage responsePerimeter = await client.GetAsync(urlPerimeter);

            string contentArea = await responseArea.Content.ReadAsStringAsync();
            string contentPerimeter = await responsePerimeter.Content.ReadAsStringAsync();

            risArea = JsonConvert.DeserializeObject<double>(contentArea);
            risPerimeter = JsonConvert.DeserializeObject<double>(contentPerimeter);

            Dispatcher.Invoke(() => lblArea.Content = risArea);
            Dispatcher.Invoke(() => lblPerimeter.Content = risPerimeter);
        }
    }
}
