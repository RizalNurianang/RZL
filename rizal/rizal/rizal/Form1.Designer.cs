namespace rizal
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
            this.angka = new System.Windows.Forms.TextBox();
            this.nominal = new System.Windows.Forms.Label();
            this.terbilang = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.cek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // angka
            // 
            this.angka.Location = new System.Drawing.Point(104, 50);
            this.angka.Name = "angka";
            this.angka.Size = new System.Drawing.Size(100, 20);
            this.angka.TabIndex = 0;
            // 
            // nominal
            // 
            this.nominal.AutoSize = true;
            this.nominal.Location = new System.Drawing.Point(24, 53);
            this.nominal.Name = "nominal";
            this.nominal.Size = new System.Drawing.Size(45, 13);
            this.nominal.TabIndex = 1;
            this.nominal.Text = "Nominal";
            // 
            // terbilang
            // 
            this.terbilang.AutoSize = true;
            this.terbilang.Location = new System.Drawing.Point(24, 94);
            this.terbilang.Name = "terbilang";
            this.terbilang.Size = new System.Drawing.Size(47, 13);
            this.terbilang.TabIndex = 2;
            this.terbilang.Text = "terbilang";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(95, 94);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(201, 69);
            this.list.TabIndex = 3;
            // 
            // cek
            // 
            this.cek.Location = new System.Drawing.Point(220, 50);
            this.cek.Name = "cek";
            this.cek.Size = new System.Drawing.Size(86, 29);
            this.cek.TabIndex = 4;
            this.cek.Text = "cek terbilang";
            this.cek.UseVisualStyleBackColor = true;
            this.cek.Click += new System.EventHandler(this.cek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cek);
            this.Controls.Add(this.list);
            this.Controls.Add(this.terbilang);
            this.Controls.Add(this.nominal);
            this.Controls.Add(this.angka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox angka;
        private System.Windows.Forms.Label nominal;
        private System.Windows.Forms.Label terbilang;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button cek;
    }
}

