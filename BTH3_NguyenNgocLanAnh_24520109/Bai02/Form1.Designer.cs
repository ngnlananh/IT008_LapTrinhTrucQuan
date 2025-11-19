namespace Bai02
{
    partial class fBai02
    {
        private System.ComponentModel.IContainer components = null;
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
            this.btnPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(633, 362);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(75, 23);
            this.btnPaint.TabIndex = 0;
            this.btnPaint.Text = "button1";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // fBai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPaint);
            this.Name = "fBai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaint;
    }
}

