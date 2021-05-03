using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;

namespace Business
{
    public class EmployeService : IEmployeService
    {
        private EmployeRepository employeRepository = new EmployeRepository();
        public List<Employe> AddEmploye(Employe employe)
        {
            if (employe.Salaire < 0)
                return employeRepository.AddEmploye(employe);
            else
                //On retourne la liste sans rien ajouter si le salaire est incorrect
                return employeRepository.GetListeEmployes();
        }

        public Employe GetEmploye(int id)
        {
            return employeRepository.GetEmploye(id);
        }

        public List<Employe> GetListeEmployes()
        {
            return employeRepository.GetListeEmployes();
        }
    }
}
