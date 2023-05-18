namespace WinFormsApp1
{
    partial class Form4
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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxCalories = new System.Windows.Forms.TextBox();
            this.textBoxProteins = new System.Windows.Forms.TextBox();
            this.textBoxFats = new System.Windows.Forms.TextBox();
            this.textBoxCarbohydrates = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonUpdateUserAge = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(356, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(12, 44);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 23);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxCalories
            // 
            this.textBoxCalories.Location = new System.Drawing.Point(118, 44);
            this.textBoxCalories.Name = "textBoxCalories";
            this.textBoxCalories.Size = new System.Drawing.Size(100, 23);
            this.textBoxCalories.TabIndex = 2;
            // 
            // textBoxProteins
            // 
            this.textBoxProteins.Location = new System.Drawing.Point(224, 44);
            this.textBoxProteins.Name = "textBoxProteins";
            this.textBoxProteins.Size = new System.Drawing.Size(100, 23);
            this.textBoxProteins.TabIndex = 3;
            // 
            // textBoxFats
            // 
            this.textBoxFats.Location = new System.Drawing.Point(330, 44);
            this.textBoxFats.Name = "textBoxFats";
            this.textBoxFats.Size = new System.Drawing.Size(100, 23);
            this.textBoxFats.TabIndex = 4;
            // 
            // textBoxCarbohydrates
            // 
            this.textBoxCarbohydrates.Location = new System.Drawing.Point(436, 44);
            this.textBoxCarbohydrates.Name = "textBoxCarbohydrates";
            this.textBoxCarbohydrates.Size = new System.Drawing.Size(100, 23);
            this.textBoxCarbohydrates.TabIndex = 5;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(542, 44);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 23);
            this.textBoxCategory.TabIndex = 6;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(648, 44);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 23);
            this.textBoxWeight.TabIndex = 7;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 105);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(100, 44);
            this.buttonAddProduct.TabIndex = 8;
            this.buttonAddProduct.Text = "Добавить продукт";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Калории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Белки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Жиры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Углеводы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Категория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(648, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Вес";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(118, 105);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(100, 44);
            this.buttonDeleteProduct.TabIndex = 16;
            this.buttonDeleteProduct.Text = "Удалить продукт";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonUpdateUserAge
            // 
            this.buttonUpdateUserAge.Location = new System.Drawing.Point(432, 105);
            this.buttonUpdateUserAge.Name = "buttonUpdateUserAge";
            this.buttonUpdateUserAge.Size = new System.Drawing.Size(100, 44);
            this.buttonUpdateUserAge.TabIndex = 17;
            this.buttonUpdateUserAge.Text = "Обновление возраста";
            this.buttonUpdateUserAge.UseVisualStyleBackColor = true;
            this.buttonUpdateUserAge.Click += new System.EventHandler(this.buttonUpdateUserAge_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(432, 171);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(356, 267);
            this.dataGridView2.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonUpdateUserAge);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxCarbohydrates);
            this.Controls.Add(this.textBoxFats);
            this.Controls.Add(this.textBoxProteins);
            this.Controls.Add(this.textBoxCalories);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxProductName;
        private TextBox textBoxCalories;
        private TextBox textBoxProteins;
        private TextBox textBoxFats;
        private TextBox textBoxCarbohydrates;
        private TextBox textBoxCategory;
        private TextBox textBoxWeight;
        private Button buttonAddProduct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonDeleteProduct;
        private Button buttonUpdateUserAge;
        private DataGridView dataGridView2;
    }
}