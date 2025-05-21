
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
            salgsDatoDateTimePicker = new DateTimePicker();
            AdresseTextBox = new TextBox();
            adresseLable = new Label();
            koeberIDLable = new Label();
            mæglerLable = new Label();
            mæglerComboBox = new ComboBox();
            datoLable = new Label();
            boligPrisLable = new Label();
            afstandLable = new Label();
            prisTextBox = new TextBox();
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
            GemButton.Click += GemButton_Click;
            // 
            // boligTableLayoutPanel
            // 
            boligTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligTableLayoutPanel.ColumnCount = 3;
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.84884F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.15116F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            boligTableLayoutPanel.Controls.Add(salgsDatoDateTimePicker, 1, 3);
            boligTableLayoutPanel.Controls.Add(AdresseTextBox, 1, 0);
            boligTableLayoutPanel.Controls.Add(adresseLable, 0, 0);
            boligTableLayoutPanel.Controls.Add(koeberIDLable, 0, 2);
            boligTableLayoutPanel.Controls.Add(mæglerLable, 0, 6);
            boligTableLayoutPanel.Controls.Add(mæglerComboBox, 1, 6);
            boligTableLayoutPanel.Controls.Add(datoLable, 0, 3);
            boligTableLayoutPanel.Controls.Add(boligPrisLable, 0, 4);
            boligTableLayoutPanel.Controls.Add(afstandLable, 0, 1);
            boligTableLayoutPanel.Controls.Add(prisTextBox, 1, 4);
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
            // 
            // salgsDatoDateTimePicker
            // 
            salgsDatoDateTimePicker.Location = new Point(115, 90);
            salgsDatoDateTimePicker.Name = "salgsDatoDateTimePicker";
            salgsDatoDateTimePicker.Size = new Size(224, 23);
            salgsDatoDateTimePicker.TabIndex = 22;
            // 
            // AdresseTextBox
            // 
            AdresseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AdresseTextBox.Location = new Point(115, 3);
            AdresseTextBox.Name = "AdresseTextBox";
            AdresseTextBox.ReadOnly = true;
            AdresseTextBox.Size = new Size(224, 23);
            AdresseTextBox.TabIndex = 16;
            AdresseTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // adresseLable
            // 
            adresseLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            adresseLable.AutoSize = true;
            adresseLable.Location = new Point(2, 7);
            adresseLable.Margin = new Padding(2, 0, 2, 0);
            adresseLable.Name = "adresseLable";
            adresseLable.Size = new Size(108, 15);
            adresseLable.TabIndex = 16;
            adresseLable.Text = "Adresse ";
            // 
            // koeberIDLable
            // 
            koeberIDLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            koeberIDLable.AutoSize = true;
            koeberIDLable.Location = new Point(2, 65);
            koeberIDLable.Margin = new Padding(2, 0, 2, 0);
            koeberIDLable.Name = "koeberIDLable";
            koeberIDLable.Size = new Size(108, 15);
            koeberIDLable.TabIndex = 2;
            koeberIDLable.Text = "Køber ";
            // 
            // mæglerLable
            // 
            mæglerLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mæglerLable.AutoSize = true;
            mæglerLable.Location = new Point(2, 155);
            mæglerLable.Margin = new Padding(2, 0, 2, 0);
            mæglerLable.Name = "mæglerLable";
            mæglerLable.Size = new Size(108, 15);
            mæglerLable.TabIndex = 27;
            mæglerLable.Text = "Ejendomsmægler";
            // 
            // mæglerComboBox
            // 
            mæglerComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mæglerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mæglerComboBox.FormattingEnabled = true;
            mæglerComboBox.Location = new Point(115, 151);
            mæglerComboBox.Name = "mæglerComboBox";
            mæglerComboBox.Size = new Size(224, 23);
            mæglerComboBox.Sorted = true;
            mæglerComboBox.TabIndex = 30;
            // 
            // datoLable
            // 
            datoLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datoLable.AutoSize = true;
            datoLable.Location = new Point(2, 94);
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
            boligPrisLable.Location = new Point(2, 123);
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
            afstandLable.Location = new Point(2, 36);
            afstandLable.Margin = new Padding(2, 0, 2, 0);
            afstandLable.Name = "afstandLable";
            afstandLable.Size = new Size(108, 15);
            afstandLable.TabIndex = 14;
            afstandLable.Text = "Sælges navn ";
            // 
            // prisTextBox
            // 
            prisTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            prisTextBox.Location = new Point(115, 119);
            prisTextBox.Name = "prisTextBox";
            prisTextBox.Size = new Size(224, 23);
            prisTextBox.TabIndex = 19;
            prisTextBox.TextAlign = HorizontalAlignment.Right;
            prisTextBox.KeyPress += prisTextBox_KeyPress;
            // 
            // krLabel
            // 
            krLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            krLabel.AutoSize = true;
            krLabel.Location = new Point(345, 123);
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
            saelgerComboBox.Location = new Point(115, 32);
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
            koeberComboBox.Location = new Point(115, 61);
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
        private TextBox prisTextBox;
        public TextBox AdresseTextBox;
        private Label adresseLable;
        private Label datoLable;
        private Label koeberIDLable;
        private Label boligPrisLable;
        private Label krLabel;
        private Label afstandLable;
        private Label mæglerLable;
        private ComboBox mæglerComboBox;
        private DateTimePicker salgsDatoDateTimePicker;
        private ComboBox saelgerComboBox;
        private ComboBox koeberComboBox;
    }
}