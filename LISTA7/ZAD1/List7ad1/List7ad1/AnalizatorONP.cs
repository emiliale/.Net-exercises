//Emilia Lebiedowska 242473
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;


namespace List7ad1
{
    /// <summary>   An analizator Reverse Polish notation. This class include some functions,
    ///             which help to calculate the expression written in Reverse Polish notation. </summary>
    ///
    /// <remarks>   Emila, 23.11.2019. </remarks>

    class AnalizatorONP
    {
        /// <summary>   The statement. </summary>
        private char[] statement;
        /// <summary>   The stack where are components of the statement. </summary>
        Stack<int> stack = new Stack<int>();
     
        /// <summary>   Sets a statement. </summary>
        ///
        /// <remarks>   Emila, 23.11.2019. </remarks>
        ///
        /// <param name="statement">    The statement. </param>

        public void SetStatement(char[] statement)
        {
            this.statement = statement;
        }

        /// <summary>   Gets the statement. </summary>
        ///
        /// <remarks>   Emila, 23.11.2019. </remarks>
        ///
        /// <returns>   An array of character. </returns>

        public char[] GetStatement()
        {
            return statement;
        }

        /// <summary>   Gets the statement from user. </summary>
        ///
        /// <remarks>   Emila, 23.11.2019. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails because of the wrong format. </returns>

        public bool GetFromUser()
        {
            WriteLine("Wpisz wyrażenie: ");
            bool ok = true;
            try
            {
                char[] s = ReadLine().ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray();
                SetStatement(s);
            }catch (Exception e)
            {
                WriteLine("Błąd!\n");
                ok = false;
            }

            return ok;
        }

        /// <summary>
        /// Addition operation. Gets components from the stack and put on the stack the result.
        /// </summary>
        ///
        /// <remarks>   Emila, 23.11.2019. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails becaude of the wrong format. </returns>

        public bool Add()
        {
            bool ok = true;
            try
            {
                int b = stack.Pop();
                int a = stack.Pop();
                stack.Push(a + b);
            }catch(Exception e)
            {
                WriteLine("Błedne wyrażenie");
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Subtraction operation. Gets components from the stack and put on the stack the result.
        /// </summary>
        ///
        /// <remarks>   Emila, 24.11.2019. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails becaude of the wrong format.  </returns>

        public bool Sub()
        {
            bool ok = true;
            try
            {
                int b1 = stack.Pop();
                int a1 = stack.Pop();
                stack.Push(a1 - b1);
            }catch(Exception e)
            {
                WriteLine("Błedne wyrażenie");
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Multiplication operation.  Gets components from the stack and put on the stack the result.
        /// </summary>
        ///
        /// <remarks>   Emila, 24.11.2019. </remarks>
        ///
        /// <returns>  True if it succeeds, false if it fails becaude of the wrong format.  </returns>

        public bool Mult()
        {
            bool ok = true;
            try
            {
                int b2 = stack.Pop();
                int a2 = stack.Pop();
                stack.Push(a2 * b2);
            }catch(Exception e)
            {
                WriteLine("Błedne wyrażenie");
                ok = false;
            }
            return ok;            
        }

        /// <summary>
        /// Division operation.  Gets components from the stack and put on the stack the result. Also
        /// checks if divider isn't zero.
        /// </summary>
        ///
        /// <remarks>   Emila, 24.11.2019. </remarks>
        ///
        /// <returns>   True if it succeeds, false if it fails because of division by zero or the wrong format. </returns>

        public bool Div()
        {
            bool ok = true;
            try
            {               
                int b3 = stack.Pop();
                int a3 = stack.Pop();
                if (b3 != 0)
                {
                    stack.Push(a3 / b3);
                }
                else
                {
                    WriteLine("Nie można dzielić przez 0!\n");
                    stack.Clear();
                    ok = false;
                }
            }catch(Exception e)
            {
                WriteLine("Błedne wyrażenie");
                ok = false;
            }

            return ok;
        }

        /// <summary>   Ends the expression. </summary>
        ///
        /// <remarks>   Emila, 24.11.2019. </remarks>
        ///
        /// <returns>  The Result of the statement. </returns>

        public int Eql()
        {
            int result = stack.Pop();
            stack.Clear();
            return result;
        }

        /// <summary>   Put a character which is number on the stack. </summary>
        ///
        /// <remarks>   Emila, 24.11.2019. </remarks>
        ///
        /// <param name="i">    Zero-based index of the. </param>

        public void Number(char i)
        {
            stack.Push(int.Parse(i.ToString()));
        }



    
    }
}
