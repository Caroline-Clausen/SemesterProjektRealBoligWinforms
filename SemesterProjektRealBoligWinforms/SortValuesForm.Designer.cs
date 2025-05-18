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
            SizeBox = new TextBox();
            TypeBox = new TextBox();
            PriceBox = new TextBox();
            ShoppingDistanceBox = new TextBox();
            AreaBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Godkend = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(185, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 0;
            label1.Text = "Addresse";
            // 
            // AddressBox
            // 
            AddressBox.Dock = DockStyle.Fill;
            AddressBox.Location = new Point(277, 3);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(447, 31);
            AddressBox.TabIndex = 1;
            // 
            // SizeBox
            // 
            SizeBox.Dock = DockStyle.Fill;
            SizeBox.Location = new Point(277, 40);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(447, 31);
            SizeBox.TabIndex = 2;
            // 
            // TypeBox
            // 
            TypeBox.Dock = DockStyle.Fill;
            TypeBox.Location = new Point(277, 77);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(447, 31);
            TypeBox.TabIndex = 3;
            // 
            // PriceBox
            // 
            PriceBox.Dock = DockStyle.Fill;
            PriceBox.Location = new Point(277, 114);
            PriceBox.Name = "PriceBox";
            PriceBox.Size = new Size(447, 31);
            PriceBox.TabIndex = 4;
            // 
            // ShoppingDistanceBox
            // 
            ShoppingDistanceBox.Dock = DockStyle.Fill;
            ShoppingDistanceBox.Location = new Point(277, 151);
            ShoppingDistanceBox.Name = "ShoppingDistanceBox";
            ShoppingDistanceBox.Size = new Size(447, 31);
            ShoppingDistanceBox.TabIndex = 5;
            // 
            // AreaBox
            // 
            AreaBox.Dock = DockStyle.Fill;
            AreaBox.Location = new Point(277, 188);
            AreaBox.Name = "AreaBox";
            AreaBox.Size = new Size(447, 31);
            AreaBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(154, 37);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 7;
            label2.Text = "Kvadratmeter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(222, 74);
            label3.Name = "label3";
            label3.Size = new Size(49, 37);
            label3.TabIndex = 8;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(231, 111);
            label4.Name = "label4";
            label4.Size = new Size(40, 37);
            label4.TabIndex = 9;
            label4.Text = "Pris";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(113, 148);
            label5.Name = "label5";
            label5.Size = new Size(158, 37);
            label5.TabIndex = 10;
            label5.Text = "Afstand Til Indkøb";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(194, 185);
            label6.Name = "label6";
            label6.Size = new Size(77, 37);
            label6.TabIndex = 11;
            label6.Text = "Område";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1881F));
            tableLayoutPanel1.Controls.Add(AreaBox, 1, 5);
            tableLayoutPanel1.Controls.Add(ShoppingDistanceBox, 1, 4);
            tableLayoutPanel1.Controls.Add(PriceBox, 1, 3);
            tableLayoutPanel1.Controls.Add(TypeBox, 1, 2);
            tableLayoutPanel1.Controls.Add(SizeBox, 1, 1);
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(727, 311);
            tableLayoutPanel1.TabIndex = 13;
            tableLayoutPanel1.Visible = false;
            // 
            // Godkend
            // 
            tableLayoutPanel1.SetColumnSpan(Godkend, 2);
            Godkend.Dock = DockStyle.Fill;
            Godkend.Location = new Point(3, 225);
            Godkend.Name = "Godkend";
            Godkend.Size = new Size(721, 83);
            Godkend.TabIndex = 12;
            Godkend.Text = "Godkend";
            Godkend.UseVisualStyleBackColor = true;
            Godkend.Click += Godkend_Click;
            // 
            // SortValuesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 311);
            Controls.Add(tableLayoutPanel1);
            Name = "SortValuesForm";
            Text = "SortValuesForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox AddressBox;
        private TextBox SizeBox;
        private TextBox TypeBox;
        private TextBox PriceBox;
        private TextBox ShoppingDistanceBox;
        private TextBox AreaBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Godkend;
    }
}