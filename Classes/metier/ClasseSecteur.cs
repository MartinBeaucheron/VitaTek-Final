using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Secteur
    {
        //D�finitions des variables :
        private string nomSecteur;

        //M�thodes getteurs :
        public getNomSecteur()
        {
            return nomSecteur;
        }

        //M�thodes setteurs :
        public void setNomSecteur(string nouveauNom)
        {
            this.setNomSecteur = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du R�le est : " + nomSecteur);
        }
    }
}