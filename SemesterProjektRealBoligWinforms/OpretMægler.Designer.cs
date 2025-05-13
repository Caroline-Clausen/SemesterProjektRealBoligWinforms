namespace SemesterProjektRealBoligWinforms
{
    partial class OpretMægler
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
            ejendomsmaeglerBindingSource = new BindingSource(components);
            vistMæglerDataGridView = new DataGridView();
            ejendomsmaeglerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personNavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personTelefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opretMæglerKnap = new Button();
            fjernMæglerLable = new Label();
            fjernMæglerKnap = new Button();
            redigerMæglerLable = new Label();
            redigerMæglerKnap = new Button();
            afslutOpretMæglerKnap = new Button();
            listeMæglerLable = new Label();
            opdaterMæglerListeKnap = new Button();
            opretMæglerLable = new Label();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ejendomsmaeglerBindingSource
            // 
            ejendomsmaeglerBindingSource.DataSource = typeof(Projekt1Semester.Ejendomsmaegler);
            // 
            // vistMæglerDataGridView
            // 
            vistMæglerDataGridView.AllowUserToAddRows = false;
            vistMæglerDataGridView.AllowUserToDeleteRows = false;
            vistMæglerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vistMæglerDataGridView.AutoGenerateColumns = false;
            vistMæglerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vistMæglerDataGridView.Columns.AddRange(new DataGridViewColumn[] { ejendomsmaeglerIDDataGridViewTextBoxColumn, personNavnDataGridViewTextBoxColumn, personEmailDataGridViewTextBoxColumn, personTelefonDataGridViewTextBoxColumn });
            vistMæglerDataGridView.DataSource = ejendomsmaeglerBindingSource;
            vistMæglerDataGridView.Location = new Point(316, 46);
            vistMæglerDataGridView.MultiSelect = false;
            vistMæglerDataGridView.Name = "vistMæglerDataGridView";
            vistMæglerDataGridView.ReadOnly = true;
            vistMæglerDataGridView.Size = new Size(454, 342);
            vistMæglerDataGridView.TabIndex = 7;
            // 
            // ejendomsmaeglerIDDataGridViewTextBoxColumn
            // 
            ejendomsmaeglerIDDataGridViewTextBoxColumn.DataPropertyName = "EjendomsmaeglerID";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.HeaderText = "EjendomsmaeglerID";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.Name = "ejendomsmaeglerIDDataGridViewTextBoxColumn";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personNavnDataGridViewTextBoxColumn
            // 
            personNavnDataGridViewTextBoxColumn.DataPropertyName = "PersonNavn";
            personNavnDataGridViewTextBoxColumn.HeaderText = "PersonNavn";
            personNavnDataGridViewTextBoxColumn.Name = "personNavnDataGridViewTextBoxColumn";
            personNavnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personEmailDataGridViewTextBoxColumn
            // 
            personEmailDataGridViewTextBoxColumn.DataPropertyName = "PersonEmail";
            personEmailDataGridViewTextBoxColumn.HeaderText = "PersonEmail";
            personEmailDataGridViewTextBoxColumn.Name = "personEmailDataGridViewTextBoxColumn";
            personEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personTelefonDataGridViewTextBoxColumn
            // 
            personTelefonDataGridViewTextBoxColumn.DataPropertyName = "PersonTelefon";
            personTelefonDataGridViewTextBoxColumn.HeaderText = "PersonTelefon";
            personTelefonDataGridViewTextBoxColumn.Name = "personTelefonDataGridViewTextBoxColumn";
            personTelefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opretMæglerKnap
            // 
            opretMæglerKnap.Location = new Point(155, 71);
            opretMæglerKnap.Name = "opretMæglerKnap";
            opretMæglerKnap.Size = new Size(155, 23);
            opretMæglerKnap.TabIndex = 8;
            opretMæglerKnap.Text = "Opret ny ejendomsmægler";
            opretMæglerKnap.UseVisualStyleBackColor = true;
            opretMæglerKnap.Click += opretMæglerKnap_Click;
            // 
            // fjernMæglerLable
            // 
            fjernMæglerLable.AutoSize = true;
            fjernMæglerLable.Location = new Point(20, 367);
            fjernMæglerLable.Name = "fjernMæglerLable";
            fjernMæglerLable.Size = new Size(129, 15);
            fjernMæglerLable.TabIndex = 9;
            fjernMæglerLable.Text = "Fjern ejendomsmægler";
            // 
            // fjernMæglerKnap
            // 
            fjernMæglerKnap.Location = new Point(155, 363);
            fjernMæglerKnap.Name = "fjernMæglerKnap";
            fjernMæglerKnap.Size = new Size(155, 23);
            fjernMæglerKnap.TabIndex = 10;
            fjernMæglerKnap.Text = "Fjern ejendomsmægler";
            fjernMæglerKnap.UseVisualStyleBackColor = true;
            fjernMæglerKnap.Click += fjernMæglerKnap_Click;
            // 
            // redigerMæglerLable
            // 
            redigerMæglerLable.AutoSize = true;
            redigerMæglerLable.Location = new Point(37, 221);
            redigerMæglerLable.Name = "redigerMæglerLable";
            redigerMæglerLable.Size = new Size(112, 15);
            redigerMæglerLable.TabIndex = 15;
            redigerMæglerLable.Text = "Rediger oplysninger";
            // 
            // redigerMæglerKnap
            // 
            redigerMæglerKnap.Location = new Point(155, 217);
            redigerMæglerKnap.Name = "redigerMæglerKnap";
            redigerMæglerKnap.Size = new Size(155, 23);
            redigerMæglerKnap.TabIndex = 16;
            redigerMæglerKnap.Text = "Rediger oplysninger";
            redigerMæglerKnap.UseVisualStyleBackColor = true;
            redigerMæglerKnap.Click += redigerMæglerKnap_Click;
            // 
            // afslutOpretMæglerKnap
            // 
            afslutOpretMæglerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutOpretMæglerKnap.Location = new Point(663, 406);
            afslutOpretMæglerKnap.Name = "afslutOpretMæglerKnap";
            afslutOpretMæglerKnap.Size = new Size(107, 29);
            afslutOpretMæglerKnap.TabIndex = 17;
            afslutOpretMæglerKnap.Text = "Afslut";
            afslutOpretMæglerKnap.UseVisualStyleBackColor = true;
            afslutOpretMæglerKnap.Click += afslutOpretMæglerKnap_Click;
            // 
            // listeMæglerLable
            // 
            listeMæglerLable.AutoSize = true;
            listeMæglerLable.Location = new Point(457, 19);
            listeMæglerLable.Name = "listeMæglerLable";
            listeMæglerLable.Size = new Size(193, 15);
            listeMæglerLable.TabIndex = 18;
            listeMæglerLable.Text = "Liste over aktive ejendomsmæglere";
            // 
            // opdaterMæglerListeKnap
            // 
            opdaterMæglerListeKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            opdaterMæglerListeKnap.Location = new Point(316, 406);
            opdaterMæglerListeKnap.Name = "opdaterMæglerListeKnap";
            opdaterMæglerListeKnap.Size = new Size(107, 29);
            opdaterMæglerListeKnap.TabIndex = 19;
            opdaterMæglerListeKnap.Text = "Opdater liste";
            opdaterMæglerListeKnap.UseVisualStyleBackColor = true;
            opdaterMæglerListeKnap.Click += opdaterMæglerListeKnap_Click;
            // 
            // opretMæglerLable
            // 
            opretMæglerLable.AutoSize = true;
            opretMæglerLable.Location = new Point(16, 75);
            opretMæglerLable.Name = "opretMæglerLable";
            opretMæglerLable.Size = new Size(133, 15);
            opretMæglerLable.TabIndex = 20;
            opretMæglerLable.Text = "Opret ejendomsmægler";
            // 
            // OpretMægler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 447);
            Controls.Add(opretMæglerLable);
            Controls.Add(opdaterMæglerListeKnap);
            Controls.Add(listeMæglerLable);
            Controls.Add(afslutOpretMæglerKnap);
            Controls.Add(redigerMæglerKnap);
            Controls.Add(redigerMæglerLable);
            Controls.Add(fjernMæglerKnap);
            Controls.Add(fjernMæglerLable);
            Controls.Add(opretMæglerKnap);
            Controls.Add(vistMæglerDataGridView);
            MinimumSize = new Size(792, 486);
            Name = "OpretMægler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opret mægler";
            Load += OpretMægler_Load;
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource ejendomsmaeglerBindingSource;
        private DataGridView vistMæglerDataGridView;
        private DataGridViewTextBoxColumn ejendomsmaeglerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personNavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personTelefonDataGridViewTextBoxColumn;
        private Button opretMæglerKnap;
        private Label fjernMæglerLable;
        private Button fjernMæglerKnap;
        private Label redigerMæglerLable;
        private Button redigerMæglerKnap;
        private Button afslutOpretMæglerKnap;
        private Label listeMæglerLable;
        private Button opdaterMæglerListeKnap;
        private Label opretMæglerLable;
    }
}