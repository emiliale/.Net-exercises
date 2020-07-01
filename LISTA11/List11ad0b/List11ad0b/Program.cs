using System;
using static System.Console;


namespace List11ad0b
{
    class Program
    {

        public void Subscribe()
        {
            Zdarzenia e = new Zdarzenia();

            // subskrypcja zdarzeń
            // to są metody anonimowe
            e.LowerCase += delegate ()
            { WriteLine("Mała litera"); };

            e.UpperCase += delegate ()
            { WriteLine("Duża litera"); };


            // metoda anonimowa
            /*e.Digit += delegate ()
            { WriteLine("Cyfra"); };*/

            // równoważne wyrażenie lambda
            e.Digit += () => WriteLine("Cyfra");

            /// poniżej tylko wyrażenia lambda 
            e.Key += () => WriteLine("Znak");
            e.FunctionKey += () => WriteLine("Klawisz funkcyjny");
            e.Alt_Key += () => WriteLine("Alt+klawisz");
            e.Ctrl_Key += () => WriteLine("Ctrl+klawisz");
            e.Ctrl_Alt_Key += () => WriteLine("Ctrl+Alt+klawisz");
            e.AnotherKey += () => WriteLine("Inny");
            e.Check();
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Subscribe();
        }
    }
}
