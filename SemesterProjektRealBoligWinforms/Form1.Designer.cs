namespace SemesterProjektRealBoligWinforms
{
    partial class Form1
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
            seBoligForsideKnap.Location = new Point(262, 130);
            seBoligForsideKnap.Name = "seBoligForsideKnap";
            seBoligForsideKnap.Size = new Size(205, 94);
            seBoligForsideKnap.TabIndex = 0;
            seBoligForsideKnap.Text = "Tryk her";
            seBoligForsideKnap.UseVisualStyleBackColor = true;
            seBoligForsideKnap.Click += seBoligForsideKnap_Click;
            // 
            // loginKnap
            // 
            loginKnap.Location = new Point(241, 344);
            loginKnap.Name = "loginKnap";
            loginKnap.Size = new Size(256, 47);
            loginKnap.TabIndex = 1;
            loginKnap.Text = "Login";
            loginKnap.UseVisualStyleBackColor = true;
            // 
            // seBoligForsideLable
            // 
            seBoligForsideLable.AutoSize = true;
            seBoligForsideLable.Location = new Point(262, 95);
            seBoligForsideLable.Name = "seBoligForsideLable";
            seBoligForsideLable.Size = new Size(205, 32);
            seBoligForsideLable.TabIndex = 2;
            seBoligForsideLable.Text = " Se boliger til salg";
            // 
            // loginLable
            // 
            loginLable.AutoSize = true;
            loginLable.Location = new Point(165, 309);
            loginLable.Name = "loginLable";
            loginLable.Size = new Size(408, 32);
            loginLable.TabIndex = 3;
            loginLable.Text = "For medarbejdere eller Administrator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 485);
            Controls.Add(loginLable);
            Controls.Add(seBoligForsideLable);
            Controls.Add(loginKnap);
            Controls.Add(seBoligForsideKnap);
            Name = "Form1";
            Text = "Form1";
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
