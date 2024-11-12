
namespace Lab_Assignment_3___Coffee_Shop
{
    partial class frmCustomerReceipt
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
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.gboTax = new System.Windows.Forms.GroupBox();
            this.lblDisplayTax = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.gboTip = new System.Windows.Forms.GroupBox();
            this.lblDisplayTip = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.lblDisplayOrder = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.gboPersonalInformation = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDisplayAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDisplayPhoneNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.gpbDateAndTime = new System.Windows.Forms.GroupBox();
            this.lblDisplayDateAndTime = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.gpbTotal = new System.Windows.Forms.GroupBox();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbItems = new System.Windows.Forms.GroupBox();
            this.lblDisplayItems = new System.Windows.Forms.Label();
            this.gboSubTotal = new System.Windows.Forms.GroupBox();
            this.lblDisplaySubTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.gboTax.SuspendLayout();
            this.gboTip.SuspendLayout();
            this.gboOrder.SuspendLayout();
            this.gboPersonalInformation.SuspendLayout();
            this.gpbDateAndTime.SuspendLayout();
            this.gpbTotal.SuspendLayout();
            this.gpbItems.SuspendLayout();
            this.gboSubTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(347, 358);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(80, 40);
            this.btnNewOrder.TabIndex = 45;
            this.btnNewOrder.Text = "Start a new order!";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // gboTax
            // 
            this.gboTax.Controls.Add(this.lblDisplayTax);
            this.gboTax.Controls.Add(this.lblTax);
            this.gboTax.Location = new System.Drawing.Point(13, 241);
            this.gboTax.Name = "gboTax";
            this.gboTax.Size = new System.Drawing.Size(200, 50);
            this.gboTax.TabIndex = 50;
            this.gboTax.TabStop = false;
            this.gboTax.Text = "Tax";
            // 
            // lblDisplayTax
            // 
            this.lblDisplayTax.AutoSize = true;
            this.lblDisplayTax.Location = new System.Drawing.Point(114, 21);
            this.lblDisplayTax.Name = "lblDisplayTax";
            this.lblDisplayTax.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayTax.TabIndex = 10;
            this.lblDisplayTax.Text = "Place Holder";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(7, 21);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(56, 13);
            this.lblTax.TabIndex = 31;
            this.lblTax.Text = "The tax is:";
            // 
            // gboTip
            // 
            this.gboTip.Controls.Add(this.lblDisplayTip);
            this.gboTip.Controls.Add(this.lblTip);
            this.gboTip.Location = new System.Drawing.Point(12, 185);
            this.gboTip.Name = "gboTip";
            this.gboTip.Size = new System.Drawing.Size(200, 50);
            this.gboTip.TabIndex = 49;
            this.gboTip.TabStop = false;
            this.gboTip.Text = "Tip";
            // 
            // lblDisplayTip
            // 
            this.lblDisplayTip.AutoSize = true;
            this.lblDisplayTip.Location = new System.Drawing.Point(114, 21);
            this.lblDisplayTip.Name = "lblDisplayTip";
            this.lblDisplayTip.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayTip.TabIndex = 10;
            this.lblDisplayTip.Text = "Place Holder";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(7, 21);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(70, 13);
            this.lblTip.TabIndex = 31;
            this.lblTip.Text = "You have tip:";
            // 
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.lblDisplayOrder);
            this.gboOrder.Controls.Add(this.lblOrder);
            this.gboOrder.Location = new System.Drawing.Point(13, 129);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Size = new System.Drawing.Size(200, 50);
            this.gboOrder.TabIndex = 48;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // lblDisplayOrder
            // 
            this.lblDisplayOrder.AutoSize = true;
            this.lblDisplayOrder.Location = new System.Drawing.Point(113, 27);
            this.lblDisplayOrder.Name = "lblDisplayOrder";
            this.lblDisplayOrder.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayOrder.TabIndex = 9;
            this.lblDisplayOrder.Text = "Place Holder";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(6, 27);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(83, 13);
            this.lblOrder.TabIndex = 9;
            this.lblOrder.Text = "You have order:";
            // 
            // gboPersonalInformation
            // 
            this.gboPersonalInformation.Controls.Add(this.lblPhoneNumber);
            this.gboPersonalInformation.Controls.Add(this.lblDisplayAddress);
            this.gboPersonalInformation.Controls.Add(this.lblAddress);
            this.gboPersonalInformation.Controls.Add(this.lblDisplayPhoneNumber);
            this.gboPersonalInformation.Controls.Add(this.lblName);
            this.gboPersonalInformation.Controls.Add(this.lblDisplayName);
            this.gboPersonalInformation.Location = new System.Drawing.Point(12, 22);
            this.gboPersonalInformation.Name = "gboPersonalInformation";
            this.gboPersonalInformation.Size = new System.Drawing.Size(200, 100);
            this.gboPersonalInformation.TabIndex = 47;
            this.gboPersonalInformation.TabStop = false;
            this.gboPersonalInformation.Text = "Personal Information";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 42);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblDisplayAddress
            // 
            this.lblDisplayAddress.AutoSize = true;
            this.lblDisplayAddress.Location = new System.Drawing.Point(114, 67);
            this.lblDisplayAddress.Name = "lblDisplayAddress";
            this.lblDisplayAddress.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayAddress.TabIndex = 8;
            this.lblDisplayAddress.Text = "Place Holder";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblDisplayPhoneNumber
            // 
            this.lblDisplayPhoneNumber.AutoSize = true;
            this.lblDisplayPhoneNumber.Location = new System.Drawing.Point(114, 42);
            this.lblDisplayPhoneNumber.Name = "lblDisplayPhoneNumber";
            this.lblDisplayPhoneNumber.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayPhoneNumber.TabIndex = 7;
            this.lblDisplayPhoneNumber.Text = "Place Holder";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(114, 20);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayName.TabIndex = 6;
            this.lblDisplayName.Text = "Place Holder";
            // 
            // gpbDateAndTime
            // 
            this.gpbDateAndTime.Controls.Add(this.lblDisplayDateAndTime);
            this.gpbDateAndTime.Controls.Add(this.lblDateAndTime);
            this.gpbDateAndTime.Location = new System.Drawing.Point(266, 297);
            this.gpbDateAndTime.Name = "gpbDateAndTime";
            this.gpbDateAndTime.Size = new System.Drawing.Size(200, 50);
            this.gpbDateAndTime.TabIndex = 52;
            this.gpbDateAndTime.TabStop = false;
            this.gpbDateAndTime.Text = "Date and Time";
            // 
            // lblDisplayDateAndTime
            // 
            this.lblDisplayDateAndTime.AutoSize = true;
            this.lblDisplayDateAndTime.Location = new System.Drawing.Point(69, 21);
            this.lblDisplayDateAndTime.Name = "lblDisplayDateAndTime";
            this.lblDisplayDateAndTime.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayDateAndTime.TabIndex = 10;
            this.lblDisplayDateAndTime.Text = "Place Holder";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(7, 21);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(56, 13);
            this.lblDateAndTime.TabIndex = 31;
            this.lblDateAndTime.Text = "Received:";
            // 
            // gpbTotal
            // 
            this.gpbTotal.Controls.Add(this.lblDisplayTotal);
            this.gpbTotal.Controls.Add(this.lblTotal);
            this.gpbTotal.Location = new System.Drawing.Point(266, 241);
            this.gpbTotal.Name = "gpbTotal";
            this.gpbTotal.Size = new System.Drawing.Size(200, 50);
            this.gpbTotal.TabIndex = 51;
            this.gpbTotal.TabStop = false;
            this.gpbTotal.Text = "Total";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(114, 21);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(68, 13);
            this.lblDisplayTotal.TabIndex = 10;
            this.lblDisplayTotal.Text = "Place Holder";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 13);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Your total is:";
            // 
            // gpbItems
            // 
            this.gpbItems.Controls.Add(this.lblDisplayItems);
            this.gpbItems.Location = new System.Drawing.Point(219, 22);
            this.gpbItems.Name = "gpbItems";
            this.gpbItems.Size = new System.Drawing.Size(261, 213);
            this.gpbItems.TabIndex = 53;
            this.gpbItems.TabStop = false;
            this.gpbItems.Text = "Items";
            // 
            // lblDisplayItems
            // 
            this.lblDisplayItems.AutoEllipsis = true;
            this.lblDisplayItems.Location = new System.Drawing.Point(6, 16);
            this.lblDisplayItems.Name = "lblDisplayItems";
            this.lblDisplayItems.Size = new System.Drawing.Size(249, 181);
            this.lblDisplayItems.TabIndex = 10;
            this.lblDisplayItems.Text = "Place Holder";
            // 
            // gboSubTotal
            // 
            this.gboSubTotal.Controls.Add(this.lblDisplaySubTotal);
            this.gboSubTotal.Controls.Add(this.lblSubTotal);
            this.gboSubTotal.Location = new System.Drawing.Point(12, 297);
            this.gboSubTotal.Name = "gboSubTotal";
            this.gboSubTotal.Size = new System.Drawing.Size(200, 50);
            this.gboSubTotal.TabIndex = 52;
            this.gboSubTotal.TabStop = false;
            this.gboSubTotal.Text = "Sub Total";
            // 
            // lblDisplaySubTotal
            // 
            this.lblDisplaySubTotal.AutoSize = true;
            this.lblDisplaySubTotal.Location = new System.Drawing.Point(114, 21);
            this.lblDisplaySubTotal.Name = "lblDisplaySubTotal";
            this.lblDisplaySubTotal.Size = new System.Drawing.Size(68, 13);
            this.lblDisplaySubTotal.TabIndex = 10;
            this.lblDisplaySubTotal.Text = "Place Holder";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(7, 21);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(82, 13);
            this.lblSubTotal.TabIndex = 31;
            this.lblSubTotal.Text = "Your subtotal is:";
            // 
            // frmCustomerReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboSubTotal);
            this.Controls.Add(this.gpbItems);
            this.Controls.Add(this.gpbDateAndTime);
            this.Controls.Add(this.gpbTotal);
            this.Controls.Add(this.gboTax);
            this.Controls.Add(this.gboTip);
            this.Controls.Add(this.gboOrder);
            this.Controls.Add(this.gboPersonalInformation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewOrder);
            this.Name = "frmCustomerReceipt";
            this.Text = "frmCustomerReceipt";
            this.gboTax.ResumeLayout(false);
            this.gboTax.PerformLayout();
            this.gboTip.ResumeLayout(false);
            this.gboTip.PerformLayout();
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
            this.gboPersonalInformation.ResumeLayout(false);
            this.gboPersonalInformation.PerformLayout();
            this.gpbDateAndTime.ResumeLayout(false);
            this.gpbDateAndTime.PerformLayout();
            this.gpbTotal.ResumeLayout(false);
            this.gpbTotal.PerformLayout();
            this.gpbItems.ResumeLayout(false);
            this.gboSubTotal.ResumeLayout(false);
            this.gboSubTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.GroupBox gboTax;
        private System.Windows.Forms.Label lblDisplayTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.GroupBox gboTip;
        private System.Windows.Forms.Label lblDisplayTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.Label lblDisplayOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.GroupBox gboPersonalInformation;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDisplayAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDisplayPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.GroupBox gpbDateAndTime;
        private System.Windows.Forms.Label lblDisplayDateAndTime;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.GroupBox gpbTotal;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gpbItems;
        private System.Windows.Forms.Label lblDisplayItems;
        private System.Windows.Forms.GroupBox gboSubTotal;
        private System.Windows.Forms.Label lblDisplaySubTotal;
        private System.Windows.Forms.Label lblSubTotal;
    }
}