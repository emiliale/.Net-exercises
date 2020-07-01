using System.Speech.Synthesis;
using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var syn = new SpeechSynthesizer();
            syn.SpeakAsync("Hello from Windows Presentation Foundation!");
        }

    }
}
