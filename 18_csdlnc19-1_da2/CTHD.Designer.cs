
namespace _18_csdlnc19_1_da2
{
    partial class CTHD
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
            this.ctdgv = new System.Windows.Forms.DataGridView();
            this.maspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ctdgv
            // 
            this.ctdgv.AllowUserToAddRows = false;
            this.ctdgv.AllowUserToDeleteRows = false;
            this.ctdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maspCol,
            this.tenspCol,
            this.gnCol,
            this.gbCol,
            this.expCol,
            this.slnCol,
            this.slxCol});
            this.ctdgv.Location = new System.Drawing.Point(-51, -1);
            this.ctdgv.Name = "ctdgv";
            this.ctdgv.RowHeadersWidth = 51;
            this.ctdgv.RowTemplate.Height = 24;
            this.ctdgv.Size = new System.Drawing.Size(853, 451);
            this.ctdgv.TabIndex = 0;
            // 
            // maspCol
            // 
            this.maspCol.HeaderText = "Mã sản phẩm";
            this.maspCol.MinimumWidth = 6;
            this.maspCol.Name = "maspCol";
            this.maspCol.ReadOnly = true;
            // 
            // tenspCol
            // 
            this.tenspCol.HeaderText = "Tên sản phẩm";
            this.tenspCol.MinimumWidth = 6;
            this.tenspCol.Name = "tenspCol";
            this.tenspCol.ReadOnly = true;
            // 
            // gnCol
            // 
            this.gnCol.HeaderText = "Giá nhập";
            this.gnCol.MinimumWidth = 6;
            this.gnCol.Name = "gnCol";
            this.gnCol.ReadOnly = true;
            // 
            // gbCol
            // 
            this.gbCol.HeaderText = "Giá bán";
            this.gbCol.MinimumWidth = 6;
            this.gbCol.Name = "gbCol";
            this.gbCol.ReadOnly = true;
            // 
            // expCol
            // 
            this.expCol.HeaderText = "Hạn dùng";
            this.expCol.MinimumWidth = 6;
            this.expCol.Name = "expCol";
            this.expCol.ReadOnly = true;
            // 
            // slnCol
            // 
            this.slnCol.HeaderText = "Số lượng nhập";
            this.slnCol.MinimumWidth = 6;
            this.slnCol.Name = "slnCol";
            this.slnCol.ReadOnly = true;
            // 
            // slxCol
            // 
            this.slxCol.HeaderText = "Số lượng xuất";
            this.slxCol.MinimumWidth = 6;
            this.slxCol.Name = "slxCol";
            this.slxCol.ReadOnly = true;
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctdgv);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "CTHD";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ctdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn slnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn slxCol;
    }
}