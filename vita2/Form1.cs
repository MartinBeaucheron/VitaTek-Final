using Classes;
using System.Windows.Forms;
namespace vita2
{
    public partial class Form1 : Form
    {

        private List<ForceDeVente> lesDirecteurs;
    
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            listeEmployes.View = View.Details;
            listeEmployes.Columns.Add("ID", 100);
            listeEmployes.Columns.Add("Nom", 150);
            listeEmployes.Columns.Add("Prenom", 150);
            listeEmployes.Columns.Add("Date Embauche", 150);
            listeEmployes.Columns.Add("Date Naissance", 150);
            listeEmployes.Columns.Add("Situation Familliale", 150);

            lesDirecteurs = await Passerelle.getAllDirecteurRegionnal();
            try
            {
               
                ListViewItem listemploye = new ListViewItem();
                foreach (var ledirecteur in lesDirecteurs)
                {
                   
                }
                
                

            }
            catch (Exception ex)
            {
                labelTest.Text = ex.Message;
            }


        }

        private void labelTest_Click(object sender, EventArgs e)
        {

        }

        private void listeEmployes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
