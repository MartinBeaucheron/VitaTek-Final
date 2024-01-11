using Classes;
using System.Windows.Forms;
namespace vita2
{
    public partial class Form1 : Form
    {
        private List<DirecteurRegional> lesDirecteurs;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lesDirecteurs = await passerelle.getAllDirecteurRegionnal();
            foreach (var ledirecteur in lesDirecteurs)
            {
                listBox1.Items.Add(ledirecteur.getNom());  
            }

        }

        private void labelTest_Click(object sender, EventArgs e)
        {

        }
    }
}
