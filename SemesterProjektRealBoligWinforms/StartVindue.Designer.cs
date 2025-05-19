namespace SemesterProjektRealBoligWinforms
{
    partial class StartVindue
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            seBoligForsideKnap = new Button();
            loginKnap = new Button();
            seBoligForsideLable = new Label();
            loginLable = new Label();
            SuspendLayout();
            // 
            // seBoligForsideKnap
            // 
            seBoligForsideKnap.Location = new Point(141, 61);
            seBoligForsideKnap.Margin = new Padding(2, 1, 2, 1);
            seBoligForsideKnap.Name = "seBoligForsideKnap";
            seBoligForsideKnap.Size = new Size(110, 44);
            seBoligForsideKnap.TabIndex = 0;
            seBoligForsideKnap.Text = "Tryk her";
            seBoligForsideKnap.UseVisualStyleBackColor = true;
            seBoligForsideKnap.Click += seBoligForsideKnap_Click;
            // 
            // loginKnap
            // 
            loginKnap.Location = new Point(130, 161);
            loginKnap.Margin = new Padding(2, 1, 2, 1);
            loginKnap.Name = "loginKnap";
            loginKnap.Size = new Size(138, 30);
            loginKnap.TabIndex = 1;
            loginKnap.Text = "Login";
            loginKnap.UseVisualStyleBackColor = true;
            loginKnap.Click += loginKnap_Click;
            // 
            // seBoligForsideLable
            // 
            seBoligForsideLable.AutoSize = true;
            seBoligForsideLable.Location = new Point(141, 45);
            seBoligForsideLable.Margin = new Padding(2, 0, 2, 0);
            seBoligForsideLable.Name = "seBoligForsideLable";
            seBoligForsideLable.Size = new Size(99, 15);
            seBoligForsideLable.TabIndex = 2;
            seBoligForsideLable.Text = " Se boliger til salg";
            // 
            // loginLable
            // 
            loginLable.AutoSize = true;
            loginLable.Location = new Point(89, 145);
            loginLable.Margin = new Padding(2, 0, 2, 0);
            loginLable.Name = "loginLable";
            loginLable.Size = new Size(201, 15);
            loginLable.TabIndex = 3;
            loginLable.Text = "For medarbejdere eller Administrator";
            // 
            // StartVindue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 227);
            Controls.Add(loginLable);
            Controls.Add(seBoligForsideLable);
            Controls.Add(loginKnap);
            Controls.Add(seBoligForsideKnap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "StartVindue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Velkommen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seBoligForsideKnap;
        private Button loginKnap;
       // private ToolTip toolTip1;
        private Label seBoligForsideLable;
        private Label loginLable;
    }
}
