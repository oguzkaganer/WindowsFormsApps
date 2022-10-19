namespace FormApp_4
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
            this.rb_mavi = new System.Windows.Forms.RadioButton();
            this.rb_mor = new System.Windows.Forms.RadioButton();
            this.rb_yesil = new System.Windows.Forms.RadioButton();
            this.rb_kirmizi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_mavi
            // 
            this.rb_mavi.AutoSize = true;
            this.rb_mavi.Location = new System.Drawing.Point(56, 38);
            this.rb_mavi.Name = "rb_mavi";
            this.rb_mavi.Size = new System.Drawing.Size(48, 17);
            this.rb_mavi.TabIndex = 0;
            this.rb_mavi.Text = "Mavi";
            this.rb_mavi.UseVisualStyleBackColor = true;
            this.rb_mavi.CheckedChanged += new System.EventHandler(this.rb_mavi_CheckedChanged);
            // 
            // rb_mor
            // 
            this.rb_mor.AutoSize = true;
            this.rb_mor.Location = new System.Drawing.Point(56, 134);
            this.rb_mor.Name = "rb_mor";
            this.rb_mor.Size = new System.Drawing.Size(43, 17);
            this.rb_mor.TabIndex = 1;
            this.rb_mor.Text = "Mor";
            this.rb_mor.UseVisualStyleBackColor = true;
            this.rb_mor.CheckedChanged += new System.EventHandler(this.rb_mor_CheckedChanged);
            // 
            // rb_yesil
            // 
            this.rb_yesil.AutoSize = true;
            this.rb_yesil.Location = new System.Drawing.Point(56, 102);
            this.rb_yesil.Name = "rb_yesil";
            this.rb_yesil.Size = new System.Drawing.Size(47, 17);
            this.rb_yesil.TabIndex = 2;
            this.rb_yesil.Text = "Yeşil";
            this.rb_yesil.UseVisualStyleBackColor = true;
            this.rb_yesil.CheckedChanged += new System.EventHandler(this.rb_yesil_CheckedChanged);
            // 
            // rb_kirmizi
            // 
            this.rb_kirmizi.AutoSize = true;
            this.rb_kirmizi.Location = new System.Drawing.Point(56, 70);
            this.rb_kirmizi.Name = "rb_kirmizi";
            this.rb_kirmizi.Size = new System.Drawing.Size(54, 17);
            this.rb_kirmizi.TabIndex = 3;
            this.rb_kirmizi.Text = "Kırmızı";
            this.rb_kirmizi.UseVisualStyleBackColor = true;
            this.rb_kirmizi.CheckedChanged += new System.EventHandler(this.rb_kirmizi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(169, 192);
            this.Controls.Add(this.rb_kirmizi);
            this.Controls.Add(this.rb_yesil);
            this.Controls.Add(this.rb_mor);
            this.Controls.Add(this.rb_mavi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_mavi;
        private System.Windows.Forms.RadioButton rb_mor;
        private System.Windows.Forms.RadioButton rb_yesil;
        private System.Windows.Forms.RadioButton rb_kirmizi;
    }
}

