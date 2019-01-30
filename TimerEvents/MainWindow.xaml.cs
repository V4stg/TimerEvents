using System;
using System.Windows;
using System.Windows.Threading;

namespace TimerEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 1);
            _timer.Tick += new EventHandler(dispathcerTimer_Tick);
            _timer.Start();
        }

        private void dispathcerTimer_Tick(object sender, EventArgs e)
        {
            myProgressBar.Value += 10;
            if (myProgressBar.Value >= 100)
            {
                _timer.Stop();
            }
        }
    }
}
