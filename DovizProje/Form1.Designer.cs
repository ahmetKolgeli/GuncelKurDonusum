namespace DovizProje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dovizDataSet3 = new DovizProje.DovizDataSet3();
            this.mNoLbl = new System.Windows.Forms.Label();
            this.mNoGelenLbl = new System.Windows.Forms.Label();
            this.mAdLbl = new System.Windows.Forms.Label();
            this.mAdGelenLbl = new System.Windows.Forms.Label();
            this.dTuruLbl = new System.Windows.Forms.Label();
            this.dTuruGelenLbl = new System.Windows.Forms.Label();
            this.miktarLbl = new System.Windows.Forms.Label();
            this.miktarGelenLbl = new System.Windows.Forms.Label();
            this.veriYenile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxDovizTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.satilacakDovizMiktar = new System.Windows.Forms.TextBox();
            this.btnDonustur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.alacaginizDovizLbl = new System.Windows.Forms.Label();
            this.islemiTamamlaBtn = new System.Windows.Forms.Button();
            this.musterilerTableAdapter = new DovizProje.DovizDataSet3TableAdapters.MusterilerTableAdapter();
            this.gozlemEkraniBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriNoDataGridViewTextBoxColumn,
            this.musteriAdiDataGridViewTextBoxColumn,
            this.dovizTuruDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musterilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // musteriNoDataGridViewTextBoxColumn
            // 
            this.musteriNoDataGridViewTextBoxColumn.DataPropertyName = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.HeaderText = "MusteriNo";
            this.musteriNoDataGridViewTextBoxColumn.Name = "musteriNoDataGridViewTextBoxColumn";
            this.musteriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            this.musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.HeaderText = "MusteriAdi";
            this.musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            this.musteriAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dovizTuruDataGridViewTextBoxColumn
            // 
            this.dovizTuruDataGridViewTextBoxColumn.DataPropertyName = "DovizTuru";
            this.dovizTuruDataGridViewTextBoxColumn.HeaderText = "DovizTuru";
            this.dovizTuruDataGridViewTextBoxColumn.Name = "dovizTuruDataGridViewTextBoxColumn";
            this.dovizTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.dovizDataSet3;
            // 
            // dovizDataSet3
            // 
            this.dovizDataSet3.DataSetName = "DovizDataSet3";
            this.dovizDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mNoLbl
            // 
            this.mNoLbl.AutoSize = true;
            this.mNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mNoLbl.Location = new System.Drawing.Point(35, 196);
            this.mNoLbl.Name = "mNoLbl";
            this.mNoLbl.Size = new System.Drawing.Size(72, 13);
            this.mNoLbl.TabIndex = 1;
            this.mNoLbl.Text = "Müşteri No:";
            // 
            // mNoGelenLbl
            // 
            this.mNoGelenLbl.AutoSize = true;
            this.mNoGelenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mNoGelenLbl.Location = new System.Drawing.Point(113, 196);
            this.mNoGelenLbl.Name = "mNoGelenLbl";
            this.mNoGelenLbl.Size = new System.Drawing.Size(0, 13);
            this.mNoGelenLbl.TabIndex = 2;
            // 
            // mAdLbl
            // 
            this.mAdLbl.AutoSize = true;
            this.mAdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mAdLbl.Location = new System.Drawing.Point(258, 196);
            this.mAdLbl.Name = "mAdLbl";
            this.mAdLbl.Size = new System.Drawing.Size(74, 13);
            this.mAdLbl.TabIndex = 3;
            this.mAdLbl.Text = "Müşteri Adı:";
            // 
            // mAdGelenLbl
            // 
            this.mAdGelenLbl.AutoSize = true;
            this.mAdGelenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mAdGelenLbl.Location = new System.Drawing.Point(339, 196);
            this.mAdGelenLbl.Name = "mAdGelenLbl";
            this.mAdGelenLbl.Size = new System.Drawing.Size(0, 13);
            this.mAdGelenLbl.TabIndex = 4;
            // 
            // dTuruLbl
            // 
            this.dTuruLbl.AutoSize = true;
            this.dTuruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTuruLbl.Location = new System.Drawing.Point(38, 235);
            this.dTuruLbl.Name = "dTuruLbl";
            this.dTuruLbl.Size = new System.Drawing.Size(73, 13);
            this.dTuruLbl.TabIndex = 5;
            this.dTuruLbl.Text = "Döviz Türü:";
            // 
            // dTuruGelenLbl
            // 
            this.dTuruGelenLbl.AutoSize = true;
            this.dTuruGelenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTuruGelenLbl.Location = new System.Drawing.Point(116, 234);
            this.dTuruGelenLbl.Name = "dTuruGelenLbl";
            this.dTuruGelenLbl.Size = new System.Drawing.Size(0, 13);
            this.dTuruGelenLbl.TabIndex = 6;
            // 
            // miktarLbl
            // 
            this.miktarLbl.AutoSize = true;
            this.miktarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarLbl.Location = new System.Drawing.Point(261, 235);
            this.miktarLbl.Name = "miktarLbl";
            this.miktarLbl.Size = new System.Drawing.Size(46, 13);
            this.miktarLbl.TabIndex = 7;
            this.miktarLbl.Text = "Miktar:";
            // 
            // miktarGelenLbl
            // 
            this.miktarGelenLbl.AutoSize = true;
            this.miktarGelenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.miktarGelenLbl.Location = new System.Drawing.Point(314, 234);
            this.miktarGelenLbl.Name = "miktarGelenLbl";
            this.miktarGelenLbl.Size = new System.Drawing.Size(0, 13);
            this.miktarGelenLbl.TabIndex = 8;
            // 
            // veriYenile
            // 
            this.veriYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriYenile.Location = new System.Drawing.Point(193, 270);
            this.veriYenile.Name = "veriYenile";
            this.veriYenile.Size = new System.Drawing.Size(121, 37);
            this.veriYenile.TabIndex = 9;
            this.veriYenile.Text = "Verileri Yenile";
            this.veriYenile.UseVisualStyleBackColor = true;
            this.veriYenile.Click += new System.EventHandler(this.veriYenile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Almak İstediğiniz Döviz Türünü Seçin:";
            // 
            // cBoxDovizTuru
            // 
            this.cBoxDovizTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxDovizTuru.FormattingEnabled = true;
            this.cBoxDovizTuru.Items.AddRange(new object[] {
            "USD",
            "TRY",
            "EUR"});
            this.cBoxDovizTuru.Location = new System.Drawing.Point(273, 335);
            this.cBoxDovizTuru.Name = "cBoxDovizTuru";
            this.cBoxDovizTuru.Size = new System.Drawing.Size(121, 21);
            this.cBoxDovizTuru.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Satmak İstediğiniz Miktarı Girin:";
            // 
            // satilacakDovizMiktar
            // 
            this.satilacakDovizMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satilacakDovizMiktar.Location = new System.Drawing.Point(239, 375);
            this.satilacakDovizMiktar.Multiline = true;
            this.satilacakDovizMiktar.Name = "satilacakDovizMiktar";
            this.satilacakDovizMiktar.Size = new System.Drawing.Size(100, 20);
            this.satilacakDovizMiktar.TabIndex = 13;
            // 
            // btnDonustur
            // 
            this.btnDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonustur.Location = new System.Drawing.Point(214, 415);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(75, 23);
            this.btnDonustur.TabIndex = 14;
            this.btnDonustur.Text = "Dönüştür";
            this.btnDonustur.UseVisualStyleBackColor = true;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alacağınız Döviz Miktarı:";
            // 
            // alacaginizDovizLbl
            // 
            this.alacaginizDovizLbl.AutoSize = true;
            this.alacaginizDovizLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacaginizDovizLbl.Location = new System.Drawing.Point(195, 466);
            this.alacaginizDovizLbl.Name = "alacaginizDovizLbl";
            this.alacaginizDovizLbl.Size = new System.Drawing.Size(0, 13);
            this.alacaginizDovizLbl.TabIndex = 16;
            // 
            // islemiTamamlaBtn
            // 
            this.islemiTamamlaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemiTamamlaBtn.Location = new System.Drawing.Point(193, 495);
            this.islemiTamamlaBtn.Name = "islemiTamamlaBtn";
            this.islemiTamamlaBtn.Size = new System.Drawing.Size(105, 27);
            this.islemiTamamlaBtn.TabIndex = 17;
            this.islemiTamamlaBtn.Text = "İşlemi Tamamla";
            this.islemiTamamlaBtn.UseVisualStyleBackColor = true;
            this.islemiTamamlaBtn.Click += new System.EventHandler(this.islemiTamamlaBtn_Click);
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // gozlemEkraniBtn
            // 
            this.gozlemEkraniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gozlemEkraniBtn.Location = new System.Drawing.Point(193, 544);
            this.gozlemEkraniBtn.Name = "gozlemEkraniBtn";
            this.gozlemEkraniBtn.Size = new System.Drawing.Size(105, 31);
            this.gozlemEkraniBtn.TabIndex = 18;
            this.gozlemEkraniBtn.Text = "Gözlem Ekranı";
            this.gozlemEkraniBtn.UseVisualStyleBackColor = true;
            this.gozlemEkraniBtn.Click += new System.EventHandler(this.gozlemEkraniBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 637);
            this.Controls.Add(this.gozlemEkraniBtn);
            this.Controls.Add(this.islemiTamamlaBtn);
            this.Controls.Add(this.alacaginizDovizLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDonustur);
            this.Controls.Add(this.satilacakDovizMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxDovizTuru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veriYenile);
            this.Controls.Add(this.miktarGelenLbl);
            this.Controls.Add(this.miktarLbl);
            this.Controls.Add(this.dTuruGelenLbl);
            this.Controls.Add(this.dTuruLbl);
            this.Controls.Add(this.mAdGelenLbl);
            this.Controls.Add(this.mAdLbl);
            this.Controls.Add(this.mNoGelenLbl);
            this.Controls.Add(this.mNoLbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dovizDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mNoLbl;
        private System.Windows.Forms.Label mNoGelenLbl;
        private System.Windows.Forms.Label mAdLbl;
        private System.Windows.Forms.Label mAdGelenLbl;
        private System.Windows.Forms.Label dTuruLbl;
        private System.Windows.Forms.Label dTuruGelenLbl;
        private System.Windows.Forms.Label miktarLbl;
        private System.Windows.Forms.Label miktarGelenLbl;
        private System.Windows.Forms.Button veriYenile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxDovizTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satilacakDovizMiktar;
        private System.Windows.Forms.Button btnDonustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label alacaginizDovizLbl;
        private System.Windows.Forms.Button islemiTamamlaBtn;
        private DovizDataSet3 dovizDataSet3;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private DovizDataSet3TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dovizTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button gozlemEkraniBtn;
    }
}

