namespace CVM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.customduration = new System.Windows.Forms.RadioButton();
            this.negativetime = new System.Windows.Forms.RadioButton();
            this.longestpossible = new System.Windows.Forms.RadioButton();
            this.timeHour = new System.Windows.Forms.NumericUpDown();
            this.timeSecond = new System.Windows.Forms.NumericUpDown();
            this.timeMinute = new System.Windows.Forms.NumericUpDown();
            this.convert = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select video.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customduration
            // 
            this.customduration.AutoSize = true;
            this.customduration.Checked = true;
            this.customduration.Location = new System.Drawing.Point(12, 46);
            this.customduration.Name = "customduration";
            this.customduration.Size = new System.Drawing.Size(101, 17);
            this.customduration.TabIndex = 1;
            this.customduration.TabStop = true;
            this.customduration.Text = "Custom duration";
            this.customduration.UseVisualStyleBackColor = true;
            // 
            // negativetime
            // 
            this.negativetime.AutoSize = true;
            this.negativetime.Location = new System.Drawing.Point(12, 92);
            this.negativetime.Name = "negativetime";
            this.negativetime.Size = new System.Drawing.Size(90, 17);
            this.negativetime.TabIndex = 2;
            this.negativetime.Text = "Negative time";
            this.negativetime.UseVisualStyleBackColor = true;
            // 
            // longestpossible
            // 
            this.longestpossible.AutoSize = true;
            this.longestpossible.Location = new System.Drawing.Point(12, 69);
            this.longestpossible.Name = "longestpossible";
            this.longestpossible.Size = new System.Drawing.Size(145, 17);
            this.longestpossible.TabIndex = 3;
            this.longestpossible.Text = "Longest possible duration";
            this.longestpossible.UseVisualStyleBackColor = true;
            // 
            // timeHour
            // 
            this.timeHour.Location = new System.Drawing.Point(12, 115);
            this.timeHour.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.timeHour.Name = "timeHour";
            this.timeHour.Size = new System.Drawing.Size(60, 20);
            this.timeHour.TabIndex = 4;
            // 
            // timeSecond
            // 
            this.timeSecond.Location = new System.Drawing.Point(12, 167);
            this.timeSecond.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.timeSecond.Name = "timeSecond";
            this.timeSecond.Size = new System.Drawing.Size(60, 20);
            this.timeSecond.TabIndex = 5;
            // 
            // timeMinute
            // 
            this.timeMinute.Location = new System.Drawing.Point(12, 141);
            this.timeMinute.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.timeMinute.Name = "timeMinute";
            this.timeMinute.Size = new System.Drawing.Size(60, 20);
            this.timeMinute.TabIndex = 6;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(12, 193);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(251, 44);
            this.convert.TabIndex = 8;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Made by Redox#8970";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 251);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.timeMinute);
            this.Controls.Add(this.timeSecond);
            this.Controls.Add(this.timeHour);
            this.Controls.Add(this.longestpossible);
            this.Controls.Add(this.negativetime);
            this.Controls.Add(this.customduration);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cursed Video Maker";
            ((System.ComponentModel.ISupportInitialize)(this.timeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton customduration;
        private System.Windows.Forms.RadioButton negativetime;
        private System.Windows.Forms.RadioButton longestpossible;
        private System.Windows.Forms.NumericUpDown timeHour;
        private System.Windows.Forms.NumericUpDown timeSecond;
        private System.Windows.Forms.NumericUpDown timeMinute;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

