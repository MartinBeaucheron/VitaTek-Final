using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Visiteur
    {
        //attributs
        private string nomrole;


        //methodes

        //D�finitions des variables :
        private String nomRole;

        //M�thodes getteurs :

        public string getNomR�le()
        {
            return this.nomRole;
        }

        //M�thodes setteurs :
        public void setNomRole(string nouveauNom)
        {
            this.nomRole = nouveauNom;
        }

        public string tostring()
        {
            return("Le nom du R�le est : " + this.nomRole);
        }
    }
}