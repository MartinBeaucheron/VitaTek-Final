using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Classes
{
    public class ForceDeVente
    {
        //Définitions des variables :
        private string nom, laSituationFamilliale;
        private int numero, nbEnfantACharge;
        private DateTime dateEmbauche, dateNaissance;

        [JsonPropertyName("situationfamilliale")]
        public string LaSituationFamilliale { get => laSituationFamilliale; set => laSituationFamilliale = value; }
        [JsonPropertyName("nom")]
        public string Nom { get => nom; set => nom = value; }


        //Méthodes getteurs :


        public string getNom()
        {
            return this.nom;


        }
      
        public int getNumero()
        {
            return numero;
        }
        public string getLaSituationFamilliale()
        {
            return this.laSituationFamilliale;
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
        void setDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauche = dateEmbauche;
        }
        void setDateNaissance(DateTime dateNaissance)
        {
            this.dateNaissance = dateNaissance;
        }
    }
}