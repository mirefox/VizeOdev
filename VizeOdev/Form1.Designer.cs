
namespace VizeOdev
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
            this.IcerikLabel = new System.Windows.Forms.Label();
            this.haberBaslikları = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IcerikLabel
            // 
            this.IcerikLabel.AutoSize = true;
            this.IcerikLabel.Location = new System.Drawing.Point(612, 72);
            this.IcerikLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.IcerikLabel.Name = "IcerikLabel";
            this.IcerikLabel.Size = new System.Drawing.Size(46, 17);
            this.IcerikLabel.TabIndex = 0;
            this.IcerikLabel.Text = "label1";
            // 
            // haberBaslikları
            // 
            this.haberBaslikları.FormattingEnabled = true;
            this.haberBaslikları.ItemHeight = 16;
            this.haberBaslikları.Location = new System.Drawing.Point(12, 12);
            this.haberBaslikları.Name = "haberBaslikları";
            this.haberBaslikları.Size = new System.Drawing.Size(481, 420);
            this.haberBaslikları.TabIndex = 1;
            this.haberBaslikları.SelectedIndexChanged += new System.EventHandler(this.haberBaslikları_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.haberBaslikları);
            this.Controls.Add(this.IcerikLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IcerikLabel;
        private System.Windows.Forms.ListBox haberBaslikları;
    }
}

