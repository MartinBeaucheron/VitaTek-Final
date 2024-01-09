using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.metier
{
    public class ForceDeVente
    {
        //Définitions des variables :
        private string nom, laSituationFamilliale;
        private int numero, nbEnfantACharge;
        private DateTime dateEmbauche, dateNaissance;

        //Méthodes getteurs :
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