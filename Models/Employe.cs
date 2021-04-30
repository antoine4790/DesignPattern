using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employe
    {
        private double salaire;
        public int Id { get; set; } = 0;
        public string Nom { get; set; }
        public string Prenom { get; set; }
        

        public double Salaire
        {
            get { return salaire; }
            set 
            {
                if (value > 0)
                    salaire = value;
                else
                    salaire = 1;
            }
        }


        public Employe() 
        {
            Id = 1;
            Nom = "";
            Prenom = "";
            Salaire = 1;
        }

        public Employe(int id,  string nom, string prenom, double salaire)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }
    }
}
