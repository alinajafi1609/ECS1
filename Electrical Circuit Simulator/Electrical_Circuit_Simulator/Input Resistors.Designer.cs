namespace Electrical_Circuit_Simulator
{
    partial class Input_Resistors
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
            this.voltageTexBox = new System.Windows.Forms.TextBox();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.posTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resitance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connected to the Power Supply in P or S";
            // 
            // voltageTexBox
            // 
            this.voltageTexBox.Location = new System.Drawing.Point(18, 100);
            this.voltageTexBox.Name = "voltageTexBox";
            this.voltageTexBox.Size = new System.Drawing.Size(41, 20);
            this.voltageTexBox.TabIndex = 4;
            this.voltageTexBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(89, 100);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(59, 20);
            this.resTextBox.TabIndex = 5;
            this.resTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // posTextBox
            // 
            this.posTextBox.Location = new System.Drawing.Point(187, 100);
            this.posTextBox.Name = "posTextBox";
            this.posTextBox.Size = new System.Drawing.Size(172, 20);
            this.posTextBox.TabIndex = 6;
            this.posTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the name of the component:\r\n";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(33, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(326, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "-";
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter a \"?\" for the value you want to work out.";
            // 
            // Input_Resistors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 187);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.posTextBox);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.voltageTexBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Input_Resistors";
            this.Text = "Input Values";
            this.Load += new System.EventHandler(this.Input_Resistors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox voltageTexBox;
        private System.Windows.Forms.TextBox resTextBox;
        private System.Windows.Forms.TextBox posTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
    }
}