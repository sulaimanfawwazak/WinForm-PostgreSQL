namespace Junpro8
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
            this.pb_qr = new System.Windows.Forms.PictureBox();
            this.lb_qr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qr
            // 
            this.pb_qr.Location = new System.Drawing.Point(32, 28);
            this.pb_qr.Name = "pb_qr";
            this.pb_qr.Size = new System.Drawing.Size(232, 233);
            this.pb_qr.TabIndex = 0;
            this.pb_qr.TabStop = false;
            // 
            // lb_qr
            // 
            this.lb_qr.AutoSize = true;
            this.lb_qr.Location = new System.Drawing.Point(29, 378);
            this.lb_qr.Name = "lb_qr";
            this.lb_qr.Size = new System.Drawing.Size(35, 13);
            this.lb_qr.TabIndex = 1;
            this.lb_qr.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.lb_qr);
            this.Controls.Add(this.pb_qr);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_qr;
        private System.Windows.Forms.Label lb_qr;
    }
}