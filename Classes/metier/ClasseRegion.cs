using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Region
    {
        //D�finitions des variables :
        private string nomRegion;

        //M�thodes getteurs :
        public string getNomRegion()
        {
            return nomRegion;
        }

        //M�thodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            this.nomRegion = nouveauNom;
        }

        public string tostring()
        {
            return("Le nom du R�le est : " + nomRegion);
        }
    }
}