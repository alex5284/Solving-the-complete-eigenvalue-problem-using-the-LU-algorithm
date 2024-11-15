namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLU = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.dgMatrix = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1004, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 276);
            this.listBox1.TabIndex = 11;
            // 
            // btnLU
            // 
            this.btnLU.Location = new System.Drawing.Point(861, 203);
            this.btnLU.Name = "btnLU";
            this.btnLU.Size = new System.Drawing.Size(84, 30);
            this.btnLU.TabIndex = 10;
            this.btnLU.Text = "LU";
            this.btnLU.UseVisualStyleBackColor = true;
            this.btnLU.Click += new System.EventHandler(this.btnLU_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.Location = new System.Drawing.Point(832, 76);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(84, 30);
            this.btnMatrix.TabIndex = 9;
            this.btnMatrix.Text = "Create";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(931, 76);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 30);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(861, 39);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(100, 22);
            this.tbSize.TabIndex = 7;
            this.tbSize.Text = "3";
            // 
            // dgMatrix
            // 
            this.dgMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatrix.Location = new System.Drawing.Point(35, 24);
            this.dgMatrix.Name = "dgMatrix";
            this.dgMatrix.RowHeadersWidth = 51;
            this.dgMatrix.RowTemplate.Height = 24;
            this.dgMatrix.Size = new System.Drawing.Size(776, 262);
            this.dgMatrix.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(769, 296);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(212, 260);
            this.listBox2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Vector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Розмір матриці";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Для вводу мого варіанту натисніть Test\r\nДля вводу будь-якої матриці натісніть Cre" +
    "ate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Знайти власні числа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Знайти власні вектори";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLU);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.dgMatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLU;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.DataGridView dgMatrix;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

