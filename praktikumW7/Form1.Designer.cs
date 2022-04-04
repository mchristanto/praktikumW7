namespace praktikumW7
{
    partial class FormQuizPanda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxKalimat = new System.Windows.Forms.TextBox();
            this.lblKalimat = new System.Windows.Forms.Label();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.lblHuruf = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxHuruf = new System.Windows.Forms.TextBox();
            this.tBoxMenjadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBoxKalimat
            // 
            this.tBoxKalimat.Location = new System.Drawing.Point(122, 10);
            this.tBoxKalimat.Name = "tBoxKalimat";
            this.tBoxKalimat.Size = new System.Drawing.Size(252, 23);
            this.tBoxKalimat.TabIndex = 0;
            this.tBoxKalimat.TextChanged += new System.EventHandler(this.tBoxKalimat_TextChanged);
            // 
            // lblKalimat
            // 
            this.lblKalimat.AutoSize = true;
            this.lblKalimat.Location = new System.Drawing.Point(12, 13);
            this.lblKalimat.Name = "lblKalimat";
            this.lblKalimat.Size = new System.Drawing.Size(104, 15);
            this.lblKalimat.TabIndex = 1;
            this.lblKalimat.Text = "Masukkan Kalimat";
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(122, 78);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(252, 23);
            this.btnKonversi.TabIndex = 2;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // lblHuruf
            // 
            this.lblHuruf.AutoSize = true;
            this.lblHuruf.Location = new System.Drawing.Point(12, 43);
            this.lblHuruf.Name = "lblHuruf";
            this.lblHuruf.Size = new System.Drawing.Size(95, 15);
            this.lblHuruf.TabIndex = 3;
            this.lblHuruf.Text = "Masukkan Huruf";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(12, 118);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(36, 15);
            this.lblHasil.TabIndex = 4;
            this.lblHasil.Text = "Hasil:";
            this.lblHasil.Click += new System.EventHandler(this.lblHasil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Menjadi";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(122, 119);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 15);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "[EMPTY]";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 7;
            // 
            // tBoxHuruf
            // 
            this.tBoxHuruf.Location = new System.Drawing.Point(122, 40);
            this.tBoxHuruf.Name = "tBoxHuruf";
            this.tBoxHuruf.Size = new System.Drawing.Size(77, 23);
            this.tBoxHuruf.TabIndex = 8;
            this.tBoxHuruf.TextChanged += new System.EventHandler(this.tBoxHuruf_TextChanged);
            // 
            // tBoxMenjadi
            // 
            this.tBoxMenjadi.Location = new System.Drawing.Point(297, 40);
            this.tBoxMenjadi.Name = "tBoxMenjadi";
            this.tBoxMenjadi.Size = new System.Drawing.Size(77, 23);
            this.tBoxMenjadi.TabIndex = 9;
            this.tBoxMenjadi.TextChanged += new System.EventHandler(this.tBoxMenjadi_TextChanged);
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 167);
            this.Controls.Add(this.tBoxMenjadi);
            this.Controls.Add(this.tBoxHuruf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblHuruf);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.lblKalimat);
            this.Controls.Add(this.tBoxKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.Load += new System.EventHandler(this.FormQuizPanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBoxKalimat;
        private Label lblKalimat;
        private Button btnKonversi;
        private Label lblHuruf;
        private Label lblHasil;
        private Label label4;
        private Label lblOutput;
        private Label label6;
        private TextBox tBoxHuruf;
        private TextBox tBoxMenjadi;
    }
}