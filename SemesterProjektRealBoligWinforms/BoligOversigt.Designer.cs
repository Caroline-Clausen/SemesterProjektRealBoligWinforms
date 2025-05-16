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
            områdeComboBox = new ComboBox();
            områdeLable = new Label();
            seBoligLable = new Label();
            budBoligTextBox = new TextBox();
            budBoligKnap = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelFilter = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)boligKundeGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // boligKundeGridView
            // 
            boligKundeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boligKundeGridView.Dock = DockStyle.Fill;
            boligKundeGridView.Location = new Point(3, 3);
            boligKundeGridView.Name = "boligKundeGridView";
            boligKundeGridView.Size = new Size(857, 348);
            boligKundeGridView.TabIndex = 0;
            boligKundeGridView.CellContentClick += boligKundeGridView_CellContentClick;
            // 
            // afslutKnap
            // 
            afslutKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutKnap.Location = new Point(781, 21);
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
            seBoligKnap.Location = new Point(576, 21);
            seBoligKnap.Name = "seBoligKnap";
            seBoligKnap.Size = new Size(73, 30);
            seBoligKnap.TabIndex = 2;
            seBoligKnap.Text = "Se bolig";
            seBoligKnap.UseVisualStyleBackColor = true;
            // 
            // områdeComboBox
            // 
            områdeComboBox.Anchor = AnchorStyles.None;
            områdeComboBox.FormattingEnabled = true;
            områdeComboBox.Location = new Point(101, 6);
            områdeComboBox.Name = "områdeComboBox";
            områdeComboBox.Size = new Size(236, 23);
            områdeComboBox.TabIndex = 5;
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
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelFilter, 0, 0);
            tableLayoutPanel1.Controls.Add(områdeLable, 1, 0);
            tableLayoutPanel1.Controls.Add(områdeComboBox, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(857, 35);
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
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 297);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(857, 54);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // BoligOversigtKunde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 354);
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
    }
}