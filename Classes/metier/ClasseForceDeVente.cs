using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class ForceDeVente
    {
        //Définitions des variables :
        private string nom;
        //private int numero, nbEnfantACharge;
        //private DateTime dateEmbauche, dateNaissance;

        //Méthodes getteurs :
<<<<<<< HEAD

        public string getNom()
        {
            return this.nom;
=======
        public string getNom()
        {
            return nom;
        }
        public int getNumero()
        {
            return numero;
        }
        public string getLaSituationFamilliale()
        {
            return laSituationFamilliale;
        }
        public int getNbEnfantACharge()
        {
            return nbEnfantACharge;
        }
        public DateTime getDateEmbauche()
        {
            return dateEmbauche;
        }
        public DateTime getDateNaissance()
        {
            return dateNaissance;
>>>>>>> 843735189915209a79ba47a7b52894c6135bf593
        }
        //Méthodes setteurs :
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setLaSituationFamilliale(string laSituationFamilliale)
        {
            this.laSituationFamilliale = laSituationFamilliale;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public void setNbEnfantACharge(int nbEnfantACharge)
        {
            this.nbEnfantACharge = nbEnfantACharge;
        }
        public void setDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }
        public void setDateNaissance(DateTime dateNaissance)
        {
            this.dateNaissance = dateNaissance;
        }
    }
}