namespace SemesterProjektRealBoligWinforms
{
    partial class RealtorForm
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
            dataGridView1 = new DataGridView();
            boligBindingSource = new BindingSource(components);
            ejendomsmaeglerBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            boligIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligAdresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligArealDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligStartPrisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligAfstandTilIndkoebDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligOmrådeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligNyPrisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligSolgtPrisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            boligStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            RegisterHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { boligIDDataGridViewTextBoxColumn, boligAdresseDataGridViewTextBoxColumn, boligArealDataGridViewTextBoxColumn, boligTypeDataGridViewTextBoxColumn, boligStartPrisDataGridViewTextBoxColumn, boligAfstandTilIndkoebDataGridViewTextBoxColumn, boligOmrådeDataGridViewTextBoxColumn, boligNyPrisDataGridViewTextBoxColumn, boligSolgtPrisDataGridViewTextBoxColumn, boligStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = boligBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1294, 359);
            dataGridView1.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            boligBindingSource.DataSource = typeof(Projekt1Semester.Bolig);
            // 
            // ejendomsmaeglerBindingSource
            // 
            ejendomsmaeglerBindingSource.DataSource = typeof(Projekt1Semester.Ejendomsmaegler);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1300, 522);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1294, 78);
            label1.TabIndex = 1;
            label1.Text = "Boliger";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            boligIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            boligIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // boligAdresseDataGridViewTextBoxColumn
            // 
            boligAdresseDataGridViewTextBoxColumn.DataPropertyName = "BoligAdresse";
            boligAdresseDataGridViewTextBoxColumn.HeaderText = "BoligAdresse";
            boligAdresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligAdresseDataGridViewTextBoxColumn.Name = "boligAdresseDataGridViewTextBoxColumn";
            boligAdresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligArealDataGridViewTextBoxColumn
            // 
            boligArealDataGridViewTextBoxColumn.DataPropertyName = "BoligAreal";
            boligArealDataGridViewTextBoxColumn.HeaderText = "BoligAreal";
            boligArealDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligArealDataGridViewTextBoxColumn.Name = "boligArealDataGridViewTextBoxColumn";
            // 
            // boligTypeDataGridViewTextBoxColumn
            // 
            boligTypeDataGridViewTextBoxColumn.DataPropertyName = "BoligType";
            boligTypeDataGridViewTextBoxColumn.HeaderText = "BoligType";
            boligTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligTypeDataGridViewTextBoxColumn.Name = "boligTypeDataGridViewTextBoxColumn";
            // 
            // boligStartPrisDataGridViewTextBoxColumn
            // 
            boligStartPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligStartPris";
            boligStartPrisDataGridViewTextBoxColumn.HeaderText = "BoligStartPris";
            boligStartPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligStartPrisDataGridViewTextBoxColumn.Name = "boligStartPrisDataGridViewTextBoxColumn";
            boligStartPrisDataGridViewTextBoxColumn.Width = 130;
            // 
            // boligAfstandTilIndkoebDataGridViewTextBoxColumn
            // 
            boligAfstandTilIndkoebDataGridViewTextBoxColumn.DataPropertyName = "BoligAfstandTilIndkoeb";
            boligAfstandTilIndkoebDataGridViewTextBoxColumn.HeaderText = "BoligAfstandTilIndkoeb";
            boligAfstandTilIndkoebDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligAfstandTilIndkoebDataGridViewTextBoxColumn.Name = "boligAfstandTilIndkoebDataGridViewTextBoxColumn";
            boligAfstandTilIndkoebDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligOmrådeDataGridViewTextBoxColumn
            // 
            boligOmrådeDataGridViewTextBoxColumn.DataPropertyName = "BoligOmråde";
            boligOmrådeDataGridViewTextBoxColumn.HeaderText = "BoligOmråde";
            boligOmrådeDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligOmrådeDataGridViewTextBoxColumn.Name = "boligOmrådeDataGridViewTextBoxColumn";
            boligOmrådeDataGridViewTextBoxColumn.Width = 130;
            // 
            // boligNyPrisDataGridViewTextBoxColumn
            // 
            boligNyPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligNyPris";
            boligNyPrisDataGridViewTextBoxColumn.HeaderText = "BoligNyPris";
            boligNyPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligNyPrisDataGridViewTextBoxColumn.Name = "boligNyPrisDataGridViewTextBoxColumn";
            boligNyPrisDataGridViewTextBoxColumn.Width = 130;
            // 
            // boligSolgtPrisDataGridViewTextBoxColumn
            // 
            boligSolgtPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligSolgtPris";
            boligSolgtPrisDataGridViewTextBoxColumn.HeaderText = "BoligSolgtPris";
            boligSolgtPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligSolgtPrisDataGridViewTextBoxColumn.Name = "boligSolgtPrisDataGridViewTextBoxColumn";
            boligSolgtPrisDataGridViewTextBoxColumn.Width = 130;
            // 
            // boligStatusDataGridViewTextBoxColumn
            // 
            boligStatusDataGridViewTextBoxColumn.DataPropertyName = "BoligStatus";
            boligStatusDataGridViewTextBoxColumn.HeaderText = "BoligStatus";
            boligStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligStatusDataGridViewTextBoxColumn.Name = "boligStatusDataGridViewTextBoxColumn";
            boligStatusDataGridViewTextBoxColumn.Width = 130;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(RegisterHome);
            flowLayoutPanel1.Location = new Point(381, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(538, 48);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(121, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 42);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(239, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 42);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // RegisterHome
            // 
            RegisterHome.AutoSize = true;
            RegisterHome.Font = new Font("Segoe UI", 11F);
            RegisterHome.Location = new Point(357, 3);
            RegisterHome.Name = "RegisterHome";
            RegisterHome.Size = new Size(178, 42);
            RegisterHome.TabIndex = 3;
            RegisterHome.Text = "Registrer Bolig";
            RegisterHome.UseVisualStyleBackColor = true;
            // 
            // RealtorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "RealtorForm";
            Text = "RealtorForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource boligBindingSource;
        private BindingSource ejendomsmaeglerBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligAdresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligArealDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligStartPrisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligAfstandTilIndkoebDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligOmrådeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligNyPrisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligSolgtPrisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn boligStatusDataGridViewTextBoxColumn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button RegisterHome;
    }
}