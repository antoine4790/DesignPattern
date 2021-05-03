using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeRepository : IEmployeRepository
    {
        public List<Employe> AddEmploye(Employe employe)
        {
            try
            {
                LocalStorage.Instance.ListeEmployes.Add(employe);
                return LocalStorage.Instance.ListeEmployes;
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'ajout");
                return LocalStorage.Instance.ListeEmployes;
            }
        }

        public Employe GetEmploye(int idToSearch)
        {
            return LocalStorage.Instance.ListeEmployes.FirstOrDefault(e => e.Id == idToSearch);
        }

        public List<Employe> GetListeEmployes()
        {
            return LocalStorage.Instance.ListeEmployes;
        }
    }
}
