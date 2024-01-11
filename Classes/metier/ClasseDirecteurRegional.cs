using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
namespace Classes;

public class DirecteurRegional : ForceDeVente

{
    //Définitions des variables :
    private int nomRole;

    [JsonPropertyName("role")]
    public int NomRole { get => nomRole; set => nomRole = value; }

    //Méthodes getteurs :
    public int getnomRole()
    {
        return nomRole;
    }

    //Méthodes setteurs :
    void setnomRole(int nomRole)
    {
        this.nomRole = nomRole;
    }

    //Méthodes toString :
    public string tostring()
    {
        return "Le nom du rôle est :" + nomRole;
    }
}