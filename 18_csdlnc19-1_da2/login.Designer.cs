
namespace _18_csdlnc19_1_da2
{
    partial class login
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
            this.khfBut = new System.Windows.Forms.Button();
            this.adBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // khfBut
            // 
            this.khfBut.Location = new System.Drawing.Point(80, 61);
            this.khfBut.Name = "khfBut";
            this.khfBut.Size = new System.Drawing.Size(110, 23);
            this.khfBut.TabIndex = 0;
            this.khfBut.Text = " Khách hàng";
            this.khfBut.UseVisualStyleBackColor = true;
            this.khfBut.Click += new System.EventHandler(this.khfBut_Click);
            // 
            // adBut
            // 
            this.adBut.Location = new System.Drawing.Point(80, 133);
            this.adBut.Name = "adBut";
            this.adBut.Size = new System.Drawing.Size(110, 23);
            this.adBut.TabIndex = 1;
            this.adBut.Text = "Admin";
            this.adBut.UseVisualStyleBackColor = true;
            this.adBut.Click += new System.EventHandler(this.adBut_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 224);
            this.Controls.Add(this.adBut);
            this.Controls.Add(this.khfBut);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button khfBut;
        private System.Windows.Forms.Button adBut;
    }
}