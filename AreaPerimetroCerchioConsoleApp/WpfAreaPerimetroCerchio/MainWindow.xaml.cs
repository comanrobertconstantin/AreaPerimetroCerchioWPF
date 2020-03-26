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

        private async void btnArea_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;

            double raggio = Convert.ToDouble(txtNr.Text);

            HttpClient client = new HttpClient();

            string url = "https://localhost:44327/api/Operations/GetArea?raggio={raggio}";

            HttpResponseMessage response = await client.GetAsync(url);

            string content = await response.Content.ReadAsStringAsync();

            ris = JsonConvert.DeserializeObject<double>(content);

            Dispatcher.Invoke(() => lblArea.Content = ris);
        }
    }
}
