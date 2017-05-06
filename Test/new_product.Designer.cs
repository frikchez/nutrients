namespace Test
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.new_prod_name = new System.Windows.Forms.TextBox();
            this.new_prod_prot = new System.Windows.Forms.TextBox();
            this.new_prod_fat = new System.Windows.Forms.TextBox();
            this.new_prod_hyd = new System.Windows.Forms.TextBox();
            this.new_prod_create = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.new_prod_cal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Белки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Жиры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Углеводы";
            // 
            // new_prod_name
            // 
            this.new_prod_name.Location = new System.Drawing.Point(139, 38);
            this.new_prod_name.Name = "new_prod_name";
            this.new_prod_name.Size = new System.Drawing.Size(175, 20);
            this.new_prod_name.TabIndex = 4;
            // 
            // new_prod_prot
            // 
            this.new_prod_prot.Location = new System.Drawing.Point(139, 92);
            this.new_prod_prot.Name = "new_prod_prot";
            this.new_prod_prot.Size = new System.Drawing.Size(69, 20);
            this.new_prod_prot.TabIndex = 6;
            // 
            // new_prod_fat
            // 
            this.new_prod_fat.Location = new System.Drawing.Point(139, 119);
            this.new_prod_fat.Name = "new_prod_fat";
            this.new_prod_fat.Size = new System.Drawing.Size(69, 20);
            this.new_prod_fat.TabIndex = 7;
            // 
            // new_prod_hyd
            // 
            this.new_prod_hyd.Location = new System.Drawing.Point(139, 145);
            this.new_prod_hyd.Name = "new_prod_hyd";
            this.new_prod_hyd.Size = new System.Drawing.Size(69, 20);
            this.new_prod_hyd.TabIndex = 8;
            // 
            // new_prod_create
            // 
            this.new_prod_create.Location = new System.Drawing.Point(96, 211);
            this.new_prod_create.Name = "new_prod_create";
            this.new_prod_create.Size = new System.Drawing.Size(75, 23);
            this.new_prod_create.TabIndex = 10;
            this.new_prod_create.Text = "Добавить";
            this.new_prod_create.UseVisualStyleBackColor = true;
            this.new_prod_create.Click += new System.EventHandler(this.new_prod_create_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Калорийность:";
            // 
            // new_prod_cal
            // 
            this.new_prod_cal.Location = new System.Drawing.Point(139, 66);
            this.new_prod_cal.Name = "new_prod_cal";
            this.new_prod_cal.Size = new System.Drawing.Size(69, 20);
            this.new_prod_cal.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.new_prod_cal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.new_prod_create);
            this.Controls.Add(this.new_prod_hyd);
            this.Controls.Add(this.new_prod_fat);
            this.Controls.Add(this.new_prod_prot);
            this.Controls.Add(this.new_prod_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_prod_name;
        private System.Windows.Forms.TextBox new_prod_prot;
        private System.Windows.Forms.TextBox new_prod_fat;
        private System.Windows.Forms.TextBox new_prod_hyd;
        private System.Windows.Forms.Button new_prod_create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox new_prod_cal;
    }
}