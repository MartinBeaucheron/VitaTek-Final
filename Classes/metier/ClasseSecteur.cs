using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Secteur
    {
        //Définitions des variables :
        private string nomSecteur;

        //Méthodes getteurs :
        public getNomSecteur()
        {
            return nomSecteur;
        }

        //Méthodes setteurs :
        public void setNomSecteur(string nouveauNom)
        {
            this.setNomSecteur = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + nomSecteur);
        }
    }
}