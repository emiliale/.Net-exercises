using System;
using System.Collections.Generic;
using System.Text;

namespace List11ad0a
{
    // klasa - emitent zdarzeń
    public class Demo
    {
        private int x;
        public event Action XJestUjemne;    // deklar. zdarzenia 1
        public event Action XJestDodatnie;  // deklar. zdarzenia 2

        public void SetX(int x) // ustaw x
        {
            this.x = x;
            if (x < 0)
            {
                // emituj zdarzenie, gdy w delegacie są zarejestrowane
                // procedury odbioru
                // if (XJestUjemne != null) XJestUjemne();
                XJestUjemne?.Invoke();  //tak prościej!
            }
            if (x > 0)
            {
                XJestDodatnie?.Invoke(); //tak prościej!
            }
        }
        // chwilowo zbędnia
        public int GetX()   // pobierz x
        {
            return x;
        }
    }
}

