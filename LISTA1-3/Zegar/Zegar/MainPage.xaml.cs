using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Zegar
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer _timer = new DispatcherTimer(); 

        public MainPage()
        {
            this.InitializeComponent();
            _timer.Tick += OnTick;
            _timer.Interval = TimeSpan.FromSeconds(1);
        }
        private void OnTimer()
        {
            _timer.Start();
        }
        private void OnTick(object sender, object e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute; int sec = DateTime.Now.Second;

            if (hour > 12)
            {
                hour -= 12;
            }

            double newAngle = 30 * hour;
            if (newAngle >= 360) newAngle = 0; rotateH.Angle = newAngle; newAngle = 6 * minute;
            if (newAngle >= 360) newAngle = 0; rotateM.Angle = newAngle; newAngle = 6 * sec;
            if (newAngle >= 360) newAngle = 0; rotateS.Angle = newAngle;
        }
        private void OnStopTimer()
        {
            _timer.Stop();
        }
    }

 }

