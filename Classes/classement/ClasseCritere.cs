using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseCritere
{
	public class Critere
	{
		//D�finitions des variables :
		private string nomCritere;

		//M�thodes getteurs :
		public getnomCritere()
		{
			return this.nomCritere;
		}

		//M�thodes setteurs :
		public setnomCritere(string nomCritere)
		{
			this.nomCritere = nomCritere;
		}

		//M�thode toString :
		public String toString()
		{
			return "Le nom du crit�re est " + this.nomCritere;
		}
	}
}