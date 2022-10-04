namespace VizeFinalHesaplama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblHarfNotları = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblHarf = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vize Final Hesaplama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHesapla);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFinal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtVize);
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 139);
            this.panel1.TabIndex = 0;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(109, 21);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 22);
            this.txtVize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " Vize Notu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final Notu :";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(109, 62);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 22);
            this.txtFinal.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(109, 90);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 33);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHarf);
            this.panel2.Controls.Add(this.lblOrtalama);
            this.panel2.Controls.Add(this.lblHarfNotları);
            this.panel2.Controls.Add(this.lblNot);
            this.panel2.Location = new System.Drawing.Point(6, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 161);
            this.panel2.TabIndex = 1;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(15, 29);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(89, 16);
            this.lblNot.TabIndex = 0;
            this.lblNot.Text = "Ortalama Not:";
            // 
            // lblHarfNotları
            // 
            this.lblHarfNotları.AutoSize = true;
            this.lblHarfNotları.Location = new System.Drawing.Point(38, 54);
            this.lblHarfNotları.Name = "lblHarfNotları";
            this.lblHarfNotları.Size = new System.Drawing.Size(66, 16);
            this.lblHarfNotları.TabIndex = 1;
            this.lblHarfNotları.Text = "Harf Notu:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(117, 29);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(21, 16);
            this.lblOrtalama.TabIndex = 2;
            this.lblOrtalama.Text = "60";
            this.lblOrtalama.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Location = new System.Drawing.Point(117, 54);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(25, 16);
            this.lblHarf.TabIndex = 3;
            this.lblHarf.Text = "CC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblHarfNotları;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVize;
    }
}

