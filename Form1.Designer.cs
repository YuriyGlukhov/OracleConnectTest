namespace OracleConnectTest
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(139, 42);
            button1.Name = "button1";
            button1.Size = new Size(258, 49);
            button1.TabIndex = 0;
            button1.Text = "Клиенты";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(557, 104);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(754, 42);
            button2.Name = "button2";
            button2.Size = new Size(265, 49);
            button2.TabIndex = 3;
            button2.Text = "Добавить клиента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(754, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(754, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(754, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(265, 27);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(726, 141);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 200);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 9;
            label2.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 256);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 11;
            label4.Text = "Телефон";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(319, 431);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(78, 27);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 434);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 13;
            label3.Text = "Id";
            // 
            // button3
            // 
            button3.Location = new Point(139, 363);
            button3.Name = "button3";
            button3.Size = new Size(258, 40);
            button3.TabIndex = 14;
            button3.Text = "Удаление клиента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 765);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Button button3;
    }
}
