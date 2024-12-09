namespace PersedianBarang
{
    partial class FormNotaBeli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotaBeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTgl = new System.Windows.Forms.TextBox();
            this.dgvNotaBeli = new System.Windows.Forms.DataGridView();
            this.idItemNotaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNotaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.GbSupplier = new System.Windows.Forms.GroupBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaBeli)).BeginInit();
            this.GbSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Nota Beli";
            // 
            // txtNotaBeli
            // 
            this.txtNotaBeli.Enabled = false;
            this.txtNotaBeli.Location = new System.Drawing.Point(155, 36);
            this.txtNotaBeli.Name = "txtNotaBeli";
            this.txtNotaBeli.Size = new System.Drawing.Size(118, 26);
            this.txtNotaBeli.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal";
            // 
            // txtTgl
            // 
            this.txtTgl.Enabled = false;
            this.txtTgl.Location = new System.Drawing.Point(770, 36);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.Size = new System.Drawing.Size(214, 26);
            this.txtTgl.TabIndex = 15;
            // 
            // dgvNotaBeli
            // 
            this.dgvNotaBeli.AllowUserToAddRows = false;
            this.dgvNotaBeli.AllowUserToDeleteRows = false;
            this.dgvNotaBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaBeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemNotaBeli,
            this.noNotaBeli,
            this.kodeBarang,
            this.namaBarang,
            this.qty,
            this.harga,
            this.jumlah});
            this.dgvNotaBeli.Location = new System.Drawing.Point(25, 238);
            this.dgvNotaBeli.Name = "dgvNotaBeli";
            this.dgvNotaBeli.ReadOnly = true;
            this.dgvNotaBeli.RowHeadersWidth = 62;
            this.dgvNotaBeli.RowTemplate.Height = 28;
            this.dgvNotaBeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotaBeli.Size = new System.Drawing.Size(959, 258);
            this.dgvNotaBeli.TabIndex = 16;
            this.dgvNotaBeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvNotaBeli_KeyDown);
            // 
            // idItemNotaBeli
            // 
            this.idItemNotaBeli.DataPropertyName = "idItemNotaBeli";
            this.idItemNotaBeli.HeaderText = "idItemNotaBeli";
            this.idItemNotaBeli.MinimumWidth = 8;
            this.idItemNotaBeli.Name = "idItemNotaBeli";
            this.idItemNotaBeli.ReadOnly = true;
            this.idItemNotaBeli.Visible = false;
            this.idItemNotaBeli.Width = 150;
            // 
            // noNotaBeli
            // 
            this.noNotaBeli.DataPropertyName = "noNotaBeli";
            this.noNotaBeli.HeaderText = "noNotaBeli";
            this.noNotaBeli.MinimumWidth = 8;
            this.noNotaBeli.Name = "noNotaBeli";
            this.noNotaBeli.ReadOnly = true;
            this.noNotaBeli.Visible = false;
            this.noNotaBeli.Width = 150;
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "kodeBarang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kodeBarang.DefaultCellStyle = dataGridViewCellStyle1;
            this.kodeBarang.HeaderText = "Kode Barang";
            this.kodeBarang.MinimumWidth = 8;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.ReadOnly = true;
            this.kodeBarang.Width = 50;
            // 
            // namaBarang
            // 
            this.namaBarang.DataPropertyName = "namaBarang";
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.MinimumWidth = 8;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.Width = 250;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 40;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.harga.DefaultCellStyle = dataGridViewCellStyle3;
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Width = 108;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle4;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 8;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(695, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Rp";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(770, 510);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 26);
            this.txtTotal.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersedianBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(919, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 60);
            this.btnClose.TabIndex = 23;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersedianBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(640, 565);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 60);
            this.btnUndo.TabIndex = 24;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersedianBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(569, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 60);
            this.btnSave.TabIndex = 25;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersedianBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(640, 565);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 60);
            this.btnNew.TabIndex = 26;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PersedianBarang.Properties.Resources._09_Delete;
            this.btnDel.Location = new System.Drawing.Point(569, 565);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 60);
            this.btnDel.TabIndex = 27;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersedianBarang.Properties.Resources._08_Edit;
            this.btnEdit.Location = new System.Drawing.Point(498, 565);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 60);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersedianBarang.Properties.Resources._06_Print;
            this.btnPrint.Location = new System.Drawing.Point(427, 565);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 60);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersedianBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(356, 565);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 60);
            this.btnFind.TabIndex = 30;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersedianBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(238, 565);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(65, 60);
            this.btnEnd.TabIndex = 31;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersedianBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(167, 565);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 60);
            this.btnNext.TabIndex = 32;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersedianBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(96, 565);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 60);
            this.btnBack.TabIndex = 33;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersedianBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(25, 565);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(65, 60);
            this.btnTop.TabIndex = 34;
            this.btnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kode Supplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nama Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Alamat";
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Enabled = false;
            this.txtKodeSupplier.Location = new System.Drawing.Point(135, 44);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.Size = new System.Drawing.Size(54, 26);
            this.txtKodeSupplier.TabIndex = 15;
            this.txtKodeSupplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeSupplier_KeyUp);
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Enabled = false;
            this.txtNamaSupplier.Location = new System.Drawing.Point(135, 79);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(292, 26);
            this.txtNamaSupplier.TabIndex = 15;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(135, 113);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(457, 26);
            this.txtAlamat.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(643, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kota";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(643, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telepon";
            // 
            // txtKota
            // 
            this.txtKota.Enabled = false;
            this.txtKota.Location = new System.Drawing.Point(726, 79);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(238, 26);
            this.txtKota.TabIndex = 15;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Enabled = false;
            this.txtTelepon.Location = new System.Drawing.Point(726, 116);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(118, 26);
            this.txtTelepon.TabIndex = 15;
            // 
            // GbSupplier
            // 
            this.GbSupplier.Controls.Add(this.txtTelepon);
            this.GbSupplier.Controls.Add(this.txtKota);
            this.GbSupplier.Controls.Add(this.label13);
            this.GbSupplier.Controls.Add(this.label12);
            this.GbSupplier.Controls.Add(this.txtAlamat);
            this.GbSupplier.Controls.Add(this.txtNamaSupplier);
            this.GbSupplier.Controls.Add(this.txtKodeSupplier);
            this.GbSupplier.Controls.Add(this.label11);
            this.GbSupplier.Controls.Add(this.label10);
            this.GbSupplier.Controls.Add(this.label9);
            this.GbSupplier.Location = new System.Drawing.Point(20, 79);
            this.GbSupplier.Name = "GbSupplier";
            this.GbSupplier.Size = new System.Drawing.Size(973, 153);
            this.GbSupplier.TabIndex = 38;
            this.GbSupplier.TabStop = false;
            this.GbSupplier.Text = "Supplier :";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(25, 275);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(109, 30);
            this.txtKodeBarang.TabIndex = 39;
            this.txtKodeBarang.TextChanged += new System.EventHandler(this.txtKodeBarang_TextChanged);
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(140, 275);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(441, 30);
            this.txtNamaBarang.TabIndex = 40;
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(587, 275);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(53, 30);
            this.txtQty.TabIndex = 41;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(646, 275);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(149, 30);
            this.txtHarga.TabIndex = 42;
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHarga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHarga_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Harga";
            // 
            // FormNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 658);
            this.Controls.Add(this.dgvNotaBeli);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.GbSupplier);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTgl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaBeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotaBeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotaBeli";
            this.Load += new System.EventHandler(this.FormNotaBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaBeli)).EndInit();
            this.GbSupplier.ResumeLayout(false);
            this.GbSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotaBeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTgl;
        private System.Windows.Forms.DataGridView dgvNotaBeli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKodeSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.GroupBox GbSupplier;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemNotaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNotaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
    }
}