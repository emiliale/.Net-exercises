using System;
using static System.Console;

namespace List7ad0d
{
    class Program
    {
        public static void Main()
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            TreatControlCAsInput = true;

            WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key."); 
            WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = ReadKey();
                Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Write("SHIFT+"); 
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Write("CTL+");
                WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
        }

    }
}
