﻿using System;
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
    public partial class Form1 : Form
    {
        string login = "Directeur";
        string password = "Directeur";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (loginBox.Text == "Directeur" && psswdBox.Text == "Directeur")
            {

                //DirecteurRegional leDr = new DirecteurRegional(7,"TestNom","TestPrenom",090909, );
                Form2 form2 = new Form2();
                form2.Show();
            } 
            
       
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
