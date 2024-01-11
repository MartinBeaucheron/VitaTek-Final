using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
namespace Classes;

public class DirecteurRegional : ForceDeVente

{
    //D�finitions des variables :
    private int nomRole;

    [JsonPropertyName("role")]
    public int NomRole { get => nomRole; set => nomRole = value; }

    //M�thodes getteurs :
    public int getnomRole()
    {
        return nomRole;
    }

    //M�thodes setteurs :
    void setnomRole(int nomRole)
    {
        this.nomRole = nomRole;
    }

    //M�thodes toString :
    public string tostring()
    {
        return "Le nom du r�le est :" + nomRole;
    }
}