
namespace BasicQueuingSystemChuaFinal
{
    partial class CustomerView
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblNowServing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(84, 36);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(229, 45);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "*Now Serving";
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNowServing.Location = new System.Drawing.Point(170, 124);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(0, 45);
            this.lblNowServing.TabIndex = 1;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 301);
            this.Controls.Add(this.lblNowServing);
            this.Controls.Add(this.lbl2);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.Load += new System.EventHandler(this.CustomerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.Label lblNowServing;
    }
}