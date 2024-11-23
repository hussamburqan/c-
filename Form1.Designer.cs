namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(109, 122);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 2;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 56);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 96);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "LastName";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(236, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 213);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(297, 246);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 6;
            button2.Text = "Read Table Student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 169);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 210);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "FirstName";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(109, 235);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 11;
            button3.Text = "Edit Student";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(511, 131);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 14;
            button4.Text = "Delete Student";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 101);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 13;
            label5.Text = "ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(510, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 288);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox textBox5;
    }
}
