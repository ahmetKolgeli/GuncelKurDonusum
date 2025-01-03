namespace DovizProje
{
    partial class Form2
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
            this.musteriNoLbl = new System.Windows.Forms.Label();
            this.dovizTuruLbl = new System.Windows.Forms.Label();
            this.islemTuruLbl = new System.Windows.Forms.Label();
            this.musteriNoTextBox = new System.Windows.Forms.TextBox();
            this.dovizTuruTextBox = new System.Windows.Forms.TextBox();
            this.islemTuruTextBox = new System.Windows.Forms.TextBox();
            this.islemSorgula = new System.Windows.Forms.Button();
            this.gozlemEkraniDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gozlemEkraniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriNoLbl
            // 
            this.musteriNoLbl.AutoSize = true;
            this.musteriNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriNoLbl.Location = new System.Drawing.Point(270, 44);
            this.musteriNoLbl.Name = "musteriNoLbl";
            this.musteriNoLbl.Size = new System.Drawing.Size(100, 20);
            this.musteriNoLbl.TabIndex = 0;
            this.musteriNoLbl.Text = "Müşteri No:";
            // 
            // dovizTuruLbl
            // 
            this.dovizTuruLbl.AutoSize = true;
            this.dovizTuruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dovizTuruLbl.Location = new System.Drawing.Point(270, 86);
            this.dovizTuruLbl.Name = "dovizTuruLbl";
            this.dovizTuruLbl.Size = new System.Drawing.Size(99, 20);
            this.dovizTuruLbl.TabIndex = 1;
            this.dovizTuruLbl.Text = "Döviz Türü:";
            // 
            // islemTuruLbl
            // 
            this.islemTuruLbl.AutoSize = true;
            this.islemTuruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTuruLbl.Location = new System.Drawing.Point(270, 129);
            this.islemTuruLbl.Name = "islemTuruLbl";
            this.islemTuruLbl.Size = new System.Drawing.Size(98, 20);
            this.islemTuruLbl.TabIndex = 2;
            this.islemTuruLbl.Text = "İşlem Türü:";
            // 
            // musteriNoTextBox
            // 
            this.musteriNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriNoTextBox.Location = new System.Drawing.Point(376, 44);
            this.musteriNoTextBox.Name = "musteriNoTextBox";
            this.musteriNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.musteriNoTextBox.TabIndex = 3;
            // 
            // dovizTuruTextBox
            // 
            this.dovizTuruTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dovizTuruTextBox.Location = new System.Drawing.Point(376, 85);
            this.dovizTuruTextBox.Name = "dovizTuruTextBox";
            this.dovizTuruTextBox.Size = new System.Drawing.Size(100, 20);
            this.dovizTuruTextBox.TabIndex = 4;
            // 
            // islemTuruTextBox
            // 
            this.islemTuruTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemTuruTextBox.Location = new System.Drawing.Point(376, 128);
            this.islemTuruTextBox.Name = "islemTuruTextBox";
            this.islemTuruTextBox.Size = new System.Drawing.Size(100, 20);
            this.islemTuruTextBox.TabIndex = 5;
            // 
            // islemSorgula
            // 
            this.islemSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemSorgula.Location = new System.Drawing.Point(309, 177);
            this.islemSorgula.Name = "islemSorgula";
            this.islemSorgula.Size = new System.Drawing.Size(142, 50);
            this.islemSorgula.TabIndex = 6;
            this.islemSorgula.Text = "İşlemleri Sorgula";
            this.islemSorgula.UseVisualStyleBackColor = true;
            this.islemSorgula.Click += new System.EventHandler(this.islemSorgula_Click);
            // 
            // gozlemEkraniDataGridView
            // 
            this.gozlemEkraniDataGridView.AllowUserToAddRows = false;
            this.gozlemEkraniDataGridView.AllowUserToDeleteRows = false;
            this.gozlemEkraniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gozlemEkraniDataGridView.Location = new System.Drawing.Point(107, 285);
            this.gozlemEkraniDataGridView.Name = "gozlemEkraniDataGridView";
            this.gozlemEkraniDataGridView.ReadOnly = true;
            this.gozlemEkraniDataGridView.Size = new System.Drawing.Size(555, 216);
            this.gozlemEkraniDataGridView.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 570);
            this.Controls.Add(this.gozlemEkraniDataGridView);
            this.Controls.Add(this.islemSorgula);
            this.Controls.Add(this.islemTuruTextBox);
            this.Controls.Add(this.dovizTuruTextBox);
            this.Controls.Add(this.musteriNoTextBox);
            this.Controls.Add(this.islemTuruLbl);
            this.Controls.Add(this.dovizTuruLbl);
            this.Controls.Add(this.musteriNoLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gozlemEkraniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteriNoLbl;
        private System.Windows.Forms.Label dovizTuruLbl;
        private System.Windows.Forms.Label islemTuruLbl;
        private System.Windows.Forms.TextBox musteriNoTextBox;
        private System.Windows.Forms.TextBox dovizTuruTextBox;
        private System.Windows.Forms.TextBox islemTuruTextBox;
        private System.Windows.Forms.Button islemSorgula;
        private System.Windows.Forms.DataGridView gozlemEkraniDataGridView;
    }
}