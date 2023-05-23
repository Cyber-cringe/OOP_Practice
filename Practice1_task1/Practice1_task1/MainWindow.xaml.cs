using System.Windows;

namespace Practice1_task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private IMeasuringDevice device;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ImperialButton.IsChecked == true)
            {
                device = new MeasureLengthDevice(Units.Imperial);
            }
            else if(MetricButton.IsChecked == true)
            {
                device = new MeasureLengthDevice(Units.Metric);
            }
        }

        private void GetRawData_Click(object sender, RoutedEventArgs e)
        {
            int[] rawData = device.GetRawData();
            rawDataList.Items.Clear();
            foreach (int data in rawData)
            {
                rawDataList.Items.Add(data);
            }
        }
        private void StartCollecting_Click(object sender, RoutedEventArgs e)
        {
            device?.StartCollecting();
        }
        private void StopCollecting_Click(object sender, RoutedEventArgs e)
        {
            device?.StopCollecting();
        }
        private void GetMetricValue_Click(object sender, RoutedEventArgs e)
        {
            decimal metricValue = device.MetricValue();
        }

        private void GetImperialValue_Click(object sender, RoutedEventArgs e)
        {
            decimal imperialValue = device.ImperialValue();
        }
    }
}
