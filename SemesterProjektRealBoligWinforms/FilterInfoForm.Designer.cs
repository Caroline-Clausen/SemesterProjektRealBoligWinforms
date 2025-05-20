namespace SemesterProjektRealBoligWinforms
{
    partial class FilterInfoForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            AddressBox = new TextBox();
            TypeBox = new TextBox();
            AreaBox = new TextBox();
            label3 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label13 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label11 = new Label();
            label12 = new Label();
            ShoppingDistanceMinBox = new TextBox();
            ShoppingDistanceMaxBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            PriceMinBox = new TextBox();
            PriceMaxBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Godkend = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            SizeMinBox = new TextBox();
            SizeMaxBox = new TextBox();
            StatusComboBox = new ComboBox();
            boligBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(75, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 35);
            label1.TabIndex = 0;
            label1.Text = "Addresse";
            // 
            // AddressBox
            // 
            AddressBox.Dock = DockStyle.Fill;
            AddressBox.Location = new Point(167, 3);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(750, 31);
            AddressBox.TabIndex = 1;
            // 
            // TypeBox
            // 
            TypeBox.Dock = DockStyle.Fill;
            TypeBox.Location = new Point(167, 73);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(750, 31);
            TypeBox.TabIndex = 3;
            // 
            // AreaBox
            // 
            AreaBox.Dock = DockStyle.Fill;
            AreaBox.Location = new Point(167, 178);
            AreaBox.Name = "AreaBox";
            AreaBox.Size = new Size(750, 31);
            AreaBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(112, 70);
            label3.Name = "label3";
            label3.Size = new Size(49, 35);
            label3.TabIndex = 8;
            label3.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(84, 175);
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
            tableLayoutPanel1.Controls.Add(label13, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(AreaBox, 1, 5);
            tableLayoutPanel1.Controls.Add(TypeBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(AddressBox, 1, 0);
            tableLayoutPanel1.Controls.Add(Godkend, 0, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(StatusComboBox, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(920, 345);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Right;
            label13.Location = new Point(101, 212);
            label13.Name = "label13";
            label13.Size = new Size(60, 33);
            label13.TabIndex = 16;
            label13.Text = "Status";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Controls.Add(label11, 0, 0);
            tableLayoutPanel4.Controls.Add(label12, 2, 0);
            tableLayoutPanel4.Controls.Add(ShoppingDistanceMinBox, 1, 0);
            tableLayoutPanel4.Controls.Add(ShoppingDistanceMaxBox, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(167, 143);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(750, 29);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 25);
            label11.TabIndex = 0;
            label11.Text = "Min";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(378, 0);
            label12.Name = "label12";
            label12.Size = new Size(45, 25);
            label12.TabIndex = 1;
            label12.Text = "Max";
            // 
            // ShoppingDistanceMinBox
            // 
            ShoppingDistanceMinBox.Dock = DockStyle.Top;
            ShoppingDistanceMinBox.Location = new Point(78, 3);
            ShoppingDistanceMinBox.Name = "ShoppingDistanceMinBox";
            ShoppingDistanceMinBox.Size = new Size(294, 31);
            ShoppingDistanceMinBox.TabIndex = 2;
            // 
            // ShoppingDistanceMaxBox
            // 
            ShoppingDistanceMaxBox.Dock = DockStyle.Top;
            ShoppingDistanceMaxBox.Location = new Point(453, 3);
            ShoppingDistanceMaxBox.Name = "ShoppingDistanceMaxBox";
            ShoppingDistanceMaxBox.Size = new Size(294, 31);
            ShoppingDistanceMaxBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(label9, 0, 0);
            tableLayoutPanel3.Controls.Add(label10, 2, 0);
            tableLayoutPanel3.Controls.Add(PriceMinBox, 1, 0);
            tableLayoutPanel3.Controls.Add(PriceMaxBox, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(167, 108);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(750, 29);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 25);
            label9.TabIndex = 0;
            label9.Text = "Min";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(378, 0);
            label10.Name = "label10";
            label10.Size = new Size(45, 25);
            label10.TabIndex = 1;
            label10.Text = "Max";
            // 
            // PriceMinBox
            // 
            PriceMinBox.Dock = DockStyle.Top;
            PriceMinBox.Location = new Point(78, 3);
            PriceMinBox.Name = "PriceMinBox";
            PriceMinBox.Size = new Size(294, 31);
            PriceMinBox.TabIndex = 2;
            // 
            // PriceMaxBox
            // 
            PriceMaxBox.Dock = DockStyle.Top;
            PriceMaxBox.Location = new Point(453, 3);
            PriceMaxBox.Name = "PriceMaxBox";
            PriceMaxBox.Size = new Size(294, 31);
            PriceMaxBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(158, 35);
            label5.TabIndex = 10;
            label5.Text = "Afstand Til Indkøb";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(121, 105);
            label4.Name = "label4";
            label4.Size = new Size(40, 35);
            label4.TabIndex = 9;
            label4.Text = "Pris";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(44, 35);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 7;
            label2.Text = "Kvadratmeter";
            // 
            // Godkend
            // 
            tableLayoutPanel1.SetColumnSpan(Godkend, 2);
            Godkend.Dock = DockStyle.Fill;
            Godkend.Location = new Point(3, 248);
            Godkend.Name = "Godkend";
            Godkend.Size = new Size(914, 94);
            Godkend.TabIndex = 12;
            Godkend.Text = "Godkend";
            Godkend.UseVisualStyleBackColor = true;
            Godkend.Click += Godkend_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(label8, 2, 0);
            tableLayoutPanel2.Controls.Add(SizeMinBox, 1, 0);
            tableLayoutPanel2.Controls.Add(SizeMaxBox, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(167, 38);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(750, 29);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 0;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 25);
            label8.TabIndex = 1;
            label8.Text = "Max";
            // 
            // SizeMinBox
            // 
            SizeMinBox.Dock = DockStyle.Top;
            SizeMinBox.Location = new Point(78, 3);
            SizeMinBox.Name = "SizeMinBox";
            SizeMinBox.Size = new Size(294, 31);
            SizeMinBox.TabIndex = 2;
            // 
            // SizeMaxBox
            // 
            SizeMaxBox.Dock = DockStyle.Top;
            SizeMaxBox.Location = new Point(453, 3);
            SizeMaxBox.Name = "SizeMaxBox";
            SizeMaxBox.Size = new Size(294, 31);
            SizeMaxBox.TabIndex = 3;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "til salg", "solgt" });
            StatusComboBox.Location = new Point(167, 215);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(182, 33);
            StatusComboBox.TabIndex = 17;
            // 
            // boligBindingSource
            // 
            boligBindingSource.DataSource = typeof(Projekt1Semester.Bolig);
            // 
            // FilterInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 345);
            Controls.Add(tableLayoutPanel1);
            Name = "FilterInfoForm";
            Text = "Filter";
            Load += SortValuesForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label8;
        private TextBox SizeMinBox;
        private TextBox SizeMaxBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label9;
        private Label label10;
        private TextBox PriceMinBox;
        private TextBox PriceMaxBox;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label11;
        private Label label12;
        private TextBox ShoppingDistanceMinBox;
        private TextBox ShoppingDistanceMaxBox;
        private ComboBox StatusComboBox;
        private BindingSource boligBindingSource;
    }
}