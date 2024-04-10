using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace ClassLibrary1
{
    public class ForceDeVente2
    {

        private string nom,prenom, situationfamilliale;
        private int id,numero, nbEnfants;
        DateTime dateEmbauche, dateNaiss;

      

        [JsonPropertyName("id")]
        public int Id { get => id; set => id = value; }
        [JsonPropertyName("nom")]
        public string Nom { get => nom; set => nom = value; }
        [JsonPropertyName("prenom")]
        public string Prenom { get => prenom; set => prenom = value; }
        [JsonPropertyName("numero")]
        public int Numero { get => numero; set => numero = value; }
        [JsonPropertyName("dateEmbauche")]
        public DateTime DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
        [JsonPropertyName("dateNaiss")]
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        [JsonPropertyName("situationfamilliale")]
        public string Situationfamilliale { get => situationfamilliale; set => situationfamilliale = value; }

        [JsonPropertyName("nbEnfants")]
        public int NbEnfants { get => nbEnfants; set => nbEnfants = value; }



        public ForceDeVente2(int id, string nom,string prenom, int numero, DateTime dateEmbauche, DateTime dateNaiss, string situationfamilliale, int nbEnfants)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.numero = numero;
            this.dateEmbauche = dateEmbauche;
            this.dateNaiss = dateNaiss;
            this.situationfamilliale = situationfamilliale; 
            this.nbEnfants = nbEnfants;
        }
        public ForceDeVente2()
        {

        }

        public int getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public DateTime getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public DateTime getDateNaiss()
        {
            return this.dateNaiss;
        }

        public string getSituationFamiliale()
        {
            return this.situationfamilliale;
        }

        public int getNbEnfants()
        {
            return this.nbEnfants;
        }





    }
}