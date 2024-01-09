using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseCritere
{
	public class Critere
	{
		//Définitions des variables :
		private string nomCritere;

		//Méthodes getteurs :
		public getnomCritere()
		{
			return this.nomCritere;
		}

		//Méthodes setteurs :
		public setnomCritere(string nomCritere)
		{
			this.nomCritere = nomCritere;
		}

		//Méthode toString :
		public String toString()
		{
			return "Le nom du critère est " + this.nomCritere;
		}
	}
}