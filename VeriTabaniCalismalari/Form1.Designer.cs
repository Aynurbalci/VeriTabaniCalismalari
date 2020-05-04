namespace VeriTabaniCalismalari
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.label_StockAmount = new System.Windows.Forms.Label();
            this.textBox_StockAmount = new System.Windows.Forms.TextBox();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 26);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 82;
            this.dgwProducts.RowTemplate.Height = 33;
            this.dgwProducts.Size = new System.Drawing.Size(1185, 225);
            this.dgwProducts.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(117, 85);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(68, 25);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.AutoSize = true;
            this.label_UnitPrice.Location = new System.Drawing.Point(117, 175);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(105, 25);
            this.label_UnitPrice.TabIndex = 3;
            this.label_UnitPrice.Text = "Unit Price";
            // 
            // label_StockAmount
            // 
            this.label_StockAmount.AutoSize = true;
            this.label_StockAmount.Location = new System.Drawing.Point(117, 244);
            this.label_StockAmount.Name = "label_StockAmount";
            this.label_StockAmount.Size = new System.Drawing.Size(145, 25);
            this.label_StockAmount.TabIndex = 4;
            this.label_StockAmount.Text = "Stock Amount";
            // 
            // textBox_StockAmount
            // 
            this.textBox_StockAmount.Location = new System.Drawing.Point(277, 244);
            this.textBox_StockAmount.Name = "textBox_StockAmount";
            this.textBox_StockAmount.Size = new System.Drawing.Size(146, 31);
            this.textBox_StockAmount.TabIndex = 5;
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(277, 154);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.Size = new System.Drawing.Size(146, 31);
            this.textBox_UnitPrice.TabIndex = 6;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(277, 85);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(146, 31);
            this.textBox_Name.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.textBox_UnitPrice);
            this.groupBox1.Controls.Add(this.label_UnitPrice);
            this.groupBox1.Controls.Add(this.textBox_StockAmount);
            this.groupBox1.Controls.Add(this.label_StockAmount);
            this.groupBox1.Location = new System.Drawing.Point(22, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 337);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a product";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(287, 298);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(108, 33);
            this.button_Add.TabIndex = 9;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.Label label_StockAmount;
        private System.Windows.Forms.TextBox textBox_StockAmount;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Add;
    }
}

