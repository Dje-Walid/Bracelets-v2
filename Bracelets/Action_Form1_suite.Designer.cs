﻿namespace Bracelet
{
    partial class Action_Form1_suite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form1_suite));
            this.label1 = new System.Windows.Forms.Label();
            this.btEffacer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbxSecIn = new System.Windows.Forms.TextBox();
            this.cbxMassifaExclure = new System.Windows.Forms.ComboBox();
            this.cbxMassifaInclur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(340, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basculement Proposés / Accordés";
            // 
            // btEffacer
            // 
            this.btEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEffacer.Location = new System.Drawing.Point(681, 621);
            this.btEffacer.Name = "btEffacer";
            this.btEffacer.Size = new System.Drawing.Size(152, 37);
            this.btEffacer.TabIndex = 1;
            this.btEffacer.Text = "Effacer";
            this.btEffacer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txbxSecIn);
            this.groupBox1.Controls.Add(this.cbxMassifaExclure);
            this.groupBox1.Controls.Add(this.cbxMassifaInclur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(173, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 431);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quel massifs éditer ? (si non spécifieé = tout)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 29);
            this.textBox2.TabIndex = 9;
            // 
            // txbxSecIn
            // 
            this.txbxSecIn.Location = new System.Drawing.Point(285, 83);
            this.txbxSecIn.Name = "txbxSecIn";
            this.txbxSecIn.Size = new System.Drawing.Size(179, 29);
            this.txbxSecIn.TabIndex = 8;
            // 
            // cbxMassifaExclure
            // 
            this.cbxMassifaExclure.FormattingEnabled = true;
            this.cbxMassifaExclure.Location = new System.Drawing.Point(285, 310);
            this.cbxMassifaExclure.Name = "cbxMassifaExclure";
            this.cbxMassifaExclure.Size = new System.Drawing.Size(179, 32);
            this.cbxMassifaExclure.TabIndex = 7;
            // 
            // cbxMassifaInclur
            // 
            this.cbxMassifaInclur.FormattingEnabled = true;
            this.cbxMassifaInclur.Location = new System.Drawing.Point(285, 158);
            this.cbxMassifaInclur.Name = "cbxMassifaInclur";
            this.cbxMassifaInclur.Size = new System.Drawing.Size(179, 32);
            this.cbxMassifaInclur.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Liste des massifs à Exclure :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Liste des secteurs à Exclure :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liste des massifs à Inclure :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Liste des secteurs à Inclure :";
            // 
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(296, 621);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(156, 37);
            this.btValider.TabIndex = 3;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(498, 621);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(139, 37);
            this.btAnnuler.TabIndex = 4;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Action_Form1_suite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEffacer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Action_Form1_suite";
            this.Text = "Sélection Massif  -> Tous les Massifs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEffacer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbxSecIn;
        private System.Windows.Forms.ComboBox cbxMassifaExclure;
        private System.Windows.Forms.ComboBox cbxMassifaInclur;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}