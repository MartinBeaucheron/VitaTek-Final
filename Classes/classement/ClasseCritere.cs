using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
	public class Critere
	{
		//D�finitions des variables :
		private string nomCritere;

		//M�thodes getteurs :
		public string getnomCritere()
		{
			return this.nomCritere;
		}

		//M�thodes setteurs :
		void setnomCritere(string nomCritere)
		{
			this.nomCritere = nomCritere;
		}

        //M�thode toString :
        public string tostring()
        {
			return "Le nom du crit�re est " + this.nomCritere;
		}
	}
}