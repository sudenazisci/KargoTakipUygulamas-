namespace WinFormsApp12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(192, 192, 255);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(355, 481);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(328, 154);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(192, 192, 255);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(762, 481);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(346, 154);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(192, 192, 255);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(797, 108);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(368, 154);
            listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.FromArgb(192, 192, 255);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 25;
            listBox4.Location = new Point(1251, 108);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(357, 154);
            listBox4.TabIndex = 3;
            // 
            // listBox5
            // 
            listBox5.BackColor = Color.FromArgb(192, 192, 255);
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 25;
            listBox5.Location = new Point(1238, 481);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(357, 154);
            listBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(466, 419);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 5;
            label1.Text = "37AB123 - Ford";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(797, 419);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 6;
            label2.Text = " 37CD456 - Mercedes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(873, 47);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 7;
            label3.Text = "37GH012 - BMW";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(1371, 47);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 8;
            label4.Text = "37EF789 - Toyota";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(1336, 419);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 9;
            label5.Text = "37JK345 - Audi";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(32, 380);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(32, 450);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 11;
            button2.Text = "Durdur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 78);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumVioletRed;
            label7.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 75);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 13;
            label7.Text = "Durum:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1657, 667);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
    }
}
