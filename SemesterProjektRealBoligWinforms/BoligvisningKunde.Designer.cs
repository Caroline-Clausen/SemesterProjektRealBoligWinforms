namespace SemesterProjektRealBoligWinforms
{
    partial class BoligVisningKunde
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
            visBoligerKnap = new Button();
            boligArealLable = new Label();
            boligTypeLable = new Label();
            boligOmrådeLable = new Label();
            maxBoligPrisLable = new Label();
            SuspendLayout();
            // 
            // visBoligerKnap
            // 
            visBoligerKnap.Location = new Point(604, 374);
            visBoligerKnap.Name = "visBoligerKnap";
            visBoligerKnap.Size = new Size(166, 56);
            visBoligerKnap.TabIndex = 0;
            visBoligerKnap.Text = "Vis boliger";
            visBoligerKnap.UseVisualStyleBackColor = true;
            // 
            // boligArealLable
            // 
            boligArealLable.AutoSize = true;
            boligArealLable.Location = new Point(39, 79);
            boligArealLable.Name = "boligArealLable";
            boligArealLable.Size = new Size(167, 32);
            boligArealLable.TabIndex = 1;
            boligArealLable.Text = "Bolig areal m2";
            // 
            // boligTypeLable
            // 
            boligTypeLable.AutoSize = true;
            boligTypeLable.Location = new Point(39, 127);
            boligTypeLable.Name = "boligTypeLable";
            boligTypeLable.Size = new Size(122, 32);
            boligTypeLable.TabIndex = 2;
            boligTypeLable.Text = "Bolig type";
            // 
            // boligOmrådeLable
            // 
            boligOmrådeLable.AutoSize = true;
            boligOmrådeLable.Location = new Point(39, 177);
            boligOmrådeLable.Name = "boligOmrådeLable";
            boligOmrådeLable.Size = new Size(150, 32);
            boligOmrådeLable.TabIndex = 3;
            boligOmrådeLable.Text = "Boligområde";
            // 
            // maxBoligPrisLable
            // 
            maxBoligPrisLable.AutoSize = true;
            maxBoligPrisLable.Location = new Point(39, 222);
            maxBoligPrisLable.Name = "maxBoligPrisLable";
            maxBoligPrisLable.Size = new Size(198, 32);
            maxBoligPrisLable.TabIndex = 4;
            maxBoligPrisLable.Text = "Max pris på bolig";
            // 
            // BoligVisningKunde
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maxBoligPrisLable);
            Controls.Add(boligOmrådeLable);
            Controls.Add(boligTypeLable);
            Controls.Add(boligArealLable);
            Controls.Add(visBoligerKnap);
            Name = "BoligVisningKunde";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button visBoligerKnap;
        private Label boligArealLable;
        private Label boligTypeLable;
        private Label boligOmrådeLable;
        private Label maxBoligPrisLable;
    }
}