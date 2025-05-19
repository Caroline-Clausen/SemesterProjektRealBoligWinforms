namespace SemesterProjektRealBoligWinforms
{
    partial class BoligVisningKunde
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            tilbageBoligKnap = new Button();
            boligArealLable = new Label();
            boligTypeLable = new Label();
            områdeLable = new Label();
            boligPrisLable = new Label();
            label1 = new Label();
            budBoligKnap = new Button();
            budBoligTextBox = new TextBox();
            afstandLable = new Label();
            boligTableLayoutPanel = new TableLayoutPanel();
            prisTextBox = new TextBox();
            områdeTextBox = new TextBox();
            afstandIndkøbTextBox = new TextBox();
            arealTextBox = new TextBox();
            boligTypeTextBox = new TextBox();
            adresseTextBox = new TextBox();
            krLabel = new Label();
            kmLabel = new Label();
            m2Label = new Label();
            adresseLable = new Label();
            boligTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tilbageBoligKnap
            // 
            tilbageBoligKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tilbageBoligKnap.Location = new Point(316, 236);
            tilbageBoligKnap.Margin = new Padding(2, 1, 2, 1);
            tilbageBoligKnap.Name = "tilbageBoligKnap";
            tilbageBoligKnap.Size = new Size(89, 26);
            tilbageBoligKnap.TabIndex = 0;
            tilbageBoligKnap.Text = "Tilbage";
            tilbageBoligKnap.UseVisualStyleBackColor = true;
            tilbageBoligKnap.Click += tilbageBoligKnap_Click;
            // 
            // boligArealLable
            // 
            boligArealLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligArealLable.AutoSize = true;
            boligArealLable.Location = new Point(2, 65);
            boligArealLable.Margin = new Padding(2, 0, 2, 0);
            boligArealLable.Name = "boligArealLable";
            boligArealLable.Size = new Size(105, 15);
            boligArealLable.TabIndex = 1;
            boligArealLable.Text = "Bolig areal m2";
            // 
            // boligTypeLable
            // 
            boligTypeLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligTypeLable.AutoSize = true;
            boligTypeLable.Location = new Point(2, 36);
            boligTypeLable.Margin = new Padding(2, 0, 2, 0);
            boligTypeLable.Name = "boligTypeLable";
            boligTypeLable.Size = new Size(105, 15);
            boligTypeLable.TabIndex = 2;
            boligTypeLable.Text = "Bolig type";
            // 
            // områdeLable
            // 
            områdeLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            områdeLable.AutoSize = true;
            områdeLable.Location = new Point(2, 123);
            områdeLable.Margin = new Padding(2, 0, 2, 0);
            områdeLable.Name = "områdeLable";
            områdeLable.Size = new Size(105, 15);
            områdeLable.TabIndex = 3;
            områdeLable.Text = "Område";
            // 
            // boligPrisLable
            // 
            boligPrisLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligPrisLable.AutoSize = true;
            boligPrisLable.Location = new Point(2, 154);
            boligPrisLable.Margin = new Padding(2, 0, 2, 0);
            boligPrisLable.Name = "boligPrisLable";
            boligPrisLable.Size = new Size(105, 15);
            boligPrisLable.TabIndex = 4;
            boligPrisLable.Text = "Pris på bolig";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 216);
            label1.Name = "label1";
            label1.Size = new Size(255, 15);
            label1.TabIndex = 13;
            label1.Text = "Ønsker du at afgive et bud på den valgte bolig?";
            // 
            // budBoligKnap
            // 
            budBoligKnap.Enabled = false;
            budBoligKnap.Location = new Point(178, 234);
            budBoligKnap.Name = "budBoligKnap";
            budBoligKnap.Size = new Size(73, 30);
            budBoligKnap.TabIndex = 12;
            budBoligKnap.Text = "Afgiv bud";
            budBoligKnap.UseVisualStyleBackColor = true;
            // 
            // budBoligTextBox
            // 
            budBoligTextBox.Location = new Point(30, 239);
            budBoligTextBox.Name = "budBoligTextBox";
            budBoligTextBox.Size = new Size(131, 23);
            budBoligTextBox.TabIndex = 11;
            // 
            // afstandLable
            // 
            afstandLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            afstandLable.AutoSize = true;
            afstandLable.Location = new Point(2, 94);
            afstandLable.Margin = new Padding(2, 0, 2, 0);
            afstandLable.Name = "afstandLable";
            afstandLable.Size = new Size(105, 15);
            afstandLable.TabIndex = 14;
            afstandLable.Text = "Afstand til indkøb";
            // 
            // boligTableLayoutPanel
            // 
            boligTableLayoutPanel.ColumnCount = 3;
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.84884F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.15116F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            boligTableLayoutPanel.Controls.Add(prisTextBox, 1, 5);
            boligTableLayoutPanel.Controls.Add(områdeTextBox, 1, 4);
            boligTableLayoutPanel.Controls.Add(afstandIndkøbTextBox, 1, 3);
            boligTableLayoutPanel.Controls.Add(arealTextBox, 1, 2);
            boligTableLayoutPanel.Controls.Add(boligTypeTextBox, 1, 1);
            boligTableLayoutPanel.Controls.Add(afstandLable, 0, 3);
            boligTableLayoutPanel.Controls.Add(boligArealLable, 0, 2);
            boligTableLayoutPanel.Controls.Add(boligTypeLable, 0, 1);
            boligTableLayoutPanel.Controls.Add(områdeLable, 0, 4);
            boligTableLayoutPanel.Controls.Add(adresseTextBox, 1, 0);
            boligTableLayoutPanel.Controls.Add(krLabel, 2, 5);
            boligTableLayoutPanel.Controls.Add(boligPrisLable, 0, 5);
            boligTableLayoutPanel.Controls.Add(kmLabel, 2, 3);
            boligTableLayoutPanel.Controls.Add(m2Label, 2, 2);
            boligTableLayoutPanel.Controls.Add(adresseLable, 0, 0);
            boligTableLayoutPanel.Location = new Point(28, 24);
            boligTableLayoutPanel.Name = "boligTableLayoutPanel";
            boligTableLayoutPanel.RowCount = 6;
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            boligTableLayoutPanel.Size = new Size(377, 178);
            boligTableLayoutPanel.TabIndex = 15;
            // 
            // prisTextBox
            // 
            prisTextBox.Location = new Point(112, 148);
            prisTextBox.Name = "prisTextBox";
            prisTextBox.Size = new Size(217, 23);
            prisTextBox.TabIndex = 21;
            prisTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // områdeTextBox
            // 
            områdeTextBox.Location = new Point(112, 119);
            områdeTextBox.Name = "områdeTextBox";
            områdeTextBox.Size = new Size(217, 23);
            områdeTextBox.TabIndex = 20;
            // 
            // afstandIndkøbTextBox
            // 
            afstandIndkøbTextBox.Location = new Point(112, 90);
            afstandIndkøbTextBox.Name = "afstandIndkøbTextBox";
            afstandIndkøbTextBox.Size = new Size(217, 23);
            afstandIndkøbTextBox.TabIndex = 19;
            afstandIndkøbTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // arealTextBox
            // 
            arealTextBox.Location = new Point(112, 61);
            arealTextBox.Name = "arealTextBox";
            arealTextBox.Size = new Size(217, 23);
            arealTextBox.TabIndex = 18;
            arealTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // boligTypeTextBox
            // 
            boligTypeTextBox.Location = new Point(112, 32);
            boligTypeTextBox.Name = "boligTypeTextBox";
            boligTypeTextBox.Size = new Size(217, 23);
            boligTypeTextBox.TabIndex = 17;
            // 
            // adresseTextBox
            // 
            adresseTextBox.Location = new Point(112, 3);
            adresseTextBox.Name = "adresseTextBox";
            adresseTextBox.Size = new Size(217, 23);
            adresseTextBox.TabIndex = 16;
            adresseTextBox.TextChanged += adresseTextBox_TextChanged;
            // 
            // krLabel
            // 
            krLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            krLabel.AutoSize = true;
            krLabel.Location = new Point(335, 154);
            krLabel.Name = "krLabel";
            krLabel.Size = new Size(39, 15);
            krLabel.TabIndex = 22;
            krLabel.Text = "kr";
            krLabel.Click += krLabel_Click;
            // 
            // kmLabel
            // 
            kmLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kmLabel.AutoSize = true;
            kmLabel.Location = new Point(335, 94);
            kmLabel.Name = "kmLabel";
            kmLabel.Size = new Size(39, 15);
            kmLabel.TabIndex = 23;
            kmLabel.Text = "km";
            // 
            // m2Label
            // 
            m2Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            m2Label.AutoSize = true;
            m2Label.Location = new Point(335, 65);
            m2Label.Name = "m2Label";
            m2Label.Size = new Size(39, 15);
            m2Label.TabIndex = 24;
            m2Label.Text = "m2";
            // 
            // adresseLable
            // 
            adresseLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            adresseLable.AutoSize = true;
            adresseLable.Location = new Point(2, 7);
            adresseLable.Margin = new Padding(2, 0, 2, 0);
            adresseLable.Name = "adresseLable";
            adresseLable.Size = new Size(105, 15);
            adresseLable.TabIndex = 16;
            adresseLable.Text = "Adresse";
            // 
            // BoligVisningKunde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 267);
            Controls.Add(boligTableLayoutPanel);
            Controls.Add(label1);
            Controls.Add(budBoligKnap);
            Controls.Add(budBoligTextBox);
            Controls.Add(tilbageBoligKnap);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            MinimizeBox = false;
            Name = "BoligVisningKunde";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Infomation om den valgte bolig";
            Load += BoligVisningKunde_Load_1;
            boligTableLayoutPanel.ResumeLayout(false);
            boligTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tilbageBoligKnap;
        private Label boligArealLable;
        private Label boligTypeLable;
        private Label områdeLable;
        private Label boligPrisLable;
        private Label label1;
        private Button budBoligKnap;
        public TextBox budBoligTextBox;
        private Label afstandLable;
        private TableLayoutPanel boligTableLayoutPanel;
        public TextBox adresseTextBox;
        private Label adresseLable;
        private TextBox boligTypeTextBox;
        private TextBox prisTextBox;
        private TextBox områdeTextBox;
        private TextBox afstandIndkøbTextBox;
        private TextBox arealTextBox;
        private Label krLabel;
        private Label kmLabel;
        private Label m2Label;
    }
}