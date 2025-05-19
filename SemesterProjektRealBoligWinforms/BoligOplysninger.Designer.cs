namespace SemesterProjektRealBoligWinforms
{
    partial class BoligOplysninger
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
            boligTableLayoutPanel = new TableLayoutPanel();
            OmrådeTextBox = new TextBox();
            AfstandIndkøbTextBox = new TextBox();
            PrisTextBox = new TextBox();
            BoligTypeTextBox = new TextBox();
            ArealText = new TextBox();
            AdresseTextBox = new TextBox();
            adresseLable = new Label();
            boligArealLable = new Label();
            boligTypeLable = new Label();
            m2Label = new Label();
            boligPrisLable = new Label();
            krLabel = new Label();
            områdeLable = new Label();
            afstandLable = new Label();
            kmLabel = new Label();
            label1 = new Label();
            SælgerComboBox = new ComboBox();
            GemButton = new Button();
            FortrydButton = new Button();
            boligTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // boligTableLayoutPanel
            // 
            boligTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligTableLayoutPanel.ColumnCount = 3;
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.84884F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.15116F));
            boligTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            boligTableLayoutPanel.Controls.Add(OmrådeTextBox, 1, 5);
            boligTableLayoutPanel.Controls.Add(AfstandIndkøbTextBox, 1, 4);
            boligTableLayoutPanel.Controls.Add(PrisTextBox, 1, 3);
            boligTableLayoutPanel.Controls.Add(BoligTypeTextBox, 1, 2);
            boligTableLayoutPanel.Controls.Add(ArealText, 1, 1);
            boligTableLayoutPanel.Controls.Add(AdresseTextBox, 1, 0);
            boligTableLayoutPanel.Controls.Add(adresseLable, 0, 0);
            boligTableLayoutPanel.Controls.Add(boligArealLable, 0, 1);
            boligTableLayoutPanel.Controls.Add(boligTypeLable, 0, 2);
            boligTableLayoutPanel.Controls.Add(m2Label, 2, 1);
            boligTableLayoutPanel.Controls.Add(boligPrisLable, 0, 3);
            boligTableLayoutPanel.Controls.Add(krLabel, 2, 3);
            boligTableLayoutPanel.Controls.Add(områdeLable, 0, 5);
            boligTableLayoutPanel.Controls.Add(afstandLable, 0, 4);
            boligTableLayoutPanel.Controls.Add(kmLabel, 2, 4);
            boligTableLayoutPanel.Controls.Add(label1, 0, 6);
            boligTableLayoutPanel.Controls.Add(SælgerComboBox, 1, 6);
            boligTableLayoutPanel.Location = new Point(12, 12);
            boligTableLayoutPanel.Name = "boligTableLayoutPanel";
            boligTableLayoutPanel.RowCount = 7;
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle());
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            boligTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            boligTableLayoutPanel.Size = new Size(481, 204);
            boligTableLayoutPanel.TabIndex = 16;
            // 
            // OmrådeTextBox
            // 
            OmrådeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            OmrådeTextBox.Location = new Point(146, 148);
            OmrådeTextBox.Name = "OmrådeTextBox";
            OmrådeTextBox.Size = new Size(287, 23);
            OmrådeTextBox.TabIndex = 21;
            OmrådeTextBox.TextAlign = HorizontalAlignment.Right;
            OmrådeTextBox.TextChanged += TextBox_TextChanged;
            // 
            // AfstandIndkøbTextBox
            // 
            AfstandIndkøbTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AfstandIndkøbTextBox.Location = new Point(146, 119);
            AfstandIndkøbTextBox.Name = "AfstandIndkøbTextBox";
            AfstandIndkøbTextBox.Size = new Size(287, 23);
            AfstandIndkøbTextBox.TabIndex = 20;
            AfstandIndkøbTextBox.TextAlign = HorizontalAlignment.Right;
            AfstandIndkøbTextBox.TextChanged += TextBox_TextChanged;
            // 
            // PrisTextBox
            // 
            PrisTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PrisTextBox.Location = new Point(146, 90);
            PrisTextBox.Name = "PrisTextBox";
            PrisTextBox.Size = new Size(287, 23);
            PrisTextBox.TabIndex = 19;
            PrisTextBox.TextAlign = HorizontalAlignment.Right;
            PrisTextBox.TextChanged += TextBox_TextChanged;
            // 
            // BoligTypeTextBox
            // 
            BoligTypeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BoligTypeTextBox.Location = new Point(146, 61);
            BoligTypeTextBox.Name = "BoligTypeTextBox";
            BoligTypeTextBox.Size = new Size(287, 23);
            BoligTypeTextBox.TabIndex = 18;
            BoligTypeTextBox.TextAlign = HorizontalAlignment.Right;
            BoligTypeTextBox.TextChanged += TextBox_TextChanged;
            // 
            // ArealText
            // 
            ArealText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ArealText.Location = new Point(146, 32);
            ArealText.Name = "ArealText";
            ArealText.Size = new Size(287, 23);
            ArealText.TabIndex = 17;
            ArealText.TextAlign = HorizontalAlignment.Right;
            ArealText.TextChanged += TextBox_TextChanged;
            // 
            // AdresseTextBox
            // 
            AdresseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AdresseTextBox.Location = new Point(146, 3);
            AdresseTextBox.Name = "AdresseTextBox";
            AdresseTextBox.Size = new Size(287, 23);
            AdresseTextBox.TabIndex = 16;
            AdresseTextBox.TextAlign = HorizontalAlignment.Right;
            AdresseTextBox.TextChanged += TextBox_TextChanged;
            // 
            // adresseLable
            // 
            adresseLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            adresseLable.AutoSize = true;
            adresseLable.Location = new Point(2, 7);
            adresseLable.Margin = new Padding(2, 0, 2, 0);
            adresseLable.Name = "adresseLable";
            adresseLable.Size = new Size(139, 15);
            adresseLable.TabIndex = 16;
            adresseLable.Text = "Adresse";
            // 
            // boligArealLable
            // 
            boligArealLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligArealLable.AutoSize = true;
            boligArealLable.Location = new Point(2, 36);
            boligArealLable.Margin = new Padding(2, 0, 2, 0);
            boligArealLable.Name = "boligArealLable";
            boligArealLable.Size = new Size(139, 15);
            boligArealLable.TabIndex = 1;
            boligArealLable.Text = "Bolig areal m2";
            // 
            // boligTypeLable
            // 
            boligTypeLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligTypeLable.AutoSize = true;
            boligTypeLable.Location = new Point(2, 65);
            boligTypeLable.Margin = new Padding(2, 0, 2, 0);
            boligTypeLable.Name = "boligTypeLable";
            boligTypeLable.Size = new Size(139, 15);
            boligTypeLable.TabIndex = 2;
            boligTypeLable.Text = "Bolig type";
            // 
            // m2Label
            // 
            m2Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            m2Label.AutoSize = true;
            m2Label.Location = new Point(439, 36);
            m2Label.Name = "m2Label";
            m2Label.Size = new Size(39, 15);
            m2Label.TabIndex = 24;
            m2Label.Text = "m2";
            // 
            // boligPrisLable
            // 
            boligPrisLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boligPrisLable.AutoSize = true;
            boligPrisLable.Location = new Point(2, 94);
            boligPrisLable.Margin = new Padding(2, 0, 2, 0);
            boligPrisLable.Name = "boligPrisLable";
            boligPrisLable.Size = new Size(139, 15);
            boligPrisLable.TabIndex = 4;
            boligPrisLable.Text = "Pris på bolig";
            // 
            // krLabel
            // 
            krLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            krLabel.AutoSize = true;
            krLabel.Location = new Point(439, 94);
            krLabel.Name = "krLabel";
            krLabel.Size = new Size(39, 15);
            krLabel.TabIndex = 22;
            krLabel.Text = "kr";
            // 
            // områdeLable
            // 
            områdeLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            områdeLable.AutoSize = true;
            områdeLable.Location = new Point(2, 152);
            områdeLable.Margin = new Padding(2, 0, 2, 0);
            områdeLable.Name = "områdeLable";
            områdeLable.Size = new Size(139, 15);
            områdeLable.TabIndex = 3;
            områdeLable.Text = "Område";
            // 
            // afstandLable
            // 
            afstandLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            afstandLable.AutoSize = true;
            afstandLable.Location = new Point(2, 123);
            afstandLable.Margin = new Padding(2, 0, 2, 0);
            afstandLable.Name = "afstandLable";
            afstandLable.Size = new Size(139, 15);
            afstandLable.TabIndex = 14;
            afstandLable.Text = "Afstand til indkøb";
            // 
            // kmLabel
            // 
            kmLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kmLabel.AutoSize = true;
            kmLabel.Location = new Point(439, 123);
            kmLabel.Name = "kmLabel";
            kmLabel.Size = new Size(39, 15);
            kmLabel.TabIndex = 23;
            kmLabel.Text = "km";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(2, 181);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 27;
            label1.Text = "Sælger";
            // 
            // SælgerComboBox
            // 
            SælgerComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SælgerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SælgerComboBox.FormattingEnabled = true;
            SælgerComboBox.Location = new Point(146, 177);
            SælgerComboBox.Name = "SælgerComboBox";
            SælgerComboBox.Size = new Size(287, 23);
            SælgerComboBox.Sorted = true;
            SælgerComboBox.TabIndex = 30;
            SælgerComboBox.SelectedIndexChanged += SælgerComboBox_SelectedIndexChanged;
            // 
            // GemButton
            // 
            GemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GemButton.DialogResult = DialogResult.OK;
            GemButton.Location = new Point(347, 222);
            GemButton.Name = "GemButton";
            GemButton.Size = new Size(70, 32);
            GemButton.TabIndex = 17;
            GemButton.Text = "Gem";
            GemButton.UseVisualStyleBackColor = true;
            GemButton.Click += GemButton_Click;
            // 
            // FortrydButton
            // 
            FortrydButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FortrydButton.DialogResult = DialogResult.Cancel;
            FortrydButton.Location = new Point(423, 222);
            FortrydButton.Name = "FortrydButton";
            FortrydButton.Size = new Size(70, 32);
            FortrydButton.TabIndex = 18;
            FortrydButton.Text = "Fortryd";
            FortrydButton.UseVisualStyleBackColor = true;
            FortrydButton.Click += FortrydButton_Click;
            // 
            // BoligOplysninger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 266);
            Controls.Add(FortrydButton);
            Controls.Add(GemButton);
            Controls.Add(boligTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BoligOplysninger";
            Text = "Oplysninger om bolig";
            boligTableLayoutPanel.ResumeLayout(false);
            boligTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel boligTableLayoutPanel;
        private TextBox OmrådeTextBox;
        private TextBox AfstandIndkøbTextBox;
        private TextBox PrisTextBox;
        private TextBox BoligTypeTextBox;
        private TextBox ArealText;
        public TextBox AdresseTextBox;
        private Label adresseLable;
        private Label boligArealLable;
        private Label boligTypeLable;
        private Label m2Label;
        private Label boligPrisLable;
        private Label krLabel;
        private Label områdeLable;
        private Label afstandLable;
        private Label kmLabel;
        private Button GemButton;
        private Button FortrydButton;
        private Label label1;
        private ComboBox SælgerComboBox;
    }
}