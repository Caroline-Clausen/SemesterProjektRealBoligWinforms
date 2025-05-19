namespace SemesterProjektRealBoligWinforms
{
    partial class SortValuesForm
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
            label1 = new Label();
            AddressBox = new TextBox();
            TypeBox = new TextBox();
            AreaBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Godkend = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(75, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 0;
            label1.Text = "Addresse";
            // 
            // AddressBox
            // 
            AddressBox.Dock = DockStyle.Fill;
            AddressBox.Location = new Point(167, 3);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(558, 31);
            AddressBox.TabIndex = 1;
            // 
            // TypeBox
            // 
            TypeBox.Dock = DockStyle.Fill;
            TypeBox.Location = new Point(167, 65);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(558, 31);
            TypeBox.TabIndex = 3;
            // 
            // AreaBox
            // 
            AreaBox.Dock = DockStyle.Fill;
            AreaBox.Location = new Point(167, 152);
            AreaBox.Name = "AreaBox";
            AreaBox.Size = new Size(558, 31);
            AreaBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(112, 62);
            label3.Name = "label3";
            label3.Size = new Size(49, 37);
            label3.TabIndex = 8;
            label3.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(84, 149);
            label6.Name = "label6";
            label6.Size = new Size(77, 37);
            label6.TabIndex = 11;
            label6.Text = "Område";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(AreaBox, 1, 5);
            tableLayoutPanel1.Controls.Add(TypeBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(AddressBox, 1, 0);
            tableLayoutPanel1.Controls.Add(Godkend, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(728, 323);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(3, 124);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 10;
            label5.Text = "Afstand Til Indkøb";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(121, 99);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 9;
            label4.Text = "Pris";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(44, 37);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 7;
            label2.Text = "Kvadratmeter";
            // 
            // Godkend
            // 
            tableLayoutPanel1.SetColumnSpan(Godkend, 2);
            Godkend.Dock = DockStyle.Fill;
            Godkend.Location = new Point(3, 189);
            Godkend.Name = "Godkend";
            Godkend.Size = new Size(722, 131);
            Godkend.TabIndex = 12;
            Godkend.Text = "Godkend";
            Godkend.UseVisualStyleBackColor = true;
            Godkend.Click += Godkend_Click;
            // 
            // SortValuesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 323);
            Controls.Add(tableLayoutPanel1);
            Name = "SortValuesForm";
            Text = "SortValuesForm";
            Load += SortValuesForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox AddressBox;
        private TextBox TypeBox;
        private TextBox AreaBox;
        private Label label3;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Godkend;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}