
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEmployeeOrCustomer = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmployeeOrCustomer
            // 
            this.lblEmployeeOrCustomer.AutoSize = true;
            this.lblEmployeeOrCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeOrCustomer.Location = new System.Drawing.Point(62, 104);
            this.lblEmployeeOrCustomer.Name = "lblEmployeeOrCustomer";
            this.lblEmployeeOrCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.lblEmployeeOrCustomer.Size = new System.Drawing.Size(570, 62);
            this.lblEmployeeOrCustomer.TabIndex = 7;
            this.lblEmployeeOrCustomer.Text = "Select Employee or Customer:";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(377, 169);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(80, 40);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(291, 169);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(80, 40);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblEmployeeOrCustomer);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnEmployee);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmployeeOrCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
    }
}