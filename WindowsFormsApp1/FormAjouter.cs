using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class FormAjouter : Form
    {
        public FormAjouter()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            int numero = int.Parse(txtNumero.Text);
            int nbEnfantACharge = int.Parse(txtNbEnfant.Text);
            DateTime dateEmbauche = DTPEmbauche.Value;
            DateTime dateNaissance = DTPNaissance.Value;
            string situationFamilliale = txtSituationFamilliale.Text;
            ForceDeVente2 forceDeVente = new ForceDeVente2(id,nom,prenom,numero,dateEmbauche,dateNaissance,situationFamilliale,nbEnfantACharge);
            try
            {
                await Passerelle.ajouteForceDeVente(forceDeVente);
            }
            catch (Exception ex) { }
        }
    }
}
