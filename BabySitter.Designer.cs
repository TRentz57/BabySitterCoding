namespace WindowsFormsApp1
{
    partial class BabySitter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTimeDate = new System.Windows.Forms.TextBox();
            this.BedTimeDate = new System.Windows.Forms.TextBox();
            this.EndTimeDate = new System.Windows.Forms.TextBox();
            this.hoursWorkedLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(442, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bed Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Time";
            // 
            // StartTimeDate
            // 
            this.StartTimeDate.Location = new System.Drawing.Point(139, 202);
            this.StartTimeDate.Name = "StartTimeDate";
            this.StartTimeDate.Size = new System.Drawing.Size(120, 20);
            this.StartTimeDate.TabIndex = 9;
            // 
            // BedTimeDate
            // 
            this.BedTimeDate.Location = new System.Drawing.Point(284, 202);
            this.BedTimeDate.Name = "BedTimeDate";
            this.BedTimeDate.Size = new System.Drawing.Size(120, 20);
            this.BedTimeDate.TabIndex = 10;
            // 
            // EndTimeDate
            // 
            this.EndTimeDate.Location = new System.Drawing.Point(442, 202);
            this.EndTimeDate.Name = "EndTimeDate";
            this.EndTimeDate.Size = new System.Drawing.Size(120, 20);
            this.EndTimeDate.TabIndex = 11;
            // 
            // hoursWorkedLbl
            // 
            this.hoursWorkedLbl.AutoSize = true;
            this.hoursWorkedLbl.Location = new System.Drawing.Point(56, 62);
            this.hoursWorkedLbl.Name = "hoursWorkedLbl";
            this.hoursWorkedLbl.Size = new System.Drawing.Size(0, 13);
            this.hoursWorkedLbl.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hoursWorkedLbl);
            this.Controls.Add(this.EndTimeDate);
            this.Controls.Add(this.BedTimeDate);
            this.Controls.Add(this.StartTimeDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "BabySitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StartTimeDate;
        private System.Windows.Forms.TextBox BedTimeDate;
        private System.Windows.Forms.TextBox EndTimeDate;
        private System.Windows.Forms.Label hoursWorkedLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

