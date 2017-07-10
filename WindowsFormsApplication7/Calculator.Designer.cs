namespace WindowsFormsApplication7
{
    partial class Calculator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimalPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.CalculationShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(43, 244);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(46, 23);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(128, 244);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 23);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(208, 244);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(43, 194);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 23);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(128, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 23);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(208, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 23);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(43, 142);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(128, 142);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(208, 142);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 23);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(43, 293);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(46, 23);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDecimalPoint
            // 
            this.btnDecimalPoint.Location = new System.Drawing.Point(128, 293);
            this.btnDecimalPoint.Name = "btnDecimalPoint";
            this.btnDecimalPoint.Size = new System.Drawing.Size(46, 23);
            this.btnDecimalPoint.TabIndex = 10;
            this.btnDecimalPoint.Text = ".";
            this.btnDecimalPoint.UseVisualStyleBackColor = true;
            this.btnDecimalPoint.Click += new System.EventHandler(this.btnDecimalPoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(208, 292);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(46, 23);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(284, 244);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 72);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(284, 194);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 23);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(284, 142);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(53, 23);
            this.btnTimes.TabIndex = 14;
            this.btnTimes.Text = "×";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(284, 96);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(53, 23);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(43, 96);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(46, 23);
            this.btnAC.TabIndex = 16;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(128, 96);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 23);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(208, 96);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(46, 23);
            this.btnPercent.TabIndex = 18;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // CalculationShow
            // 
            this.CalculationShow.AutoSize = true;
            this.CalculationShow.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CalculationShow.Location = new System.Drawing.Point(12, 29);
            this.CalculationShow.Name = "CalculationShow";
            this.CalculationShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalculationShow.Size = new System.Drawing.Size(36, 37);
            this.CalculationShow.TabIndex = 19;
            this.CalculationShow.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 330);
            this.Controls.Add(this.CalculationShow);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimalPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn_1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimalPoint;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Label CalculationShow;
    }
}

