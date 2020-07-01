//Emilia Lebiedowska 242473

using System;
using System.Linq;
using Windows.ApplicationModel;
using Windows.Media.SpeechSynthesis;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace ZAD7
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {     
        String text = "";
        

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Play(VoiceGender.Female);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Play(VoiceGender.Male);
        }

        private async void Play(VoiceGender gender)
        {
            MediaElement mediaElement = new MediaElement();
            var synte = new SpeechSynthesizer();
            VoiceInformation voiceInfo =
           (
               from voice in SpeechSynthesizer.AllVoices
               where voice.Gender == gender
               select voice
           ).FirstOrDefault() ?? SpeechSynthesizer.DefaultVoice;
            synte.Voice = voiceInfo;
            
            GetText();
            SpeechSynthesisStream stm = await synte.SynthesizeTextToStreamAsync(text);
            mediaElement.SetSource(stm, stm.ContentType);
            mediaElement.Play();
        }

        private async void GetText()
        {
            string root = Package.Current.InstalledLocation.Path;
            string path = root + @"\Assets";
            StorageFolder storageFolder = await StorageFolder.GetFolderFromPathAsync(path);
            StorageFile sampleFile = await storageFolder.GetFileAsync("plik.txt");
            text = await FileIO.ReadTextAsync(sampleFile);
        }
    }
}
