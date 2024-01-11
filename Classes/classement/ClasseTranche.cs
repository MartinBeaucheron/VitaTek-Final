using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
	public class Tranche
	{
		//Définitions des variables :
		private int nbPoints;
		private double valeurMaximum;
		private double valeurMin;

		//Méthodes getteurs :
		public int getnbPoints()
		{
			return this.nbPoints;
		}
		public double getvaleurMaximum()
		{
			return this.valeurMaximum;
		}
		public double getvaleurMin()
		{
			return this.valeurMin;
		}
		void setnbPoints(int nbPoints)
		{
			this.nbPoints = nbPoints;
		}
		void setvaleurMaximum(double valeurMaximum)
		{
			this.valeurMaximum = valeurMaximum;
		}
		void setvaleurMin(double valeurMin)
		{
			this.valeurMin = valeurMin;
		}

        //Méthode toString :
        public string tostring()
        {
			return "Le nombre de points est de :" + this.nbPoints + "\nLa valeur maximum est de : " + this.valeurMaximum + "\nLa valeur minimum est de : " + this.valeurMin;
		}
	}
}