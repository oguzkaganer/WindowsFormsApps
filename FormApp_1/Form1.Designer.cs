namespace FormApp_1
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
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_cikart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(76, 12);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(81, 20);
            this.txt_sayi1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İkinci Sayı";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(76, 40);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(81, 20);
            this.txt_sayi2.TabIndex = 2;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(12, 72);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(76, 36);
            this.btn_topla.TabIndex = 4;
            this.btn_topla.Text = "Topla";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_sonuc.Location = new System.Drawing.Point(255, 14);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(13, 17);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(185, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sonuç  : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_exit);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(258, 72);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(76, 36);
            this.btn_bol.TabIndex = 8;
            this.btn_bol.Text = "Böl";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(176, 72);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(76, 36);
            this.btn_carp.TabIndex = 9;
            this.btn_carp.Text = "Çarp";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_cikart
            // 
            this.btn_cikart.Location = new System.Drawing.Point(94, 72);
            this.btn_cikart.Name = "btn_cikart";
            this.btn_cikart.Size = new System.Drawing.Size(76, 36);
            this.btn_cikart.TabIndex = 10;
            this.btn_cikart.Text = "Çıkart";
            this.btn_cikart.UseVisualStyleBackColor = true;
            this.btn_cikart.Click += new System.EventHandler(this.btn_cikart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 164);
            this.Controls.Add(this.btn_cikart);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_cikart;
    }
}

