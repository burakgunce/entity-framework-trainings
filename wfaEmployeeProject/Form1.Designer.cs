namespace wfaEmployeeProject
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
            dgvEmployees = new DataGridView();
            btnShowEmployees = new Button();
            btnFirstEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(18, 112);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 29;
            dgvEmployees.Size = new Size(763, 259);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // btnShowEmployees
            // 
            btnShowEmployees.Location = new Point(16, 19);
            btnShowEmployees.Name = "btnShowEmployees";
            btnShowEmployees.Size = new Size(224, 71);
            btnShowEmployees.TabIndex = 1;
            btnShowEmployees.Text = "Çalışanları Göster";
            btnShowEmployees.UseVisualStyleBackColor = true;
            btnShowEmployees.Click += btnShowEmployees_Click;
            // 
            // btnFirstEmployee
            // 
            btnFirstEmployee.Location = new Point(273, 21);
            btnFirstEmployee.Name = "btnFirstEmployee";
            btnFirstEmployee.Size = new Size(110, 63);
            btnFirstEmployee.TabIndex = 2;
            btnFirstEmployee.Text = "ilk çalışan";
            btnFirstEmployee.UseVisualStyleBackColor = true;
            btnFirstEmployee.Click += btnFirstEmployee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFirstEmployee);
            Controls.Add(btnShowEmployees);
            Controls.Add(dgvEmployees);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button btnShowEmployees;
        private Button btnFirstEmployee;
    }
}