namespace FormApp_3
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_kars = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(27, 44);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 0;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(147, 44);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 1;
            // 
            // btn_kars
            // 
            this.btn_kars.Location = new System.Drawing.Point(27, 79);
            this.btn_kars.Name = "btn_kars";
            this.btn_kars.Size = new System.Drawing.Size(220, 23);
            this.btn_kars.TabIndex = 2;
            this.btn_kars.Text = "Karşılaştır";
            this.btn_kars.UseVisualStyleBackColor = true;
            this.btn_kars.Click += new System.EventHandler(this.btn_kars_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(24, 121);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(25, 13);
            this.lbl_sonuc.TabIndex = 3;
            this.lbl_sonuc.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birinci :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İkinci : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_kars);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_kars;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

