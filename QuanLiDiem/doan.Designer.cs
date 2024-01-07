namespace QuanLiDiem
{
    partial class doan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doan));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.dgvbangdoan = new Guna.UI.WinForms.GunaDataGridView();
            this.madaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dACSNDataSet4 = new QuanLiDiem.DACSNDataSet4();
            this.doanTableAdapter = new QuanLiDiem.DACSNDataSet4TableAdapters.doanTableAdapter();
            this.txtmada = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txttenda = new Guna.UI.WinForms.GunaTextBox();
            this.txtmota = new Guna.UI.WinForms.GunaTextBox();
            this.cbmagv = new Guna.UI.WinForms.GunaComboBox();
            this.btthem = new Guna.UI.WinForms.GunaButton();
            this.btxoa = new Guna.UI.WinForms.GunaButton();
            this.btsua = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txttimkiem = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangdoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // dgvbangdoan
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvbangdoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvbangdoan.AutoGenerateColumns = false;
            this.dgvbangdoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbangdoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvbangdoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvbangdoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvbangdoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbangdoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvbangdoan.ColumnHeadersHeight = 27;
            this.dgvbangdoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madaDataGridViewTextBoxColumn,
            this.tendaDataGridViewTextBoxColumn,
            this.motaDataGridViewTextBoxColumn,
            this.magvDataGridViewTextBoxColumn});
            this.dgvbangdoan.DataSource = this.doanBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbangdoan.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvbangdoan.EnableHeadersVisualStyles = false;
            this.dgvbangdoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvbangdoan.Location = new System.Drawing.Point(99, 328);
            this.dgvbangdoan.Name = "dgvbangdoan";
            this.dgvbangdoan.RowHeadersVisible = false;
            this.dgvbangdoan.RowHeadersWidth = 51;
            this.dgvbangdoan.RowTemplate.Height = 24;
            this.dgvbangdoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbangdoan.Size = new System.Drawing.Size(998, 361);
            this.dgvbangdoan.TabIndex = 0;
            this.dgvbangdoan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvbangdoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvbangdoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvbangdoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvbangdoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvbangdoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvbangdoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvbangdoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvbangdoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvbangdoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvbangdoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvbangdoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvbangdoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvbangdoan.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvbangdoan.ThemeStyle.ReadOnly = false;
            this.dgvbangdoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvbangdoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvbangdoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvbangdoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvbangdoan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvbangdoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvbangdoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvbangdoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbangdoan_CellContentClick);
            // 
            // madaDataGridViewTextBoxColumn
            // 
            this.madaDataGridViewTextBoxColumn.DataPropertyName = "mada";
            this.madaDataGridViewTextBoxColumn.HeaderText = "Mã đồ án";
            this.madaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.madaDataGridViewTextBoxColumn.Name = "madaDataGridViewTextBoxColumn";
            // 
            // tendaDataGridViewTextBoxColumn
            // 
            this.tendaDataGridViewTextBoxColumn.DataPropertyName = "tenda";
            this.tendaDataGridViewTextBoxColumn.HeaderText = "Tên đồ án";
            this.tendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tendaDataGridViewTextBoxColumn.Name = "tendaDataGridViewTextBoxColumn";
            // 
            // motaDataGridViewTextBoxColumn
            // 
            this.motaDataGridViewTextBoxColumn.DataPropertyName = "mota";
            this.motaDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.motaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motaDataGridViewTextBoxColumn.Name = "motaDataGridViewTextBoxColumn";
            // 
            // magvDataGridViewTextBoxColumn
            // 
            this.magvDataGridViewTextBoxColumn.DataPropertyName = "magv";
            this.magvDataGridViewTextBoxColumn.HeaderText = "Mã giảng viên";
            this.magvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.magvDataGridViewTextBoxColumn.Name = "magvDataGridViewTextBoxColumn";
            // 
            // doanBindingSource
            // 
            this.doanBindingSource.DataMember = "doan";
            this.doanBindingSource.DataSource = this.dACSNDataSet4;
            // 
            // dACSNDataSet4
            // 
            this.dACSNDataSet4.DataSetName = "DACSNDataSet4";
            this.dACSNDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doanTableAdapter
            // 
            this.doanTableAdapter.ClearBeforeFill = true;
            // 
            // txtmada
            // 
            this.txtmada.BaseColor = System.Drawing.Color.White;
            this.txtmada.BorderColor = System.Drawing.Color.Silver;
            this.txtmada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmada.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmada.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmada.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmada.Location = new System.Drawing.Point(238, 41);
            this.txtmada.Name = "txtmada";
            this.txtmada.PasswordChar = '\0';
            this.txtmada.SelectedText = "";
            this.txtmada.Size = new System.Drawing.Size(331, 32);
            this.txtmada.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.Location = new System.Drawing.Point(95, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Mã đồ án";
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel2.Location = new System.Drawing.Point(95, 117);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(87, 23);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Tên đồ án";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel3.Location = new System.Drawing.Point(95, 179);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(57, 23);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Mô tả";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel4.Location = new System.Drawing.Point(624, 50);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(124, 23);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Mã giảng viên";
            // 
            // txttenda
            // 
            this.txttenda.BaseColor = System.Drawing.Color.White;
            this.txttenda.BorderColor = System.Drawing.Color.Silver;
            this.txttenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenda.FocusedBaseColor = System.Drawing.Color.White;
            this.txttenda.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttenda.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenda.Location = new System.Drawing.Point(238, 108);
            this.txttenda.Name = "txttenda";
            this.txttenda.PasswordChar = '\0';
            this.txttenda.SelectedText = "";
            this.txttenda.Size = new System.Drawing.Size(859, 32);
            this.txttenda.TabIndex = 7;
            // 
            // txtmota
            // 
            this.txtmota.BaseColor = System.Drawing.Color.White;
            this.txtmota.BorderColor = System.Drawing.Color.Silver;
            this.txtmota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmota.FocusedBaseColor = System.Drawing.Color.White;
            this.txtmota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtmota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtmota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmota.Location = new System.Drawing.Point(238, 170);
            this.txtmota.Name = "txtmota";
            this.txtmota.PasswordChar = '\0';
            this.txtmota.SelectedText = "";
            this.txtmota.Size = new System.Drawing.Size(859, 32);
            this.txtmota.TabIndex = 8;
            // 
            // cbmagv
            // 
            this.cbmagv.BackColor = System.Drawing.Color.Transparent;
            this.cbmagv.BaseColor = System.Drawing.Color.White;
            this.cbmagv.BorderColor = System.Drawing.Color.Silver;
            this.cbmagv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmagv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmagv.FocusedColor = System.Drawing.Color.Empty;
            this.cbmagv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmagv.ForeColor = System.Drawing.Color.Black;
            this.cbmagv.FormattingEnabled = true;
            this.cbmagv.Items.AddRange(new object[] {
            "gv1",
            "gv2",
            "gv3",
            "gv4",
            "gv5"});
            this.cbmagv.Location = new System.Drawing.Point(776, 42);
            this.cbmagv.Name = "cbmagv";
            this.cbmagv.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbmagv.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbmagv.Size = new System.Drawing.Size(321, 31);
            this.cbmagv.TabIndex = 9;
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
            this.btthem.Location = new System.Drawing.Point(605, 247);
            this.btthem.Name = "btthem";
            this.btthem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btthem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btthem.OnHoverForeColor = System.Drawing.Color.White;
            this.btthem.OnHoverImage = null;
            this.btthem.OnPressedColor = System.Drawing.Color.Black;
            this.btthem.Size = new System.Drawing.Size(160, 42);
            this.btthem.TabIndex = 17;
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
            this.btxoa.Location = new System.Drawing.Point(771, 247);
            this.btxoa.Name = "btxoa";
            this.btxoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btxoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btxoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btxoa.OnHoverImage = null;
            this.btxoa.OnPressedColor = System.Drawing.Color.Black;
            this.btxoa.Size = new System.Drawing.Size(160, 42);
            this.btxoa.TabIndex = 18;
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
            this.btsua.Location = new System.Drawing.Point(937, 247);
            this.btsua.Name = "btsua";
            this.btsua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btsua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btsua.OnHoverForeColor = System.Drawing.Color.White;
            this.btsua.OnHoverImage = null;
            this.btsua.OnPressedColor = System.Drawing.Color.Black;
            this.btsua.Size = new System.Drawing.Size(160, 42);
            this.btsua.TabIndex = 19;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.Location = new System.Drawing.Point(94, 257);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(86, 23);
            this.gunaLabel6.TabIndex = 35;
            this.gunaLabel6.Text = "Tìm kiếm";
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
            this.txttimkiem.Location = new System.Drawing.Point(238, 248);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(296, 32);
            this.txttimkiem.TabIndex = 36;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // doan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbmagv);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txttenda);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtmada);
            this.Controls.Add(this.dgvbangdoan);
            this.Name = "doan";
            this.Size = new System.Drawing.Size(1184, 738);
            this.Load += new System.EventHandler(this.doan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbangdoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dACSNDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView dgvbangdoan;
        private System.Windows.Forms.BindingSource doanBindingSource;
        private DACSNDataSet4 dACSNDataSet4;
        private DACSNDataSet4TableAdapters.doanTableAdapter doanTableAdapter;
        private Guna.UI.WinForms.GunaTextBox txtmota;
        private Guna.UI.WinForms.GunaTextBox txttenda;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtmada;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private Guna.UI.WinForms.GunaComboBox cbmagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magvDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton btthem;
        private Guna.UI.WinForms.GunaButton btxoa;
        private Guna.UI.WinForms.GunaButton btsua;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txttimkiem;
    }
}
