namespace alarm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hoursNUD = new System.Windows.Forms.NumericUpDown();
            this.minutesNUD = new System.Windows.Forms.NumericUpDown();
            this.addB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hoursNUD
            // 
            this.hoursNUD.Location = new System.Drawing.Point(16, 15);
            this.hoursNUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursNUD.Name = "hoursNUD";
            this.hoursNUD.Size = new System.Drawing.Size(160, 22);
            this.hoursNUD.TabIndex = 0;
            // 
            // minutesNUD
            // 
            this.minutesNUD.Location = new System.Drawing.Point(184, 15);
            this.minutesNUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minutesNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNUD.Name = "minutesNUD";
            this.minutesNUD.Size = new System.Drawing.Size(160, 22);
            this.minutesNUD.TabIndex = 1;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(16, 47);
            this.addB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(100, 28);
            this.addB.TabIndex = 2;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 244);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(123, 47);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 28);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 336);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.minutesNUD);
            this.Controls.Add(this.hoursNUD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown hoursNUD;
        private System.Windows.Forms.NumericUpDown minutesNUD;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemove;
    }
}

