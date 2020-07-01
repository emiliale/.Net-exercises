using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace demo3
{
    class Info
    {
        public void WyswietlDane(string message,
                                 [CallerMemberName] string memberName = "",
                                 [CallerFilePath] string sourceFilePath = "",
                                 [CallerLineNumber] int sourceLineNumber = 0)
        {
            Trace.WriteLine("Wiadomość:" + message);
            Trace.WriteLine("Nazwa metody:" + memberName);
            Trace.WriteLine("Plik źródłowy:" + sourceFilePath);
            Trace.WriteLine("Numer linii pliku:" + sourceLineNumber);
        }


    }
}
