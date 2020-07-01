using System;

using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Lista5A1a
{
    class Program
    {
        //struktura = typ wartości 
        public struct Punkt
        {
            public int X, Y;
        }

    static async Task Main()    // dopuszczalne w C# 7.1
    {
        string result = await DemoAsync("Demo: typ wartości, async/Main/C# 7.1", 5000); WriteLine(result);
        DemoWart();
    }
    // zadanie = metoda asynchroniczna
    static Task<string> DemoAsync(string info, int delta)
    {
        return Task.Run<string>(() =>
        {
            Thread.Sleep(delta); return info;
        });
    }
        static void DemoWart()
    {
        Punkt p1 = new Punkt(); 
        p1.X = 0x17;

        Punkt p2 = p1; //przypisanie powoduje utworzenie kopii 
        WriteLine(p1.X);
        WriteLine(p2.X);//???

        p1.X = 0x23;    //zmiana wartości p1.X NIE wpływa na p2.X
        WriteLine(p1.X);
        WriteLine(p2.X);

        WriteLine(p1.Y); //zainicjowane domyślnie wart. 0 
        WriteLine(p2.Y); //zainicjowane domyślnie wart. 0
    }
}
}
