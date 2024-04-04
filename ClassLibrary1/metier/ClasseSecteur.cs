using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Secteur
    {
        //Définitions des variables :
        private string nomSecteur;

        //Méthodes getteurs :
        public string getNomSecteur()
        {
            return nomSecteur;
        }

        //Méthodes setteurs :
        public void setNomSecteur(string nouveauNom)
        {
            this.nomSecteur = nouveauNom;
        }

        public string tostring()
        {
            return ("Le nom du Rôle est : " + nomSecteur);
        }
    }
}