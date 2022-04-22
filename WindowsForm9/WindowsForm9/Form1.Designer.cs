
namespace WindowsForm9
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_isim = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_tlfno = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_hobi = new System.Windows.Forms.Label();
            this.checkbox_ = new System.Windows.Forms.CheckBox();
            this.grpbox_kayıt = new System.Windows.Forms.GroupBox();
            this.checkbox_ktpoku = new System.Windows.Forms.CheckBox();
            this.checkbox_uçutrma = new System.Windows.Forms.CheckBox();
            this.lbl_ogrdrm = new System.Windows.Forms.Label();
            this.radioBtn_erk = new System.Windows.Forms.RadioButton();
            this.radioBtn_kdn = new System.Windows.Forms.RadioButton();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpbox_kayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_isim.Location = new System.Drawing.Point(26, 67);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(55, 25);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "AD :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(253, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 30);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_soyisim.Location = new System.Drawing.Point(20, 111);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(110, 25);
            this.lbl_soyisim.TabIndex = 2;
            this.lbl_soyisim.Text = "SOYİSİM:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(253, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 30);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_adres.Location = new System.Drawing.Point(26, 162);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(169, 25);
            this.lbl_adres.TabIndex = 12;
            this.lbl_adres.Text = "EMAİL ADRES :";
            this.lbl_adres.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(253, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 30);
            this.textBox3.TabIndex = 2;
            // 
            // lbl_tlfno
            // 
            this.lbl_tlfno.AutoSize = true;
            this.lbl_tlfno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_tlfno.Location = new System.Drawing.Point(26, 215);
            this.lbl_tlfno.Name = "lbl_tlfno";
            this.lbl_tlfno.Size = new System.Drawing.Size(156, 25);
            this.lbl_tlfno.TabIndex = 6;
            this.lbl_tlfno.Text = "TELEFON NO:";
            this.lbl_tlfno.Click += new System.EventHandler(this.lbl_tlfno_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(253, 215);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 30);
            this.textBox4.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Red;
            this.btn_kaydet.Location = new System.Drawing.Point(23, 546);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(427, 56);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_hobi
            // 
            this.lbl_hobi.AutoSize = true;
            this.lbl_hobi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_hobi.Location = new System.Drawing.Point(26, 407);
            this.lbl_hobi.Name = "lbl_hobi";
            this.lbl_hobi.Size = new System.Drawing.Size(104, 25);
            this.lbl_hobi.TabIndex = 2;
            this.lbl_hobi.Text = "HOBİLER";
            // 
            // checkbox_
            // 
            this.checkbox_.AutoSize = true;
            this.checkbox_.Location = new System.Drawing.Point(253, 403);
            this.checkbox_.Name = "checkbox_";
            this.checkbox_.Size = new System.Drawing.Size(97, 29);
            this.checkbox_.TabIndex = 4;
            this.checkbox_.Text = "yüzme";
            this.checkbox_.UseVisualStyleBackColor = true;
            // 
            // grpbox_kayıt
            // 
            this.grpbox_kayıt.BackColor = System.Drawing.Color.DarkGray;
            this.grpbox_kayıt.Controls.Add(this.comboBox1);
            this.grpbox_kayıt.Controls.Add(this.lbl_cinsiyet);
            this.grpbox_kayıt.Controls.Add(this.radioBtn_kdn);
            this.grpbox_kayıt.Controls.Add(this.radioBtn_erk);
            this.grpbox_kayıt.Controls.Add(this.lbl_ogrdrm);
            this.grpbox_kayıt.Controls.Add(this.checkbox_uçutrma);
            this.grpbox_kayıt.Controls.Add(this.checkbox_ktpoku);
            this.grpbox_kayıt.Controls.Add(this.checkbox_);
            this.grpbox_kayıt.Controls.Add(this.lbl_hobi);
            this.grpbox_kayıt.Controls.Add(this.btn_kaydet);
            this.grpbox_kayıt.Controls.Add(this.textBox4);
            this.grpbox_kayıt.Controls.Add(this.lbl_tlfno);
            this.grpbox_kayıt.Controls.Add(this.textBox3);
            this.grpbox_kayıt.Controls.Add(this.lbl_adres);
            this.grpbox_kayıt.Controls.Add(this.textBox2);
            this.grpbox_kayıt.Controls.Add(this.lbl_soyisim);
            this.grpbox_kayıt.Controls.Add(this.textBox1);
            this.grpbox_kayıt.Controls.Add(this.lbl_isim);
            this.grpbox_kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_kayıt.Location = new System.Drawing.Point(12, 22);
            this.grpbox_kayıt.Name = "grpbox_kayıt";
            this.grpbox_kayıt.Size = new System.Drawing.Size(498, 671);
            this.grpbox_kayıt.TabIndex = 0;
            this.grpbox_kayıt.TabStop = false;
            this.grpbox_kayıt.Text = "YENİ KAYIT";
            // 
            // checkbox_ktpoku
            // 
            this.checkbox_ktpoku.AutoSize = true;
            this.checkbox_ktpoku.Location = new System.Drawing.Point(253, 438);
            this.checkbox_ktpoku.Name = "checkbox_ktpoku";
            this.checkbox_ktpoku.Size = new System.Drawing.Size(150, 29);
            this.checkbox_ktpoku.TabIndex = 5;
            this.checkbox_ktpoku.Text = "kitap okuma";
            this.checkbox_ktpoku.UseVisualStyleBackColor = true;
            // 
            // checkbox_uçutrma
            // 
            this.checkbox_uçutrma.AutoSize = true;
            this.checkbox_uçutrma.Location = new System.Drawing.Point(253, 473);
            this.checkbox_uçutrma.Name = "checkbox_uçutrma";
            this.checkbox_uçutrma.Size = new System.Drawing.Size(188, 29);
            this.checkbox_uçutrma.TabIndex = 6;
            this.checkbox_uçutrma.Text = "uçurtma uçurma";
            this.checkbox_uçutrma.UseVisualStyleBackColor = true;
            // 
            // lbl_ogrdrm
            // 
            this.lbl_ogrdrm.AutoSize = true;
            this.lbl_ogrdrm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ogrdrm.Location = new System.Drawing.Point(26, 277);
            this.lbl_ogrdrm.Name = "lbl_ogrdrm";
            this.lbl_ogrdrm.Size = new System.Drawing.Size(217, 25);
            this.lbl_ogrdrm.TabIndex = 13;
            this.lbl_ogrdrm.Text = "ÖĞRENİM DURUMU:";
            // 
            // radioBtn_erk
            // 
            this.radioBtn_erk.AutoSize = true;
            this.radioBtn_erk.Location = new System.Drawing.Point(244, 346);
            this.radioBtn_erk.Name = "radioBtn_erk";
            this.radioBtn_erk.Size = new System.Drawing.Size(105, 29);
            this.radioBtn_erk.TabIndex = 15;
            this.radioBtn_erk.TabStop = true;
            this.radioBtn_erk.Text = "ERKEK";
            this.radioBtn_erk.UseVisualStyleBackColor = true;
            // 
            // radioBtn_kdn
            // 
            this.radioBtn_kdn.AutoSize = true;
            this.radioBtn_kdn.Location = new System.Drawing.Point(355, 346);
            this.radioBtn_kdn.Name = "radioBtn_kdn";
            this.radioBtn_kdn.Size = new System.Drawing.Size(99, 29);
            this.radioBtn_kdn.TabIndex = 16;
            this.radioBtn_kdn.TabStop = true;
            this.radioBtn_kdn.Text = "KADIN";
            this.radioBtn_kdn.UseVisualStyleBackColor = true;
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_cinsiyet.Location = new System.Drawing.Point(26, 346);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(112, 25);
            this.lbl_cinsiyet.TabIndex = 17;
            this.lbl_cinsiyet.Text = "CİNSİYET";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İlkokul ",
            "Ortaokul",
            "Lise",
            "Üniversite"});
            this.comboBox1.Location = new System.Drawing.Point(253, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 738);
            this.Controls.Add(this.grpbox_kayıt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpbox_kayıt.ResumeLayout(false);
            this.grpbox_kayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_tlfno;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_hobi;
        private System.Windows.Forms.CheckBox checkbox_;
        private System.Windows.Forms.GroupBox grpbox_kayıt;
        private System.Windows.Forms.CheckBox checkbox_uçutrma;
        private System.Windows.Forms.CheckBox checkbox_ktpoku;
        private System.Windows.Forms.Label lbl_ogrdrm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.RadioButton radioBtn_kdn;
        private System.Windows.Forms.RadioButton radioBtn_erk;
    }
}

