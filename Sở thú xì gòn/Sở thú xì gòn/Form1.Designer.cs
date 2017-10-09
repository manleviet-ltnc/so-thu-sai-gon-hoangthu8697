namespace Sở_thú_xì_gòn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstThuMoi = new System.Windows.Forms.ListBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh Sách Thú";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lstThuMoi
            // 
            this.lstThuMoi.AllowDrop = true;
            this.lstThuMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstThuMoi.FormattingEnabled = true;
            this.lstThuMoi.Location = new System.Drawing.Point(3, 16);
            this.lstThuMoi.Name = "lstThuMoi";
            this.lstThuMoi.Size = new System.Drawing.Size(128, 135);
            this.lstThuMoi.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstThuMoi, "Ấn chuột và kéo sang Danh Sách");
            this.lstThuMoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.LB_DragEnter);
            this.lstThuMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_MouseDown);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.AllowDrop = true;
            this.lstDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(137, 16);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(129, 135);
            this.lstDanhSach.TabIndex = 1;
            this.lstDanhSach.DragDrop += new System.Windows.Forms.DragEventHandler(this.LB_DragDrop);
            this.lstDanhSach.DragEnter += new System.Windows.Forms.DragEventHandler(this.LB_DragEnter);
            this.lstDanhSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_MouseDown);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(231, 187);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(35, 22);
            this.btnLuu.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnLuu, "Lưu vào File danhsach.txt");
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.Luu);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstDanhSach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstThuMoi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 212);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTime, 2);
            this.lblTime.Location = new System.Drawing.Point(3, 154);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Bây giờ là...ngày...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuLuu,
            this.toolStripSeparator1,
            this.mnuKetThuc});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(153, 22);
            this.mnuLoad.Text = "Tải Danh Sách";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuLuu
            // 
            this.mnuLuu.Image = ((System.Drawing.Image)(resources.GetObject("mnuLuu.Image")));
            this.mnuLuu.Name = "mnuLuu";
            this.mnuLuu.Size = new System.Drawing.Size(153, 22);
            this.mnuLuu.Text = "Lưu Danh Sách";
            this.mnuLuu.Click += new System.EventHandler(this.Luu);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(153, 22);
            this.mnuKetThuc.Text = "Kết Thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem,
            this.saoToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa Đổi";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cắtToolStripMenuItem.Text = "Sao";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dánToolStripMenuItem.Text = "Cắt";
            // 
            // saoToolStripMenuItem
            // 
            this.saoToolStripMenuItem.Name = "saoToolStripMenuItem";
            this.saoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.saoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saoToolStripMenuItem.Text = "Dán";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Editing-Delete-icon.png");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(100, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 22);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.delete);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(285, 274);
            this.Name = "Form1";
            this.Text = "Sở thú xì gòn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstThuMoi;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

