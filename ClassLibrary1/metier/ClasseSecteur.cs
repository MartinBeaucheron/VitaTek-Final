using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Secteur
    {
        //D�finitions des variables :
        private string nomSecteur;

        //M�thodes getteurs :
        public string getNomSecteur()
        {
            return nomSecteur;
        }

        //M�thodes setteurs :
        public void setNomSecteur(string nouveauNom)
        {
            this.nomSecteur = nouveauNom;
        }

        public string tostring()
        {
            return ("Le nom du R�le est : " + nomSecteur);
        }
    }
}