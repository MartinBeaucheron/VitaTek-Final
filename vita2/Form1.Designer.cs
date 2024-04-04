namespace vita2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem2 = new ListViewItem("");
            labelTest = new Label();
            listeEmployes = new ListView();
            SuspendLayout();
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(348, 22);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(50, 20);
            labelTest.TabIndex = 0;
            labelTest.Text = "label2";
            labelTest.Click += labelTest_Click;
            // 
            // listeEmployes
            // 
            listeEmployes.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listeEmployes.Location = new Point(33, 66);
            listeEmployes.Name = "listeEmployes";
            listeEmployes.Size = new Size(1219, 600);
            listeEmployes.TabIndex = 1;
            listeEmployes.UseCompatibleStateImageBehavior = false;
            listeEmployes.SelectedIndexChanged += listeEmployes_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 733);
            Controls.Add(listeEmployes);
            Controls.Add(labelTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelTest;
        private ListView listeEmployes;
    }
}
