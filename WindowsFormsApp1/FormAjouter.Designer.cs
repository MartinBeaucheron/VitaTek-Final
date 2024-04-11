namespace WindowsFormsApp1
{
    partial class FormAjouter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNbEnfant = new System.Windows.Forms.TextBox();
            this.txtSituationFamilliale = new System.Windows.Forms.TextBox();
            this.DTPEmbauche = new System.Windows.Forms.DateTimePicker();
            this.DTPNaissance = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enfant a charge";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date Embauche";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Naissance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Situation Familliale";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(323, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(323, 129);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(323, 166);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 11;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(323, 205);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 12;
            // 
            // txtNbEnfant
            // 
            this.txtNbEnfant.Location = new System.Drawing.Point(323, 246);
            this.txtNbEnfant.Name = "txtNbEnfant";
            this.txtNbEnfant.Size = new System.Drawing.Size(100, 22);
            this.txtNbEnfant.TabIndex = 13;
            // 
            // txtSituationFamilliale
            // 
            this.txtSituationFamilliale.Location = new System.Drawing.Point(323, 373);
            this.txtSituationFamilliale.Name = "txtSituationFamilliale";
            this.txtSituationFamilliale.Size = new System.Drawing.Size(100, 22);
            this.txtSituationFamilliale.TabIndex = 16;
            // 
            // DTPEmbauche
            // 
            this.DTPEmbauche.Location = new System.Drawing.Point(323, 287);
            this.DTPEmbauche.Name = "DTPEmbauche";
            this.DTPEmbauche.Size = new System.Drawing.Size(200, 22);
            this.DTPEmbauche.TabIndex = 17;
            // 
            // DTPNaissance
            // 
            this.DTPNaissance.Location = new System.Drawing.Point(323, 327);
            this.DTPNaissance.Name = "DTPNaissance";
            this.DTPNaissance.Size = new System.Drawing.Size(200, 22);
            this.DTPNaissance.TabIndex = 18;
            // 
            // FormAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTPNaissance);
            this.Controls.Add(this.DTPEmbauche);
            this.Controls.Add(this.txtSituationFamilliale);
            this.Controls.Add(this.txtNbEnfant);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjouter";
            this.Text = "FormAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNbEnfant;
        private System.Windows.Forms.TextBox txtSituationFamilliale;
        private System.Windows.Forms.DateTimePicker DTPEmbauche;
        private System.Windows.Forms.DateTimePicker DTPNaissance;
    }
}