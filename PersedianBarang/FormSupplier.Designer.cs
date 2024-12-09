namespace PersedianBarang
{
    partial class FormSupplier
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
            this.kodeSupplier = new System.Windows.Forms.Label();
            this.namaSupplier = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.telepon = new System.Windows.Forms.Label();
            this.kota = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTlp = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeSupplier
            // 
            this.kodeSupplier.AutoSize = true;
            this.kodeSupplier.Location = new System.Drawing.Point(33, 44);
            this.kodeSupplier.Name = "kodeSupplier";
            this.kodeSupplier.Size = new System.Drawing.Size(108, 20);
            this.kodeSupplier.TabIndex = 0;
            this.kodeSupplier.Text = "Kode Supplier";
            // 
            // namaSupplier
            // 
            this.namaSupplier.AutoSize = true;
            this.namaSupplier.Location = new System.Drawing.Point(33, 82);
            this.namaSupplier.Name = "namaSupplier";
            this.namaSupplier.Size = new System.Drawing.Size(113, 20);
            this.namaSupplier.TabIndex = 1;
            this.namaSupplier.Text = "Nama Supplier";
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Location = new System.Drawing.Point(33, 121);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(59, 20);
            this.alamat.TabIndex = 2;
            this.alamat.Text = "Alamat";
            // 
            // telepon
            // 
            this.telepon.AutoSize = true;
            this.telepon.Location = new System.Drawing.Point(761, 82);
            this.telepon.Name = "telepon";
            this.telepon.Size = new System.Drawing.Size(57, 20);
            this.telepon.TabIndex = 3;
            this.telepon.Text = "Telpon";
            // 
            // kota
            // 
            this.kota.AutoSize = true;
            this.kota.Location = new System.Drawing.Point(761, 121);
            this.kota.Name = "kota";
            this.kota.Size = new System.Drawing.Size(42, 20);
            this.kota.TabIndex = 4;
            this.kota.Text = "Kota";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(167, 44);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(44, 26);
            this.txtKode.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(167, 82);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(459, 26);
            this.txtNama.TabIndex = 6;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(167, 121);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(562, 26);
            this.txtAlamat.TabIndex = 7;
            // 
            // txtTlp
            // 
            this.txtTlp.Location = new System.Drawing.Point(833, 79);
            this.txtTlp.Name = "txtTlp";
            this.txtTlp.Size = new System.Drawing.Size(130, 26);
            this.txtTlp.TabIndex = 8;
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(833, 121);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(205, 26);
            this.txtKota.TabIndex = 9;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSupplier.Location = new System.Drawing.Point(37, 281);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(1001, 349);
            this.dgvSupplier.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeSupplier";
            this.Column1.HeaderText = "Kode Supplier";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namaSupplier";
            this.Column2.HeaderText = "Nama Supplier";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "alamat";
            this.Column3.HeaderText = "Alamat";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "telepon";
            this.Column4.HeaderText = "Telpon";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "kota";
            this.Column5.HeaderText = "Kota";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 95;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersedianBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(973, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 60);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersedianBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(679, 200);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 60);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersedianBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(608, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 60);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersedianBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(679, 200);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 60);
            this.btnNew.TabIndex = 14;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::PersedianBarang.Properties.Resources._09_Delete;
            this.btnDel.Location = new System.Drawing.Point(608, 200);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 60);
            this.btnDel.TabIndex = 15;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersedianBarang.Properties.Resources._08_Edit;
            this.btnEdit.Location = new System.Drawing.Point(537, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 60);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersedianBarang.Properties.Resources._06_Print;
            this.btnPrint.Location = new System.Drawing.Point(466, 200);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 60);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersedianBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(395, 200);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 60);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersedianBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(251, 200);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(65, 60);
            this.btnEnd.TabIndex = 19;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersedianBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(180, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 60);
            this.btnNext.TabIndex = 20;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersedianBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(109, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 60);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersedianBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(38, 200);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(65, 60);
            this.btnTop.TabIndex = 22;
            this.btnTop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 663);
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
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtTlp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.kota);
            this.Controls.Add(this.telepon);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.namaSupplier);
            this.Controls.Add(this.kodeSupplier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kodeSupplier;
        private System.Windows.Forms.Label namaSupplier;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.Label telepon;
        private System.Windows.Forms.Label kota;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTlp;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.DataGridView dgvSupplier;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}