namespace QuanLiDiem
{
    partial class quanligiangvien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanligiangvien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtmagv = new Guna.UI.WinForms.GunaTextBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.txthoten = new Guna.UI.WinForms.GunaTextBox();
            this.txtbomon = new Guna.UI.WinForms.GunaTextBox();
            this.txtkhoa = new Guna.UI.WinForms.GunaTextBox();
            this.dtngaysinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btthem = new Guna.UI.WinForms.GunaButton();
            this.btxoa = new Guna.UI.WinForms.GunaButton();
            this.btsua = new Guna.UI.WinForms.GunaButton();
            this.dgvgiangvien = new Guna.UI.WinForms.GunaDataGridView();
            this.magvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bomonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dACSNDataSet2 = new QuanLiDiem.DACSNDataSet2();
            this.giangvienTableAdapter = new QuanLiDiem.DACSNDataSet2TableAdapters.giangvienTableAdapter();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txttimkiem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiangvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(57, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(124, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mã giảng viên";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.Location = new System.Drawing.Point(57, 102);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Họ tên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(590, 35);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 23);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Ngày sinh";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(629, 102);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(50, 23);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Khoa";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(57, 163);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(72, 23);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Bộ môn";
            // 
            // txtmagv
            // 
            this.txtmagv.BaseColor = System.Drawing.Color.White;
            this.txtmagv.BorderColor = System.Drawing.Color.Silver;
            this.txtmagv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmagv.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmagv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmagv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmagv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmagv.Location = new System.Drawing.Point(231, 26);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.PasswordChar = '\0';
            this.txtmagv.SelectedText = "";
            this.txtmagv.Size = new System.Drawing.Size(269, 32);
            this.txtmagv.TabIndex = 5;
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txthoten
            // 
            this.txthoten.BaseColor = System.Drawing.Color.White;
            this.txthoten.BorderColor = System.Drawing.Color.Silver;
            this.txthoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthoten.FocusedBaseColor = System.Drawing.Color.White;
            this.txthoten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txthoten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txthoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthoten.Location = new System.Drawing.Point(231, 93);
            this.txthoten.Name = "txthoten";
            this.txthoten.PasswordChar = '\0';
            this.txthoten.SelectedText = "";
            this.txthoten.Size = new System.Drawing.Size(269, 32);
            this.txthoten.TabIndex = 7;
            // 
            // txtbomon
            // 
            this.txtbomon.BaseColor = System.Drawing.Color.White;
            this.txtbomon.BorderColor = System.Drawing.Color.Silver;
            this.txtbomon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbomon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbomon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbomon.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbomon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbomon.Location = new System.Drawing.Point(231, 154);
            this.txtbomon.Name = "txtbomon";
            this.txtbomon.PasswordChar = '\0';
            this.txtbomon.SelectedText = "";
            this.txtbomon.Size = new System.Drawing.Size(269, 32);
            this.txtbomon.TabIndex = 8;
            // 
            // txtkhoa
            // 
            this.txtkhoa.BaseColor = System.Drawing.Color.White;
            this.txtkhoa.BorderColor = System.Drawing.Color.Silver;
            this.txtkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkhoa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtkhoa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtkhoa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtkhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtkhoa.Location = new System.Drawing.Point(737, 93);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.PasswordChar = '\0';
            this.txtkhoa.SelectedText = "";
            this.txtkhoa.Size = new System.Drawing.Size(296, 32);
            this.txtkhoa.TabIndex = 9;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.BaseColor = System.Drawing.Color.White;
            this.dtngaysinh.BorderColor = System.Drawing.Color.Silver;
            this.dtngaysinh.CustomFormat = null;
            this.dtngaysinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtngaysinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtngaysinh.ForeColor = System.Drawing.Color.Black;
            this.dtngaysinh.Location = new System.Drawing.Point(737, 35);
            this.dtngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtngaysinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngaysinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngaysinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtngaysinh.Size = new System.Drawing.Size(296, 30);
            this.dtngaysinh.TabIndex = 10;
            this.dtngaysinh.Text = "28 Tháng Mười Hai 2023";
            this.dtngaysinh.Value = new System.DateTime(2023, 12, 28, 20, 25, 14, 268);
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(864, 35);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(30, 8);
            this.gunaDataGridView1.TabIndex = 11;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btthem
            // 
            this.btthem.AnimationHoverSpeed = 0.07F;
            this.btthem.AnimationSpeed = 0.03F;
            this.btthem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btthem.BorderColor = System.Drawing.Color.Black;
            this.btthem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btthem.FocusedColor = System.Drawing.Color.Empty;
            this.btthem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Image = ((System.Drawing.Image)(resources.GetObject("btthem.Image")));
            this.btthem.ImageSize = new System.Drawing.Size(20, 20);
            this.btthem.Location = new System.Drawing.Point(231, 224);
            this.btthem.Name = "btthem";
            this.btthem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btthem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btthem.OnHoverForeColor = System.Drawing.Color.White;
            this.btthem.OnHoverImage = null;
            this.btthem.OnPressedColor = System.Drawing.Color.Black;
            this.btthem.Size = new System.Drawing.Size(160, 42);
            this.btthem.TabIndex = 15;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.AnimationHoverSpeed = 0.07F;
            this.btxoa.AnimationSpeed = 0.03F;
            this.btxoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btxoa.BorderColor = System.Drawing.Color.Black;
            this.btxoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btxoa.FocusedColor = System.Drawing.Color.Empty;
            this.btxoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btxoa.ForeColor = System.Drawing.Color.White;
            this.btxoa.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.Image")));
            this.btxoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btxoa.Location = new System.Drawing.Point(536, 224);
            this.btxoa.Name = "btxoa";
            this.btxoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btxoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btxoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btxoa.OnHoverImage = null;
            this.btxoa.OnPressedColor = System.Drawing.Color.Black;
            this.btxoa.Size = new System.Drawing.Size(160, 42);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.AnimationHoverSpeed = 0.07F;
            this.btsua.AnimationSpeed = 0.03F;
            this.btsua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btsua.BorderColor = System.Drawing.Color.Black;
            this.btsua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btsua.FocusedColor = System.Drawing.Color.Empty;
            this.btsua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btsua.ForeColor = System.Drawing.Color.White;
            this.btsua.Image = ((System.Drawing.Image)(resources.GetObject("btsua.Image")));
            this.btsua.ImageSize = new System.Drawing.Size(20, 20);
            this.btsua.Location = new System.Drawing.Point(846, 224);
            this.btsua.Name = "btsua";
            this.btsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsua.OnHoverForeColor = System.Drawing.Color.White;
            this.btsua.OnHoverImage = null;
            this.btsua.OnPressedColor = System.Drawing.Color.Black;
            this.btsua.Size = new System.Drawing.Size(160, 42);
            this.btsua.TabIndex = 17;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // dgvgiangvien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgiangvien.AutoGenerateColumns = false;
            this.dgvgiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgiangvien.BackgroundColor = System.Drawing.Color.White;
            this.dgvgiangvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvgiangvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvgiangvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgiangvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvgiangvien.ColumnHeadersHeight = 27;
            this.dgvgiangvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.khoaDataGridViewTextBoxColumn,
            this.bomonDataGridViewTextBoxColumn});
            this.dgvgiangvien.DataSource = this.giangvienBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgiangvien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvgiangvien.EnableHeadersVisualStyles = false;
            this.dgvgiangvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.Location = new System.Drawing.Point(61, 324);
            this.dgvgiangvien.Name = "dgvgiangvien";
            this.dgvgiangvien.RowHeadersVisible = false;
            this.dgvgiangvien.RowHeadersWidth = 51;
            this.dgvgiangvien.RowTemplate.Height = 24;
            this.dgvgiangvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgiangvien.Size = new System.Drawing.Size(1041, 372);
            this.dgvgiangvien.TabIndex = 18;
            this.dgvgiangvien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvgiangvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvgiangvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvgiangvien.ThemeStyle.ReadOnly = false;
            this.dgvgiangvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvgiangvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvgiangvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvgiangvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvgiangvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvgiangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView2_CellContentClick);
            // 
            // magvDataGridViewTextBoxColumn
            // 
            this.magvDataGridViewTextBoxColumn.DataPropertyName = "magv";
            this.magvDataGridViewTextBoxColumn.HeaderText = "Mã giảng viên";
            this.magvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.magvDataGridViewTextBoxColumn.Name = "magvDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // khoaDataGridViewTextBoxColumn
            // 
            this.khoaDataGridViewTextBoxColumn.DataPropertyName = "khoa";
            this.khoaDataGridViewTextBoxColumn.HeaderText = "Khoa";
            this.khoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoaDataGridViewTextBoxColumn.Name = "khoaDataGridViewTextBoxColumn";
            // 
            // bomonDataGridViewTextBoxColumn
            // 
            this.bomonDataGridViewTextBoxColumn.DataPropertyName = "bomon";
            this.bomonDataGridViewTextBoxColumn.HeaderText = "Bộ môn";
            this.bomonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bomonDataGridViewTextBoxColumn.Name = "bomonDataGridViewTextBoxColumn";
            // 
            // giangvienBindingSource
            // 
            this.giangvienBindingSource.DataMember = "giangvien";
            this.giangvienBindingSource.DataSource = this.dACSNDataSet2;
            // 
            // dACSNDataSet2
            // 
            this.dACSNDataSet2.DataSetName = "DACSNDataSet2";
            this.dACSNDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangvienTableAdapter
            // 
            this.giangvienTableAdapter.ClearBeforeFill = true;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txttimkiem
            // 
            this.txttimkiem.BaseColor = System.Drawing.Color.White;
            this.txttimkiem.BorderColor = System.Drawing.Color.Silver;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.FocusedBaseColor = System.Drawing.Color.White;
            this.txttimkiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttimkiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiem.Location = new System.Drawing.Point(737, 154);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(296, 32);
            this.txttimkiem.TabIndex = 32;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(610, 163);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel6.TabIndex = 33;
            this.gunaLabel6.Text = "Tìm kiếm";
            // 
            // quanligiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvgiangvien);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.txtbomon);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "quanligiangvien";
            this.Size = new System.Drawing.Size(1184, 738);
            this.Load += new System.EventHandler(this.quanligiangvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiangvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtmagv;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private Guna.UI.WinForms.GunaTextBox txthoten;
        private Guna.UI.WinForms.GunaTextBox txtbomon;
        private Guna.UI.WinForms.GunaTextBox txtkhoa;
        private Guna.UI.WinForms.GunaDateTimePicker dtngaysinh;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaButton btthem;
        private Guna.UI.WinForms.GunaButton btxoa;
        private Guna.UI.WinForms.GunaButton btsua;
        private Guna.UI.WinForms.GunaDataGridView dgvgiangvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn magvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bomonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giangvienBindingSource;
        private DACSNDataSet2 dACSNDataSet2;
        private DACSNDataSet2TableAdapters.giangvienTableAdapter giangvienTableAdapter;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txttimkiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}
