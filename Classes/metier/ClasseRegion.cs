using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.metier
{
    public class Region
    {
        //Définitions des variables :
        private string nomRegion;

        //Méthodes getteurs :
        public getNomRegion()
        {
            return nomRegion;
        }

        //Méthodes setteurs :
        public void setNomRegion(string nouveauNom)
        {
            nomRegion = nouveauNom;
        }

        public void ToString()
        {
            Console.WriteLine("Le nom du Rôle est : " + nomRegion);
        }
    }