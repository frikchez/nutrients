namespace Test
{
    partial class New_dish
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
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.textBox_product = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_cal = new System.Windows.Forms.Label();
            this.label_prot = new System.Windows.Forms.Label();
            this.label_fat = new System.Windows.Forms.Label();
            this.label_carbo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(12, 107);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_products.TabIndex = 0;
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(12, 19);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(49, 13);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "Продукт";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(12, 42);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(26, 13);
            this.label_weight.TabIndex = 2;
            this.label_weight.Text = "Вес";
            // 
            // textBox_product
            // 
            this.textBox_product.Location = new System.Drawing.Point(67, 16);
            this.textBox_product.Name = "textBox_product";
            this.textBox_product.Size = new System.Drawing.Size(100, 20);
            this.textBox_product.TabIndex = 3;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(67, 42);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(58, 68);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Добавить продукт";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название рецепта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(321, 56);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(123, 23);
            this.button_create.TabIndex = 8;
            this.button_create.Text = "Создать рецепт";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_carbo);
            this.groupBox1.Controls.Add(this.label_fat);
            this.groupBox1.Controls.Add(this.label_prot);
            this.groupBox1.Controls.Add(this.label_cal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(321, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Калорийность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Белки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Жиры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Углеводы";
            // 
            // label_cal
            // 
            this.label_cal.AutoSize = true;
            this.label_cal.Location = new System.Drawing.Point(104, 10);
            this.label_cal.Name = "label_cal";
            this.label_cal.Size = new System.Drawing.Size(0, 13);
            this.label_cal.TabIndex = 4;
            // 
            // label_prot
            // 
            this.label_prot.AutoSize = true;
            this.label_prot.Location = new System.Drawing.Point(104, 31);
            this.label_prot.Name = "label_prot";
            this.label_prot.Size = new System.Drawing.Size(0, 13);
            this.label_prot.TabIndex = 5;
            // 
            // label_fat
            // 
            this.label_fat.AutoSize = true;
            this.label_fat.Location = new System.Drawing.Point(104, 53);
            this.label_fat.Name = "label_fat";
            this.label_fat.Size = new System.Drawing.Size(0, 13);
            this.label_fat.TabIndex = 6;
            // 
            // label_carbo
            // 
            this.label_carbo.AutoSize = true;
            this.label_carbo.Location = new System.Drawing.Point(104, 76);
            this.label_carbo.Name = "label_carbo";
            this.label_carbo.Size = new System.Drawing.Size(0, 13);
            this.label_carbo.TabIndex = 7;
            // 
            // New_dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_product);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dataGridView_products);
            this.Name = "New_dish";
            this.Text = "Новый рецепт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.TextBox textBox_product;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_carbo;
        private System.Windows.Forms.Label label_fat;
        private System.Windows.Forms.Label label_prot;
        private System.Windows.Forms.Label label_cal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}