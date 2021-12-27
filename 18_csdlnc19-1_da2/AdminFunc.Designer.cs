
namespace _18_csdlnc19_1_da2
{
    partial class AdminFunc
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
            this.adTab1 = new System.Windows.Forms.TabPage();
            this.tendgv = new System.Windows.Forms.DataGridView();
            this.maspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenspCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findTenBut = new System.Windows.Forms.Button();
            this.tenspText = new System.Windows.Forms.TextBox();
            this.adTab2 = new System.Windows.Forms.TabPage();
            this.seeDBut = new System.Windows.Forms.Button();
            this.rbDx = new System.Windows.Forms.RadioButton();
            this.hddgv = new System.Windows.Forms.DataGridView();
            this.rbDn = new System.Windows.Forms.RadioButton();
            this.madonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nccCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctvcCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.adTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).BeginInit();
            this.adTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adTab1);
            this.tabControl1.Controls.Add(this.adTab2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1263, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // adTab1
            // 
            this.adTab1.Controls.Add(this.tendgv);
            this.adTab1.Controls.Add(this.findTenBut);
            this.adTab1.Controls.Add(this.tenspText);
            this.adTab1.Location = new System.Drawing.Point(4, 25);
            this.adTab1.Name = "adTab1";
            this.adTab1.Padding = new System.Windows.Forms.Padding(3);
            this.adTab1.Size = new System.Drawing.Size(1255, 426);
            this.adTab1.TabIndex = 0;
            this.adTab1.Text = "Kiểm kho";
            this.adTab1.UseVisualStyleBackColor = true;
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
            this.hieuCol,
            this.loaiCol,
            this.slCol});
            this.tendgv.Location = new System.Drawing.Point(2, 37);
            this.tendgv.Name = "tendgv";
            this.tendgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tendgv.RowTemplate.Height = 24;
            this.tendgv.Size = new System.Drawing.Size(1253, 389);
            this.tendgv.TabIndex = 4;
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
            // findTenBut
            // 
            this.findTenBut.Location = new System.Drawing.Point(768, 8);
            this.findTenBut.Name = "findTenBut";
            this.findTenBut.Size = new System.Drawing.Size(165, 23);
            this.findTenBut.TabIndex = 3;
            this.findTenBut.Text = "Kiểm kho sản phẩm";
            this.findTenBut.UseVisualStyleBackColor = true;
            this.findTenBut.Click += new System.EventHandler(this.findTenBut_Click);
            // 
            // tenspText
            // 
            this.tenspText.Location = new System.Drawing.Point(376, 8);
            this.tenspText.Name = "tenspText";
            this.tenspText.Size = new System.Drawing.Size(367, 22);
            this.tenspText.TabIndex = 2;
            // 
            // adTab2
            // 
            this.adTab2.Controls.Add(this.seeDBut);
            this.adTab2.Controls.Add(this.rbDx);
            this.adTab2.Controls.Add(this.hddgv);
            this.adTab2.Controls.Add(this.rbDn);
            this.adTab2.Location = new System.Drawing.Point(4, 25);
            this.adTab2.Name = "adTab2";
            this.adTab2.Padding = new System.Windows.Forms.Padding(3);
            this.adTab2.Size = new System.Drawing.Size(1255, 426);
            this.adTab2.TabIndex = 1;
            this.adTab2.Text = "Xem đơn hàng";
            this.adTab2.UseVisualStyleBackColor = true;
            // 
            // seeDBut
            // 
            this.seeDBut.Location = new System.Drawing.Point(584, 36);
            this.seeDBut.Name = "seeDBut";
            this.seeDBut.Size = new System.Drawing.Size(128, 23);
            this.seeDBut.TabIndex = 4;
            this.seeDBut.Text = "Xem dánh sách";
            this.seeDBut.UseVisualStyleBackColor = true;
            this.seeDBut.Click += new System.EventHandler(this.seeDBut_Click);
            // 
            // rbDx
            // 
            this.rbDx.AutoSize = true;
            this.rbDx.Location = new System.Drawing.Point(710, 6);
            this.rbDx.Name = "rbDx";
            this.rbDx.Size = new System.Drawing.Size(113, 21);
            this.rbDx.TabIndex = 1;
            this.rbDx.TabStop = true;
            this.rbDx.Text = "Hóa đơn xuất";
            this.rbDx.UseVisualStyleBackColor = true;
            // 
            // hddgv
            // 
            this.hddgv.AllowUserToAddRows = false;
            this.hddgv.AllowUserToDeleteRows = false;
            this.hddgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hddgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madonCol,
            this.ngaylapCol,
            this.nccCol,
            this.khCol,
            this.sdtCol,
            this.cnCol,
            this.nvCol,
            this.ctvcCol,
            this.stateCol,
            this.ttCol});
            this.hddgv.Location = new System.Drawing.Point(-68, 65);
            this.hddgv.Name = "hddgv";
            this.hddgv.RowHeadersWidth = 51;
            this.hddgv.RowTemplate.Height = 24;
            this.hddgv.Size = new System.Drawing.Size(1323, 361);
            this.hddgv.TabIndex = 3;
            this.hddgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hddgv_CellClick);
            // 
            // rbDn
            // 
            this.rbDn.AutoSize = true;
            this.rbDn.Location = new System.Drawing.Point(464, 6);
            this.rbDn.Name = "rbDn";
            this.rbDn.Size = new System.Drawing.Size(119, 21);
            this.rbDn.TabIndex = 0;
            this.rbDn.TabStop = true;
            this.rbDn.Text = "Hóa đơn nhập";
            this.rbDn.UseVisualStyleBackColor = true;
            // 
            // madonCol
            // 
            this.madonCol.HeaderText = "Mã đơn";
            this.madonCol.MinimumWidth = 6;
            this.madonCol.Name = "madonCol";
            this.madonCol.ReadOnly = true;
            // 
            // ngaylapCol
            // 
            this.ngaylapCol.HeaderText = "Ngày lập đơn";
            this.ngaylapCol.MinimumWidth = 6;
            this.ngaylapCol.Name = "ngaylapCol";
            this.ngaylapCol.ReadOnly = true;
            // 
            // nccCol
            // 
            this.nccCol.HeaderText = "Nhà cung cấp";
            this.nccCol.MinimumWidth = 6;
            this.nccCol.Name = "nccCol";
            this.nccCol.ReadOnly = true;
            // 
            // khCol
            // 
            this.khCol.HeaderText = "Khách hàng";
            this.khCol.MinimumWidth = 6;
            this.khCol.Name = "khCol";
            this.khCol.ReadOnly = true;
            // 
            // sdtCol
            // 
            this.sdtCol.HeaderText = "SĐTKH";
            this.sdtCol.MinimumWidth = 6;
            this.sdtCol.Name = "sdtCol";
            this.sdtCol.ReadOnly = true;
            // 
            // cnCol
            // 
            this.cnCol.HeaderText = "Chi nhánh";
            this.cnCol.MinimumWidth = 6;
            this.cnCol.Name = "cnCol";
            this.cnCol.ReadOnly = true;
            // 
            // nvCol
            // 
            this.nvCol.HeaderText = "Nhân viên phụ trách";
            this.nvCol.MinimumWidth = 6;
            this.nvCol.Name = "nvCol";
            this.nvCol.ReadOnly = true;
            // 
            // ctvcCol
            // 
            this.ctvcCol.HeaderText = "CTVC";
            this.ctvcCol.MinimumWidth = 6;
            this.ctvcCol.Name = "ctvcCol";
            this.ctvcCol.ReadOnly = true;
            // 
            // stateCol
            // 
            this.stateCol.HeaderText = "Tình trạng";
            this.stateCol.MinimumWidth = 6;
            this.stateCol.Name = "stateCol";
            this.stateCol.ReadOnly = true;
            // 
            // ttCol
            // 
            this.ttCol.HeaderText = "Tổng tiền";
            this.ttCol.MinimumWidth = 6;
            this.ttCol.Name = "ttCol";
            this.ttCol.ReadOnly = true;
            // 
            // AdminFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1274, 497);
            this.MinimumSize = new System.Drawing.Size(1274, 497);
            this.Name = "AdminFunc";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.adTab1.ResumeLayout(false);
            this.adTab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tendgv)).EndInit();
            this.adTab2.ResumeLayout(false);
            this.adTab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hddgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage adTab1;
        private System.Windows.Forms.Button findTenBut;
        private System.Windows.Forms.TextBox tenspText;
        private System.Windows.Forms.TabPage adTab2;
        private System.Windows.Forms.DataGridView tendgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenspCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn slCol;
        private System.Windows.Forms.DataGridView hddgv;
        private System.Windows.Forms.RadioButton rbDx;
        private System.Windows.Forms.RadioButton rbDn;
        private System.Windows.Forms.Button seeDBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn madonCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nccCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn khCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctvcCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttCol;
    }
}