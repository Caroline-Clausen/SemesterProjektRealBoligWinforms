namespace SemesterProjektRealBoligWinforms
{
    partial class MinMax
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            MinTextBox = new TextBox();
            label2 = new Label();
            MaxTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(MinTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(MaxTextBox, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(806, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(74, 150);
            label1.TabIndex = 0;
            label1.Text = "Min";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MinTextBox
            // 
            MinTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MinTextBox.Location = new Point(83, 59);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(316, 31);
            MinTextBox.TabIndex = 1;
            MinTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(405, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(74, 150);
            label2.TabIndex = 2;
            label2.Text = "Max";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MaxTextBox.Location = new Point(485, 59);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(318, 31);
            MaxTextBox.TabIndex = 3;
            MaxTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MinMax
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MinMax";
            Size = new Size(806, 150);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox MinTextBox;
        private Label label2;
        private TextBox MaxTextBox;
    }
}
