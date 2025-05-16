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
            boligKundeGridView = new DataGridView();
            afslutKnap = new Button();
            seBoligKnap = new Button();
            boligTilSalgLable = new Label();
            begrænsVisningLable = new Label();
            områdeComboBox = new ComboBox();
            områdeLable = new Label();
            seBoligLable = new Label();
            budBoligTextBox = new TextBox();
            budBoligKnap = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)boligKundeGridView).BeginInit();
            SuspendLayout();
            // 
            // boligKundeGridView
            // 
            boligKundeGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boligKundeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boligKundeGridView.Location = new Point(44, 54);
            boligKundeGridView.Name = "boligKundeGridView";
            boligKundeGridView.Size = new Size(691, 167);
            boligKundeGridView.TabIndex = 0;
            boligKundeGridView.CellContentClick += boligKundeGridView_CellContentClick;
            // 
            // afslutKnap
            // 
            afslutKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutKnap.Location = new Point(629, 385);
            afslutKnap.Name = "afslutKnap";
            afslutKnap.Size = new Size(73, 30);
            afslutKnap.TabIndex = 1;
            afslutKnap.Text = "Afslut";
            afslutKnap.UseVisualStyleBackColor = true;
            // 
            // seBoligKnap
            // 
            seBoligKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            seBoligKnap.Enabled = false;
            seBoligKnap.Location = new Point(629, 270);
            seBoligKnap.Name = "seBoligKnap";
            seBoligKnap.Size = new Size(73, 30);
            seBoligKnap.TabIndex = 2;
            seBoligKnap.Text = "Se bolig";
            seBoligKnap.UseVisualStyleBackColor = true;
            // 
            // boligTilSalgLable
            // 
            boligTilSalgLable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            boligTilSalgLable.AutoSize = true;
            boligTilSalgLable.Location = new Point(340, 36);
            boligTilSalgLable.Name = "boligTilSalgLable";
            boligTilSalgLable.Size = new Size(81, 15);
            boligTilSalgLable.TabIndex = 3;
            boligTilSalgLable.Text = "Boliger til salg";
            // 
            // begrænsVisningLable
            // 
            begrænsVisningLable.AutoSize = true;
            begrænsVisningLable.Location = new Point(76, 257);
            begrænsVisningLable.Name = "begrænsVisningLable";
            begrænsVisningLable.Size = new Size(157, 15);
            begrænsVisningLable.TabIndex = 4;
            begrænsVisningLable.Text = "Begræns viste boliger ud fra:";
            // 
            // områdeComboBox
            // 
            områdeComboBox.FormattingEnabled = true;
            områdeComboBox.Location = new Point(128, 275);
            områdeComboBox.Name = "områdeComboBox";
            områdeComboBox.Size = new Size(131, 23);
            områdeComboBox.TabIndex = 5;
            // 
            // områdeLable
            // 
            områdeLable.AutoSize = true;
            områdeLable.Location = new Point(76, 278);
            områdeLable.Name = "områdeLable";
            områdeLable.Size = new Size(50, 15);
            områdeLable.TabIndex = 6;
            områdeLable.Text = "Område";
            // 
            // seBoligLable
            // 
            seBoligLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            seBoligLable.AutoSize = true;
            seBoligLable.Location = new Point(449, 278);
            seBoligLable.Name = "seBoligLable";
            seBoligLable.Size = new Size(177, 15);
            seBoligLable.TabIndex = 7;
            seBoligLable.Text = "Se den valgte boligs oplysninger";
            // 
            // budBoligTextBox
            // 
            budBoligTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            budBoligTextBox.Location = new Point(76, 390);
            budBoligTextBox.Name = "budBoligTextBox";
            budBoligTextBox.Size = new Size(131, 23);
            budBoligTextBox.TabIndex = 8;
            // 
            // budBoligKnap
            // 
            budBoligKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            budBoligKnap.Enabled = false;
            budBoligKnap.Location = new Point(224, 385);
            budBoligKnap.Name = "budBoligKnap";
            budBoligKnap.Size = new Size(73, 30);
            budBoligKnap.TabIndex = 9;
            budBoligKnap.Text = "Afgiv bud";
            budBoligKnap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(76, 367);
            label1.Name = "label1";
            label1.Size = new Size(255, 15);
            label1.TabIndex = 10;
            label1.Text = "Ønsker du at afgive et bud på den valgte bolig?";
            // 
            // BoligOversigtKunde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(budBoligKnap);
            Controls.Add(budBoligTextBox);
            Controls.Add(seBoligLable);
            Controls.Add(områdeLable);
            Controls.Add(områdeComboBox);
            Controls.Add(begrænsVisningLable);
            Controls.Add(boligTilSalgLable);
            Controls.Add(seBoligKnap);
            Controls.Add(afslutKnap);
            Controls.Add(boligKundeGridView);
            Name = "BoligOversigtKunde";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Boliger til salg";
            ((System.ComponentModel.ISupportInitialize)boligKundeGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView boligKundeGridView;
        private Button afslutKnap;
        private Button seBoligKnap;
        private Label boligTilSalgLable;
        private Label begrænsVisningLable;
        private ComboBox områdeComboBox;
        private Label områdeLable;
        private Label seBoligLable;
        private TextBox budBoligTextBox;
        private Button budBoligKnap;
        private Label label1;
    }
}