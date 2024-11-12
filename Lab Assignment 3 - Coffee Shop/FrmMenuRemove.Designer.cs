
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class FrmMenuRemove
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
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(511, 338);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(108, 44);
            this.btnRemoveItem.TabIndex = 9;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 338);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(169, 51);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 27;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(450, 234);
            this.dgvMenu.TabIndex = 11;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(292, 400);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblSearchCategory.Location = new System.Drawing.Point(18, 411);
            this.lblSearchCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(160, 16);
            this.lblSearchCategory.TabIndex = 13;
            this.lblSearchCategory.Text = "Search by Category:";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(182, 406);
            this.cboSearchCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(92, 21);
            this.cboSearchCategory.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 362);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 31);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(21, 338);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(121, 13);
            this.lblReset.TabIndex = 16;
            this.lblReset.Text = "Reset to view all item(s)!";
            // 
            // FrmMenuRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchCategory);
            this.Controls.Add(this.cboSearchCategory);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmMenuRemove";
            this.Text = "FrmMenuRemove";
            this.Load += new System.EventHandler(this.FrmMenuRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.ComboBox cboSearchCategory;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblReset;
    }
}