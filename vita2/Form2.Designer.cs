namespace vita2
{
    partial class Form2
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
            labelTitre = new Label();
            SuspendLayout();
            // 
            // labelTitre
            // 
            labelTitre.AutoSize = true;
            labelTitre.Location = new Point(498, 76);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(114, 20);
            labelTitre.TabIndex = 0;
            labelTitre.Text = "Connectez-vous";
            labelTitre.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 557);
            Controls.Add(labelTitre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitre;
    }
}