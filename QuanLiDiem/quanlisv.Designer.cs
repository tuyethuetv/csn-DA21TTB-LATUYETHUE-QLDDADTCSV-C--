namespace QuanLiDiem
{
    partial class quanlisv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlisv));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtmasv = new Guna.UI.WinForms.GunaTextBox();
            this.txthoten = new Guna.UI.WinForms.GunaTextBox();
            this.txtlop = new Guna.UI.WinForms.GunaTextBox();
            this.txtnganhhoc = new Guna.UI.WinForms.GunaTextBox();
            this.dtngaysinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btxoa = new Guna.UI.WinForms.GunaButton();
            this.btthem = new Guna.UI.WinForms.GunaButton();
            this.btsua = new Guna.UI.WinForms.GunaButton();
            this.dgvquanlisv = new Guna.UI.WinForms.GunaDataGridView();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotensvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhsvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganhhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dACSNDataSet = new QuanLiDiem.DACSNDataSet();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.sinhvienTableAdapter = new QuanLiDiem.DACSNDataSetTableAdapters.sinhvienTableAdapter();
            this.txttimkiem = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlisv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(49, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(110, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Mã sinh viên";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.Location = new System.Drawing.Point(95, 129);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(64, 23);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Họ tên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(70, 206);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 23);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Ngày sinh";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(656, 50);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(41, 23);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Lớp";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel5.Location = new System.Drawing.Point(601, 129);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(96, 23);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Ngành học";
            // 
            // txtmasv
            // 
            this.txtmasv.BaseColor = System.Drawing.Color.White;
            this.txtmasv.BorderColor = System.Drawing.Color.Silver;
            this.txtmasv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmasv.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmasv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmasv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmasv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmasv.Location = new System.Drawing.Point(219, 50);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.PasswordChar = '\0';
            this.txtmasv.SelectedText = "";
            this.txtmasv.Size = new System.Drawing.Size(338, 32);
            this.txtmasv.TabIndex = 5;
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
            this.txthoten.Location = new System.Drawing.Point(219, 120);
            this.txthoten.Name = "txthoten";
            this.txthoten.PasswordChar = '\0';
            this.txthoten.SelectedText = "";
            this.txthoten.Size = new System.Drawing.Size(338, 32);
            this.txthoten.TabIndex = 7;
            // 
            // txtlop
            // 
            this.txtlop.BaseColor = System.Drawing.Color.White;
            this.txtlop.BorderColor = System.Drawing.Color.Silver;
            this.txtlop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlop.FocusedBaseColor = System.Drawing.Color.White;
            this.txtlop.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtlop.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtlop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtlop.Location = new System.Drawing.Point(759, 50);
            this.txtlop.Name = "txtlop";
            this.txtlop.PasswordChar = '\0';
            this.txtlop.SelectedText = "";
            this.txtlop.Size = new System.Drawing.Size(338, 32);
            this.txtlop.TabIndex = 8;
            // 
            // txtnganhhoc
            // 
            this.txtnganhhoc.BaseColor = System.Drawing.Color.White;
            this.txtnganhhoc.BorderColor = System.Drawing.Color.Silver;
            this.txtnganhhoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnganhhoc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnganhhoc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnganhhoc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnganhhoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnganhhoc.Location = new System.Drawing.Point(759, 129);
            this.txtnganhhoc.Name = "txtnganhhoc";
            this.txtnganhhoc.PasswordChar = '\0';
            this.txtnganhhoc.SelectedText = "";
            this.txtnganhhoc.Size = new System.Drawing.Size(338, 32);
            this.txtnganhhoc.TabIndex = 9;
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
            this.dtngaysinh.Location = new System.Drawing.Point(219, 198);
            this.dtngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtngaysinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngaysinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtngaysinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtngaysinh.Size = new System.Drawing.Size(338, 30);
            this.dtngaysinh.TabIndex = 10;
            this.dtngaysinh.Text = "28 Tháng Mười Hai 2023";
            this.dtngaysinh.Value = new System.DateTime(2023, 12, 28, 9, 31, 48, 673);
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
            this.btxoa.Location = new System.Drawing.Point(537, 274);
            this.btxoa.Name = "btxoa";
            this.btxoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btxoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btxoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btxoa.OnHoverImage = null;
            this.btxoa.OnPressedColor = System.Drawing.Color.Black;
            this.btxoa.Size = new System.Drawing.Size(160, 42);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
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
            this.btthem.Location = new System.Drawing.Point(219, 274);
            this.btthem.Name = "btthem";
            this.btthem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btthem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btthem.OnHoverForeColor = System.Drawing.Color.White;
            this.btthem.OnHoverImage = null;
            this.btthem.OnPressedColor = System.Drawing.Color.Black;
            this.btthem.Size = new System.Drawing.Size(160, 42);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
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
            this.btsua.Location = new System.Drawing.Point(891, 274);
            this.btsua.Name = "btsua";
            this.btsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsua.OnHoverForeColor = System.Drawing.Color.White;
            this.btsua.OnHoverImage = null;
            this.btsua.OnPressedColor = System.Drawing.Color.Black;
            this.btsua.Size = new System.Drawing.Size(160, 42);
            this.btsua.TabIndex = 13;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // dgvquanlisv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvquanlisv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvquanlisv.AutoGenerateColumns = false;
            this.dgvquanlisv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlisv.BackgroundColor = System.Drawing.Color.White;
            this.dgvquanlisv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvquanlisv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvquanlisv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvquanlisv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvquanlisv.ColumnHeadersHeight = 27;
            this.dgvquanlisv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotensvDataGridViewTextBoxColumn,
            this.ngaysinhsvDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.nganhhocDataGridViewTextBoxColumn});
            this.dgvquanlisv.DataSource = this.sinhvienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvquanlisv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvquanlisv.EnableHeadersVisualStyles = false;
            this.dgvquanlisv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvquanlisv.Location = new System.Drawing.Point(87, 351);
            this.dgvquanlisv.Name = "dgvquanlisv";
            this.dgvquanlisv.RowHeadersVisible = false;
            this.dgvquanlisv.RowHeadersWidth = 51;
            this.dgvquanlisv.RowTemplate.Height = 24;
            this.dgvquanlisv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvquanlisv.Size = new System.Drawing.Size(1041, 329);
            this.dgvquanlisv.TabIndex = 14;
            this.dgvquanlisv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvquanlisv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvquanlisv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvquanlisv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvquanlisv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvquanlisv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvquanlisv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvquanlisv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvquanlisv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvquanlisv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvquanlisv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvquanlisv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvquanlisv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvquanlisv.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvquanlisv.ThemeStyle.ReadOnly = false;
            this.dgvquanlisv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvquanlisv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvquanlisv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvquanlisv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvquanlisv.ThemeStyle.RowsStyle.Height = 24;
            this.dgvquanlisv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvquanlisv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvquanlisv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvquanlisv_CellContentClick);
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.masvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            // 
            // hotensvDataGridViewTextBoxColumn
            // 
            this.hotensvDataGridViewTextBoxColumn.DataPropertyName = "hotensv";
            this.hotensvDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hotensvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotensvDataGridViewTextBoxColumn.Name = "hotensvDataGridViewTextBoxColumn";
            // 
            // ngaysinhsvDataGridViewTextBoxColumn
            // 
            this.ngaysinhsvDataGridViewTextBoxColumn.DataPropertyName = "ngaysinhsv";
            this.ngaysinhsvDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhsvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhsvDataGridViewTextBoxColumn.Name = "ngaysinhsvDataGridViewTextBoxColumn";
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            // 
            // nganhhocDataGridViewTextBoxColumn
            // 
            this.nganhhocDataGridViewTextBoxColumn.DataPropertyName = "nganhhoc";
            this.nganhhocDataGridViewTextBoxColumn.HeaderText = "Ngành học";
            this.nganhhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nganhhocDataGridViewTextBoxColumn.Name = "nganhhocDataGridViewTextBoxColumn";
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.dACSNDataSet;
            // 
            // dACSNDataSet
            // 
            this.dACSNDataSet.DataSetName = "DACSNDataSet";
            this.dACSNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
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
            this.txttimkiem.Location = new System.Drawing.Point(759, 196);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(338, 32);
            this.txttimkiem.TabIndex = 28;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(611, 206);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel6.TabIndex = 34;
            this.gunaLabel6.Text = "Tìm kiếm";
            // 
            // quanlisv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvquanlisv);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.txtnganhhoc);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "quanlisv";
            this.Size = new System.Drawing.Size(1184, 738);
            this.Load += new System.EventHandler(this.quanlisv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlisv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtmasv;
        private Guna.UI.WinForms.GunaTextBox txthoten;
        private Guna.UI.WinForms.GunaTextBox txtlop;
        private Guna.UI.WinForms.GunaTextBox txtnganhhoc;
        private Guna.UI.WinForms.GunaDateTimePicker dtngaysinh;
        private Guna.UI.WinForms.GunaButton btxoa;
        private Guna.UI.WinForms.GunaButton btthem;
        private Guna.UI.WinForms.GunaButton btsua;
        private Guna.UI.WinForms.GunaDataGridView dgvquanlisv;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private DACSNDataSet dACSNDataSet;
        private DACSNDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotensvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhsvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganhhocDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaTextBox txttimkiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}
