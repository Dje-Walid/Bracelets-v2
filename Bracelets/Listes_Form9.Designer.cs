namespace Bracelet
{
    partial class Listes_Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listes_Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCdeRefus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxLibelleRefus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chboxDroitRecours = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxTxtLettre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des codes refus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Refus";
            // 
            // cbxCdeRefus
            // 
            this.cbxCdeRefus.FormattingEnabled = true;
            this.cbxCdeRefus.Location = new System.Drawing.Point(155, 29);
            this.cbxCdeRefus.Name = "cbxCdeRefus";
            this.cbxCdeRefus.Size = new System.Drawing.Size(43, 32);
            this.cbxCdeRefus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Libelle Refus";
            // 
            // txtbxLibelleRefus
            // 
            this.txtbxLibelleRefus.Location = new System.Drawing.Point(145, 88);
            this.txtbxLibelleRefus.Name = "txtbxLibelleRefus";
            this.txtbxLibelleRefus.Size = new System.Drawing.Size(255, 29);
            this.txtbxLibelleRefus.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chboxDroitRecours);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbxTxtLettre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbxLibelleRefus);
            this.groupBox1.Controls.Add(this.cbxCdeRefus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 375);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chboxDroitRecours
            // 
            this.chboxDroitRecours.AutoSize = true;
            this.chboxDroitRecours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxDroitRecours.Location = new System.Drawing.Point(560, 88);
            this.chboxDroitRecours.Name = "chboxDroitRecours";
            this.chboxDroitRecours.Size = new System.Drawing.Size(191, 28);
            this.chboxDroitRecours.TabIndex = 7;
            this.chboxDroitRecours.Text = "Avec Droit Recours";
            this.chboxDroitRecours.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texte de la lettre";
            // 
            // txbxTxtLettre
            // 
            this.txbxTxtLettre.Location = new System.Drawing.Point(176, 143);
            this.txbxTxtLettre.Multiline = true;
            this.txbxTxtLettre.Name = "txbxTxtLettre";
            this.txbxTxtLettre.Size = new System.Drawing.Size(543, 155);
            this.txbxTxtLettre.TabIndex = 5;
            // 
            // Listes_Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listes_Form9";
            this.Text = "Liste des codes refus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCdeRefus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxLibelleRefus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chboxDroitRecours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxTxtLettre;
    }
}