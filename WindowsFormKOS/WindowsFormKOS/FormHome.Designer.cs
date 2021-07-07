
namespace WindowsFormKOS
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmanetKitap = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOkuyucu = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetKitap)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 93);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(810, 356);
            this.tabControl.TabIndex = 6;
            this.tabControl.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = " ";
            this.tabPage1.Controls.Add(this.dgEmanetKitap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emanet Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEmanetKitap
            // 
            this.dgEmanetKitap.AllowUserToAddRows = false;
            this.dgEmanetKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmanetKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgEmanetKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmanetKitap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmanetKitap.Location = new System.Drawing.Point(3, 3);
            this.dgEmanetKitap.MultiSelect = false;
            this.dgEmanetKitap.Name = "dgEmanetKitap";
            this.dgEmanetKitap.ReadOnly = true;
            this.dgEmanetKitap.RowHeadersVisible = false;
            this.dgEmanetKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanetKitap.Size = new System.Drawing.Size(796, 324);
            this.dgEmanetKitap.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMevcutKitaplar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMevcutKitaplar
            // 
            this.dgMevcutKitaplar.AllowUserToAddRows = false;
            this.dgMevcutKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMevcutKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dgMevcutKitaplar.MultiSelect = false;
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.ReadOnly = true;
            this.dgMevcutKitaplar.RowHeadersVisible = false;
            this.dgMevcutKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(796, 324);
            this.dgMevcutKitaplar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgOkuyucu);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(802, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOkuyucu
            // 
            this.dgOkuyucu.AllowUserToAddRows = false;
            this.dgOkuyucu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOkuyucu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOkuyucu.Location = new System.Drawing.Point(3, 3);
            this.dgOkuyucu.MultiSelect = false;
            this.dgOkuyucu.Name = "dgOkuyucu";
            this.dgOkuyucu.ReadOnly = true;
            this.dgOkuyucu.RowHeadersVisible = false;
            this.dgOkuyucu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucu.Size = new System.Drawing.Size(796, 324);
            this.dgOkuyucu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(722, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 75);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.Location = new System.Drawing.Point(436, 12);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(100, 75);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.Image")));
            this.btnIstatistik.Location = new System.Drawing.Point(330, 12);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(100, 75);
            this.btnIstatistik.TabIndex = 3;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnOkuyucuEkle
            // 
            this.btnOkuyucuEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOkuyucuEkle.Image")));
            this.btnOkuyucuEkle.Location = new System.Drawing.Point(224, 12);
            this.btnOkuyucuEkle.Name = "btnOkuyucuEkle";
            this.btnOkuyucuEkle.Size = new System.Drawing.Size(100, 75);
            this.btnOkuyucuEkle.TabIndex = 2;
            this.btnOkuyucuEkle.Text = "Okuyucu Ekle";
            this.btnOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOkuyucuEkle.UseVisualStyleBackColor = true;
            this.btnOkuyucuEkle.Click += new System.EventHandler(this.btnOkuyucuEkle_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.Image")));
            this.btnKitapEkle.Location = new System.Drawing.Point(118, 12);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 75);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.Image")));
            this.btnEmanetIslem.Location = new System.Drawing.Point(12, 12);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Size = new System.Drawing.Size(100, 75);
            this.btnEmanetIslem.TabIndex = 0;
            this.btnEmanetIslem.Text = "Emanet İşlemleri";
            this.btnEmanetIslem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnOkuyucuEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetIslem);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.Activated += new System.EventHandler(this.FormHome_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetKitap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnOkuyucuEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgEmanetKitap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgMevcutKitaplar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgOkuyucu;
    }
}