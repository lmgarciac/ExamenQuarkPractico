
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
            this.pricingsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pricingsLabel
            // 
            this.pricingsLabel.Location = new System.Drawing.Point(12, 9);
            this.pricingsLabel.Name = "pricingsLabel";
            this.pricingsLabel.Size = new System.Drawing.Size(142, 287);
            this.pricingsLabel.TabIndex = 0;
            this.pricingsLabel.Text = "label1";
            this.pricingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(246, 122);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PricingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 347);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pricingsLabel);
            this.Name = "PricingHistoryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pricingsLabel;
        private System.Windows.Forms.Button closeButton;
    }
}