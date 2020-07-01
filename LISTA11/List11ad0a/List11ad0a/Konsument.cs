using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace List11ad0a
{
    class Konsument
    {
        // metoda obsługi nie ma parametrów, dlatego event typu Action
        public void ObsluzUjemne()	//proc. obsługi zdarzenia1
        {
            WriteLine("Obsługa zdarzenia: X ujemne");
        }
        public void ObsluzDodatnie()    //proc. obsługi zdarzenia2
        {
            WriteLine("Obsługa zdarzenia: X dodatnie");
        }
    }
}
