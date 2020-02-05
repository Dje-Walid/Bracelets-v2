namespace Bracelet
{
    partial class Action_Form3_Suite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form3_Suite));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbx_secteurs_exlure = new System.Windows.Forms.TextBox();
            this.txbx_secteur_inclure = new System.Windows.Forms.TextBox();
            this.txbx_secteur_exclure = new System.Windows.Forms.ComboBox();
            this.txbx_Massif_Inclure = new System.Windows.Forms.ComboBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_Effacer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Basculement Proposés / Accordés";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbx_secteurs_exlure);
            this.groupBox1.Controls.Add(this.txbx_secteur_inclure);
            this.groupBox1.Controls.Add(this.txbx_secteur_exclure);
            this.groupBox1.Controls.Add(this.txbx_Massif_Inclure);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(54, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 365);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quelles zones éditer ? (si non spécifié = tout)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbx_secteurs_exlure
            // 
            this.txbx_secteurs_exlure.Location = new System.Drawing.Point(331, 170);
            this.txbx_secteurs_exlure.Name = "txbx_secteurs_exlure";
            this.txbx_secteurs_exlure.Size = new System.Drawing.Size(179, 29);
            this.txbx_secteurs_exlure.TabIndex = 9;
            // 
            // txbx_secteur_inclure
            // 
            this.txbx_secteur_inclure.Location = new System.Drawing.Point(331, 68);
            this.txbx_secteur_inclure.Name = "txbx_secteur_inclure";
            this.txbx_secteur_inclure.Size = new System.Drawing.Size(179, 29);
            this.txbx_secteur_inclure.TabIndex = 8;
            // 
            // txbx_secteur_exclure
            // 
            this.txbx_secteur_exclure.FormattingEnabled = true;
            this.txbx_secteur_exclure.Location = new System.Drawing.Point(331, 226);
            this.txbx_secteur_exclure.Name = "txbx_secteur_exclure";
            this.txbx_secteur_exclure.Size = new System.Drawing.Size(179, 32);
            this.txbx_secteur_exclure.TabIndex = 7;
            // 
            // txbx_Massif_Inclure
            // 
            this.txbx_Massif_Inclure.FormattingEnabled = true;
            this.txbx_Massif_Inclure.Location = new System.Drawing.Point(331, 115);
            this.txbx_Massif_Inclure.Name = "txbx_Massif_Inclure";
            this.txbx_Massif_Inclure.Size = new System.Drawing.Size(179, 32);
            this.txbx_Massif_Inclure.TabIndex = 5;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(40, 234);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(245, 24);
            this.lb3.TabIndex = 3;
            this.lb3.Text = "Liste des massifs à Exclure :";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(36, 175);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(255, 24);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Liste des secteurs à Exclure :";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(40, 118);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(237, 24);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Liste des massifs à Inclure :";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(40, 71);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(247, 24);
            this.lb.TabIndex = 0;
            this.lb.Text = "Liste des secteurs à Inclure :";
            // 
            // bt_Annuler
            // 
            this.bt_Annuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Annuler.Location = new System.Drawing.Point(632, 557);
            this.bt_Annuler.Name = "bt_Annuler";
            this.bt_Annuler.Size = new System.Drawing.Size(181, 41);
            this.bt_Annuler.TabIndex = 19;
            this.bt_Annuler.Text = "Annuler";
            this.bt_Annuler.UseVisualStyleBackColor = true;
            this.bt_Annuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OK.Location = new System.Drawing.Point(219, 557);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(184, 41);
            this.bt_OK.TabIndex = 18;
            this.bt_OK.Text = "Ok";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // bt_Effacer
            // 
            this.bt_Effacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Effacer.Location = new System.Drawing.Point(429, 557);
            this.bt_Effacer.Name = "bt_Effacer";
            this.bt_Effacer.Size = new System.Drawing.Size(180, 41);
            this.bt_Effacer.TabIndex = 17;
            this.bt_Effacer.Text = "Effacer";
            this.bt_Effacer.UseVisualStyleBackColor = true;
            this.bt_Effacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Action_Form3_Suite
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
            this.Name = "Action_Form3_Suite";
            this.Text = "Action_Form3_Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Action_Form3_Suite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbx_secteurs_exlure;
        private System.Windows.Forms.TextBox txbx_secteur_inclure;
        private System.Windows.Forms.ComboBox txbx_secteur_exclure;
        private System.Windows.Forms.ComboBox txbx_Massif_Inclure;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_Effacer;
    }
}