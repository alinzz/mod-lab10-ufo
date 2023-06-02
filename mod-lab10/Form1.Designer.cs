namespace mod_lab10
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
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.ColSteps = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(87, 95);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(43, 22);
            this.x2.TabIndex = 1;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(87, 123);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(43, 22);
            this.y2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "X2 =";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y2 =";
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(365, 53);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(142, 22);
            this.Value.TabIndex = 9;
            this.Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // ColSteps
            // 
            this.ColSteps.Location = new System.Drawing.Point(365, 81);
            this.ColSteps.Name = "ColSteps";
            this.ColSteps.Size = new System.Drawing.Size(142, 22);
            this.ColSteps.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(87, 67);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(43, 22);
            this.y1.TabIndex = 12;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(87, 40);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(43, 22);
            this.x1.TabIndex = 13;
            this.x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x1_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "X1 = ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y1 = ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(229, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Точность";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(180, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Количество членов ряда";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Использование угла", "Уравнение прямой" });
            this.comboBox1.Location = new System.Drawing.Point(269, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 707);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColSteps);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;

        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TextBox ColSteps;

        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox y2;

        #endregion
    }
}