namespace PersedianBarang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblKode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblHargaBeli = new System.Windows.Forms.Label();
            this.lblHargaJual = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Location = new System.Drawing.Point(67, 107);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(46, 20);
            this.lblKode.TabIndex = 0;
            this.lblKode.Text = "Kode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(67, 164);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(107, 20);
            this.lblNamaBarang.TabIndex = 0;
            this.lblNamaBarang.Text = "Nama Barang";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(454, 27);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(229, 25);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Form Persediaan Barang";
            // 
            // lblHargaBeli
            // 
            this.lblHargaBeli.AutoSize = true;
            this.lblHargaBeli.Location = new System.Drawing.Point(424, 107);
            this.lblHargaBeli.Name = "lblHargaBeli";
            this.lblHargaBeli.Size = new System.Drawing.Size(83, 20);
            this.lblHargaBeli.TabIndex = 0;
            this.lblHargaBeli.Text = "Harga Beli";
            // 
            // lblHargaJual
            // 
            this.lblHargaJual.AutoSize = true;
            this.lblHargaJual.Location = new System.Drawing.Point(424, 164);
            this.lblHargaJual.Name = "lblHargaJual";
            this.lblHargaJual.Size = new System.Drawing.Size(86, 20);
            this.lblHargaJual.TabIndex = 0;
            this.lblHargaJual.Text = "Harga Jual";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(777, 110);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(42, 20);
            this.lblStok.TabIndex = 0;
            this.lblStok.Text = "Stok";
            // 
            // lblSatuan
            // 
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.Location = new System.Drawing.Point(777, 164);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(61, 20);
            this.lblSatuan.TabIndex = 2;
            this.lblSatuan.Text = "Satuan";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(194, 110);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(116, 26);
            this.txtKode.TabIndex = 3;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(194, 161);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(192, 26);
            this.txtNamaBarang.TabIndex = 3;
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Location = new System.Drawing.Point(546, 110);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(178, 26);
            this.txtHargaBeli.TabIndex = 3;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(546, 161);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(178, 26);
            this.txtHargaJual.TabIndex = 3;
            // 
            // txtStok
            // 
            this.txtStok.Enabled = false;
            this.txtStok.Location = new System.Drawing.Point(857, 110);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(87, 26);
            this.txtStok.TabIndex = 3;
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(857, 161);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(135, 26);
            this.txtSatuan.TabIndex = 3;
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBarang.Location = new System.Drawing.Point(16, 317);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersWidth = 62;
            this.dgvBarang.RowTemplate.Height = 28;
            this.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarang.Size = new System.Drawing.Size(1102, 314);
            this.dgvBarang.TabIndex = 5;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeBarang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Kode Barang";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaBarang";
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 273;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hargaBeli";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Harga Beli";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "hargaJual";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Harga Jual";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "stok";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Stok";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "satuan";
            this.Column6.HeaderText = "Satuan";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 90;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersedianBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(1016, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersedianBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(710, 246);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 60);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersedianBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(639, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 60);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersedianBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(710, 246);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 60);
            this.btnNew.TabIndex = 4;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PersedianBarang.Properties.Resources._09_Delete;
            this.btnDel.Location = new System.Drawing.Point(639, 246);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 60);
            this.btnDel.TabIndex = 4;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersedianBarang.Properties.Resources._08_Edit;
            this.btnEdit.Location = new System.Drawing.Point(568, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 60);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersedianBarang.Properties.Resources._06_Print;
            this.btnPrint.Location = new System.Drawing.Point(497, 246);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 60);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersedianBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(426, 246);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 60);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersedianBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(282, 246);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(65, 60);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersedianBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(211, 246);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 60);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersedianBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(140, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 60);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersedianBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(69, 246);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(65, 60);
            this.btnTop.TabIndex = 4;
            this.btnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 640);
            this.Controls.Add(this.dgvBarang);
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
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHargaJual);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblNamaBarang);
            this.Controls.Add(this.lblHargaJual);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblHargaBeli);
            this.Controls.Add(this.lblKode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHargaBeli;
        private System.Windows.Forms.Label lblHargaJual;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblSatuan;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

