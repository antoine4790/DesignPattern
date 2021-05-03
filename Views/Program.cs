using System;
using static System.Console;
using static Controllers.Tools;
using static Controllers.EmployeController;
using Entities;
using Unity;
using Controllers;

namespace Views
{
    public class Program
    {
        public static void Main()
        {
            ////Créer le container Unity
            //IUnityContainer unitycontainer = new UnityContainer();

            ////Lie les implémentations aux interfaces correspondantes
            //unitycontainer.RegisterType<IEmployeService, EmployeService>();

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
                EmployeController employeController = new EmployeController();
                switch (option)
                {
                    case "1":
                        Employe EmployeToAdd = GetInfosEmploye("Robuchon", "Joel", 10000);
                        
                        employeController.AddEmploye(EmployeToAdd);
                        Console.WriteLine($"Employe {EmployeToAdd.ToString()}");
                        break;
                    case "2":
                        foreach (var employe in employeController.GetListeEmployes())
                            Console.WriteLine($"{employe.ToString()}");
                        break;
                    case "3":
                        int idToSearch = GetIntegerFromCmdLine("Entrez le numero de l'employé à rechercher");
                        try
                        {
                            Employe result = employeController.GetEmploye(idToSearch);
                            if (result is null)
                                Console.WriteLine("Aucun employe trouvé");
                            else
                                Console.WriteLine($"{result.ToString()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Erreur rencontrée lors de la recherche d'un employe par son Id");
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        break;
                }
            } while (option != "0");
        }
    }
}
