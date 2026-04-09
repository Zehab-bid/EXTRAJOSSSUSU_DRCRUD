namespace CRUDMahasiswaADO
{
    partial class FormMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(158, 19);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(315, 22);
            this.txtNIM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(158, 47);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(315, 22);
            this.txtNama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jenis Kelamin";
            // 
            // cmbJK
            // 
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJK.Location = new System.Drawing.Point(158, 75);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(315, 24);
            this.cmbJK.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(158, 105);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(315, 22);
            this.dtpTanggalLahir.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alamat";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(158, 133);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(315, 45);
            this.txtAlamat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(158, 184);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(315, 22);
            this.txtKodeProdi.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 177);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(539, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(152, 24);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Membuka Koneksi";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(539, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(152, 24);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(539, 78);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(152, 24);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(539, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 24);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(539, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 24);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label1);
            this.Name = "FormMahasiswa";
            this.Text = "Form Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

