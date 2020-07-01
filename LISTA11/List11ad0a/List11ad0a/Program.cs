using System;
using System.Threading;
using static System.Console;

namespace List11ad0a
{
    class Program   // symulacja działań
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo(); // inst. emitenta zdarzeń
            Konsument kons = new Konsument();	// inst. słuchacza zdarzeń

            // subskrybcja zdarzenia 1 = rejestracja procedury obsługi 
            demo.XJestUjemne += kons.ObsluzUjemne;

            // subskrybcja zdarzenia 2 = rejestracja procedury obsługi 
            demo.XJestDodatnie += kons.ObsluzDodatnie;

            WriteLine($"Emisja zdarzenia: XJestUjemne");
            demo.SetX(-1);  // konsument dostanie info o zdarzeniu
            Thread.Sleep(3000);
            WriteLine($"\nEmisja zdarzenia: XJestDodatnie");
            demo.SetX(+1);  // konsument dostanie info o zdarzeniu 
            Thread.Sleep(3000);
            WriteLine($"\nX ustawine na 0 nie powoduje emisji zdarzenia");
            demo.SetX(0);
            Thread.Sleep(1000);

            WriteLine($"\nSkasowanie subskrypcji zdarzenia XJestUjemne");
            demo.XJestUjemne -= kons.ObsluzUjemne;
            Thread.Sleep(1000);

            WriteLine($"lista pusta = emitent nie emituje zdarzenia XJestUjemne"); 
            demo.SetX(-1); // emisja zdarzenia XJestUjemne
            Thread.Sleep(1000);

            WriteLine($"\nEmisja zdarzenia: XJestDodatnie");
            demo.SetX(+1); // konsument dostanie info o zdarzeniu

            WriteLine($"\nSkasowanie subskrypcji zdarzenia XJestDodatnie\n i koniec przykładu.");
            demo.XJestDodatnie -= kons.ObsluzDodatnie;
        }
    }
}



