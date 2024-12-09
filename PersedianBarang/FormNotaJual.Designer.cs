namespace PersedianBarang
{
    partial class FormNotaJual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetailJual = new System.Windows.Forms.DataGridView();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTgl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotaJual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idItemNotaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNotaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailJual
            // 
            this.dgvDetailJual.AllowUserToAddRows = false;
            this.dgvDetailJual.AllowUserToDeleteRows = false;
            this.dgvDetailJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailJual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemNotaBeli,
            this.noNotaBeli,
            this.kodeBarang,
            this.namaBarang,
            this.qty,
            this.harga,
            this.jumlah});
            this.dgvDetailJual.Location = new System.Drawing.Point(26, 145);
            this.dgvDetailJual.Name = "dgvDetailJual";
            this.dgvDetailJual.ReadOnly = true;
            this.dgvDetailJual.RowHeadersWidth = 62;
            this.dgvDetailJual.RowTemplate.Height = 28;
            this.dgvDetailJual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailJual.Size = new System.Drawing.Size(959, 340);
            this.dgvDetailJual.TabIndex = 51;
            this.dgvDetailJual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDetailJual_KeyUp);
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeBarang.Enabled = false;
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(156, 78);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(829, 41);
            this.txtKodeBarang.TabIndex = 67;
            this.txtKodeBarang.TextChanged += new System.EventHandler(this.txtKodeBarang_TextChanged);
            this.txtKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeBarang_KeyUp);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersedianBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(920, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 60);
            this.btnClose.TabIndex = 54;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersedianBarang.Properties.Resources._06_Print;
            this.btnPrint.Location = new System.Drawing.Point(428, 554);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 60);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersedianBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(357, 554);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 60);
            this.btnFind.TabIndex = 61;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersedianBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(641, 554);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 60);
            this.btnUndo.TabIndex = 55;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersedianBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(570, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 60);
            this.btnSave.TabIndex = 56;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersedianBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(641, 554);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 60);
            this.btnNew.TabIndex = 57;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PersedianBarang.Properties.Resources._09_Delete;
            this.btnDel.Location = new System.Drawing.Point(570, 554);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 60);
            this.btnDel.TabIndex = 58;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersedianBarang.Properties.Resources._08_Edit;
            this.btnEdit.Location = new System.Drawing.Point(499, 554);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 60);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersedianBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(239, 554);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(65, 60);
            this.btnEnd.TabIndex = 62;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersedianBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(168, 554);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 60);
            this.btnNext.TabIndex = 63;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersedianBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(97, 554);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 60);
            this.btnBack.TabIndex = 64;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersedianBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(26, 554);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(65, 60);
            this.btnTop.TabIndex = 65;
            this.btnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(771, 499);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 26);
            this.txtTotal.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(696, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total Rp";
            // 
            // txtTgl
            // 
            this.txtTgl.Enabled = false;
            this.txtTgl.Location = new System.Drawing.Point(771, 25);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.Size = new System.Drawing.Size(214, 26);
            this.txtTgl.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tanggal";
            // 
            // txtNotaJual
            // 
            this.txtNotaJual.Enabled = false;
            this.txtNotaJual.Location = new System.Drawing.Point(156, 25);
            this.txtNotaJual.Name = "txtNotaJual";
            this.txtNotaJual.Size = new System.Drawing.Size(118, 26);
            this.txtNotaJual.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "No. Nota Jual";
            // 
            // idItemNotaBeli
            // 
            this.idItemNotaBeli.DataPropertyName = "idItemNotaJual";
            this.idItemNotaBeli.HeaderText = "idItemNotaJual";
            this.idItemNotaBeli.MinimumWidth = 8;
            this.idItemNotaBeli.Name = "idItemNotaBeli";
            this.idItemNotaBeli.ReadOnly = true;
            this.idItemNotaBeli.Visible = false;
            this.idItemNotaBeli.Width = 150;
            // 
            // noNotaBeli
            // 
            this.noNotaBeli.DataPropertyName = "noNotaJual";
            this.noNotaBeli.HeaderText = "noNotaJual";
            this.noNotaBeli.MinimumWidth = 8;
            this.noNotaBeli.Name = "noNotaBeli";
            this.noNotaBeli.ReadOnly = true;
            this.noNotaBeli.Visible = false;
            this.noNotaBeli.Width = 150;
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "kodeBarang";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kodeBarang.DefaultCellStyle = dataGridViewCellStyle29;
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
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle30;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 40;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Format = "N0";
            dataGridViewCellStyle31.NullValue = null;
            this.harga.DefaultCellStyle = dataGridViewCellStyle31;
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Width = 108;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle32.Format = "N0";
            dataGridViewCellStyle32.NullValue = null;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle32;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 8;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Kode Barang";
            // 
            // FormNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 633);
            this.Controls.Add(this.dgvDetailJual);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTgl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaJual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotaJual";
            this.Text = "Form Nota Penjualan";
            this.Load += new System.EventHandler(this.FormNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailJual;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTgl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotaJual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemNotaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNotaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.Label label2;
    }
}