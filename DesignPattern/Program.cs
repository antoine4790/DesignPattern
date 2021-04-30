using System;
using static System.Console;

namespace DesignPattern
{
    public class Program
    {
        public static void Main()
        {
            static string GetStringFromCmdLine(string question = "Quelle est la valeur?")
            {
                WriteLine(question);
                string input = Console.ReadLine();

                return input;
            }

            static int GetIntegerFromCmdLine(string question = "Quelle est la valeur?", bool checkSign = false)
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

            static bool CheckSignOfInteger(int number = 0)
            {
                bool isNegative = false;
                if (number < 0)
                    isNegative = true;
                else if (number > 0)
                    isNegative = false;


                return isNegative;
            }

            string option = "";
            do
            {
                WriteLine("Menu");
                WriteLine(
                            "1- Ajouter un employe random\n" +
                            "2- Afficher la liste des employés\n" +
                            "3- Afficher un employe en rentrant son Id\n" +
                            "0- Quitter le menu"
                            );
                option = GetStringFromCmdLine("Quel numéro choisissez vous?");
                switch (option)
                {
                    case "1":
                        Employe employeToAdd = new Employe(1,"Robuchon", "Joel", 10000);
                        LocalStorage.Instance.ListeEmployes.Add(employeToAdd);
                        Console.WriteLine($"Employe {employeToAdd.ToString()}");
                        break;
                    case "2":
                        foreach (var employe in LocalStorage.Instance.ListeEmployes)
                        {
                            Console.WriteLine($"{employe.ToString()}");
                        }
                        break;
                    case "3":
                        int idToSearch = GetIntegerFromCmdLine("Entrez le numero de l'employé à rechercher");
                        Employe result = LocalStorage.Instance.ListeEmployes.Find(e => e.Id == idToSearch);
                        if (result is null)
                            Console.WriteLine("Aucun employe trouvé");
                        else
                            Console.WriteLine($"{result.ToString()}");
                        break;
                    default:
                        break;
                }
            } while (option != "0");
        }
    }
}
