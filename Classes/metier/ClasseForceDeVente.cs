using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Classes
{
    public class ForceDeVente
    {
        public string nomfv, prenomfv, situationfamillialefv;
        public int numerofv, nbEnfantsAChargefv, idfv;
        public DateTime dateEmbauchefv, dateNaissfv;

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
            this.idfv = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Numero = numero;
            this.NbEnfantACharge = nbEnfantsACharge;
            this.DateEmbauche = dateEmbauche;
            this.DateNaissance = dateNaiss;
            this.situationfamillialefv = situationfamilliale;
        }

        public string getNom()
        {
            return this.nomfv;


        }
        public string getPreom()
        {
            return this.prenomfv;


        }

        public int getNumero()
        {
            return this.numerofv;
        }
        public int getId()
        {
            return this.idfv;
        }
        public string getLaSituationFamilliale()
        {
            return this.situationfamillialefv;
        }
        public int getNbEnfantACharge()
        {
            return this.nbEnfantsAChargefv;
        }
        public DateTime getDateEmbauche()
        {
            return this.dateEmbauchefv;
        }
        public DateTime getDateNaissance()
        {
            return this.dateNaissfv;

        }
        //M�thodes setteurs :
        public void setNom(string nom)
        {
            this.nomfv = nom;
        }
        public void setLaSituationFamilliale(string laSituationFamilliale)
        {
            this.situationfamillialefv = laSituationFamilliale;
        }
        public void setNumero(int numero)
        {
            this.numerofv = numero;
        }
        public void setNbEnfantACharge(int nbEnfantACharge)
        {
            this.nbEnfantsAChargefv = nbEnfantACharge;
        }
        void setDateEmbauche(DateTime dateEmbauche)
        {
            this.dateEmbauchefv = dateEmbauche;
        }
        void setDateNaissance(DateTime dateNaissance)
        {
            this.dateNaissfv = dateNaissance;
        }
    }
}