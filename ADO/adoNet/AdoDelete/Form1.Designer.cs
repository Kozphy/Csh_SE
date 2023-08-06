namespace AdoDelete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prev5page = new System.Windows.Forms.Button();
            this.next5page = new System.Windows.Forms.Button();
            this.deleteThroughDs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(144, 35);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(105, 46);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "selectBtn";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(563, 35);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 46);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(280, 35);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(105, 46);
            this.insertBtn.TabIndex = 3;
            this.insertBtn.Text = "insertBtn";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(410, 35);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 46);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "updateBtn";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(144, 413);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(105, 36);
            this.prevBtn.TabIndex = 5;
            this.prevBtn.Text = "prevBtn";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(561, 413);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(105, 36);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "nextBtn";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // prev5page
            // 
            this.prev5page.Location = new System.Drawing.Point(41, 413);
            this.prev5page.Name = "prev5page";
            this.prev5page.Size = new System.Drawing.Size(75, 36);
            this.prev5page.TabIndex = 8;
            this.prev5page.Text = "prev5page";
            this.prev5page.UseVisualStyleBackColor = true;
            this.prev5page.Click += new System.EventHandler(this.prev5page_Click);
            // 
            // next5page
            // 
            this.next5page.Location = new System.Drawing.Point(713, 413);
            this.next5page.Name = "next5page";
            this.next5page.Size = new System.Drawing.Size(75, 36);
            this.next5page.TabIndex = 9;
            this.next5page.Text = "next5page";
            this.next5page.UseVisualStyleBackColor = true;
            this.next5page.Click += new System.EventHandler(this.next5page_Click);
            // 
            // deleteThroughDs
            // 
            this.deleteThroughDs.Location = new System.Drawing.Point(677, 35);
            this.deleteThroughDs.Name = "deleteThroughDs";
            this.deleteThroughDs.Size = new System.Drawing.Size(111, 49);
            this.deleteThroughDs.TabIndex = 10;
            this.deleteThroughDs.Text = "deleteThroughDs";
            this.deleteThroughDs.UseVisualStyleBackColor = true;
            this.deleteThroughDs.Click += new System.EventHandler(this.deleteThroughDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.deleteThroughDs);
            this.Controls.Add(this.next5page);
            this.Controls.Add(this.prev5page);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prev5page;
        private System.Windows.Forms.Button next5page;
        private System.Windows.Forms.Button deleteThroughDs;
    }
}

