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
            this.text_info = new System.Windows.Forms.TextBox();
            this.text_Mesaj = new System.Windows.Forms.TextBox();
            this.buton_Gonder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buton_Baslat = new System.Windows.Forms.Button();
            this.list_ClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_IP
            // 
            this.text_IP.Location = new System.Drawing.Point(144, 41);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(367, 22);
            this.text_IP.TabIndex = 1;
            this.text_IP.Text = "127.0.0.1:9000";
            // 
            // text_info
            // 
            this.text_info.Location = new System.Drawing.Point(144, 69);
            this.text_info.Multiline = true;
            this.text_info.Name = "text_info";
            this.text_info.ReadOnly = true;
            this.text_info.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_info.Size = new System.Drawing.Size(367, 269);
            this.text_info.TabIndex = 2;
            // 
            // text_Mesaj
            // 
            this.text_Mesaj.Location = new System.Drawing.Point(144, 344);
            this.text_Mesaj.Name = "text_Mesaj";
            this.text_Mesaj.Size = new System.Drawing.Size(367, 22);
            this.text_Mesaj.TabIndex = 3;
            // 
            // buton_Gonder
            // 
            this.buton_Gonder.Location = new System.Drawing.Point(528, 343);
            this.buton_Gonder.Name = "buton_Gonder";
            this.buton_Gonder.Size = new System.Drawing.Size(75, 23);
            this.buton_Gonder.TabIndex = 4;
            this.buton_Gonder.Text = "Gönder";
            this.buton_Gonder.UseVisualStyleBackColor = true;
            this.buton_Gonder.Click += new System.EventHandler(this.buton_Gonder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesaj :";
            // 
            // buton_Baslat
            // 
            this.buton_Baslat.Location = new System.Drawing.Point(528, 38);
            this.buton_Baslat.Name = "buton_Baslat";
            this.buton_Baslat.Size = new System.Drawing.Size(75, 23);
            this.buton_Baslat.TabIndex = 6;
            this.buton_Baslat.Text = "Başlat";
            this.buton_Baslat.UseVisualStyleBackColor = true;
            this.buton_Baslat.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_ClientIP
            // 
            this.list_ClientIP.FormattingEnabled = true;
            this.list_ClientIP.ItemHeight = 16;
            this.list_ClientIP.Location = new System.Drawing.Point(643, 95);
            this.list_ClientIP.Name = "list_ClientIP";
            this.list_ClientIP.Size = new System.Drawing.Size(278, 180);
            this.list_ClientIP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client IP :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_ClientIP);
            this.Controls.Add(this.buton_Baslat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buton_Gonder);
            this.Controls.Add(this.text_Mesaj);
            this.Controls.Add(this.text_info);
            this.Controls.Add(this.text_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.TextBox text_info;
        private System.Windows.Forms.TextBox text_Mesaj;
        private System.Windows.Forms.Button buton_Gonder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buton_Baslat;
        private System.Windows.Forms.ListBox list_ClientIP;
        private System.Windows.Forms.Label label3;
    }
}

