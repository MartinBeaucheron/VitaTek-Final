using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.metier
{
    public class Region
    {
        //D�finitions des variables :
        private string nomRegion;

        //M�thodes getteurs :
        public getNomRegion()
        {
            return nomRegion;
        }

        //M�thodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            nomRegion = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du R�le est : " + nomRegion);
        }
    }