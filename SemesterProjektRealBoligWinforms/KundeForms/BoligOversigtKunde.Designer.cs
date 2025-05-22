namespace SemesterProjektRealBoligWinforms
{
    partial class BoligOversigtKunde
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
            boligKundeGridView = new DataGridView();
            boligBindingSource = new BindingSource(components);
            afslutKnap = new Button();
            seBoligKnap = new Button();
            områdeComboBox = new ComboBox();
            områdeLable = new Label();
            seBoligLable = new Label();
            budBoligTextBox = new TextBox();
            budBoligKnap = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelFilter = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kvadratmeterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            afstandTilIndkoebDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            områdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)boligKundeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // boligKundeGridView
            // 
            boligKundeGridView.AllowUserToAddRows = false;
            boligKundeGridView.AllowUserToDeleteRows = false;
            boligKundeGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligKundeGridView.AutoGenerateColumns = false;
            boligKundeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boligKundeGridView.Columns.AddRange(new DataGridViewColumn[] { adresseDataGridViewTextBoxColumn, kvadratmeterDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, prisDataGridViewTextBoxColumn, afstandTilIndkoebDataGridViewTextBoxColumn, områdeDataGridViewTextBoxColumn });
            boligKundeGridView.DataSource = boligBindingSource;
            boligKundeGridView.Location = new Point(3, 38);
            boligKundeGridView.MultiSelect = false;
            boligKundeGridView.Name = "boligKundeGridView";
            boligKundeGridView.ReadOnly = true;
            boligKundeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            boligKundeGridView.Size = new Size(950, 517);
            boligKundeGridView.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            boligBindingSource.DataSource = typeof(Projekt1Semester.Bolig);
            // 
            // afslutKnap
            // 
            afslutKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutKnap.Location = new Point(874, 21);
            afslutKnap.Name = "afslutKnap";
            afslutKnap.Size = new Size(73, 30);
            afslutKnap.TabIndex = 1;
            afslutKnap.Text = "Afslut";
            afslutKnap.UseVisualStyleBackColor = true;
            afslutKnap.Click += afslutKnap_Click;
            // 
            // seBoligKnap
            // 
            seBoligKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            seBoligKnap.Location = new Point(576, 21);
            seBoligKnap.Name = "seBoligKnap";
            seBoligKnap.Size = new Size(73, 30);
            seBoligKnap.TabIndex = 2;
            seBoligKnap.Text = "Se bolig";
            seBoligKnap.UseVisualStyleBackColor = true;
            seBoligKnap.Click += seBoligKnap_Click;
            // 
            // områdeComboBox
            // 
            områdeComboBox.Anchor = AnchorStyles.None;
            områdeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            områdeComboBox.FormattingEnabled = true;
            områdeComboBox.Location = new Point(101, 6);
            områdeComboBox.Name = "områdeComboBox";
            områdeComboBox.Size = new Size(236, 23);
            områdeComboBox.Sorted = true;
            områdeComboBox.TabIndex = 5;
            områdeComboBox.SelectedIndexChanged += områdeComboBox_SelectedIndexChanged;
            // 
            // områdeLable
            // 
            områdeLable.Anchor = AnchorStyles.None;
            områdeLable.AutoSize = true;
            områdeLable.Location = new Point(45, 10);
            områdeLable.Name = "områdeLable";
            områdeLable.Size = new Size(50, 15);
            områdeLable.TabIndex = 6;
            områdeLable.Text = "Område";
            områdeLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seBoligLable
            // 
            seBoligLable.Anchor = AnchorStyles.Right;
            seBoligLable.AutoSize = true;
            seBoligLable.Location = new Point(343, 28);
            seBoligLable.Name = "seBoligLable";
            seBoligLable.Padding = new Padding(50, 0, 0, 0);
            seBoligLable.Size = new Size(227, 15);
            seBoligLable.TabIndex = 7;
            seBoligLable.Text = "Se den valgte boligs oplysninger";
            // 
            // budBoligTextBox
            // 
            budBoligTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            budBoligTextBox.Location = new Point(3, 24);
            budBoligTextBox.Name = "budBoligTextBox";
            budBoligTextBox.Size = new Size(255, 23);
            budBoligTextBox.TabIndex = 8;
            // 
            // budBoligKnap
            // 
            budBoligKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            budBoligKnap.Enabled = false;
            budBoligKnap.Location = new Point(264, 21);
            budBoligKnap.Name = "budBoligKnap";
            budBoligKnap.Size = new Size(73, 30);
            budBoligKnap.TabIndex = 9;
            budBoligKnap.Text = "Afgiv bud";
            budBoligKnap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 3, 0, 0);
            label1.Size = new Size(255, 18);
            label1.TabIndex = 10;
            label1.Text = "Ønsker du at afgive et bud på den valgte bolig?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelFilter, 0, 0);
            tableLayoutPanel1.Controls.Add(områdeLable, 1, 0);
            tableLayoutPanel1.Controls.Add(områdeComboBox, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(950, 35);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // labelFilter
            // 
            labelFilter.Anchor = AnchorStyles.None;
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(3, 10);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(36, 15);
            labelFilter.TabIndex = 0;
            labelFilter.Text = "Filter:";
            labelFilter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(budBoligKnap, 1, 1);
            tableLayoutPanel2.Controls.Add(budBoligTextBox, 0, 1);
            tableLayoutPanel2.Controls.Add(seBoligLable, 2, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(seBoligKnap, 3, 1);
            tableLayoutPanel2.Controls.Add(afslutKnap, 4, 1);
            tableLayoutPanel2.Location = new Point(3, 555);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(950, 54);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kvadratmeterDataGridViewTextBoxColumn
            // 
            kvadratmeterDataGridViewTextBoxColumn.DataPropertyName = "Kvadratmeter";
            kvadratmeterDataGridViewTextBoxColumn.HeaderText = "Kvadratmeter";
            kvadratmeterDataGridViewTextBoxColumn.Name = "kvadratmeterDataGridViewTextBoxColumn";
            kvadratmeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            prisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // afstandTilIndkoebDataGridViewTextBoxColumn
            // 
            afstandTilIndkoebDataGridViewTextBoxColumn.DataPropertyName = "AfstandTilIndkoeb";
            afstandTilIndkoebDataGridViewTextBoxColumn.HeaderText = "Afstand til indkøb";
            afstandTilIndkoebDataGridViewTextBoxColumn.Name = "afstandTilIndkoebDataGridViewTextBoxColumn";
            afstandTilIndkoebDataGridViewTextBoxColumn.ReadOnly = true;
            afstandTilIndkoebDataGridViewTextBoxColumn.Width = 130;
            // 
            // områdeDataGridViewTextBoxColumn
            // 
            områdeDataGridViewTextBoxColumn.DataPropertyName = "Område";
            områdeDataGridViewTextBoxColumn.HeaderText = "Område";
            områdeDataGridViewTextBoxColumn.Name = "områdeDataGridViewTextBoxColumn";
            områdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BoligOversigtKunde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 615);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(boligKundeGridView);
            MinimumSize = new Size(765, 200);
            Name = "BoligOversigtKunde";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boliger til salg";
            Load += BoligOversigtKunde_Load;
            ((System.ComponentModel.ISupportInitialize)boligKundeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView boligKundeGridView;
        private Button afslutKnap;
        private Button seBoligKnap;
        private ComboBox områdeComboBox;
        private Label områdeLable;
        private Label seBoligLable;
        private TextBox budBoligTextBox;
        private Button budBoligKnap;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelFilter;
        private TableLayoutPanel tableLayoutPanel2;
        private BindingSource boligBindingSource;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kvadratmeterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afstandTilIndkoebDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
    }
}