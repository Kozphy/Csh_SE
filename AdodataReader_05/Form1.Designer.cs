namespace AdodataReader_05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 76);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "食物的卡路里計算";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 122);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "資料來源";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 203);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "請挑選:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 306);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "份量:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(322, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(353, 149);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 369);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 8;
            label5.Text = "total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 369);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // button2
            // 
            button2.Location = new Point(524, 180);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}