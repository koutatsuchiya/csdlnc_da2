
namespace _18_csdlnc19_1_da2
{
    partial class KhachHangFind
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tenspTab = new System.Windows.Forms.TabPage();
            this.ttTenNoLab = new System.Windows.Forms.Label();
            this.totalTenLabel = new System.Windows.Forms.Label();
            this.tendgv = new System.Windows.Forms.DataGridView();
            this.maspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctkmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findTenBut = new System.Windows.Forms.Button();
            this.tenspText = new System.Windows.Forms.TextBox();
            this.loaiTab = new System.Windows.Forms.TabPage();
            this.loaidgv = new System.Windows.Forms.DataGridView();
            this.maloaiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanhieuTab = new System.Windows.Forms.TabPage();
            this.dtdgv = new System.Windows.Forms.DataGridView();
            this.madtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonedtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maildtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonhaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qhCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tenspTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).BeginInit();
            this.loaiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaidgv)).BeginInit();
            this.nhanhieuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tenspTab);
            this.tabControl1.Controls.Add(this.loaiTab);
            this.tabControl1.Controls.Add(this.nhanhieuTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tenspTab
            // 
            this.tenspTab.Controls.Add(this.ttTenNoLab);
            this.tenspTab.Controls.Add(this.totalTenLabel);
            this.tenspTab.Controls.Add(this.tendgv);
            this.tenspTab.Controls.Add(this.findTenBut);
            this.tenspTab.Controls.Add(this.tenspText);
            this.tenspTab.Location = new System.Drawing.Point(4, 25);
            this.tenspTab.Name = "tenspTab";
            this.tenspTab.Size = new System.Drawing.Size(793, 419);
            this.tenspTab.TabIndex = 2;
            this.tenspTab.Text = "Tên sản phẩm";
            this.tenspTab.UseVisualStyleBackColor = true;
            // 
            // ttTenNoLab
            // 
            this.ttTenNoLab.AutoSize = true;
            this.ttTenNoLab.Location = new System.Drawing.Point(443, 32);
            this.ttTenNoLab.Name = "ttTenNoLab";
            this.ttTenNoLab.Size = new System.Drawing.Size(0, 17);
            this.ttTenNoLab.TabIndex = 4;
            // 
            // totalTenLabel
            // 
            this.totalTenLabel.AutoSize = true;
            this.totalTenLabel.Location = new System.Drawing.Point(269, 32);
            this.totalTenLabel.Name = "totalTenLabel";
            this.totalTenLabel.Size = new System.Drawing.Size(168, 17);
            this.totalTenLabel.TabIndex = 3;
            this.totalTenLabel.Text = "Tổng sản phẩm tìm được:";
            // 
            // tendgv
            // 
            this.tendgv.AllowUserToAddRows = false;
            this.tendgv.AllowUserToDeleteRows = false;
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
            this.tendgv.Location = new System.Drawing.Point(0, 67);
            this.tendgv.Name = "tendgv";
            this.tendgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tendgv.RowTemplate.Height = 24;
            this.tendgv.Size = new System.Drawing.Size(793, 352);
            this.tendgv.TabIndex = 2;
            // 
            // maspCol
            // 
            this.maspCol.HeaderText = "Mã sản phẩm";
            this.maspCol.MinimumWidth = 6;
            this.maspCol.Name = "maspCol";
            this.maspCol.ReadOnly = true;
            this.maspCol.Width = 96;
            // 
            // tenspCol
            // 
            this.tenspCol.HeaderText = "Tên sản phẩm";
            this.tenspCol.MinimumWidth = 6;
            this.tenspCol.Name = "tenspCol";
            this.tenspCol.ReadOnly = true;
            this.tenspCol.Width = 97;
            // 
            // giaCol
            // 
            this.giaCol.HeaderText = "Giá bán";
            this.giaCol.MinimumWidth = 6;
            this.giaCol.Name = "giaCol";
            this.giaCol.ReadOnly = true;
            this.giaCol.Width = 95;
            // 
            // expCol
            // 
            this.expCol.HeaderText = "Hạn dùng";
            this.expCol.MinimumWidth = 6;
            this.expCol.Name = "expCol";
            this.expCol.ReadOnly = true;
            this.expCol.Width = 96;
            // 
            // hieuCol
            // 
            this.hieuCol.HeaderText = "Nhãn hiệu";
            this.hieuCol.MinimumWidth = 6;
            this.hieuCol.Name = "hieuCol";
            this.hieuCol.ReadOnly = true;
            this.hieuCol.Width = 97;
            // 
            // loaiCol
            // 
            this.loaiCol.HeaderText = "Loại";
            this.loaiCol.MinimumWidth = 6;
            this.loaiCol.Name = "loaiCol";
            this.loaiCol.ReadOnly = true;
            this.loaiCol.Width = 96;
            // 
            // slCol
            // 
            this.slCol.HeaderText = "Số lượng tồn";
            this.slCol.MinimumWidth = 6;
            this.slCol.Name = "slCol";
            this.slCol.ReadOnly = true;
            this.slCol.Width = 96;
            // 
            // ctkmCol
            // 
            this.ctkmCol.HeaderText = "CTKH";
            this.ctkmCol.MinimumWidth = 6;
            this.ctkmCol.Name = "ctkmCol";
            this.ctkmCol.ReadOnly = true;
            this.ctkmCol.Width = 97;
            // 
            // findTenBut
            // 
            this.findTenBut.Location = new System.Drawing.Point(524, 3);
            this.findTenBut.Name = "findTenBut";
            this.findTenBut.Size = new System.Drawing.Size(102, 23);
            this.findTenBut.TabIndex = 1;
            this.findTenBut.Text = "Tìm kiếm";
            this.findTenBut.UseVisualStyleBackColor = true;
            this.findTenBut.Click += new System.EventHandler(this.findTenBut_Click);
            // 
            // tenspText
            // 
            this.tenspText.Location = new System.Drawing.Point(135, 3);
            this.tenspText.Name = "tenspText";
            this.tenspText.Size = new System.Drawing.Size(367, 22);
            this.tenspText.TabIndex = 0;
            // 
            // loaiTab
            // 
            this.loaiTab.Controls.Add(this.loaidgv);
            this.loaiTab.Location = new System.Drawing.Point(4, 25);
            this.loaiTab.Name = "loaiTab";
            this.loaiTab.Padding = new System.Windows.Forms.Padding(3);
            this.loaiTab.Size = new System.Drawing.Size(793, 419);
            this.loaiTab.TabIndex = 0;
            this.loaiTab.Text = "Loại";
            this.loaiTab.UseVisualStyleBackColor = true;
            // 
            // loaidgv
            // 
            this.loaidgv.AllowUserToAddRows = false;
            this.loaidgv.AllowUserToDeleteRows = false;
            this.loaidgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loaidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaidgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloaiCol,
            this.tenloaiCol,
            this.motaCol});
            this.loaidgv.Location = new System.Drawing.Point(87, 60);
            this.loaidgv.Name = "loaidgv";
            this.loaidgv.RowHeadersWidth = 51;
            this.loaidgv.RowTemplate.Height = 24;
            this.loaidgv.Size = new System.Drawing.Size(610, 293);
            this.loaidgv.TabIndex = 0;
            this.loaidgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loaidgv_CellClick);
            // 
            // maloaiCol
            // 
            this.maloaiCol.HeaderText = "Mã loại";
            this.maloaiCol.MinimumWidth = 6;
            this.maloaiCol.Name = "maloaiCol";
            this.maloaiCol.ReadOnly = true;
            // 
            // tenloaiCol
            // 
            this.tenloaiCol.HeaderText = "Tên loại";
            this.tenloaiCol.MinimumWidth = 6;
            this.tenloaiCol.Name = "tenloaiCol";
            this.tenloaiCol.ReadOnly = true;
            // 
            // motaCol
            // 
            this.motaCol.HeaderText = "Mô tả";
            this.motaCol.MinimumWidth = 6;
            this.motaCol.Name = "motaCol";
            this.motaCol.ReadOnly = true;
            // 
            // nhanhieuTab
            // 
            this.nhanhieuTab.Controls.Add(this.dtdgv);
            this.nhanhieuTab.Location = new System.Drawing.Point(4, 25);
            this.nhanhieuTab.Name = "nhanhieuTab";
            this.nhanhieuTab.Padding = new System.Windows.Forms.Padding(3);
            this.nhanhieuTab.Size = new System.Drawing.Size(793, 419);
            this.nhanhieuTab.TabIndex = 1;
            this.nhanhieuTab.Text = "Nhãn hiệu";
            this.nhanhieuTab.UseVisualStyleBackColor = true;
            // 
            // dtdgv
            // 
            this.dtdgv.AllowUserToAddRows = false;
            this.dtdgv.AllowUserToDeleteRows = false;
            this.dtdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madtCol,
            this.tendtCol,
            this.phonedtCol,
            this.maildtCol,
            this.sonhaCol,
            this.duongCol,
            this.pxCol,
            this.qhCol,
            this.tpCol});
            this.dtdgv.Location = new System.Drawing.Point(0, 37);
            this.dtdgv.Name = "dtdgv";
            this.dtdgv.RowHeadersWidth = 51;
            this.dtdgv.RowTemplate.Height = 24;
            this.dtdgv.Size = new System.Drawing.Size(789, 351);
            this.dtdgv.TabIndex = 0;
            this.dtdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtdgv_CellClick);
            // 
            // madtCol
            // 
            this.madtCol.HeaderText = "Mã đối tác";
            this.madtCol.MinimumWidth = 6;
            this.madtCol.Name = "madtCol";
            this.madtCol.ReadOnly = true;
            this.madtCol.Width = 125;
            // 
            // tendtCol
            // 
            this.tendtCol.HeaderText = "Tên đối tác";
            this.tendtCol.MinimumWidth = 6;
            this.tendtCol.Name = "tendtCol";
            this.tendtCol.ReadOnly = true;
            this.tendtCol.Width = 125;
            // 
            // phonedtCol
            // 
            this.phonedtCol.HeaderText = "SĐT";
            this.phonedtCol.MinimumWidth = 6;
            this.phonedtCol.Name = "phonedtCol";
            this.phonedtCol.ReadOnly = true;
            this.phonedtCol.Width = 125;
            // 
            // maildtCol
            // 
            this.maildtCol.HeaderText = "Email";
            this.maildtCol.MinimumWidth = 6;
            this.maildtCol.Name = "maildtCol";
            this.maildtCol.ReadOnly = true;
            this.maildtCol.Width = 125;
            // 
            // sonhaCol
            // 
            this.sonhaCol.HeaderText = "Số nhà";
            this.sonhaCol.MinimumWidth = 6;
            this.sonhaCol.Name = "sonhaCol";
            this.sonhaCol.ReadOnly = true;
            this.sonhaCol.Width = 125;
            // 
            // duongCol
            // 
            this.duongCol.HeaderText = "Đường";
            this.duongCol.MinimumWidth = 6;
            this.duongCol.Name = "duongCol";
            this.duongCol.ReadOnly = true;
            this.duongCol.Width = 125;
            // 
            // pxCol
            // 
            this.pxCol.HeaderText = "Phường/xã";
            this.pxCol.MinimumWidth = 6;
            this.pxCol.Name = "pxCol";
            this.pxCol.ReadOnly = true;
            this.pxCol.Width = 125;
            // 
            // qhCol
            // 
            this.qhCol.HeaderText = "Quận/huyện";
            this.qhCol.MinimumWidth = 6;
            this.qhCol.Name = "qhCol";
            this.qhCol.ReadOnly = true;
            this.qhCol.Width = 125;
            // 
            // tpCol
            // 
            this.tpCol.HeaderText = "Tỉnh/thành phố";
            this.tpCol.MinimumWidth = 6;
            this.tpCol.Name = "tpCol";
            this.tpCol.ReadOnly = true;
            this.tpCol.Width = 125;
            // 
            // KhachHangFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "KhachHangFind";
            this.Text = "Khách hàng tìm kiếm";
            this.Load += new System.EventHandler(this.KhachHangFind_Load);
            this.tabControl1.ResumeLayout(false);
            this.tenspTab.ResumeLayout(false);
            this.tenspTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).EndInit();
            this.loaiTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loaidgv)).EndInit();
            this.nhanhieuTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loaiTab;
        private System.Windows.Forms.TabPage nhanhieuTab;
        private System.Windows.Forms.TabPage tenspTab;
        private System.Windows.Forms.DataGridView tendgv;
        private System.Windows.Forms.Button findTenBut;
        private System.Windows.Forms.TextBox tenspText;
        private System.Windows.Forms.Label ttTenNoLab;
        private System.Windows.Forms.Label totalTenLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn expCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn slCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctkmCol;
        private System.Windows.Forms.DataGridView loaidgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaCol;
        private System.Windows.Forms.DataGridView dtdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonedtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn maildtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonhaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn qhCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpCol;
    }
}

