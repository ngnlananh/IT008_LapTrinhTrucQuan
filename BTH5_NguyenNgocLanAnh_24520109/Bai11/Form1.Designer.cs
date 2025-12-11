namespace Bai11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.rbTextureBrush = new System.Windows.Forms.RadioButton();
            this.rbHatchBrush = new System.Windows.Forms.RadioButton();
            this.rbSolidBrush = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(281, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 550);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEllipse);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEllipse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbEllipse.Location = new System.Drawing.Point(23, 90);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(76, 23);
            this.rbEllipse.TabIndex = 2;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRectangle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbRectangle.Location = new System.Drawing.Point(23, 61);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(100, 23);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLine.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbLine.Location = new System.Drawing.Point(23, 32);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(59, 23);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.tbWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(20, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnColor.Location = new System.Drawing.Point(72, 67);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(89, 25);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 26);
            this.tbWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLinearGradientBrush);
            this.groupBox3.Controls.Add(this.rbTextureBrush);
            this.groupBox3.Controls.Add(this.rbHatchBrush);
            this.groupBox3.Controls.Add(this.rbSolidBrush);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox3.Location = new System.Drawing.Point(20, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 166);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rbLinearGradientBrush
            // 
            this.rbLinearGradientBrush.AutoSize = true;
            this.rbLinearGradientBrush.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLinearGradientBrush.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbLinearGradientBrush.Location = new System.Drawing.Point(24, 119);
            this.rbLinearGradientBrush.Name = "rbLinearGradientBrush";
            this.rbLinearGradientBrush.Size = new System.Drawing.Size(184, 23);
            this.rbLinearGradientBrush.TabIndex = 3;
            this.rbLinearGradientBrush.TabStop = true;
            this.rbLinearGradientBrush.Text = "LinearGradientBrush";
            this.rbLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // rbTextureBrush
            // 
            this.rbTextureBrush.AutoSize = true;
            this.rbTextureBrush.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTextureBrush.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbTextureBrush.Location = new System.Drawing.Point(23, 90);
            this.rbTextureBrush.Name = "rbTextureBrush";
            this.rbTextureBrush.Size = new System.Drawing.Size(127, 23);
            this.rbTextureBrush.TabIndex = 2;
            this.rbTextureBrush.TabStop = true;
            this.rbTextureBrush.Text = "TextureBrush";
            this.rbTextureBrush.UseVisualStyleBackColor = true;
            // 
            // rbHatchBrush
            // 
            this.rbHatchBrush.AutoSize = true;
            this.rbHatchBrush.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHatchBrush.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbHatchBrush.Location = new System.Drawing.Point(23, 61);
            this.rbHatchBrush.Name = "rbHatchBrush";
            this.rbHatchBrush.Size = new System.Drawing.Size(116, 23);
            this.rbHatchBrush.TabIndex = 1;
            this.rbHatchBrush.TabStop = true;
            this.rbHatchBrush.Text = "HatchBrush";
            this.rbHatchBrush.UseVisualStyleBackColor = true;
            // 
            // rbSolidBrush
            // 
            this.rbSolidBrush.AutoSize = true;
            this.rbSolidBrush.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolidBrush.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbSolidBrush.Location = new System.Drawing.Point(23, 32);
            this.rbSolidBrush.Name = "rbSolidBrush";
            this.rbSolidBrush.Size = new System.Drawing.Size(108, 23);
            this.rbSolidBrush.TabIndex = 0;
            this.rbSolidBrush.TabStop = true;
            this.rbSolidBrush.Text = "SolidBrush";
            this.rbSolidBrush.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 550);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bai Thi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTextureBrush;
        private System.Windows.Forms.RadioButton rbHatchBrush;
        private System.Windows.Forms.RadioButton rbSolidBrush;
        private System.Windows.Forms.RadioButton rbLinearGradientBrush;
    }
}

