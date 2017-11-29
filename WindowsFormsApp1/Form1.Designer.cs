namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myNumericTextBox2 = new WindowsFormsControlLibrary1.MyNumericTextBox();
            this.myNumericTextBox1 = new WindowsFormsControlLibrary1.MyNumericTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "MyNumericeTextBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "MyNumericeTextBox2";
            // 
            // myNumericTextBox2
            // 
            this.myNumericTextBox2.Location = new System.Drawing.Point(143, 111);
            this.myNumericTextBox2.Name = "myNumericTextBox2";
            this.myNumericTextBox2.P1 = 100;
            this.myNumericTextBox2.P2 = 0;
            this.myNumericTextBox2.Size = new System.Drawing.Size(100, 22);
            this.myNumericTextBox2.TabIndex = 2;
            // 
            // myNumericTextBox1
            // 
            this.myNumericTextBox1.Location = new System.Drawing.Point(143, 61);
            this.myNumericTextBox1.Name = "myNumericTextBox1";
            this.myNumericTextBox1.P1 = 0;
            this.myNumericTextBox1.P2 = 0;
            this.myNumericTextBox1.Size = new System.Drawing.Size(100, 22);
            this.myNumericTextBox1.TabIndex = 0;
            this.myNumericTextBox1.Text = "777";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myNumericTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myNumericTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.MyNumericTextBox myNumericTextBox1;
        private System.Windows.Forms.Button button1;
        private WindowsFormsControlLibrary1.MyNumericTextBox myNumericTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

