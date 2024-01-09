using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Classes.metier;

public class DirecteurRegional : ForceDeVente

{
    //Définitions des variables :
    private string nomRole;

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
    public string toString()
    {
        return "Le nom du rôle est :" + nomRole;
    }
}