namespace SemesterProjektRealBoligWinforms
{
    partial class RealtorForm
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
            components = new System.ComponentModel.Container();
            HomesGridView = new DataGridView();
            boligBindingSource = new BindingSource(components);
            ejendomsmaeglerBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UpdateDataTableButton = new Button();
            RegisterHomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HomesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // HomesGridView
            // 
            HomesGridView.AllowUserToAddRows = false;
            HomesGridView.AllowUserToDeleteRows = false;
            HomesGridView.AllowUserToResizeColumns = false;
            HomesGridView.AllowUserToResizeRows = false;
            HomesGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            HomesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HomesGridView.Dock = DockStyle.Fill;
            HomesGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            HomesGridView.Location = new Point(3, 81);
            HomesGridView.Name = "HomesGridView";
            HomesGridView.ReadOnly = true;
            HomesGridView.RowHeadersWidth = 62;
            HomesGridView.Size = new Size(1294, 359);
            HomesGridView.TabIndex = 0;
            // 
            // boligBindingSource
            // 
            boligBindingSource.DataSource = typeof(Projekt1Semester.Bolig);
            // 
            // ejendomsmaeglerBindingSource
            // 
            ejendomsmaeglerBindingSource.DataSource = typeof(Projekt1Semester.Ejendomsmaegler);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(HomesGridView, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(1300, 522);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1294, 78);
            label1.TabIndex = 1;
            label1.Text = "Boliger";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(UpdateDataTableButton);
            flowLayoutPanel1.Controls.Add(RegisterHomeButton);
            flowLayoutPanel1.Location = new Point(474, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(351, 48);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // UpdateDataTableButton
            // 
            UpdateDataTableButton.AutoSize = true;
            UpdateDataTableButton.Font = new Font("Segoe UI", 11F);
            UpdateDataTableButton.Location = new Point(3, 3);
            UpdateDataTableButton.Name = "UpdateDataTableButton";
            UpdateDataTableButton.Size = new Size(161, 42);
            UpdateDataTableButton.TabIndex = 2;
            UpdateDataTableButton.Text = "Opdater Tabel";
            UpdateDataTableButton.UseVisualStyleBackColor = true;
            UpdateDataTableButton.Click += RefreshDataTable;
            // 
            // RegisterHomeButton
            // 
            RegisterHomeButton.AutoSize = true;
            RegisterHomeButton.Font = new Font("Segoe UI", 11F);
            RegisterHomeButton.Location = new Point(170, 3);
            RegisterHomeButton.Name = "RegisterHomeButton";
            RegisterHomeButton.Size = new Size(178, 42);
            RegisterHomeButton.TabIndex = 3;
            RegisterHomeButton.Text = "Registrer Bolig";
            RegisterHomeButton.UseVisualStyleBackColor = true;
            RegisterHomeButton.Click += RegisterHomeButton_Click;
            // 
            // RealtorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "RealtorForm";
            Text = "RealtorForm";
            Load += RealtorForm_Load;
            ((System.ComponentModel.ISupportInitialize)HomesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)boligBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HomesGridView;
        private BindingSource boligBindingSource;
        private BindingSource ejendomsmaeglerBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button UpdateDataTableButton;
        private Button RegisterHomeButton;
    }
}