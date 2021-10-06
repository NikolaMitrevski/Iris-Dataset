namespace NaiveBayesAlgorithm
{
    partial class Form1
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
            this.textBox_sepalLength = new System.Windows.Forms.TextBox();
            this.textBox_sepalWidth = new System.Windows.Forms.TextBox();
            this.textBox_petalLength = new System.Windows.Forms.TextBox();
            this.textBox_petalWidth = new System.Windows.Forms.TextBox();
            this.button_run = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sepal length(cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sepal width(cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Petal length(cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Petal width(cm):";
            // 
            // textBox_sepalLength
            // 
            this.textBox_sepalLength.Location = new System.Drawing.Point(161, 70);
            this.textBox_sepalLength.Name = "textBox_sepalLength";
            this.textBox_sepalLength.Size = new System.Drawing.Size(124, 20);
            this.textBox_sepalLength.TabIndex = 4;
            // 
            // textBox_sepalWidth
            // 
            this.textBox_sepalWidth.Location = new System.Drawing.Point(161, 104);
            this.textBox_sepalWidth.Name = "textBox_sepalWidth";
            this.textBox_sepalWidth.Size = new System.Drawing.Size(124, 20);
            this.textBox_sepalWidth.TabIndex = 5;
            // 
            // textBox_petalLength
            // 
            this.textBox_petalLength.Location = new System.Drawing.Point(161, 139);
            this.textBox_petalLength.Name = "textBox_petalLength";
            this.textBox_petalLength.Size = new System.Drawing.Size(124, 20);
            this.textBox_petalLength.TabIndex = 6;
            // 
            // textBox_petalWidth
            // 
            this.textBox_petalWidth.Location = new System.Drawing.Point(161, 176);
            this.textBox_petalWidth.Name = "textBox_petalWidth";
            this.textBox_petalWidth.Size = new System.Drawing.Size(124, 20);
            this.textBox_petalWidth.TabIndex = 7;
            // 
            // button_run
            // 
            this.button_run.BackColor = System.Drawing.Color.LawnGreen;
            this.button_run.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_run.ForeColor = System.Drawing.Color.White;
            this.button_run.Location = new System.Drawing.Point(91, 253);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(141, 33);
            this.button_run.TabIndex = 8;
            this.button_run.Text = "RUN";
            this.button_run.UseVisualStyleBackColor = false;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_result.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_result.Location = new System.Drawing.Point(83, 326);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(68, 23);
            this.label_result.TabIndex = 9;
            this.label_result.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.textBox_petalWidth);
            this.Controls.Add(this.textBox_petalLength);
            this.Controls.Add(this.textBox_sepalWidth);
            this.Controls.Add(this.textBox_sepalLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 488);
            this.MinimumSize = new System.Drawing.Size(338, 488);
            this.Name = "Form1";
            this.Text = "PREDICT THE TYPE OF IRIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_sepalLength;
        private System.Windows.Forms.TextBox textBox_sepalWidth;
        private System.Windows.Forms.TextBox textBox_petalLength;
        private System.Windows.Forms.TextBox textBox_petalWidth;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Label label_result;
    }
}

