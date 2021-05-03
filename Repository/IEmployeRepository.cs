using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    //Contient toutes les règles sur la persistance des données
    interface IEmployeRepository
    {
        public List<Employe> GetListeEmployes();
        public Employe GetEmploye(int id);
        public List<Employe> AddEmploye(Employe employe);
    }
}
