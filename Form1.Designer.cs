namespace Proje
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OgrenciID = new System.Windows.Forms.TextBox();
            this.OgrenciAd = new System.Windows.Forms.TextBox();
            this.OgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TercihKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dersListesi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dersKaydet = new System.Windows.Forms.Button();
            this.dersAd = new System.Windows.Forms.TextBox();
            this.Eslestir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TercihGetir = new System.Windows.Forms.Button();
            this.ders5Listesi = new System.Windows.Forms.ComboBox();
            this.ders4Listesi = new System.Windows.Forms.ComboBox();
            this.ders3Listesi = new System.Windows.Forms.ComboBox();
            this.ders2Listesi = new System.Windows.Forms.ComboBox();
            this.ders1Listesi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listeleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(446, 207);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OgrenciID
            // 
            this.OgrenciID.Location = new System.Drawing.Point(56, 20);
            this.OgrenciID.Name = "OgrenciID";
            this.OgrenciID.Size = new System.Drawing.Size(55, 20);
            this.OgrenciID.TabIndex = 1;
            this.OgrenciID.TextChanged += new System.EventHandler(this.OgrenciID_TextChanged);
            // 
            // OgrenciAd
            // 
            this.OgrenciAd.Location = new System.Drawing.Point(56, 46);
            this.OgrenciAd.Name = "OgrenciAd";
            this.OgrenciAd.Size = new System.Drawing.Size(100, 20);
            this.OgrenciAd.TabIndex = 2;
            // 
            // OgrenciSoyad
            // 
            this.OgrenciSoyad.Location = new System.Drawing.Point(56, 72);
            this.OgrenciSoyad.Name = "OgrenciSoyad";
            this.OgrenciSoyad.Size = new System.Drawing.Size(100, 20);
            this.OgrenciSoyad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // TercihKaydet
            // 
            this.TercihKaydet.Location = new System.Drawing.Point(56, 240);
            this.TercihKaydet.Name = "TercihKaydet";
            this.TercihKaydet.Size = new System.Drawing.Size(100, 34);
            this.TercihKaydet.TabIndex = 9;
            this.TercihKaydet.Text = "Ekle";
            this.TercihKaydet.UseVisualStyleBackColor = true;
            this.TercihKaydet.Click += new System.EventHandler(this.TercihKaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ders 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ders 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ders 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ders 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ders 5:";
            // 
            // dersListesi
            // 
            this.dersListesi.FormattingEnabled = true;
            this.dersListesi.Location = new System.Drawing.Point(6, 20);
            this.dersListesi.Name = "dersListesi";
            this.dersListesi.Size = new System.Drawing.Size(120, 199);
            this.dersListesi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dersKaydet);
            this.groupBox1.Controls.Add(this.dersAd);
            this.groupBox1.Controls.Add(this.dersListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 295);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Listesi";
            // 
            // dersKaydet
            // 
            this.dersKaydet.Enabled = false;
            this.dersKaydet.Location = new System.Drawing.Point(7, 253);
            this.dersKaydet.Name = "dersKaydet";
            this.dersKaydet.Size = new System.Drawing.Size(119, 23);
            this.dersKaydet.TabIndex = 11;
            this.dersKaydet.Text = "Ekle";
            this.dersKaydet.UseVisualStyleBackColor = true;
            this.dersKaydet.Click += new System.EventHandler(this.dersKaydet_Click);
            // 
            // dersAd
            // 
            this.dersAd.Location = new System.Drawing.Point(6, 226);
            this.dersAd.Name = "dersAd";
            this.dersAd.Size = new System.Drawing.Size(120, 20);
            this.dersAd.TabIndex = 10;
            this.dersAd.TextChanged += new System.EventHandler(this.dersAd_TextChanged);
            // 
            // Eslestir
            // 
            this.Eslestir.Location = new System.Drawing.Point(144, 233);
            this.Eslestir.Name = "Eslestir";
            this.Eslestir.Size = new System.Drawing.Size(125, 27);
            this.Eslestir.TabIndex = 12;
            this.Eslestir.Text = "Eşleştir";
            this.Eslestir.UseVisualStyleBackColor = true;
            this.Eslestir.Click += new System.EventHandler(this.Eslestir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Eslestir);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(162, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 290);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci - Kayıt Tablosu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TercihGetir);
            this.groupBox3.Controls.Add(this.ders5Listesi);
            this.groupBox3.Controls.Add(this.ders4Listesi);
            this.groupBox3.Controls.Add(this.ders3Listesi);
            this.groupBox3.Controls.Add(this.ders2Listesi);
            this.groupBox3.Controls.Add(this.ders1Listesi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TercihKaydet);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.OgrenciSoyad);
            this.groupBox3.Controls.Add(this.OgrenciAd);
            this.groupBox3.Controls.Add(this.OgrenciID);
            this.groupBox3.Location = new System.Drawing.Point(623, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 293);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ders Kayıt";
            // 
            // TercihGetir
            // 
            this.TercihGetir.Location = new System.Drawing.Point(118, 20);
            this.TercihGetir.Name = "TercihGetir";
            this.TercihGetir.Size = new System.Drawing.Size(38, 20);
            this.TercihGetir.TabIndex = 10;
            this.TercihGetir.Text = "Getir";
            this.TercihGetir.UseVisualStyleBackColor = true;
            this.TercihGetir.Click += new System.EventHandler(this.TercihGetir_Click);
            // 
            // ders5Listesi
            // 
            this.ders5Listesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ders5Listesi.FormattingEnabled = true;
            this.ders5Listesi.Location = new System.Drawing.Point(56, 206);
            this.ders5Listesi.Name = "ders5Listesi";
            this.ders5Listesi.Size = new System.Drawing.Size(100, 21);
            this.ders5Listesi.TabIndex = 8;
            // 
            // ders4Listesi
            // 
            this.ders4Listesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ders4Listesi.FormattingEnabled = true;
            this.ders4Listesi.Location = new System.Drawing.Point(56, 180);
            this.ders4Listesi.Name = "ders4Listesi";
            this.ders4Listesi.Size = new System.Drawing.Size(100, 21);
            this.ders4Listesi.TabIndex = 7;
            // 
            // ders3Listesi
            // 
            this.ders3Listesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ders3Listesi.FormattingEnabled = true;
            this.ders3Listesi.Location = new System.Drawing.Point(56, 151);
            this.ders3Listesi.Name = "ders3Listesi";
            this.ders3Listesi.Size = new System.Drawing.Size(100, 21);
            this.ders3Listesi.TabIndex = 6;
            // 
            // ders2Listesi
            // 
            this.ders2Listesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ders2Listesi.FormattingEnabled = true;
            this.ders2Listesi.Location = new System.Drawing.Point(56, 124);
            this.ders2Listesi.Name = "ders2Listesi";
            this.ders2Listesi.Size = new System.Drawing.Size(100, 21);
            this.ders2Listesi.TabIndex = 5;
            // 
            // ders1Listesi
            // 
            this.ders1Listesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ders1Listesi.FormattingEnabled = true;
            this.ders1Listesi.Location = new System.Drawing.Point(56, 97);
            this.ders1Listesi.Name = "ders1Listesi";
            this.ders1Listesi.Size = new System.Drawing.Size(100, 21);
            this.ders1Listesi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(802, 323);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox OgrenciID;
        private System.Windows.Forms.TextBox OgrenciAd;
        private System.Windows.Forms.TextBox OgrenciSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TercihKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox dersListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dersKaydet;
        private System.Windows.Forms.TextBox dersAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ders1Listesi;
        private System.Windows.Forms.ComboBox ders5Listesi;
        private System.Windows.Forms.ComboBox ders4Listesi;
        private System.Windows.Forms.ComboBox ders3Listesi;
        private System.Windows.Forms.ComboBox ders2Listesi;
        private System.Windows.Forms.Button TercihGetir;
        private System.Windows.Forms.Button Eslestir;
    }
}

