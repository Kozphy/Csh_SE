namespace Lab0522_form
{
    partial class select_update
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
            this.btnUpdateV2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtCurrencyKey = new System.Windows.Forms.TextBox();
            this.txtCurrencyAlternateKey = new System.Windows.Forms.TextBox();
            this.txtCurrencyName = new System.Windows.Forms.TextBox();
            this.btnUpdateV3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(119, 99);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 34);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "btnSelect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(275, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateV2
            // 
            this.btnUpdateV2.Location = new System.Drawing.Point(428, 99);
            this.btnUpdateV2.Name = "btnUpdateV2";
            this.btnUpdateV2.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateV2.TabIndex = 2;
            this.btnUpdateV2.Text = "btnUpdateV2";
            this.btnUpdateV2.UseVisualStyleBackColor = true;
            this.btnUpdateV2.Click += new System.EventHandler(this.btnUpdateV2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 162);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(626, 107);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(162, 255);
            this.txtResult.TabIndex = 4;
            // 
            // txtCurrencyKey
            // 
            this.txtCurrencyKey.Location = new System.Drawing.Point(119, 153);
            this.txtCurrencyKey.Name = "txtCurrencyKey";
            this.txtCurrencyKey.Size = new System.Drawing.Size(100, 20);
            this.txtCurrencyKey.TabIndex = 5;
            // 
            // txtCurrencyAlternateKey
            // 
            this.txtCurrencyAlternateKey.Location = new System.Drawing.Point(275, 153);
            this.txtCurrencyAlternateKey.Name = "txtCurrencyAlternateKey";
            this.txtCurrencyAlternateKey.Size = new System.Drawing.Size(100, 20);
            this.txtCurrencyAlternateKey.TabIndex = 6;
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Location = new System.Drawing.Point(428, 153);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.Size = new System.Drawing.Size(100, 20);
            this.txtCurrencyName.TabIndex = 7;
            // 
            // btnUpdateV3
            // 
            this.btnUpdateV3.Location = new System.Drawing.Point(428, 38);
            this.btnUpdateV3.Name = "btnUpdateV3";
            this.btnUpdateV3.Size = new System.Drawing.Size(100, 34);
            this.btnUpdateV3.TabIndex = 8;
            this.btnUpdateV3.Text = "btnUpdateV3";
            this.btnUpdateV3.UseVisualStyleBackColor = true;
            this.btnUpdateV3.Click += new System.EventHandler(this.btnUpdateV3_Click);
            // 
            // select_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnUpdateV3);
            this.Controls.Add(this.txtCurrencyName);
            this.Controls.Add(this.txtCurrencyAlternateKey);
            this.Controls.Add(this.txtCurrencyKey);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateV2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Name = "select_update";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateV2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtCurrencyKey;
        private System.Windows.Forms.TextBox txtCurrencyAlternateKey;
        private System.Windows.Forms.TextBox txtCurrencyName;
        private System.Windows.Forms.Button btnUpdateV3;
    }
}

