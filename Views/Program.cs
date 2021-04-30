using System;
using static System.Console;
using static Controllers.Tools;
using static Controllers.EmployeController;
using Models;

namespace DesignPattern
{
    public class Program
    {
        public static void Main()
        {
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
                        Employe EmployeToAdd = GetInfosEmploye("Robuchon", "Joel", 10000);
                        AddEmploye(EmployeToAdd);
                        Console.WriteLine($"Employe {EmployeToAdd.ToString()}");
                        break;
                    case "2":
                        foreach (var employe in GetListeEmployes())
                        {
                            Console.WriteLine($"{employe.ToString()}");
                        }
                        break;
                    case "3":
                        int idToSearch = GetIntegerFromCmdLine("Entrez le numero de l'employé à rechercher");
                        Employe result = GetListeEmployes().Find(e => e.Id == idToSearch);
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
