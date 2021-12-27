namespace TCPHaberlesme
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.text_İnfo = new System.Windows.Forms.TextBox();
            this.text_Mesaj = new System.Windows.Forms.TextBox();
            this.buton_Gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buton_Baglan = new System.Windows.Forms.Button();
            this.text_isim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(237, 43);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(367, 22);
            this.text_IP.TabIndex = 1;
            this.text_IP.Text = "127.0.0.1:9000";
            // 
            // text_İnfo
            // 
            this.text_İnfo.Location = new System.Drawing.Point(237, 97);
            this.text_İnfo.Multiline = true;
            this.text_İnfo.Name = "text_İnfo";
            this.text_İnfo.ReadOnly = true;
            this.text_İnfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_İnfo.Size = new System.Drawing.Size(367, 177);
            this.text_İnfo.TabIndex = 2;
            // 
            // text_Mesaj
            // 
            this.text_Mesaj.Location = new System.Drawing.Point(237, 308);
            this.text_Mesaj.Name = "text_Mesaj";
            this.text_Mesaj.Size = new System.Drawing.Size(367, 22);
            this.text_Mesaj.TabIndex = 3;
            // 
            // buton_Gonder
            // 
            this.buton_Gonder.Location = new System.Drawing.Point(621, 302);
            this.buton_Gonder.Name = "buton_Gonder";
            this.buton_Gonder.Size = new System.Drawing.Size(92, 34);
            this.buton_Gonder.TabIndex = 4;
            this.buton_Gonder.Text = "Gönder";
            this.buton_Gonder.UseVisualStyleBackColor = true;
            this.buton_Gonder.Click += new System.EventHandler(this.buton_Gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesaj :";
            // 
            // buton_Baglan
            // 
            this.buton_Baglan.Location = new System.Drawing.Point(621, 34);
            this.buton_Baglan.Name = "buton_Baglan";
            this.buton_Baglan.Size = new System.Drawing.Size(92, 34);
            this.buton_Baglan.TabIndex = 6;
            this.buton_Baglan.Text = "Bağlan";
            this.buton_Baglan.UseVisualStyleBackColor = true;
            this.buton_Baglan.Click += new System.EventHandler(this.buton_Baglan_Click);
            // 
            // text_isim
            // 
            this.text_isim.Location = new System.Drawing.Point(237, 69);
            this.text_isim.Name = "text_isim";
            this.text_isim.Size = new System.Drawing.Size(100, 22);
            this.text_isim.TabIndex = 7;
            this.text_isim.Text = "Hasan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.text_isim);
            this.Controls.Add(this.buton_Baglan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buton_Gonder);
            this.Controls.Add(this.text_Mesaj);
            this.Controls.Add(this.text_İnfo);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.TextBox text_İnfo;
        private System.Windows.Forms.TextBox text_Mesaj;
        private System.Windows.Forms.Button buton_Gonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buton_Baglan;
        private System.Windows.Forms.TextBox text_isim;
    }
}

