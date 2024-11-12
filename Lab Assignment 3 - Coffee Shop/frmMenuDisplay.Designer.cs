
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmMenuDisplay
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbDetail = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostDisplay = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblLongDescription = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.gpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.gpbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(421, 329);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 40);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Start an order!";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbDetail
            // 
            this.gpbDetail.Controls.Add(this.lblCost);
            this.gpbDetail.Controls.Add(this.lblCostDisplay);
            this.gpbDetail.Controls.Add(this.lblLong);
            this.gpbDetail.Controls.Add(this.lblShort);
            this.gpbDetail.Controls.Add(this.lblLongDescription);
            this.gpbDetail.Controls.Add(this.pbxImage);
            this.gpbDetail.Location = new System.Drawing.Point(680, 38);
            this.gpbDetail.Name = "gpbDetail";
            this.gpbDetail.Size = new System.Drawing.Size(281, 360);
            this.gpbDetail.TabIndex = 15;
            this.gpbDetail.TabStop = false;
            this.gpbDetail.Text = "Detail";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(11, 223);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 25;
            this.lblCost.Text = "Cost:";
            // 
            // lblCostDisplay
            // 
            this.lblCostDisplay.AutoSize = true;
            this.lblCostDisplay.Location = new System.Drawing.Point(47, 223);
            this.lblCostDisplay.Name = "lblCostDisplay";
            this.lblCostDisplay.Size = new System.Drawing.Size(95, 13);
            this.lblCostDisplay.TabIndex = 24;
            this.lblCostDisplay.Text = "Place Holder(Cost)";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(6, 245);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(63, 13);
            this.lblLong.TabIndex = 19;
            this.lblLong.Text = "Description:";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(11, 173);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(0, 13);
            this.lblShort.TabIndex = 18;
            // 
            // lblLongDescription
            // 
            this.lblLongDescription.Location = new System.Drawing.Point(75, 245);
            this.lblLongDescription.Name = "lblLongDescription";
            this.lblLongDescription.Size = new System.Drawing.Size(200, 108);
            this.lblLongDescription.TabIndex = 17;
            this.lblLongDescription.Text = "Place Holder (long)";
            this.lblLongDescription.Click += new System.EventHandler(this.lblLongDescription_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(6, 20);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(269, 150);
            this.pbxImage.TabIndex = 16;
            this.pbxImage.TabStop = false;
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.dgvMenu);
            this.gpbMenu.Location = new System.Drawing.Point(208, 38);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(401, 258);
            this.gpbMenu.TabIndex = 15;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(23, 60);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(347, 176);
            this.dgvMenu.TabIndex = 17;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            this.dgvMenu.Click += new System.EventHandler(this.dgvMenu_SelectionChanged);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(21, 336);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(121, 13);
            this.lblReset.TabIndex = 30;
            this.lblReset.Text = "Reset to view all item(s)!";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 360);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 31);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(292, 398);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 31);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblSearchCategory.Location = new System.Drawing.Point(18, 409);
            this.lblSearchCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(160, 16);
            this.lblSearchCategory.TabIndex = 27;
            this.lblSearchCategory.Text = "Search by Category:";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(182, 404);
            this.cboSearchCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(92, 21);
            this.cboSearchCategory.TabIndex = 26;
            // 
            // frmMenuDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 450);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.gpbDetail);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.lblSearchCategory);
            this.Controls.Add(this.cboSearchCategory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMenuDisplay";
            this.Text = "frmMenuDisplay";
            this.Load += new System.EventHandler(this.frmMenuDisplay_Load);
            this.gpbDetail.ResumeLayout(false);
            this.gpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.gpbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbDetail;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblLongDescription;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostDisplay;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.ComboBox cboSearchCategory;
    }
}