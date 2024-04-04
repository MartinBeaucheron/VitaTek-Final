using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace ClassLibrary1
{
    public class ForceDeVente
    {
        private string nomfv, prenomfv, situationfamillialefv;
        private int numerofv, nbEnfantsAChargefv, idfv;
        private DateTime dateEmbauchefv, dateNaissfv;

        [JsonPropertyName("situationfamilliale")]
        public string SituationFamilliale { get => situationfamillialefv; set => situationfamillialefv = value; }

        [JsonPropertyName("nom")]
        public string Nom { get => nomfv; set => nomfv = value; }

        [JsonPropertyName("dateNaiss")]
        public DateTime DateNaissance { get => dateNaissfv; set => dateNaissfv = value; }

        [JsonPropertyName("id")]
        public int Id { get => idfv; set => idfv = value; }

        [JsonPropertyName("prenom")]
        public string Prenom { get => prenomfv; set => prenomfv = value; }

        [JsonPropertyName("numero")]
        public int Numero { get => numerofv; set => numerofv = value; }

        [JsonPropertyName("nbEnfantsAcharge")]
        public int NbEnfantACharge { get => nbEnfantsAChargefv; set => nbEnfantsAChargefv = value; }

        [JsonPropertyName("dateEmbauche")]
        public DateTime DateEmbauche { get => dateEmbauchefv; set => dateEmbauchefv = value; }

        public ForceDeVente(int id, string nom, string prenom, int numero, DateTime dateEmbauche, DateTime dateNaiss, string situationfamilliale, int nbEnfantsACharge)
        {
            idfv = id;
            Nom = nom;
            Prenom = prenom;
            Numero = numero;
            NbEnfantACharge = nbEnfantsACharge;
            DateEmbauche = dateEmbauche;
            DateNaissance = dateNaiss;
            situationfamillialefv = situationfamilliale;
        }

        public string getNom()
        {
            return nomfv;


        }
        public string getPreom()
        {
            return prenomfv;


        }

        public int getNumero()
        {
            return numerofv;
        }
        public int getId()
        {
            return idfv;
        }
        public string getLaSituationFamilliale()
        {
            return situationfamillialefv;
        }
        public int getNbEnfantACharge()
        {
            return nbEnfantsAChargefv;
        }
        public DateTime getDateEmbauche()
        {
            return dateEmbauchefv;
        }
        public DateTime getDateNaissance()
        {
            return dateNaissfv;

        }
        //Méthodes setteurs :
        public void setNom(string nom)
        {
            nomfv = nom;
        }
        public void setLaSituationFamilliale(string laSituationFamilliale)
        {
            situationfamillialefv = laSituationFamilliale;
        }
        public void setNumero(int numero)
        {
            numerofv = numero;
        }
        public void setNbEnfantACharge(int nbEnfantACharge)
        {
            nbEnfantsAChargefv = nbEnfantACharge;
        }
        void setDateEmbauche(DateTime dateEmbauche)
        {
            dateEmbauchefv = dateEmbauche;
        }
        void setDateNaissance(DateTime dateNaissance)
        {
            dateNaissfv = dateNaissance;
        }
    }
}