namespace UIWinFormss
{
    partial class frmProduct
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
            dgwProducts = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button8 = new Button();
            radioButton1 = new RadioButton();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button7 = new Button();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dgwProductCatName = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProductCatName).BeginInit();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(0, 192);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(1197, 294);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Kategoriler:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(79, 38);
            button1.Name = "button1";
            button1.Size = new Size(40, 24);
            button1.TabIndex = 3;
            button1.Text = "aç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 28);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Ürün Ara:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(79, 56);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 8;
            button2.Text = "Tümünü Görüntüle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 76);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategoriler";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(0, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 92);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürünler";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(287, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(884, 161);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Name:";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonShadow;
            button8.Location = new Point(739, 106);
            button8.Name = "button8";
            button8.Size = new Size(127, 31);
            button8.TabIndex = 24;
            button8.Text = "DTO";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(752, 61);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(102, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Discountinued";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(599, 119);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(116, 23);
            textBox8.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(598, 87);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(116, 23);
            textBox7.TabIndex = 21;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(598, 56);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(116, 23);
            textBox6.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(510, 122);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 19;
            label11.Text = "ReOrder Level:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(510, 87);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 18;
            label10.Text = "Units on Order:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 59);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 17;
            label9.Text = "Units in Stock:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(361, 53);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(116, 23);
            comboBox3.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 122);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 15;
            label8.Text = "Unit Price:";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(361, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(116, 23);
            textBox5.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 90);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 13;
            label7.Text = "Quantity Per Unit:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(361, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 23);
            textBox4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 56);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "Category ID:";
            label6.Click += label6_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(123, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(116, 23);
            comboBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 8;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.Location = new Point(79, 122);
            button7.Name = "button7";
            button7.Size = new Size(40, 24);
            button7.TabIndex = 7;
            button7.Text = "aç";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 122);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 6;
            label5.Text = "Supplier ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Product ID:";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.GradientActiveCaption;
            button6.Location = new Point(309, 22);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 3;
            button6.Text = "Sil";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.MouseEnter += button6_MouseEnter;
           
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Location = new Point(210, 22);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Güncelle";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            button5.MouseEnter += button5_MouseEnter;
            
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(113, 22);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 1;
            button4.Text = "Ekle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
           
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(20, 22);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Yeni";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dgwProductCatName
            // 
            dgwProductCatName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProductCatName.Location = new Point(0, 492);
            dgwProductCatName.Name = "dgwProductCatName";
            dgwProductCatName.RowTemplate.Height = 25;
            dgwProductCatName.Size = new Size(359, 262);
            dgwProductCatName.TabIndex = 12;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1194, 749);
            Controls.Add(dgwProductCatName);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwProducts);
            Name = "frmProduct";
            Text = "Ürünler";
            Load += frmProduct_Load;
            LocationChanged += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProductCatName).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button7;
        private Label label5;
        private Label label3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label1;
        private ComboBox comboBox3;
        private Label label8;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button8;
        private RadioButton radioButton1;
        private TextBox textBox8;
        private DataGridView dgwProductCatName;
    }
}
