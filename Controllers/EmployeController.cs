using System;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public static class EmployeController
    {
        public static int id = 0;
        public static Employe GetInfosEmploye(string nom, string prenom, double salaire) 
        {
            id += 1;
            Employe employe = new Employe(id, nom, prenom, salaire);
            return employe;
        }

        public static bool AddEmploye(Employe employeToAdd)
        {
            try
            {
                LocalStorage.Instance.ListeEmployes.Add(employeToAdd);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Impossible d'ajouter l'employe");
                return false;
            }
            
        }
        public static List<Employe> GetListeEmployes() 
        {
            return LocalStorage.Instance.ListeEmployes;
        }
    }
}
