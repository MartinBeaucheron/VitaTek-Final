using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
	public class Critere
	{
		//Définitions des variables :
		private string nomCritere;

		//Méthodes getteurs :
		public string getnomCritere()
		{
			return this.nomCritere;
		}

		//Méthodes setteurs :
		void setnomCritere(string nomCritere)
		{
			this.nomCritere = nomCritere;
		}

        //Méthode toString :
        public string tostring()
        {
			return "Le nom du critère est " + this.nomCritere;
		}
	}
}