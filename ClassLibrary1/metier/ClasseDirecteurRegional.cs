using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
namespace ClassLibrary1
{

    public class DirecteurRegional : ForceDeVente2
    {

        private string nom, prenom, situationfamilliale,role;
        private int id, numero, nbEnfants;
        DateTime dateEmbauche, dateNaiss;


        public string Nom1 { get => nom; set => nom = value; }
        public string Prenom1 { get => prenom; set => prenom = value; }
        public string Situationfamilliale1 { get => situationfamilliale; set => situationfamilliale = value; }
        public int Id1 { get => id; set => id = value; }
        public int Numero1 { get => numero; set => numero = value; }

        public int NbEnfants1 { get => nbEnfants; set => nbEnfants = value; }
        public DateTime DateEmbauche1 { get => dateEmbauche; set => dateEmbauche = value; }
        public DateTime DateNaiss1 { get => dateNaiss; set => dateNaiss = value; }

        [JsonPropertyName("role")]
        public string Role { get => role; set => role = value; }

        public DirecteurRegional(int id, string nom, string prenom, int numero, DateTime dateEmbauche, DateTime dateNaiss,string situationfamilliale1, int nbEnfants,string role) :base(id,nom,prenom,numero,dateEmbauche,dateNaiss,situationfamilliale1,nbEnfants)
        {
           
         
            this.role = role;
        }








        //Méthodes getteurs :

        public string getRole()
        {
            return this.role;
        }

        //Méthodes setteurs :


        //Méthodes toString :

    }
}