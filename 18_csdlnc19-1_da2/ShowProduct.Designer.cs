
namespace _18_csdlnc19_1_da2
{
    partial class ShowProduct
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
            this.tendgv = new System.Windows.Forms.DataGridView();
            this.maspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctkmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalspLabel = new System.Windows.Forms.Label();
            this.ttTenNoLab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tendgv
            // 
            this.tendgv.AllowUserToAddRows = false;
            this.tendgv.AllowUserToDeleteRows = false;
            this.tendgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tendgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tendgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maspCol,
            this.tenspCol,
            this.giaCol,
            this.expCol,
            this.hieuCol,
            this.loaiCol,
            this.slCol,
            this.ctkmCol});
            this.tendgv.Location = new System.Drawing.Point(-1, -1);
            this.tendgv.Name = "tendgv";
            this.tendgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tendgv.RowTemplate.Height = 24;
            this.tendgv.Size = new System.Drawing.Size(800, 410);
            this.tendgv.TabIndex = 3;
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
            // giaCol
            // 
            this.giaCol.HeaderText = "Giá bán";
            this.giaCol.MinimumWidth = 6;
            this.giaCol.Name = "giaCol";
            this.giaCol.ReadOnly = true;
            // 
            // expCol
            // 
            this.expCol.HeaderText = "Hạn dùng";
            this.expCol.MinimumWidth = 6;
            this.expCol.Name = "expCol";
            this.expCol.ReadOnly = true;
            // 
            // hieuCol
            // 
            this.hieuCol.HeaderText = "Nhãn hiệu";
            this.hieuCol.MinimumWidth = 6;
            this.hieuCol.Name = "hieuCol";
            this.hieuCol.ReadOnly = true;
            // 
            // loaiCol
            // 
            this.loaiCol.HeaderText = "Loại";
            this.loaiCol.MinimumWidth = 6;
            this.loaiCol.Name = "loaiCol";
            this.loaiCol.ReadOnly = true;
            // 
            // slCol
            // 
            this.slCol.HeaderText = "Số lượng tồn";
            this.slCol.MinimumWidth = 6;
            this.slCol.Name = "slCol";
            this.slCol.ReadOnly = true;
            // 
            // ctkmCol
            // 
            this.ctkmCol.HeaderText = "CTKH";
            this.ctkmCol.MinimumWidth = 6;
            this.ctkmCol.Name = "ctkmCol";
            this.ctkmCol.ReadOnly = true;
            // 
            // totalspLabel
            // 
            this.totalspLabel.AutoSize = true;
            this.totalspLabel.Location = new System.Drawing.Point(256, 424);
            this.totalspLabel.Name = "totalspLabel";
            this.totalspLabel.Size = new System.Drawing.Size(187, 17);
            this.totalspLabel.TabIndex = 4;
            this.totalspLabel.Text = "Tổng số sản phẩm tìm được:";
            // 
            // ttTenNoLab
            // 
            this.ttTenNoLab.AutoSize = true;
            this.ttTenNoLab.Location = new System.Drawing.Point(449, 424);
            this.ttTenNoLab.Name = "ttTenNoLab";
            this.ttTenNoLab.Size = new System.Drawing.Size(0, 17);
            this.ttTenNoLab.TabIndex = 5;
            // 
            // ShowProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ttTenNoLab);
            this.Controls.Add(this.totalspLabel);
            this.Controls.Add(this.tendgv);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ShowProduct";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.ShowProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tendgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn slCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctkmCol;
        private System.Windows.Forms.Label totalspLabel;
        private System.Windows.Forms.Label ttTenNoLab;
    }
}