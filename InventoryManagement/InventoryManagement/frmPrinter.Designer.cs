﻿namespace InventoryManagement
{
    partial class frmPrinter
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
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.btnPrintBarcode = new System.Windows.Forms.Button();
            this.lblDatePrinted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(12, 12);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(300, 100);
            this.pbBarcode.TabIndex = 0;
            this.pbBarcode.TabStop = false;
            // 
            // btnPrintBarcode
            // 
            this.btnPrintBarcode.Location = new System.Drawing.Point(112, 181);
            this.btnPrintBarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintBarcode.Name = "btnPrintBarcode";
            this.btnPrintBarcode.Size = new System.Drawing.Size(100, 30);
            this.btnPrintBarcode.TabIndex = 4;
            this.btnPrintBarcode.Text = "Print";
            this.btnPrintBarcode.UseVisualStyleBackColor = true;
            this.btnPrintBarcode.Click += new System.EventHandler(this.btnPrintBarcode_Click);
            // 
            // lblDatePrinted
            // 
            this.lblDatePrinted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePrinted.Location = new System.Drawing.Point(12, 115);
            this.lblDatePrinted.Name = "lblDatePrinted";
            this.lblDatePrinted.Size = new System.Drawing.Size(300, 29);
            this.lblDatePrinted.TabIndex = 5;
            this.lblDatePrinted.Text = "...";
            this.lblDatePrinted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 223);
            this.Controls.Add(this.lblDatePrinted);
            this.Controls.Add(this.btnPrintBarcode);
            this.Controls.Add(this.pbBarcode);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Sticker Printer";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Button btnPrintBarcode;
        private System.Windows.Forms.Label lblDatePrinted;
    }
}