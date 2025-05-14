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
            boligBindingSource = new BindingSource(components);
            ejendomsmaeglerBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { boligIDDataGridViewTextBoxColumn, boligAdresseDataGridViewTextBoxColumn, boligArealDataGridViewTextBoxColumn, boligTypeDataGridViewTextBoxColumn, boligStartPrisDataGridViewTextBoxColumn, boligAfstandTilIndkoebDataGridViewTextBoxColumn, boligOmrådeDataGridViewTextBoxColumn, boligNyPrisDataGridViewTextBoxColumn, boligSolgtPrisDataGridViewTextBoxColumn, boligStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = boligBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(794, 309);
            dataGridView1.TabIndex = 0;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            boligIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            boligIDDataGridViewTextBoxColumn.Width = 150;
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
            boligArealDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligTypeDataGridViewTextBoxColumn
            // 
            boligTypeDataGridViewTextBoxColumn.DataPropertyName = "BoligType";
            boligTypeDataGridViewTextBoxColumn.HeaderText = "BoligType";
            boligTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligTypeDataGridViewTextBoxColumn.Name = "boligTypeDataGridViewTextBoxColumn";
            boligTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligStartPrisDataGridViewTextBoxColumn
            // 
            boligStartPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligStartPris";
            boligStartPrisDataGridViewTextBoxColumn.HeaderText = "BoligStartPris";
            boligStartPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligStartPrisDataGridViewTextBoxColumn.Name = "boligStartPrisDataGridViewTextBoxColumn";
            boligStartPrisDataGridViewTextBoxColumn.Width = 150;
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
            boligOmrådeDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligNyPrisDataGridViewTextBoxColumn
            // 
            boligNyPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligNyPris";
            boligNyPrisDataGridViewTextBoxColumn.HeaderText = "BoligNyPris";
            boligNyPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligNyPrisDataGridViewTextBoxColumn.Name = "boligNyPrisDataGridViewTextBoxColumn";
            boligNyPrisDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligSolgtPrisDataGridViewTextBoxColumn
            // 
            boligSolgtPrisDataGridViewTextBoxColumn.DataPropertyName = "BoligSolgtPris";
            boligSolgtPrisDataGridViewTextBoxColumn.HeaderText = "BoligSolgtPris";
            boligSolgtPrisDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligSolgtPrisDataGridViewTextBoxColumn.Name = "boligSolgtPrisDataGridViewTextBoxColumn";
            boligSolgtPrisDataGridViewTextBoxColumn.Width = 150;
            // 
            // boligStatusDataGridViewTextBoxColumn
            // 
            boligStatusDataGridViewTextBoxColumn.DataPropertyName = "BoligStatus";
            boligStatusDataGridViewTextBoxColumn.HeaderText = "BoligStatus";
            boligStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligStatusDataGridViewTextBoxColumn.Name = "boligStatusDataGridViewTextBoxColumn";
            boligStatusDataGridViewTextBoxColumn.Width = 150;
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 67);
            label1.TabIndex = 1;
            label1.Text = "Boliger";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RealtorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "RealtorForm";
            Text = "RealtorForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
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
        private BindingSource boligBindingSource;
        private BindingSource ejendomsmaeglerBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}