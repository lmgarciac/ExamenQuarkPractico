
namespace ExamenQuarkPractico
{
    partial class PricingForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.shopName = new System.Windows.Forms.Label();
            this.shopAddress = new System.Windows.Forms.Label();
            this.sellerName = new System.Windows.Forms.Label();
            this.sellerCode = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.shirt = new System.Windows.Forms.RadioButton();
            this.pants = new System.Windows.Forms.RadioButton();
            this.shortSleeve = new System.Windows.Forms.CheckBox();
            this.maoNeck = new System.Windows.Forms.CheckBox();
            this.skinnyFit = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stockAvailable = new System.Windows.Forms.Label();
            this.standardQuality = new System.Windows.Forms.RadioButton();
            this.premiumQuality = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cotizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.finalPrice = new System.Windows.Forms.Label();
            this.containerClothesQuality = new System.Windows.Forms.GroupBox();
            this.containerClothesType = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.containerClothesQuality.SuspendLayout();
            this.containerClothesType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.Location = new System.Drawing.Point(78, 65);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(117, 20);
            this.shopName.TabIndex = 0;
            this.shopName.Text = "Nombre Tienda";
            // 
            // shopAddress
            // 
            this.shopAddress.AutoSize = true;
            this.shopAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopAddress.Location = new System.Drawing.Point(354, 65);
            this.shopAddress.Name = "shopAddress";
            this.shopAddress.Size = new System.Drawing.Size(127, 20);
            this.shopAddress.TabIndex = 1;
            this.shopAddress.Text = "Direccion Tienda";
            // 
            // sellerName
            // 
            this.sellerName.AutoSize = true;
            this.sellerName.Location = new System.Drawing.Point(40, 120);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(141, 13);
            this.sellerName.TabIndex = 2;
            this.sellerName.Text = "Nombre y Apellido Vendedor";
            // 
            // sellerCode
            // 
            this.sellerCode.AutoSize = true;
            this.sellerCode.Location = new System.Drawing.Point(201, 120);
            this.sellerCode.Name = "sellerCode";
            this.sellerCode.Size = new System.Drawing.Size(89, 13);
            this.sellerCode.TabIndex = 3;
            this.sellerCode.Text = "Codigo Vendedor";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(355, 117);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Historial de Cotizaciones";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // shirt
            // 
            this.shirt.AutoSize = true;
            this.shirt.Checked = true;
            this.shirt.Location = new System.Drawing.Point(24, 28);
            this.shirt.Name = "shirt";
            this.shirt.Size = new System.Drawing.Size(59, 17);
            this.shirt.TabIndex = 5;
            this.shirt.TabStop = true;
            this.shirt.Text = "Camisa";
            this.shirt.UseVisualStyleBackColor = true;
            this.shirt.CheckedChanged += new System.EventHandler(this.shirt_CheckedChanged);
            // 
            // pants
            // 
            this.pants.AutoSize = true;
            this.pants.Location = new System.Drawing.Point(24, 73);
            this.pants.Name = "pants";
            this.pants.Size = new System.Drawing.Size(67, 17);
            this.pants.TabIndex = 6;
            this.pants.Text = "Pantalon";
            this.pants.UseVisualStyleBackColor = true;
            this.pants.CheckedChanged += new System.EventHandler(this.pants_CheckedChanged);
            // 
            // shortSleeve
            // 
            this.shortSleeve.AutoSize = true;
            this.shortSleeve.Location = new System.Drawing.Point(125, 29);
            this.shortSleeve.Name = "shortSleeve";
            this.shortSleeve.Size = new System.Drawing.Size(87, 17);
            this.shortSleeve.TabIndex = 7;
            this.shortSleeve.Text = "Manga Corta";
            this.shortSleeve.UseVisualStyleBackColor = true;
            this.shortSleeve.CheckedChanged += new System.EventHandler(this.shortSleeve_CheckedChanged);
            // 
            // maoNeck
            // 
            this.maoNeck.AutoSize = true;
            this.maoNeck.Location = new System.Drawing.Point(233, 28);
            this.maoNeck.Name = "maoNeck";
            this.maoNeck.Size = new System.Drawing.Size(79, 17);
            this.maoNeck.TabIndex = 8;
            this.maoNeck.Text = "Cuello Mao";
            this.maoNeck.UseVisualStyleBackColor = true;
            this.maoNeck.CheckedChanged += new System.EventHandler(this.maoNeck_CheckedChanged);
            // 
            // skinnyFit
            // 
            this.skinnyFit.AutoSize = true;
            this.skinnyFit.Enabled = false;
            this.skinnyFit.Location = new System.Drawing.Point(125, 74);
            this.skinnyFit.Name = "skinnyFit";
            this.skinnyFit.Size = new System.Drawing.Size(59, 17);
            this.skinnyFit.TabIndex = 9;
            this.skinnyFit.Text = "Chupin";
            this.skinnyFit.UseVisualStyleBackColor = true;
            this.skinnyFit.CheckedChanged += new System.EventHandler(this.skinnyFit_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unidades de Stock Disponibles:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stockAvailable
            // 
            this.stockAvailable.AutoSize = true;
            this.stockAvailable.Location = new System.Drawing.Point(199, 16);
            this.stockAvailable.Name = "stockAvailable";
            this.stockAvailable.Size = new System.Drawing.Size(13, 13);
            this.stockAvailable.TabIndex = 11;
            this.stockAvailable.Text = "0";
            // 
            // standardQuality
            // 
            this.standardQuality.AutoSize = true;
            this.standardQuality.Checked = true;
            this.standardQuality.Location = new System.Drawing.Point(24, 41);
            this.standardQuality.Name = "standardQuality";
            this.standardQuality.Size = new System.Drawing.Size(68, 17);
            this.standardQuality.TabIndex = 12;
            this.standardQuality.TabStop = true;
            this.standardQuality.Text = "Standard";
            this.standardQuality.UseVisualStyleBackColor = true;
            this.standardQuality.CheckedChanged += new System.EventHandler(this.standardQuality_CheckedChanged);
            // 
            // premiumQuality
            // 
            this.premiumQuality.AutoSize = true;
            this.premiumQuality.Location = new System.Drawing.Point(116, 39);
            this.premiumQuality.Name = "premiumQuality";
            this.premiumQuality.Size = new System.Drawing.Size(65, 17);
            this.premiumQuality.TabIndex = 13;
            this.premiumQuality.Text = "Premium";
            this.premiumQuality.UseVisualStyleBackColor = true;
            this.premiumQuality.CheckedChanged += new System.EventHandler(this.premiumQuality_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cantidad";
            // 
            // cotizar
            // 
            this.cotizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cotizar.Location = new System.Drawing.Point(70, 514);
            this.cotizar.Name = "cotizar";
            this.cotizar.Size = new System.Drawing.Size(162, 44);
            this.cotizar.TabIndex = 19;
            this.cotizar.Text = "Cotizar";
            this.cotizar.UseVisualStyleBackColor = false;
            this.cotizar.Click += new System.EventHandler(this.cotizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(257, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "$";
            // 
            // finalPrice
            // 
            this.finalPrice.AutoSize = true;
            this.finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalPrice.Location = new System.Drawing.Point(281, 520);
            this.finalPrice.Name = "finalPrice";
            this.finalPrice.Size = new System.Drawing.Size(26, 29);
            this.finalPrice.TabIndex = 21;
            this.finalPrice.Text = "0";
            // 
            // containerClothesQuality
            // 
            this.containerClothesQuality.Controls.Add(this.premiumQuality);
            this.containerClothesQuality.Controls.Add(this.standardQuality);
            this.containerClothesQuality.Location = new System.Drawing.Point(43, 366);
            this.containerClothesQuality.Name = "containerClothesQuality";
            this.containerClothesQuality.Size = new System.Drawing.Size(191, 80);
            this.containerClothesQuality.TabIndex = 22;
            this.containerClothesQuality.TabStop = false;
            this.containerClothesQuality.Text = "Calidad de Prenda";
            this.containerClothesQuality.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // containerClothesType
            // 
            this.containerClothesType.Controls.Add(this.label14);
            this.containerClothesType.Controls.Add(this.skinnyFit);
            this.containerClothesType.Controls.Add(this.maoNeck);
            this.containerClothesType.Controls.Add(this.shortSleeve);
            this.containerClothesType.Controls.Add(this.pants);
            this.containerClothesType.Controls.Add(this.shirt);
            this.containerClothesType.Location = new System.Drawing.Point(43, 168);
            this.containerClothesType.Name = "containerClothesType";
            this.containerClothesType.Size = new System.Drawing.Size(322, 106);
            this.containerClothesType.TabIndex = 23;
            this.containerClothesType.TabStop = false;
            this.containerClothesType.Text = "Prenda";
            this.containerClothesType.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(5, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(308, 2);
            this.label14.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stockAvailable);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(43, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 44);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "____";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "______________________________";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbQuantity);
            this.groupBox4.Controls.Add(this.tbUnitPrice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(276, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 80);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio Unitario y Cantidad";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(12, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(550, 2);
            this.label15.TabIndex = 11;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(186, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(9, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "|";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(11, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(550, 2);
            this.label17.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(11, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(550, 2);
            this.label18.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(11, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(550, 2);
            this.label13.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(104, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(356, 36);
            this.label19.TabIndex = 32;
            this.label19.Text = "COTIZADOR EXPRESS";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(156, 36);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(49, 20);
            this.tbQuantity.TabIndex = 18;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(39, 36);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(42, 20);
            this.tbUnitPrice.TabIndex = 17;
            this.tbUnitPrice.TextChanged += new System.EventHandler(this.tbUnitPrice_TextChanged_1);
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 595);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.finalPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.containerClothesType);
            this.Controls.Add(this.containerClothesQuality);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cotizar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sellerCode);
            this.Controls.Add(this.sellerName);
            this.Controls.Add(this.shopAddress);
            this.Controls.Add(this.shopName);
            this.Name = "PricingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.containerClothesQuality.ResumeLayout(false);
            this.containerClothesQuality.PerformLayout();
            this.containerClothesType.ResumeLayout(false);
            this.containerClothesType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.Label shopAddress;
        private System.Windows.Forms.Label sellerName;
        private System.Windows.Forms.Label sellerCode;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton shirt;
        private System.Windows.Forms.RadioButton pants;
        private System.Windows.Forms.CheckBox shortSleeve;
        private System.Windows.Forms.CheckBox maoNeck;
        private System.Windows.Forms.CheckBox skinnyFit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stockAvailable;
        private System.Windows.Forms.RadioButton standardQuality;
        private System.Windows.Forms.RadioButton premiumQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cotizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label finalPrice;
        private System.Windows.Forms.GroupBox containerClothesQuality;
        private System.Windows.Forms.GroupBox containerClothesType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbUnitPrice;
    }
}

