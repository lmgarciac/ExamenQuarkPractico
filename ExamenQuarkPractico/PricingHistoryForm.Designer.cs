
namespace ExamenQuarkPractico
{
    partial class PricingHistoryForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.histPrice = new System.Windows.Forms.Label();
            this.pricingQty = new System.Windows.Forms.Label();
            this.pricingClothe = new System.Windows.Forms.Label();
            this.pricingSeller = new System.Windows.Forms.Label();
            this.pricingDate = new System.Windows.Forms.Label();
            this.pricingID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(166, 410);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Cotizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio";
            // 
            // histPrice
            // 
            this.histPrice.AutoSize = true;
            this.histPrice.Location = new System.Drawing.Point(358, 31);
            this.histPrice.Name = "histPrice";
            this.histPrice.Size = new System.Drawing.Size(0, 13);
            this.histPrice.TabIndex = 13;
            // 
            // pricingQty
            // 
            this.pricingQty.AutoSize = true;
            this.pricingQty.Location = new System.Drawing.Point(303, 31);
            this.pricingQty.Name = "pricingQty";
            this.pricingQty.Size = new System.Drawing.Size(0, 13);
            this.pricingQty.TabIndex = 12;
            // 
            // pricingClothe
            // 
            this.pricingClothe.AutoSize = true;
            this.pricingClothe.Location = new System.Drawing.Point(241, 31);
            this.pricingClothe.Name = "pricingClothe";
            this.pricingClothe.Size = new System.Drawing.Size(0, 13);
            this.pricingClothe.TabIndex = 11;
            // 
            // pricingSeller
            // 
            this.pricingSeller.AutoSize = true;
            this.pricingSeller.Location = new System.Drawing.Point(163, 31);
            this.pricingSeller.Name = "pricingSeller";
            this.pricingSeller.Size = new System.Drawing.Size(0, 13);
            this.pricingSeller.TabIndex = 10;
            // 
            // pricingDate
            // 
            this.pricingDate.AutoSize = true;
            this.pricingDate.Location = new System.Drawing.Point(46, 31);
            this.pricingDate.Name = "pricingDate";
            this.pricingDate.Size = new System.Drawing.Size(0, 13);
            this.pricingDate.TabIndex = 9;
            // 
            // pricingID
            // 
            this.pricingID.AutoSize = true;
            this.pricingID.Location = new System.Drawing.Point(12, 31);
            this.pricingID.Name = "pricingID";
            this.pricingID.Size = new System.Drawing.Size(0, 13);
            this.pricingID.TabIndex = 8;
            // 
            // PricingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 465);
            this.Controls.Add(this.histPrice);
            this.Controls.Add(this.pricingQty);
            this.Controls.Add(this.pricingClothe);
            this.Controls.Add(this.pricingSeller);
            this.Controls.Add(this.pricingDate);
            this.Controls.Add(this.pricingID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Name = "PricingHistoryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label histPrice;
        private System.Windows.Forms.Label pricingQty;
        private System.Windows.Forms.Label pricingClothe;
        private System.Windows.Forms.Label pricingSeller;
        private System.Windows.Forms.Label pricingDate;
        private System.Windows.Forms.Label pricingID;
    }
}