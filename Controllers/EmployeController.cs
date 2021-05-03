using Entities;
using System;
using System.Collections.Generic;
using Business;


namespace Controllers
{
    public class EmployeController
    {
        private static int id = 0;
        public EmployeService EmployeService { get; set; } = new EmployeService();
        public static Employe GetInfosEmploye(string nom, string prenom, double salaire) 
        {
            id += 1;
            Employe employe = new Employe(id, nom, prenom, salaire);
            return employe;
        }

        public List<Employe> AddEmploye(Employe employeToAdd)
        {
            return EmployeService.AddEmploye(employeToAdd);
        }
        public List<Employe> GetListeEmployes()
        {
            return EmployeService.GetListeEmployes();
        }

        public Employe GetEmploye(int idToSearch) 
        {
            return EmployeService.GetEmploye(idToSearch);
        }
    }
}
