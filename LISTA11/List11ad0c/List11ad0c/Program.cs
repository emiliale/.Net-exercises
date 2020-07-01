//Emilia Lebiedowska242473
using System;
using System.Threading;
using static System.Console;

namespace List11ad0c
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer1 = new CarDealer("Dealer1");
            var dealer2 = new CarDealer("Dealer2");

            var michal = new Consumer("Michał"); //k_1
            // subskrypcja zdarzenia przez klienta nr 1 (k_1)
            dealer1.NewCarInfo += michal.NewCarIsHere;
            // emisja zdarzenia z param. "Audi/A-6", czeka k_1
            dealer1.RaiseNewCarInfo("Audi/A-6");
            Thread.Sleep(3000); // symulacja upływu czasu

            var ela = new Consumer("Ela"); //k_2
            var kalina = new Consumer("Kalina"); //k_3
            // subskrypcja zdarzenia przez k_2
            dealer1.NewCarInfo += ela.NewCarIsHere;
            dealer2.NewCarInfo += michal.NewCarIsHere;
            // emisja zdarzenia z param. "Honda/Accord", czeka k_1,k_2
            dealer2.RaiseNewCarInfo("Honda/Accord");
            dealer1.RaiseNewCarInfo("Toyota/Yaris");
            Thread.Sleep(3000); // symulacja upływu czasu

            // desubskrypcja zdarzenia przez k_1
            dealer1.NewCarInfo -= michal.NewCarIsHere;
            // subskrypcja zdarzenia przez k_3
            dealer1.NewCarInfo += kalina.NewCarIsHere;
            dealer2.NewCarInfo += ela.NewCarIsHere;
            // emisja zdarzenia z param. "Opel/Corsa", czeka k_2,k_3
            dealer1.RaiseNewCarInfo("Opel/Corsa");
            dealer2.RaiseNewCarInfo("Opel/Vectra");
            Thread.Sleep(3000); // symulacja upływu czasu

            dealer1.NewCarInfo -= kalina.NewCarIsHere; // desubskrypcja
            dealer1.NewCarInfo -= ela.NewCarIsHere; // desubskrypcja

            dealer2.NewCarInfo += kalina.NewCarIsHere;
            dealer2.NewCarInfo -= michal.NewCarIsHere;
            dealer2.RaiseNewCarInfo("Honda/Civic");
            Thread.Sleep(3000); // symulacja upływu czasu

            // BRAK emisji zdarzenia, nikt nie czeka!
            dealer1.RaiseNewCarInfo("Opel/Insygnia");
            Thread.Sleep(1000); // symulacja upływu czasu

            WriteLine("To już koniec...nikt nie czeka!");

        }
    }
}
