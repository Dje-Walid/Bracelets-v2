namespace Bracelet
{
    partial class Edition_Form1
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtb1_Edition_Form1 = new System.Windows.Forms.TextBox();
            this.cbxMassifaExclure = new System.Windows.Forms.ComboBox();
            this.txtb2_Edition_Form1 = new System.Windows.Forms.ComboBox();
            this.lb4_Edition_Form1 = new System.Windows.Forms.Label();
            this.lb3_Edition_Form1 = new System.Windows.Forms.Label();
            this.lb2_Edition_Form1 = new System.Windows.Forms.Label();
            this.lb1_Edition_Form1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(441, 342);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(102, 29);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(238, 342);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 29);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(573, 83);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(102, 29);
            this.btnEffacer.TabIndex = 11;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Document sous-Commission";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtb1_Edition_Form1);
            this.groupBox1.Controls.Add(this.cbxMassifaExclure);
            this.groupBox1.Controls.Add(this.txtb2_Edition_Form1);
            this.groupBox1.Controls.Add(this.lb4_Edition_Form1);
            this.groupBox1.Controls.Add(this.lb3_Edition_Form1);
            this.groupBox1.Controls.Add(this.lb2_Edition_Form1);
            this.groupBox1.Controls.Add(this.lb1_Edition_Form1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(125, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 166);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quelles zones éditer ? (si non spécifié = tout)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 20);
            this.textBox2.TabIndex = 9;
            // 
            // txtb1_Edition_Form1
            // 
            this.txtb1_Edition_Form1.Location = new System.Drawing.Point(209, 31);
            this.txtb1_Edition_Form1.Name = "txtb1_Edition_Form1";
            this.txtb1_Edition_Form1.Size = new System.Drawing.Size(179, 20);
            this.txtb1_Edition_Form1.TabIndex = 8;
            // 
            // cbxMassifaExclure
            // 
            this.cbxMassifaExclure.FormattingEnabled = true;
            this.cbxMassifaExclure.Location = new System.Drawing.Point(209, 128);
            this.cbxMassifaExclure.Name = "cbxMassifaExclure";
            this.cbxMassifaExclure.Size = new System.Drawing.Size(179, 21);
            this.cbxMassifaExclure.TabIndex = 7;
            // 
            // txtb2_Edition_Form1
            // 
            this.txtb2_Edition_Form1.FormattingEnabled = true;
            this.txtb2_Edition_Form1.Location = new System.Drawing.Point(209, 62);
            this.txtb2_Edition_Form1.Name = "txtb2_Edition_Form1";
            this.txtb2_Edition_Form1.Size = new System.Drawing.Size(179, 21);
            this.txtb2_Edition_Form1.TabIndex = 5;
            // 
            // lb4_Edition_Form1
            // 
            this.lb4_Edition_Form1.AutoSize = true;
            this.lb4_Edition_Form1.Location = new System.Drawing.Point(36, 131);
            this.lb4_Edition_Form1.Name = "lb4_Edition_Form1";
            this.lb4_Edition_Form1.Size = new System.Drawing.Size(133, 13);
            this.lb4_Edition_Form1.TabIndex = 3;
            this.lb4_Edition_Form1.Text = "Liste des zones à Exclure :";
            // 
            // lb3_Edition_Form1
            // 
            this.lb3_Edition_Form1.AutoSize = true;
            this.lb3_Edition_Form1.Location = new System.Drawing.Point(36, 98);
            this.lb3_Edition_Form1.Name = "lb3_Edition_Form1";
            this.lb3_Edition_Form1.Size = new System.Drawing.Size(145, 13);
            this.lb3_Edition_Form1.TabIndex = 2;
            this.lb3_Edition_Form1.Text = "Liste des secteurs à Exclure :";
            // 
            // lb2_Edition_Form1
            // 
            this.lb2_Edition_Form1.AutoSize = true;
            this.lb2_Edition_Form1.Location = new System.Drawing.Point(36, 65);
            this.lb2_Edition_Form1.Name = "lb2_Edition_Form1";
            this.lb2_Edition_Form1.Size = new System.Drawing.Size(130, 13);
            this.lb2_Edition_Form1.TabIndex = 1;
            this.lb2_Edition_Form1.Text = "Liste des zones à Inclure :";
            // 
            // lb1_Edition_Form1
            // 
            this.lb1_Edition_Form1.AutoSize = true;
            this.lb1_Edition_Form1.Location = new System.Drawing.Point(36, 34);
            this.lb1_Edition_Form1.Name = "lb1_Edition_Form1";
            this.lb1_Edition_Form1.Size = new System.Drawing.Size(142, 13);
            this.lb1_Edition_Form1.TabIndex = 0;
            this.lb1_Edition_Form1.Text = "Liste des secteurs à Inclure :";
            // 
            // Edition_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.label1);
            this.Name = "Edition_Form1";
            this.Text = "v";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtb1_Edition_Form1;
        private System.Windows.Forms.ComboBox cbxMassifaExclure;
        private System.Windows.Forms.ComboBox txtb2_Edition_Form1;
        private System.Windows.Forms.Label lb4_Edition_Form1;
        private System.Windows.Forms.Label lb3_Edition_Form1;
        private System.Windows.Forms.Label lb2_Edition_Form1;
        private System.Windows.Forms.Label lb1_Edition_Form1;
    }
}