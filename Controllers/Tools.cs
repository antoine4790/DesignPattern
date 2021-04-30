using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using System.Threading.Tasks;

namespace Controllers
{
    public class Tools
    {
        public static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
        {
            WriteLine(question);
            string input = Console.ReadLine();

            return input;
        }

        public static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?", bool checkSign = false)
        {
            if (int.TryParse(GetStringFromCmdLine(question), out int integer_input))
            {
                if (checkSign)
                {
                    if (CheckSignOfInteger(integer_input))
                        WriteLine(integer_input + " est négatif");
                    else
                        WriteLine(integer_input + " est positif");
                }
                return integer_input;
            }
            else
                WriteLine("Ceci n'est pas un chiffre");
            return -1;
        }

        public static bool CheckSignOfInteger(int number = 0)
        {
            bool isNegative = false;
            if (number < 0)
                isNegative = true;
            else if (number > 0)
                isNegative = false;


            return isNegative;
        }
    }
}
