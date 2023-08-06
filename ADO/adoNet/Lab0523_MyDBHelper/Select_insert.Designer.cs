namespace Lab0523_MyDBHelper
{
    partial class Select_insert
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCurrencyKey = new System.Windows.Forms.TextBox();
            this.txtCurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupNorthwind = new System.Windows.Forms.GroupBox();
            this.ProductsV2 = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.intoNWRegion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupNorthwind.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(113, 80);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 35);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(559, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(336, 80);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 35);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCurrencyKey
            // 
            this.txtCurrencyKey.Location = new System.Drawing.Point(113, 142);
            this.txtCurrencyKey.Name = "txtCurrencyKey";
            this.txtCurrencyKey.Size = new System.Drawing.Size(100, 22);
            this.txtCurrencyKey.TabIndex = 3;
            // 
            // txtCurrencyAlternateKey
            // 
            this.txtCurrencyAlternateKey.Location = new System.Drawing.Point(336, 142);
            this.txtCurrencyAlternateKey.Name = "txtCurrencyAlternateKey";
            this.txtCurrencyAlternateKey.Size = new System.Drawing.Size(100, 22);
            this.txtCurrencyAlternateKey.TabIndex = 4;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(559, 142);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(100, 22);
            this.txtCurrencyName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 213);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupNorthwind
            // 
            this.groupNorthwind.Controls.Add(this.textBox2);
            this.groupNorthwind.Controls.Add(this.textBox1);
            this.groupNorthwind.Controls.Add(this.intoNWRegion);
            this.groupNorthwind.Controls.Add(this.ProductsV2);
            this.groupNorthwind.Controls.Add(this.ProductsBtn);
            this.groupNorthwind.Location = new System.Drawing.Point(730, 80);
            this.groupNorthwind.Name = "groupNorthwind";
            this.groupNorthwind.Size = new System.Drawing.Size(273, 200);
            this.groupNorthwind.TabIndex = 7;
            this.groupNorthwind.TabStop = false;
            this.groupNorthwind.Text = "northwind";
            // 
            // ProductsV2
            // 
            this.ProductsV2.Location = new System.Drawing.Point(19, 79);
            this.ProductsV2.Name = "ProductsV2";
            this.ProductsV2.Size = new System.Drawing.Size(106, 57);
            this.ProductsV2.TabIndex = 1;
            this.ProductsV2.Text = "ProductsV2";
            this.ProductsV2.UseVisualStyleBackColor = true;
            this.ProductsV2.Click += new System.EventHandler(this.ProductsV2_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Location = new System.Drawing.Point(19, 21);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(106, 50);
            this.ProductsBtn.TabIndex = 0;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // intoNWRegion
            // 
            this.intoNWRegion.Location = new System.Drawing.Point(149, 71);
            this.intoNWRegion.Name = "intoNWRegion";
            this.intoNWRegion.Size = new System.Drawing.Size(105, 65);
            this.intoNWRegion.TabIndex = 2;
            this.intoNWRegion.Text = "寫入北風region";
            this.intoNWRegion.UseVisualStyleBackColor = true;
            this.intoNWRegion.Click += new System.EventHandler(this.intoNWRegion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.groupNorthwind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.txtCurrencyAlternateKey);
            this.Controls.Add(this.txtCurrencyKey);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupNorthwind.ResumeLayout(false);
            this.groupNorthwind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCurrencyKey;
        private System.Windows.Forms.TextBox txtCurrencyAlternateKey;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupNorthwind;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Button ProductsV2;
        private System.Windows.Forms.Button intoNWRegion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

