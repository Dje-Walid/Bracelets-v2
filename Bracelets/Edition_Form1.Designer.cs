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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edition_Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbx_secteur_exclure = new System.Windows.Forms.TextBox();
            this.txbx_secteur_inclure = new System.Windows.Forms.TextBox();
            this.lstb_zones_exclure = new System.Windows.Forms.ComboBox();
            this.lsbx_zones_inclure = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Effacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Document sous-Commission";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbx_secteur_exclure);
            this.groupBox1.Controls.Add(this.txbx_secteur_inclure);
            this.groupBox1.Controls.Add(this.lstb_zones_exclure);
            this.groupBox1.Controls.Add(this.lsbx_zones_inclure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(52, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 365);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quelles zones éditer ? (si non spécifié = tout)";
            // 
            // txbx_secteur_exclure
            // 
            this.txbx_secteur_exclure.Location = new System.Drawing.Point(331, 170);
            this.txbx_secteur_exclure.Name = "txbx_secteur_exclure";
            this.txbx_secteur_exclure.Size = new System.Drawing.Size(179, 29);
            this.txbx_secteur_exclure.TabIndex = 9;
            // 
            // txbx_secteur_inclure
            // 
            this.txbx_secteur_inclure.Location = new System.Drawing.Point(331, 68);
            this.txbx_secteur_inclure.Name = "txbx_secteur_inclure";
            this.txbx_secteur_inclure.Size = new System.Drawing.Size(179, 29);
            this.txbx_secteur_inclure.TabIndex = 8;
            // 
            // lstb_zones_exclure
            // 
            this.lstb_zones_exclure.FormattingEnabled = true;
            this.lstb_zones_exclure.Location = new System.Drawing.Point(331, 226);
            this.lstb_zones_exclure.Name = "lstb_zones_exclure";
            this.lstb_zones_exclure.Size = new System.Drawing.Size(179, 32);
            this.lstb_zones_exclure.TabIndex = 7;
            // 
            // lsbx_zones_inclure
            // 
            this.lsbx_zones_inclure.FormattingEnabled = true;
            this.lsbx_zones_inclure.Location = new System.Drawing.Point(331, 115);
            this.lsbx_zones_inclure.Name = "lsbx_zones_inclure";
            this.lsbx_zones_inclure.Size = new System.Drawing.Size(179, 32);
            this.lsbx_zones_inclure.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Liste des zones à Exclure :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Liste des secteurs à Exclure :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Liste des zones à Inclure :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Liste des secteurs à Inclure :";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Annuler.Location = new System.Drawing.Point(622, 538);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(182, 35);
            this.bt_Annuler.TabIndex = 19;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.bt_Annuler_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.Location = new System.Drawing.Point(141, 538);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(186, 35);
            this.bt_OK.TabIndex = 18;
            this.bt_OK.Text = "Ok";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // bt_Effacer
            // 
            this.bt_Effacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Effacer.Location = new System.Drawing.Point(384, 538);
            this.bt_Effacer.Name = "bt_Effacer";
            this.bt_Effacer.Size = new System.Drawing.Size(192, 35);
            this.bt_Effacer.TabIndex = 17;
            this.bt_Effacer.Text = "Effacer";
            this.bt_Effacer.UseVisualStyleBackColor = true;
            this.bt_Effacer.Click += new System.EventHandler(this.btnEffacer_Click_1);
            // 
            // Edition_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Effacer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edition_Form1";
            this.Text = "Document sous-Commision";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbx_secteur_exclure;
        private System.Windows.Forms.TextBox txbx_secteur_inclure;
        private System.Windows.Forms.ComboBox lstb_zones_exclure;
        private System.Windows.Forms.ComboBox lsbx_zones_inclure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_Effacer;
    }
}