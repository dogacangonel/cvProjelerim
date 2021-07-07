
namespace WindowsFormKOS
{
    partial class FormEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltreleOkuyucu = new System.Windows.Forms.TextBox();
            this.dgOkuyucu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblGecikmeBedeli = new System.Windows.Forms.Label();
            this.pictureProfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltreleKitap = new System.Windows.Forms.TextBox();
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKayitNo = new System.Windows.Forms.Label();
            this.lblKitabinAdi = new System.Windows.Forms.Label();
            this.lblYazarinAdi = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmanetEt = new System.Windows.Forms.Button();
            this.btnSureUzat = new System.Windows.Forms.Button();
            this.btnDusumYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiltreleOkuyucu);
            this.groupBox1.Controls.Add(this.dgOkuyucu);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okuyucu Seç";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Filtrele:";
            // 
            // txtFiltreleOkuyucu
            // 
            this.txtFiltreleOkuyucu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltreleOkuyucu.Location = new System.Drawing.Point(654, 174);
            this.txtFiltreleOkuyucu.Name = "txtFiltreleOkuyucu";
            this.txtFiltreleOkuyucu.Size = new System.Drawing.Size(150, 20);
            this.txtFiltreleOkuyucu.TabIndex = 1;
            this.txtFiltreleOkuyucu.TextChanged += new System.EventHandler(this.txtFiltreleOkuyucu_TextChanged);
            // 
            // dgOkuyucu
            // 
            this.dgOkuyucu.AllowUserToAddRows = false;
            this.dgOkuyucu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOkuyucu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOkuyucu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucu.Location = new System.Drawing.Point(262, 19);
            this.dgOkuyucu.MultiSelect = false;
            this.dgOkuyucu.Name = "dgOkuyucu";
            this.dgOkuyucu.ReadOnly = true;
            this.dgOkuyucu.RowHeadersVisible = false;
            this.dgOkuyucu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucu.Size = new System.Drawing.Size(542, 149);
            this.dgOkuyucu.TabIndex = 1;
            this.dgOkuyucu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOkuyucu_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureProfil, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblAdSoyad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSinif, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOkulNo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGecikmeBedeli, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 94);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 5);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblSinif
            // 
            this.lblSinif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(3, 28);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(27, 13);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(3, 51);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(46, 13);
            this.lblOkulNo.TabIndex = 2;
            this.lblOkulNo.Text = "Okul No";
            // 
            // lblGecikmeBedeli
            // 
            this.lblGecikmeBedeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGecikmeBedeli.AutoSize = true;
            this.lblGecikmeBedeli.Location = new System.Drawing.Point(3, 75);
            this.lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            this.lblGecikmeBedeli.Size = new System.Drawing.Size(81, 13);
            this.lblGecikmeBedeli.TabIndex = 3;
            this.lblGecikmeBedeli.Text = "Gecikme Bedeli";
            // 
            // pictureProfil
            // 
            this.pictureProfil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfil.Image")));
            this.pictureProfil.Location = new System.Drawing.Point(3, 3);
            this.pictureProfil.Name = "pictureProfil";
            this.pictureProfil.Size = new System.Drawing.Size(74, 94);
            this.pictureProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfil.TabIndex = 2;
            this.pictureProfil.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFiltreleKitap);
            this.groupBox2.Controls.Add(this.dgKitaplar);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filtrele:";
            // 
            // txtFiltreleKitap
            // 
            this.txtFiltreleKitap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltreleKitap.Location = new System.Drawing.Point(654, 173);
            this.txtFiltreleKitap.Name = "txtFiltreleKitap";
            this.txtFiltreleKitap.Size = new System.Drawing.Size(150, 20);
            this.txtFiltreleKitap.TabIndex = 2;
            this.txtFiltreleKitap.TextChanged += new System.EventHandler(this.txtFiltreleKitap_TextChanged);
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AllowUserToAddRows = false;
            this.dgKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Location = new System.Drawing.Point(262, 19);
            this.dgKitaplar.MultiSelect = false;
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.ReadOnly = true;
            this.dgKitaplar.RowHeadersVisible = false;
            this.dgKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKitaplar.Size = new System.Drawing.Size(542, 149);
            this.dgKitaplar.TabIndex = 3;
            this.dgKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKitaplar_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblKayitNo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKitabinAdi, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblYazarinAdi, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 90);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt No";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazarın Adı";
            // 
            // lblKayitNo
            // 
            this.lblKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKayitNo.AutoSize = true;
            this.lblKayitNo.Location = new System.Drawing.Point(83, 8);
            this.lblKayitNo.Name = "lblKayitNo";
            this.lblKayitNo.Size = new System.Drawing.Size(16, 13);
            this.lblKayitNo.TabIndex = 3;
            this.lblKayitNo.Text = "...";
            // 
            // lblKitabinAdi
            // 
            this.lblKitabinAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKitabinAdi.AutoSize = true;
            this.lblKitabinAdi.Location = new System.Drawing.Point(83, 38);
            this.lblKitabinAdi.Name = "lblKitabinAdi";
            this.lblKitabinAdi.Size = new System.Drawing.Size(16, 13);
            this.lblKitabinAdi.TabIndex = 4;
            this.lblKitabinAdi.Text = "...";
            // 
            // lblYazarinAdi
            // 
            this.lblYazarinAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYazarinAdi.AutoSize = true;
            this.lblYazarinAdi.Location = new System.Drawing.Point(83, 68);
            this.lblYazarinAdi.Name = "lblYazarinAdi";
            this.lblYazarinAdi.Size = new System.Drawing.Size(16, 13);
            this.lblYazarinAdi.TabIndex = 5;
            this.lblYazarinAdi.Text = "...";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEmanetEt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSureUzat, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDusumYap, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(522, 424);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 30);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnEmanetEt
            // 
            this.btnEmanetEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmanetEt.Location = new System.Drawing.Point(3, 3);
            this.btnEmanetEt.Name = "btnEmanetEt";
            this.btnEmanetEt.Size = new System.Drawing.Size(94, 24);
            this.btnEmanetEt.TabIndex = 0;
            this.btnEmanetEt.Text = "Emanet Et";
            this.btnEmanetEt.UseVisualStyleBackColor = true;
            this.btnEmanetEt.Click += new System.EventHandler(this.btnEmanetEt_Click);
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSureUzat.Location = new System.Drawing.Point(103, 3);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(94, 24);
            this.btnSureUzat.TabIndex = 1;
            this.btnSureUzat.Text = "Süre Uzat";
            this.btnSureUzat.UseVisualStyleBackColor = true;
            this.btnSureUzat.Click += new System.EventHandler(this.btnSureUzat_Click);
            // 
            // btnDusumYap
            // 
            this.btnDusumYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDusumYap.Location = new System.Drawing.Point(203, 3);
            this.btnDusumYap.Name = "btnDusumYap";
            this.btnDusumYap.Size = new System.Drawing.Size(94, 24);
            this.btnDusumYap.TabIndex = 2;
            this.btnDusumYap.Text = "Düşüm Yap";
            this.btnDusumYap.UseVisualStyleBackColor = true;
            this.btnDusumYap.Click += new System.EventHandler(this.btnDusumYap_Click);
            // 
            // FormEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmanet";
            this.Load += new System.EventHandler(this.FormEmanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltreleOkuyucu;
        private System.Windows.Forms.DataGridView dgOkuyucu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblGecikmeBedeli;
        private System.Windows.Forms.PictureBox pictureProfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltreleKitap;
        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKayitNo;
        private System.Windows.Forms.Label lblKitabinAdi;
        private System.Windows.Forms.Label lblYazarinAdi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEmanetEt;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Button btnDusumYap;
    }
}