namespace Bai01
{
    partial class Form2
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
            this.lbChildEvents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbChildEvents
            // 
            this.lbChildEvents.FormattingEnabled = true;
            this.lbChildEvents.Location = new System.Drawing.Point(54, 37);
            this.lbChildEvents.Name = "lbChildEvents";
            this.lbChildEvents.Size = new System.Drawing.Size(418, 238);
            this.lbChildEvents.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 304);
            this.Controls.Add(this.lbChildEvents);
            this.Name = "Form2";
            this.Text = "Bai1_Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbChildEvents;
    }
}