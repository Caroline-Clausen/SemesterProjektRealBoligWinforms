namespace SemesterProjektRealBoligWinforms
{
    partial class OpretBolig
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
            buttonBolig = new Button();
            buttonBoligSlet = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonBolig
            // 
            buttonBolig.Location = new Point(225, 254);
            buttonBolig.Name = "buttonBolig";
            buttonBolig.Size = new Size(182, 77);
            buttonBolig.TabIndex = 0;
            buttonBolig.Text = "Opret Bolig";
            buttonBolig.UseVisualStyleBackColor = true;
            buttonBolig.Click += buttonBolig_Click;
            // 
            // buttonBoligSlet
            // 
            buttonBoligSlet.Location = new Point(467, 254);
            buttonBoligSlet.Name = "buttonBoligSlet";
            buttonBoligSlet.Size = new Size(182, 77);
            buttonBoligSlet.TabIndex = 1;
            buttonBoligSlet.Text = "Slet Bolig";
            buttonBoligSlet.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 146);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 61);
            textBox1.TabIndex = 2;
            textBox1.Text = "Velkommen, her kan du oprette en bolig og tilføje den til databasen, eller slette den.";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // OpretBolig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 586);
            Controls.Add(textBox1);
            Controls.Add(buttonBoligSlet);
            Controls.Add(buttonBolig);
            Name = "OpretBolig";
            Text = "Form2";
            Load += OpretBolig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBolig;
        private Button buttonBoligSlet;
        private TextBox textBox1;
    }
}