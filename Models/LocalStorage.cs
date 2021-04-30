using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public sealed class LocalStorage
    {
        //public List<Employe> listeEmployes = new List<Employe> { new Employe("Anderson", "Jacquouillet", 1000) };
        public List<Employe> ListeEmployes { get; set; } = new List<Employe> { new Employe(2, "Anderson", "Jacquouillet", 1000) };

        private static LocalStorage instance = null;
        private LocalStorage() { }

        //on retourne l'instance que l'on crée si elle n'existe pas
        public static LocalStorage Instance
        {
            get {
                if (instance == null)
                    instance = new LocalStorage();
                return instance;

            }
        }

    }
}
