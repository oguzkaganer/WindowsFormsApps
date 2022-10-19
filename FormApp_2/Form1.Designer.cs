namespace FormApp_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kisaKenar = new System.Windows.Forms.TextBox();
            this.txt_uzunKenar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kısa Kenar :";
            // 
            // txt_kisaKenar
            // 
            this.txt_kisaKenar.Location = new System.Drawing.Point(85, 7);
            this.txt_kisaKenar.Name = "txt_kisaKenar";
            this.txt_kisaKenar.Size = new System.Drawing.Size(100, 20);
            this.txt_kisaKenar.TabIndex = 2;
            this.txt_kisaKenar.Text = "0";
            // 
            // txt_uzunKenar
            // 
            this.txt_uzunKenar.Location = new System.Drawing.Point(85, 37);
            this.txt_uzunKenar.Name = "txt_uzunKenar";
            this.txt_uzunKenar.Size = new System.Drawing.Size(100, 20);
            this.txt_uzunKenar.TabIndex = 4;
            this.txt_uzunKenar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uzun Kenar :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 114);
            this.Controls.Add(this.txt_uzunKenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kisaKenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kisaKenar;
        private System.Windows.Forms.TextBox txt_uzunKenar;
        private System.Windows.Forms.Label label2;
    }
}

