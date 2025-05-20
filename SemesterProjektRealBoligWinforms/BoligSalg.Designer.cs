namespace SemesterProjektRealBoligWinforms
{
    partial class salgBolig
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
            FortrydButton = new Button();
            GemButton = new Button();
            boligTableLayoutPanel = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            AdresseTextBox = new TextBox();
            adresseLable = new Label();
            koeberIDLable = new Label();
            label1 = new Label();
            SælgerComboBox = new ComboBox();
            datoLable = new Label();
            boligPrisLable = new Label();
            afstandLable = new Label();
            PrisTextBox = new TextBox();
            krLabel = new Label();
            saelgerComboBox = new ComboBox();
            koeberComboBox = new ComboBox();
            boligTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FortrydButton
            // 
            FortrydButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FortrydButton.DialogResult = DialogResult.Cancel;
            FortrydButton.Location = new Point(308, 199);
            FortrydButton.Name = "FortrydButton";
            FortrydButton.Size = new Size(70, 32);
            FortrydButton.TabIndex = 21;
            FortrydButton.Text = "Fortryd";
            FortrydButton.UseVisualStyleBackColor = true;
            // 
            // GemButton
            // 
            GemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GemButton.DialogResult = DialogResult.OK;
            GemButton.Location = new Point(232, 199);
            GemButton.Name = "GemButton";
            GemButton.Size = new Size(70, 32);
            GemButton.TabIndex = 20;
            GemButton.Text = "Gem";
            GemButton.UseVisualStyleBackColor = true;
            // 
            // boligTableLayoutPanel
            // 
            boligTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligTableLayoutPanel.ColumnCount = 3;
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.84884F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.15116F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            boligTableLayoutPanel.Controls.Add(dateTimePicker1, 1, 3);
            boligTableLayoutPanel.Controls.Add(AdresseTextBox, 1, 0);
            boligTableLayoutPanel.Controls.Add(adresseLable, 0, 0);
            boligTableLayoutPanel.Controls.Add(koeberIDLable, 0, 2);
            boligTableLayoutPanel.Controls.Add(label1, 0, 6);
            boligTableLayoutPanel.Controls.Add(SælgerComboBox, 1, 6);
            boligTableLayoutPanel.Controls.Add(datoLable, 0, 3);
            boligTableLayoutPanel.Controls.Add(boligPrisLable, 0, 4);
            boligTableLayoutPanel.Controls.Add(afstandLable, 0, 1);
            boligTableLayoutPanel.Controls.Add(PrisTextBox, 1, 4);
            boligTableLayoutPanel.Controls.Add(krLabel, 2, 4);
            boligTableLayoutPanel.Controls.Add(saelgerComboBox, 1, 1);
            boligTableLayoutPanel.Controls.Add(koeberComboBox, 1, 2);
            boligTableLayoutPanel.Location = new Point(5, 12);
            boligTableLayoutPanel.Name = "boligTableLayoutPanel";
            boligTableLayoutPanel.RowCount = 7;
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            boligTableLayoutPanel.Size = new Size(373, 181);
            boligTableLayoutPanel.TabIndex = 19;
            boligTableLayoutPanel.Paint += boligTableLayoutPanel_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // AdresseTextBox
            // 
            AdresseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AdresseTextBox.Location = new Point(115, 3);
            AdresseTextBox.Name = "AdresseTextBox";
            AdresseTextBox.Size = new Size(224, 23);
            AdresseTextBox.TabIndex = 16;
            AdresseTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // adresseLable
            // 
            adresseLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            adresseLable.AutoSize = true;
            adresseLable.Location = new Point(2, 0);
            adresseLable.Margin = new Padding(2, 0, 2, 0);
            adresseLable.Name = "adresseLable";
            adresseLable.Size = new Size(108, 30);
            adresseLable.TabIndex = 16;
            adresseLable.Text = "Adresse (den man er trykket ind på)";
            // 
            // koeberIDLable
            // 
            koeberIDLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            koeberIDLable.AutoSize = true;
            koeberIDLable.Location = new Point(2, 60);
            koeberIDLable.Margin = new Padding(2, 0, 2, 0);
            koeberIDLable.Name = "koeberIDLable";
            koeberIDLable.Size = new Size(108, 30);
            koeberIDLable.TabIndex = 2;
            koeberIDLable.Text = "Køber (hvis ikke på liste, opret)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(2, 157);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 27;
            label1.Text = "Sælger";
            // 
            // SælgerComboBox
            // 
            SælgerComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SælgerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SælgerComboBox.FormattingEnabled = true;
            SælgerComboBox.Location = new Point(115, 153);
            SælgerComboBox.Name = "SælgerComboBox";
            SælgerComboBox.Size = new Size(224, 23);
            SælgerComboBox.Sorted = true;
            SælgerComboBox.TabIndex = 30;
            // 
            // datoLable
            // 
            datoLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datoLable.AutoSize = true;
            datoLable.Location = new Point(2, 97);
            datoLable.Margin = new Padding(2, 0, 2, 0);
            datoLable.Name = "datoLable";
            datoLable.Size = new Size(108, 15);
            datoLable.TabIndex = 1;
            datoLable.Text = "Dato for boligsalg";
            // 
            // boligPrisLable
            // 
            boligPrisLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligPrisLable.AutoSize = true;
            boligPrisLable.Location = new Point(2, 126);
            boligPrisLable.Margin = new Padding(2, 0, 2, 0);
            boligPrisLable.Name = "boligPrisLable";
            boligPrisLable.Size = new Size(108, 15);
            boligPrisLable.TabIndex = 4;
            boligPrisLable.Text = "Pris på bolig";
            // 
            // afstandLable
            // 
            afstandLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            afstandLable.AutoSize = true;
            afstandLable.Location = new Point(2, 30);
            afstandLable.Margin = new Padding(2, 0, 2, 0);
            afstandLable.Name = "afstandLable";
            afstandLable.Size = new Size(108, 30);
            afstandLable.TabIndex = 14;
            afstandLable.Text = "Sælges navn (vælg fra liste)";
            // 
            // PrisTextBox
            // 
            PrisTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PrisTextBox.Location = new Point(115, 122);
            PrisTextBox.Name = "PrisTextBox";
            PrisTextBox.Size = new Size(224, 23);
            PrisTextBox.TabIndex = 19;
            PrisTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // krLabel
            // 
            krLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            krLabel.AutoSize = true;
            krLabel.Location = new Point(345, 126);
            krLabel.Name = "krLabel";
            krLabel.Size = new Size(25, 15);
            krLabel.TabIndex = 22;
            krLabel.Text = "kr";
            // 
            // saelgerComboBox
            // 
            saelgerComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            saelgerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            saelgerComboBox.FormattingEnabled = true;
            saelgerComboBox.Location = new Point(115, 33);
            saelgerComboBox.Name = "saelgerComboBox";
            saelgerComboBox.Size = new Size(224, 23);
            saelgerComboBox.Sorted = true;
            saelgerComboBox.TabIndex = 31;
            // 
            // koeberComboBox
            // 
            koeberComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            koeberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            koeberComboBox.FormattingEnabled = true;
            koeberComboBox.Location = new Point(115, 63);
            koeberComboBox.Name = "koeberComboBox";
            koeberComboBox.Size = new Size(224, 23);
            koeberComboBox.Sorted = true;
            koeberComboBox.TabIndex = 32;
            // 
            // salgBolig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 232);
            Controls.Add(FortrydButton);
            Controls.Add(GemButton);
            Controls.Add(boligTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "salgBolig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bolig Solgt";
            boligTableLayoutPanel.ResumeLayout(false);
            boligTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button FortrydButton;
        private Button GemButton;
        private TableLayoutPanel boligTableLayoutPanel;
        private TextBox PrisTextBox;
        public TextBox AdresseTextBox;
        private Label adresseLable;
        private Label datoLable;
        private Label koeberIDLable;
        private Label boligPrisLable;
        private Label krLabel;
        private Label afstandLable;
        private Label label1;
        private ComboBox SælgerComboBox;
        private DateTimePicker dateTimePicker1;
        private ComboBox saelgerComboBox;
        private ComboBox koeberComboBox;
    }
}