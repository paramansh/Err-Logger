using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;
using ErrorLog.View;
using System;

using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ErrorLog.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public class firstGraph
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
    public sealed partial class BlankPage1 : Page
    {
    
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void chartPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadChartContents();
        }
        private void LoadChartContents()
        {
           
            List<firstGraph> stSource = new List<firstGraph>();
            stSource.Add(new firstGraph() { Name = "Cal Err",Amount = GlobalsSil.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Concept", Amount = GlobalsConc.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Oversight", Amount = GlobalsOth.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Recall", Amount = GlobalsRcl.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Time", Amount = GlobalsTime.GlobalInt });
            stSource.Add(new firstGraph() { Name = "", Amount = 0 });
            (ColumnChart.Series[0] as ColumnSeries).ItemsSource = stSource;
            (PieChart.Series[0] as PieSeries).ItemsSource = stSource;
        }
        public class Keypharesec
        {
            public string phrases
            {
                get;
                set;
            }
        }
        public class Kpcol
        {
            public Keypharesec kpco
            {
                get;
                set;
            }
        }
        static string requestString;
        public ObservableCollection<Kpcol> KeyPharseResults
        {
            get;
            set;
        } = new ObservableCollection<Kpcol>();
        private async void btnKeyPhrase_Click(object sender, RoutedEventArgs e)
        {
            
            var kp = await getKeyPhrase();
            for (int i = 0; i < kp.Count(); i++)
            {
                Keypharesec kc = kp.ElementAt(i);
                KeyPharseResults.Add(new Kpcol
                {
                    kpco = kc
                });
            }
        }
        static async Task<IEnumerable<Keypharesec>> getKeyPhrase()
        {
            List<Keypharesec> phrases = new List<Keypharesec>();
            var client = new HttpClient();
            string language = "en";
            string[] input = new string[] {
        GlobalString.GlobString
    };
            if (input != null)
            {
                // Request body.  
                requestString = "{\"documents\":[";
                for (int i = 0; i < input.Length; i++)
                {
                    requestString += string.Format("{{\"id\":\"{0}\",\"text\":\"{1}\", \"language\":\"{2}\"}}", i, input[i].Replace("\"", "'"), language);
                    if (i != input.Length - 1)
                    {
                        requestString += ",";
                    }
                }
                requestString += "]}";
            }
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "9b7c52dfa54a4696b70e47320ea27176");
            var uri = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases?";
            HttpResponseMessage response;
            byte[] byteData = System.Text.Encoding.UTF8.GetBytes(requestString);
            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
            }
            string content1 = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Text Analytics failed. " + content1);
            }
            dynamic data = JObject.Parse(content1);
            if (data.documents != null)
            {
                for (int i = 0; i < data.documents.Count; i++)
                {
                    for (int j = 0; j < data.documents[i].keyPhrases.Count; j++)
                    {
                        phrases.Add(new Keypharesec
                        {
                            phrases = data.documents[i].keyPhrases[j]
                        });
                    }
                }
            }
            return phrases;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NewEntry));
        }

        private void remedialbutton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SubmittedForm));
        }
    }

}
