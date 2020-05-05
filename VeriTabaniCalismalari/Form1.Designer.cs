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
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_UpdateName = new System.Windows.Forms.TextBox();
            this.label_UpdateName = new System.Windows.Forms.Label();
            this.textBox_UpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UpdateStockAmoun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
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
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
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
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.button_Add);
            this.gbxAdd.Controls.Add(this.textBox_Name);
            this.gbxAdd.Controls.Add(this.label_Name);
            this.gbxAdd.Controls.Add(this.textBox_UnitPrice);
            this.gbxAdd.Controls.Add(this.label_UnitPrice);
            this.gbxAdd.Controls.Add(this.textBox_StockAmount);
            this.gbxAdd.Controls.Add(this.label_StockAmount);
            this.gbxAdd.Location = new System.Drawing.Point(22, 257);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(602, 337);
            this.gbxAdd.TabIndex = 9;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a product";
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
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.button_Remove);
            this.gbxUpdate.Controls.Add(this.button_Update);
            this.gbxUpdate.Controls.Add(this.textBox_UpdateName);
            this.gbxUpdate.Controls.Add(this.label_UpdateName);
            this.gbxUpdate.Controls.Add(this.textBox_UpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.label2);
            this.gbxUpdate.Controls.Add(this.textBox_UpdateStockAmoun);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Location = new System.Drawing.Point(630, 267);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(570, 345);
            this.gbxUpdate.TabIndex = 10;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Uptade a product";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(287, 298);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(108, 33);
            this.button_Update.TabIndex = 9;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_UpdateName
            // 
            this.textBox_UpdateName.Location = new System.Drawing.Point(277, 85);
            this.textBox_UpdateName.Name = "textBox_UpdateName";
            this.textBox_UpdateName.Size = new System.Drawing.Size(146, 31);
            this.textBox_UpdateName.TabIndex = 8;
            // 
            // label_UpdateName
            // 
            this.label_UpdateName.AutoSize = true;
            this.label_UpdateName.Location = new System.Drawing.Point(117, 85);
            this.label_UpdateName.Name = "label_UpdateName";
            this.label_UpdateName.Size = new System.Drawing.Size(68, 25);
            this.label_UpdateName.TabIndex = 1;
            this.label_UpdateName.Text = "Name";
            // 
            // textBox_UpdateUnitPrice
            // 
            this.textBox_UpdateUnitPrice.Location = new System.Drawing.Point(277, 154);
            this.textBox_UpdateUnitPrice.Name = "textBox_UpdateUnitPrice";
            this.textBox_UpdateUnitPrice.Size = new System.Drawing.Size(146, 31);
            this.textBox_UpdateUnitPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Price";
            // 
            // textBox_UpdateStockAmoun
            // 
            this.textBox_UpdateStockAmoun.Location = new System.Drawing.Point(277, 244);
            this.textBox_UpdateStockAmoun.Name = "textBox_UpdateStockAmoun";
            this.textBox_UpdateStockAmoun.Size = new System.Drawing.Size(146, 31);
            this.textBox_UpdateStockAmoun.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock Amount";
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(69, 300);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(116, 31);
            this.button_Remove.TabIndex = 11;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 606);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_UpdateName;
        private System.Windows.Forms.Label label_UpdateName;
        private System.Windows.Forms.TextBox textBox_UpdateUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UpdateStockAmoun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Remove;
    }
}

