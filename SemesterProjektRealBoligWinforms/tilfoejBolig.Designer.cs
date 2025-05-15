namespace SemesterProjektRealBoligWinforms
{
    partial class tilfoejBolig
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            labelAdresse = new Label();
            labelKommune = new Label();
            labelStorellse = new Label();
            labelPris = new Label();
            button1 = new Button();
            labelAlleBoliger = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Location = new Point(445, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.77305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.22695F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(256, 253);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(78, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 4;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(78, 54);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(48, 15);
            labelAdresse.TabIndex = 5;
            labelAdresse.Text = "Adresse";
            // 
            // labelKommune
            // 
            labelKommune.AutoSize = true;
            labelKommune.Location = new Point(78, 122);
            labelKommune.Name = "labelKommune";
            labelKommune.Size = new Size(63, 15);
            labelKommune.TabIndex = 6;
            labelKommune.Text = "Kommune";
            // 
            // labelStorellse
            // 
            labelStorellse.AutoSize = true;
            labelStorellse.Location = new Point(78, 182);
            labelStorellse.Name = "labelStorellse";
            labelStorellse.Size = new Size(78, 15);
            labelStorellse.TabIndex = 7;
            labelStorellse.Text = "Størrelse i m2";
            // 
            // labelPris
            // 
            labelPris.AutoSize = true;
            labelPris.Location = new Point(78, 253);
            labelPris.Name = "labelPris";
            labelPris.Size = new Size(88, 15);
            labelPris.TabIndex = 8;
            labelPris.Text = "Forlangede pris";
            // 
            // button1
            // 
            button1.Location = new Point(125, 349);
            button1.Name = "button1";
            button1.Size = new Size(93, 35);
            button1.TabIndex = 9;
            button1.Text = "Tilføj";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelAlleBoliger
            // 
            labelAlleBoliger.AutoSize = true;
            labelAlleBoliger.Location = new Point(521, 71);
            labelAlleBoliger.Name = "labelAlleBoliger";
            labelAlleBoliger.Size = new Size(130, 15);
            labelAlleBoliger.TabIndex = 10;
            labelAlleBoliger.Text = "Alle nuværende Boliger";
            // 
            // tilfoejBolig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAlleBoliger);
            Controls.Add(button1);
            Controls.Add(labelPris);
            Controls.Add(labelStorellse);
            Controls.Add(labelKommune);
            Controls.Add(labelAdresse);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "tilfoejBolig";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label labelAdresse;
        private Label labelKommune;
        private Label labelStorellse;
        private Label labelPris;
        private Button button1;
        private Label labelAlleBoliger;
    }
}