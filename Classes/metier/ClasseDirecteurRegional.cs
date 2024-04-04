using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
namespace Classes;

public class DirecteurRegional : ForceDeVente

{
    //Définitions des variables :
    public string nomRole;
    [JsonPropertyName("role")]
    public string NomRole { get => nomRole; set => nomRole = value; }
   
    public DirecteurRegional(int id, string nom, string prenom, int numero, DateTime dateEmbauche, DateTime dateNaiss, string situationfamilliale, int nbEnfantsACharge, string nomRole)
        : base(id,nom, prenom, numero, dateEmbauche , dateNaiss, situationfamilliale, nbEnfantsACharge)
    {
        
        this.nomRole = nomRole;
    }



    //Méthodes getteurs :
    public string getnomRole()
    {
        return nomRole;
    }

    //Méthodes setteurs :
    void setnomRole(string nomRole)
    {
        this.nomRole = nomRole;
    }

    //Méthodes toString :
    public string tostring()
    {
        return "Le nom du rôle est :" + nomRole;
    }
}