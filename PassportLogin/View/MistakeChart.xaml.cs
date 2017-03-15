using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;
using ErrorLog.View;
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
            stSource.Add(new firstGraph() { Name = "Silly",Amount = GlobalsSil.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Conceptual", Amount = GlobalsConc.GlobalInt });
            stSource.Add(new firstGraph() { Name = "Others", Amount = GlobalsOth.GlobalInt });
            stSource.Add(new firstGraph() { Name = "", Amount = 0 });
            (ColumnChart.Series[0] as ColumnSeries).ItemsSource = stSource;
            (PieChart.Series[0] as PieSeries).ItemsSource = stSource;
        }
    }
}
