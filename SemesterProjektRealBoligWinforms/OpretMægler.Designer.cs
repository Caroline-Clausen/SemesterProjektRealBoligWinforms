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
            navnMæglerTekstbox = new TextBox();
            navnMæglerLable = new Label();
            opretNyEjendomsmæglerLable = new Label();
            telefonMæglerLable = new Label();
            telefonMæglerTekstboks = new TextBox();
            emailMæglerLable = new Label();
            emailMæglerTekstboks = new TextBox();
            ejendomsmaeglerBindingSource = new BindingSource(components);
            vistMæglerDataGridView = new DataGridView();
            ejendomsmaeglerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personNavnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personTelefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            opretMæglerKnap = new Button();
            fjernMæglerLable = new Label();
            fjernMæglerKnap = new Button();
            brugernavnMæglerTekstboks = new TextBox();
            parswordMæglerTekstboks = new TextBox();
            brugernavnMæglerLable = new Label();
            parswordMæglerLable = new Label();
            redigerMæglerLable = new Label();
            redigerMæglerKnap = new Button();
            afslutOpretMæglerKnap = new Button();
            listeMæglerLable = new Label();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // navnMæglerTekstbox
            // 
            navnMæglerTekstbox.Location = new Point(137, 46);
            navnMæglerTekstbox.Name = "navnMæglerTekstbox";
            navnMæglerTekstbox.Size = new Size(155, 23);
            navnMæglerTekstbox.TabIndex = 0;
            // 
            // navnMæglerLable
            // 
            navnMæglerLable.AutoSize = true;
            navnMæglerLable.Location = new Point(69, 49);
            navnMæglerLable.Name = "navnMæglerLable";
            navnMæglerLable.Size = new Size(63, 15);
            navnMæglerLable.TabIndex = 1;
            navnMæglerLable.Text = "Fuldt navn";
            // 
            // opretNyEjendomsmæglerLable
            // 
            opretNyEjendomsmæglerLable.AutoSize = true;
            opretNyEjendomsmæglerLable.Location = new Point(56, 18);
            opretNyEjendomsmæglerLable.Name = "opretNyEjendomsmæglerLable";
            opretNyEjendomsmæglerLable.Size = new Size(236, 15);
            opretNyEjendomsmæglerLable.TabIndex = 2;
            opretNyEjendomsmæglerLable.Text = "Indtast oplysninger på ny ejendomsmægler";
            // 
            // telefonMæglerLable
            // 
            telefonMæglerLable.AutoSize = true;
            telefonMæglerLable.Location = new Point(40, 83);
            telefonMæglerLable.Name = "telefonMæglerLable";
            telefonMæglerLable.Size = new Size(92, 15);
            telefonMæglerLable.TabIndex = 3;
            telefonMæglerLable.Text = "Telefonnummer";
            // 
            // telefonMæglerTekstboks
            // 
            telefonMæglerTekstboks.Location = new Point(137, 80);
            telefonMæglerTekstboks.Name = "telefonMæglerTekstboks";
            telefonMæglerTekstboks.Size = new Size(155, 23);
            telefonMæglerTekstboks.TabIndex = 4;
            // 
            // emailMæglerLable
            // 
            emailMæglerLable.AutoSize = true;
            emailMæglerLable.Location = new Point(52, 118);
            emailMæglerLable.Name = "emailMæglerLable";
            emailMæglerLable.Size = new Size(80, 15);
            emailMæglerLable.TabIndex = 5;
            emailMæglerLable.Text = "E-mailadresse";
            // 
            // emailMæglerTekstboks
            // 
            emailMæglerTekstboks.Location = new Point(137, 115);
            emailMæglerTekstboks.Name = "emailMæglerTekstboks";
            emailMæglerTekstboks.Size = new Size(155, 23);
            emailMæglerTekstboks.TabIndex = 6;
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
            vistMæglerDataGridView.Size = new Size(448, 210);
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
            opretMæglerKnap.Location = new Point(136, 232);
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
            fjernMæglerLable.Location = new Point(3, 416);
            fjernMæglerLable.Name = "fjernMæglerLable";
            fjernMæglerLable.Size = new Size(129, 15);
            fjernMæglerLable.TabIndex = 9;
            fjernMæglerLable.Text = "Fjern ejendomsmægler";
            // 
            // fjernMæglerKnap
            // 
            fjernMæglerKnap.Location = new Point(137, 412);
            fjernMæglerKnap.Name = "fjernMæglerKnap";
            fjernMæglerKnap.Size = new Size(155, 23);
            fjernMæglerKnap.TabIndex = 10;
            fjernMæglerKnap.Text = "Fjern ejendomsmægler";
            fjernMæglerKnap.UseVisualStyleBackColor = true;
            fjernMæglerKnap.Click += fjernMæglerKnap_Click;
            // 
            // brugernavnMæglerTekstboks
            // 
            brugernavnMæglerTekstboks.Location = new Point(137, 153);
            brugernavnMæglerTekstboks.Name = "brugernavnMæglerTekstboks";
            brugernavnMæglerTekstboks.Size = new Size(155, 23);
            brugernavnMæglerTekstboks.TabIndex = 11;
            // 
            // parswordMæglerTekstboks
            // 
            parswordMæglerTekstboks.Location = new Point(137, 188);
            parswordMæglerTekstboks.Name = "parswordMæglerTekstboks";
            parswordMæglerTekstboks.Size = new Size(155, 23);
            parswordMæglerTekstboks.TabIndex = 12;
            // 
            // brugernavnMæglerLable
            // 
            brugernavnMæglerLable.AutoSize = true;
            brugernavnMæglerLable.Location = new Point(64, 156);
            brugernavnMæglerLable.Name = "brugernavnMæglerLable";
            brugernavnMæglerLable.Size = new Size(68, 15);
            brugernavnMæglerLable.TabIndex = 13;
            brugernavnMæglerLable.Text = "Brugernavn";
            // 
            // parswordMæglerLable
            // 
            parswordMæglerLable.AutoSize = true;
            parswordMæglerLable.Location = new Point(75, 196);
            parswordMæglerLable.Name = "parswordMæglerLable";
            parswordMæglerLable.Size = new Size(57, 15);
            parswordMæglerLable.TabIndex = 14;
            parswordMæglerLable.Text = "Password";
            // 
            // redigerMæglerLable
            // 
            redigerMæglerLable.AutoSize = true;
            redigerMæglerLable.Location = new Point(20, 323);
            redigerMæglerLable.Name = "redigerMæglerLable";
            redigerMæglerLable.Size = new Size(112, 15);
            redigerMæglerLable.TabIndex = 15;
            redigerMæglerLable.Text = "Rediger oplysninger";
            // 
            // redigerMæglerKnap
            // 
            redigerMæglerKnap.Location = new Point(136, 319);
            redigerMæglerKnap.Name = "redigerMæglerKnap";
            redigerMæglerKnap.Size = new Size(155, 23);
            redigerMæglerKnap.TabIndex = 16;
            redigerMæglerKnap.Text = "Marker person og tryk her";
            redigerMæglerKnap.UseVisualStyleBackColor = true;
            // 
            // afslutOpretMæglerKnap
            // 
            afslutOpretMæglerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutOpretMæglerKnap.Location = new Point(657, 406);
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
            listeMæglerLable.Location = new Point(422, 15);
            listeMæglerLable.Name = "listeMæglerLable";
            listeMæglerLable.Size = new Size(193, 15);
            listeMæglerLable.TabIndex = 18;
            listeMæglerLable.Text = "Liste over aktive ejendomsmæglere";
            // 
            // OpretMægler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 447);
            Controls.Add(listeMæglerLable);
            Controls.Add(afslutOpretMæglerKnap);
            Controls.Add(redigerMæglerKnap);
            Controls.Add(redigerMæglerLable);
            Controls.Add(parswordMæglerLable);
            Controls.Add(brugernavnMæglerLable);
            Controls.Add(parswordMæglerTekstboks);
            Controls.Add(brugernavnMæglerTekstboks);
            Controls.Add(fjernMæglerKnap);
            Controls.Add(fjernMæglerLable);
            Controls.Add(opretMæglerKnap);
            Controls.Add(vistMæglerDataGridView);
            Controls.Add(emailMæglerTekstboks);
            Controls.Add(emailMæglerLable);
            Controls.Add(telefonMæglerTekstboks);
            Controls.Add(telefonMæglerLable);
            Controls.Add(opretNyEjendomsmæglerLable);
            Controls.Add(navnMæglerLable);
            Controls.Add(navnMæglerTekstbox);
            MinimumSize = new Size(792, 486);
            Name = "OpretMægler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opret mægler";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox navnMæglerTekstbox;
        private Label navnMæglerLable;
        private Label opretNyEjendomsmæglerLable;
        private Label telefonMæglerLable;
        private TextBox telefonMæglerTekstboks;
        private Label emailMæglerLable;
        private TextBox emailMæglerTekstboks;
        private BindingSource ejendomsmaeglerBindingSource;
        private DataGridView vistMæglerDataGridView;
        private DataGridViewTextBoxColumn ejendomsmaeglerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personNavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personTelefonDataGridViewTextBoxColumn;
        private Button opretMæglerKnap;
        private Label fjernMæglerLable;
        private Button fjernMæglerKnap;
        private TextBox brugernavnMæglerTekstboks;
        private TextBox parswordMæglerTekstboks;
        private Label brugernavnMæglerLable;
        private Label parswordMæglerLable;
        private Label redigerMæglerLable;
        private Button redigerMæglerKnap;
        private Button afslutOpretMæglerKnap;
        private Label listeMæglerLable;
    }
}