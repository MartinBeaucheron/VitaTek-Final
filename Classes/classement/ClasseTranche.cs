using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseTranche
{
	public class Tranche
	{
		//D�finitions des variables :
		private int nbPoints;
		private double valeurMaximum;
		private double valeurMin;

		//M�thodes getteurs :
		public getnbPoints()
		{
			return this.nbPoints;
		}
		public getvaleurMaximum()
		{
			return this.valeurMaximum;
		}
		public getvaleurMin()
		{
			return this.valeurMin;
		}
		public setnbPoints(double nbPoints)
		{
			this.nbPoints = nbPoints;
		}
		public setvaleurMaximum(double valeurMaximum)
		{
			this.valeurMaximum = valeurMaximum;
		}
		public setvaleurMin(set valeurMin)
		{
			this.valeurMin = valeurMin;
		}

		//M�thode toString :
		public string toString()
		{
			return "Le nombre de points est de :" + this.nbPoints + "\nLa valeur maximum est de : " + this.valeurMaximum + "\nLa valeur minimum est de : " + this.valeurMin;
		}
	}
}