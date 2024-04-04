using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form2 : Form
    {
        List<ForceDeVente2> lesDirecteurs;
        public Form2()
        {

            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            listeEmployes.View = View.Details;
            listeEmployes.Columns.Add("ID", 100);
            listeEmployes.Columns.Add("Nom", 150);
            listeEmployes.Columns.Add("Prenom", 150);
            listeEmployes.Columns.Add("Numero", 150);
            listeEmployes.Columns.Add("Date Embauche", 150);
            listeEmployes.Columns.Add("Date Naissance", 150);
            listeEmployes.Columns.Add("Situation Familliale", 150);
            listeEmployes.Columns.Add("Nombre d'enfants", 150);
            listeEmployes.Columns.Add("Role", 150);
           
            listeEmployes.Columns.Add("Points", 150);

            lesDirecteurs = await Passerelle.getAllForceDevente();


            try
            {

               
                foreach (var ledirecteur in lesDirecteurs)
                {

                    int points = int.Parse(await Passerelle.getNbPoints(ledirecteur.getId()));
                    ListViewItem item = new ListViewItem(ledirecteur.getId().ToString());
                    item.SubItems.Add(ledirecteur.getNom());
                    item.SubItems.Add(ledirecteur.getPrenom());
                    item.SubItems.Add(ledirecteur.getNumero().ToString());
                    item.SubItems.Add(ledirecteur.getDateEmbauche().ToString());
                    item.SubItems.Add(ledirecteur.getDateNaiss().ToString());
                    item.SubItems.Add(ledirecteur.getSituationFamiliale());
                    item.SubItems.Add(ledirecteur.getNbEnfants().ToString());
                    item.SubItems.Add(ledirecteur.getNbEnfants().ToString());
                 
                    item.SubItems.Add(points.ToString());
                    listeEmployes.Items.Add(item);
                }



            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbRole.SelectedIndex == 0)
            {
                listeEmployes.Items.Clear();
                //Permet d'afficher les force de vente
                lesDirecteurs = await Passerelle.getAllForceDevente();
                foreach (var ledirecteur in lesDirecteurs)
                {

                    ListViewItem item = new ListViewItem(ledirecteur.getId().ToString());
                    item.SubItems.Add(ledirecteur.getNom());
                    item.SubItems.Add(ledirecteur.getPrenom());
                    item.SubItems.Add(ledirecteur.getNumero().ToString());
                    item.SubItems.Add(ledirecteur.getDateEmbauche().ToString());
                    item.SubItems.Add(ledirecteur.getDateNaiss().ToString());
                    item.SubItems.Add(ledirecteur.getSituationFamiliale());
                    item.SubItems.Add(ledirecteur.getNbEnfants().ToString());

                    listeEmployes.Items.Add(item);
                }
              
            } 
            else if(cbRole.SelectedIndex == 1)
            {

                listeEmployes.Items.Clear();

                //FAIRE REQUETE API POUR AFFICHEr LES  directeur regionaux
                List<DirecteurRegional> lesDirecteurs;
                lesDirecteurs = await Passerelle.getToutLesDirecteurRegionaux();



                ListViewItem listemploye = new ListViewItem();
                foreach (var ledirecteur in lesDirecteurs)
                {
                    
                    ListViewItem item = new ListViewItem(ledirecteur.getId().ToString());
                    item.SubItems.Add(ledirecteur.getNom());
                    item.SubItems.Add(ledirecteur.getPrenom());
                    item.SubItems.Add(ledirecteur.getNumero().ToString());
                    item.SubItems.Add(ledirecteur.getDateEmbauche().ToString());
                    item.SubItems.Add(ledirecteur.getDateNaiss().ToString());
                    item.SubItems.Add(ledirecteur.getSituationFamiliale());
                    item.SubItems.Add(ledirecteur.getNbEnfants().ToString());
                    item.SubItems.Add(ledirecteur.getRole());

                    item.SubItems.Add(await Passerelle.getNbPoints(ledirecteur.getId()));
                   
                    listeEmployes.Items.Add(item);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cette force de vente?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                //List directeurASupprimer = listeEmployes.SelectedItems;
                //Console.WriteLine(directeurASupprimer.ToString());
                //Passerelle.deleteForceDeVente();
            }
        }
    }
}
