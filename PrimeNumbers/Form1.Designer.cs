namespace PrimeNumbers
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxPrimeNumbers = new System.Windows.Forms.ListBox();
            this.CalculatePrimeNumbers = new System.Windows.Forms.Button();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.calculatePrimeNumberSequential = new System.Windows.Forms.Button();
            this.listBoxPNAsync = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPrimeNumbers
            // 
            this.listBoxPrimeNumbers.FormattingEnabled = true;
            this.listBoxPrimeNumbers.ItemHeight = 16;
            this.listBoxPrimeNumbers.Location = new System.Drawing.Point(54, 30);
            this.listBoxPrimeNumbers.Name = "listBoxPrimeNumbers";
            this.listBoxPrimeNumbers.Size = new System.Drawing.Size(334, 196);
            this.listBoxPrimeNumbers.TabIndex = 0;
            // 
            // CalculatePrimeNumbers
            // 
            this.CalculatePrimeNumbers.Location = new System.Drawing.Point(767, 390);
            this.CalculatePrimeNumbers.Name = "CalculatePrimeNumbers";
            this.CalculatePrimeNumbers.Size = new System.Drawing.Size(89, 23);
            this.CalculatePrimeNumbers.TabIndex = 1;
            this.CalculatePrimeNumbers.Text = "Calculate";
            this.CalculatePrimeNumbers.UseVisualStyleBackColor = true;
            this.CalculatePrimeNumbers.Click += new System.EventHandler(this.CalculatePrimeNumbers_ClickAsync);
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(145, 279);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(107, 22);
            this.firstNumber.TabIndex = 2;
            this.firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNumber_KeyPress);
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(756, 279);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(106, 22);
            this.secondNumber.TabIndex = 3;
            this.secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNumber_KeyPress);
            // 
            // calculatePrimeNumberSequential
            // 
            this.calculatePrimeNumberSequential.Location = new System.Drawing.Point(152, 390);
            this.calculatePrimeNumberSequential.Name = "calculatePrimeNumberSequential";
            this.calculatePrimeNumberSequential.Size = new System.Drawing.Size(90, 23);
            this.calculatePrimeNumberSequential.TabIndex = 4;
            this.calculatePrimeNumberSequential.Text = "Sequential";
            this.calculatePrimeNumberSequential.UseVisualStyleBackColor = true;
            this.calculatePrimeNumberSequential.Click += new System.EventHandler(this.calculatePrimeNumberSequential_Click);
            // 
            // listBoxPNAsync
            // 
            this.listBoxPNAsync.FormattingEnabled = true;
            this.listBoxPNAsync.ItemHeight = 16;
            this.listBoxPNAsync.Location = new System.Drawing.Point(650, 30);
            this.listBoxPNAsync.Name = "listBoxPNAsync";
            this.listBoxPNAsync.Size = new System.Drawing.Size(334, 196);
            this.listBoxPNAsync.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 177);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(780, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 259);
            this.label3.MaximumSize = new System.Drawing.Size(400, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 144);
            this.label3.TabIndex = 9;
            this.label3.Text = "I PROMISE THE PROBLEM ITS PRINTING ALL THE NUMBERS. THATS WHY IT FREEZES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxPNAsync);
            this.Controls.Add(this.calculatePrimeNumberSequential);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.CalculatePrimeNumbers);
            this.Controls.Add(this.listBoxPrimeNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrimeNumbers;
        private System.Windows.Forms.Button CalculatePrimeNumbers;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.Button calculatePrimeNumberSequential;
        private System.Windows.Forms.ListBox listBoxPNAsync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

