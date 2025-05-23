﻿namespace SemesterProjektRealBoligWinforms
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
            HomesGridView = new DataGridView();
            boligUdvidetBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UpdateDataTableButton = new Button();
            SortListButton = new Button();
            RegisterHomeButton = new Button();
            EditHomeButton = new Button();
            sletBoligButton = new Button();
            ExportListButton = new Button();
            homeSaleButton = new Button();
            boligIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kvadratmeterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            afstandTilIndkoebDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saelgerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            områdeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SalgsDato = new DataGridViewTextBoxColumn();
            SalgsPris = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)HomesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boligUdvidetBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // HomesGridView
            // 
            HomesGridView.AllowUserToAddRows = false;
            HomesGridView.AllowUserToDeleteRows = false;
            HomesGridView.AllowUserToResizeColumns = false;
            HomesGridView.AllowUserToResizeRows = false;
            HomesGridView.AutoGenerateColumns = false;
            HomesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            HomesGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            HomesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HomesGridView.Columns.AddRange(new DataGridViewColumn[] { boligIDDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, kvadratmeterDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, prisDataGridViewTextBoxColumn, afstandTilIndkoebDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, saelgerIDDataGridViewTextBoxColumn, områdeDataGridViewTextBoxColumn, SalgsDato, SalgsPris });
            HomesGridView.DataSource = boligUdvidetBindingSource;
            HomesGridView.Dock = DockStyle.Fill;
            HomesGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            HomesGridView.Location = new Point(3, 81);
            HomesGridView.Name = "HomesGridView";
            HomesGridView.ReadOnly = true;
            HomesGridView.RowHeadersWidth = 62;
            HomesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            HomesGridView.Size = new Size(1294, 359);
            HomesGridView.TabIndex = 0;
            // 
            // boligUdvidetBindingSource
            // 
            boligUdvidetBindingSource.DataSource = typeof(Projekt1Semester.BoligUdvidet);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(HomesGridView, 0, 1);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(UpdateDataTableButton);
            flowLayoutPanel1.Controls.Add(SortListButton);
            flowLayoutPanel1.Controls.Add(RegisterHomeButton);
            flowLayoutPanel1.Controls.Add(EditHomeButton);
            flowLayoutPanel1.Controls.Add(sletBoligButton);
            flowLayoutPanel1.Controls.Add(ExportListButton);
            flowLayoutPanel1.Controls.Add(homeSaleButton);
            flowLayoutPanel1.Location = new Point(172, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(956, 46);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // UpdateDataTableButton
            // 
            UpdateDataTableButton.AutoSize = true;
            UpdateDataTableButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateDataTableButton.Font = new Font("Segoe UI", 11F);
            UpdateDataTableButton.Location = new Point(3, 3);
            UpdateDataTableButton.Name = "UpdateDataTableButton";
            UpdateDataTableButton.Size = new Size(161, 40);
            UpdateDataTableButton.TabIndex = 2;
            UpdateDataTableButton.Text = "Opdater Tabel";
            UpdateDataTableButton.UseVisualStyleBackColor = true;
            UpdateDataTableButton.Click += RefreshDataTable;
            // 
            // SortListButton
            // 
            SortListButton.AutoSize = true;
            SortListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SortListButton.Dock = DockStyle.Fill;
            SortListButton.Font = new Font("Segoe UI", 11F);
            SortListButton.Location = new Point(170, 3);
            SortListButton.Name = "SortListButton";
            SortListButton.Size = new Size(71, 40);
            SortListButton.TabIndex = 5;
            SortListButton.Text = "Filter";
            SortListButton.UseVisualStyleBackColor = true;
            SortListButton.Click += SortListButton_Click;
            // 
            // RegisterHomeButton
            // 
            RegisterHomeButton.AutoSize = true;
            RegisterHomeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterHomeButton.Font = new Font("Segoe UI", 11F);
            RegisterHomeButton.Location = new Point(247, 3);
            RegisterHomeButton.Name = "RegisterHomeButton";
            RegisterHomeButton.Size = new Size(135, 40);
            RegisterHomeButton.TabIndex = 3;
            RegisterHomeButton.Text = "Opret Bolig";
            RegisterHomeButton.UseVisualStyleBackColor = true;
            RegisterHomeButton.Click += RegisterHomeButton_Click;
            // 
            // EditHomeButton
            // 
            EditHomeButton.AutoSize = true;
            EditHomeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditHomeButton.Font = new Font("Segoe UI", 11F);
            EditHomeButton.Location = new Point(388, 3);
            EditHomeButton.Name = "EditHomeButton";
            EditHomeButton.Size = new Size(153, 40);
            EditHomeButton.TabIndex = 4;
            EditHomeButton.Text = "Rediger Bolig";
            EditHomeButton.UseVisualStyleBackColor = true;
            EditHomeButton.Click += EditHomeButton_Click;
            // 
            // sletBoligButton
            // 
            sletBoligButton.AutoSize = true;
            sletBoligButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sletBoligButton.Font = new Font("Segoe UI", 11F);
            sletBoligButton.Location = new Point(547, 3);
            sletBoligButton.Name = "sletBoligButton";
            sletBoligButton.Size = new Size(114, 40);
            sletBoligButton.TabIndex = 7;
            sletBoligButton.Text = "Slet Bolig";
            sletBoligButton.UseVisualStyleBackColor = true;
            sletBoligButton.Click += sletBoligButton_Click;
            // 
            // ExportListButton
            // 
            ExportListButton.AutoSize = true;
            ExportListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExportListButton.Font = new Font("Segoe UI", 11F);
            ExportListButton.Location = new Point(667, 3);
            ExportListButton.Name = "ExportListButton";
            ExportListButton.Size = new Size(154, 40);
            ExportListButton.TabIndex = 6;
            ExportListButton.Text = "Exporter Liste";
            ExportListButton.UseVisualStyleBackColor = true;
            ExportListButton.MouseClick += ExportListButton_MouseClick;
            // 
            // homeSaleButton
            // 
            homeSaleButton.AutoSize = true;
            homeSaleButton.Font = new Font("Segoe UI", 11F);
            homeSaleButton.Location = new Point(826, 2);
            homeSaleButton.Margin = new Padding(2);
            homeSaleButton.Name = "homeSaleButton";
            homeSaleButton.Size = new Size(128, 40);
            homeSaleButton.TabIndex = 8;
            homeSaleButton.Text = "Bolig Solgt";
            homeSaleButton.UseVisualStyleBackColor = true;
            homeSaleButton.Click += homeSaleButton_Click;
            // 
            // boligIDDataGridViewTextBoxColumn
            // 
            boligIDDataGridViewTextBoxColumn.DataPropertyName = "BoligID";
            boligIDDataGridViewTextBoxColumn.HeaderText = "BoligID";
            boligIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            boligIDDataGridViewTextBoxColumn.Name = "boligIDDataGridViewTextBoxColumn";
            boligIDDataGridViewTextBoxColumn.ReadOnly = true;
            boligIDDataGridViewTextBoxColumn.Width = 106;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.ReadOnly = true;
            adresseDataGridViewTextBoxColumn.Width = 111;
            // 
            // kvadratmeterDataGridViewTextBoxColumn
            // 
            kvadratmeterDataGridViewTextBoxColumn.DataPropertyName = "Kvadratmeter";
            kvadratmeterDataGridViewTextBoxColumn.HeaderText = "Kvadratmeter";
            kvadratmeterDataGridViewTextBoxColumn.MinimumWidth = 8;
            kvadratmeterDataGridViewTextBoxColumn.Name = "kvadratmeterDataGridViewTextBoxColumn";
            kvadratmeterDataGridViewTextBoxColumn.ReadOnly = true;
            kvadratmeterDataGridViewTextBoxColumn.Width = 153;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 85;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            prisDataGridViewTextBoxColumn.MinimumWidth = 8;
            prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            prisDataGridViewTextBoxColumn.ReadOnly = true;
            prisDataGridViewTextBoxColumn.Width = 76;
            // 
            // afstandTilIndkoebDataGridViewTextBoxColumn
            // 
            afstandTilIndkoebDataGridViewTextBoxColumn.DataPropertyName = "AfstandTilIndkoeb";
            afstandTilIndkoebDataGridViewTextBoxColumn.HeaderText = "AfstandTilIndkoeb";
            afstandTilIndkoebDataGridViewTextBoxColumn.MinimumWidth = 8;
            afstandTilIndkoebDataGridViewTextBoxColumn.Name = "afstandTilIndkoebDataGridViewTextBoxColumn";
            afstandTilIndkoebDataGridViewTextBoxColumn.ReadOnly = true;
            afstandTilIndkoebDataGridViewTextBoxColumn.Width = 193;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 96;
            // 
            // saelgerIDDataGridViewTextBoxColumn
            // 
            saelgerIDDataGridViewTextBoxColumn.DataPropertyName = "SaelgerID";
            saelgerIDDataGridViewTextBoxColumn.HeaderText = "SaelgerID";
            saelgerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            saelgerIDDataGridViewTextBoxColumn.Name = "saelgerIDDataGridViewTextBoxColumn";
            saelgerIDDataGridViewTextBoxColumn.ReadOnly = true;
            saelgerIDDataGridViewTextBoxColumn.Width = 124;
            // 
            // områdeDataGridViewTextBoxColumn
            // 
            områdeDataGridViewTextBoxColumn.DataPropertyName = "Område";
            områdeDataGridViewTextBoxColumn.HeaderText = "Område";
            områdeDataGridViewTextBoxColumn.MinimumWidth = 8;
            områdeDataGridViewTextBoxColumn.Name = "områdeDataGridViewTextBoxColumn";
            områdeDataGridViewTextBoxColumn.ReadOnly = true;
            områdeDataGridViewTextBoxColumn.Width = 113;
            // 
            // SalgsDato
            // 
            SalgsDato.HeaderText = "Salgs Dato";
            SalgsDato.MinimumWidth = 8;
            SalgsDato.Name = "SalgsDato";
            SalgsDato.ReadOnly = true;
            SalgsDato.Width = 134;
            // 
            // SalgsPris
            // 
            SalgsPris.HeaderText = "Salgs Pris";
            SalgsPris.MinimumWidth = 8;
            SalgsPris.Name = "SalgsPris";
            SalgsPris.ReadOnly = true;
            SalgsPris.Width = 123;
            // 
            // RealtorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "RealtorForm";
            Text = "RealtorForm";
            Load += RealtorForm_Load;
            ((System.ComponentModel.ISupportInitialize)HomesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)boligUdvidetBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HomesGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button UpdateDataTableButton;
        private Button RegisterHomeButton;
        private Button EditHomeButton;
        private Button SortListButton;
        private Button ExportListButton;
        private Button sletBoligButton;
        private Button homeSaleButton;
        private BindingSource boligUdvidetBindingSource;
        private DataGridViewTextBoxColumn boligIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kvadratmeterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afstandTilIndkoebDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saelgerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn områdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SalgsDato;
        private DataGridViewTextBoxColumn SalgsPris;
    }
}