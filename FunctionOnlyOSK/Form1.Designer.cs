namespace FunctionOnlyOSK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnF1 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF1
            // 
            this.btnF1.AutoSize = true;
            this.btnF1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnF1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnF1.Font = new System.Drawing.Font("Segoe UI", 115F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF1.Location = new System.Drawing.Point(0, 0);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(264, 257);
            this.btnF1.TabIndex = 0;
            this.btnF1.Text = "F1";
            this.btnF1.UseVisualStyleBackColor = true;
            this.btnF1.Click += new System.EventHandler(this.btnF1_Click);
            // 
            // btnF2
            // 
            this.btnF2.AutoSize = true;
            this.btnF2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnF2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnF2.Font = new System.Drawing.Font("Segoe UI", 115F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF2.Location = new System.Drawing.Point(264, 0);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(264, 257);
            this.btnF2.TabIndex = 1;
            this.btnF2.Text = "F2";
            this.btnF2.UseVisualStyleBackColor = true;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // btnF3
            // 
            this.btnF3.AutoSize = true;
            this.btnF3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnF3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnF3.Font = new System.Drawing.Font("Segoe UI", 115F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF3.Location = new System.Drawing.Point(528, 0);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(264, 257);
            this.btnF3.TabIndex = 2;
            this.btnF3.Text = "F3";
            this.btnF3.UseVisualStyleBackColor = true;
            this.btnF3.Click += new System.EventHandler(this.btnF3_Click);
            // 
            // btnF4
            // 
            this.btnF4.AutoSize = true;
            this.btnF4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnF4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnF4.Font = new System.Drawing.Font("Segoe UI", 115F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF4.Location = new System.Drawing.Point(792, 0);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(264, 257);
            this.btnF4.TabIndex = 3;
            this.btnF4.Text = "F4";
            this.btnF4.UseVisualStyleBackColor = true;
            this.btnF4.Click += new System.EventHandler(this.btnF4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 257);
            this.ControlBox = false;
            this.Controls.Add(this.btnF4);
            this.Controls.Add(this.btnF3);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnF1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1076, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1076, 256);
            this.Name = "Form1";
            this.Text = "Function Only OSK";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnF1;
        private Button btnF2;
        private Button btnF3;
        private Button btnF4;
    }
}