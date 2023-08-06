namespace Lab0522_form
{
    partial class Insert
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.insertV1 = new System.Windows.Forms.Button();
            this.insertV2 = new System.Windows.Forms.Button();
            this.txtCurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(102, 61);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(365, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(484, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 230);
            this.textBox1.TabIndex = 2;
            // 
            // insertV1
            // 
            this.insertV1.Location = new System.Drawing.Point(243, 61);
            this.insertV1.Name = "insertV1";
            this.insertV1.Size = new System.Drawing.Size(75, 23);
            this.insertV1.TabIndex = 3;
            this.insertV1.Text = "insertV1";
            this.insertV1.UseVisualStyleBackColor = true;
            this.insertV1.Click += new System.EventHandler(this.insertV1_Click);
            // 
            // insertV2
            // 
            this.insertV2.Location = new System.Drawing.Point(380, 61);
            this.insertV2.Name = "insertV2";
            this.insertV2.Size = new System.Drawing.Size(75, 23);
            this.insertV2.TabIndex = 4;
            this.insertV2.Text = "insertV2";
            this.insertV2.UseVisualStyleBackColor = true;
            this.insertV2.Click += new System.EventHandler(this.insertV2_Click);
            // 
            // txtCurrencyAlternateKey
            // 
            this.txtCurrencyAlternateKey.Location = new System.Drawing.Point(90, 121);
            this.txtCurrencyAlternateKey.Name = "txtCurrencyAlternateKey";
            this.txtCurrencyAlternateKey.Size = new System.Drawing.Size(114, 22);
            this.txtCurrencyAlternateKey.TabIndex = 5;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(341, 121);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(114, 22);
            this.txtCurrencyName.TabIndex = 6;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.txtCurrencyAlternateKey);
            this.Controls.Add(this.insertV2);
            this.Controls.Add(this.insertV1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Name = "Insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button insertV1;
        private System.Windows.Forms.Button insertV2;
        private System.Windows.Forms.TextBox txtCurrencyAlternateKey;
        private System.Windows.Forms.TextBox txtCurrencyName;
    }
}