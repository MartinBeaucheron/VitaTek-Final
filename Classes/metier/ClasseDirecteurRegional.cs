using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Classes.metier;

public class DirecteurRegional : ForceDeVente

{
    //D�finitions des variables :
    private string nomRole;

    //M�thodes getteurs :
    public string getnomRole()
    {
        return nomRole;
    }

    //M�thodes setteurs :
    void setnomRole(string nomRole)
    {
        this.nomRole = nomRole;
    }

    //M�thodes toString :
    public string toString()
    {
        return "Le nom du r�le est :" + nomRole;
    }
}