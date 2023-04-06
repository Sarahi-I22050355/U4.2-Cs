namespace U4._2_Cs
{
    partial class Form1
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
            this.lvInventory = new System.Windows.Forms.ListView();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbProcessor = new System.Windows.Forms.ComboBox();
            this.cbOS = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvInventory
            // 
            this.lvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInventory.HideSelection = false;
            this.lvInventory.Location = new System.Drawing.Point(5, 220);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(546, 218);
            this.lvInventory.TabIndex = 0;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvInventory_KeyDown);
            // 
            // cbBrand
            // 
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "HP",
            "Dell",
            "Lenovo",
            "ASUS",
            "Acer",
            "MSI",
            "Toshiba",
            "Samsung",
            "LG"});
            this.cbBrand.Location = new System.Drawing.Point(195, 60);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(143, 28);
            this.cbBrand.TabIndex = 1;
            // 
            // cbProcessor
            // 
            this.cbProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProcessor.FormattingEnabled = true;
            this.cbProcessor.Items.AddRange(new object[] {
            "Intel Core (Intel)",
            "AMD Ryzen (AMD)",
            "Qualcomm Snapdragon (Qualcomm)",
            "NVIDIA Tegra (NVIDIA)",
            "Samsung Exynos (Samsung)",
            "MediaTek Helio (MediaTek)",
            "IBM Power (IBM)",
            "VIA Nano (VIA Technologies)",
            "ARM Cortex (ARM)",
            "Rockchip RK (Rockchip)"});
            this.cbProcessor.Location = new System.Drawing.Point(195, 184);
            this.cbProcessor.Name = "cbProcessor";
            this.cbProcessor.Size = new System.Drawing.Size(143, 28);
            this.cbProcessor.TabIndex = 2;
            // 
            // cbOS
            // 
            this.cbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOS.FormattingEnabled = true;
            this.cbOS.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 11",
            "Ubuntu",
            "Debian",
            "Fedora",
            "Red Hat",
            "Solaris"});
            this.cbOS.Location = new System.Drawing.Point(195, 143);
            this.cbOS.Name = "cbOS";
            this.cbOS.Size = new System.Drawing.Size(143, 28);
            this.cbOS.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(195, 24);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(195, 98);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(143, 26);
            this.txtModel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Operating System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Processor";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(367, 147);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(76, 39);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 449);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbOS);
            this.Controls.Add(this.cbProcessor);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.lvInventory);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbProcessor;
        private System.Windows.Forms.ComboBox cbOS;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdd;
    }
}

