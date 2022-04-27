
namespace LabComputerGraphic.Week3_4_5
{
    partial class Week5_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 36);
            this.button2.TabIndex = 0;
            this.button2.Text = "RotateNoneFlipX";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(995, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "RotateNoneFlipY";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(995, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 36);
            this.button4.TabIndex = 0;
            this.button4.Text = "RotateNoneFlipXY";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(1100, 45);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(59, 22);
            this.txtW.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(1201, 45);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(59, 22);
            this.txtH.TabIndex = 1;
            this.txtH.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Week5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 543);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Week5_2";
            this.Text = "Week5_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
    }
}