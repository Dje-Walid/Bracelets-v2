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
            this.txbxSecEx = new System.Windows.Forms.TextBox();
            this.txbxSecIn = new System.Windows.Forms.TextBox();
            this.cbxMasEx = new System.Windows.Forms.ComboBox();
            this.cbxMasIn = new System.Windows.Forms.ComboBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.bt_Annuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.bt_Effacer = new System.Windows.Forms.Button();
            this.txbxMasIn = new System.Windows.Forms.TextBox();
            this.txbxMasEx = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(341, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Basculement Proposés / Accordés";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbxMasEx);
            this.groupBox1.Controls.Add(this.txbxMasIn);
            this.groupBox1.Controls.Add(this.txbxSecEx);
            this.groupBox1.Controls.Add(this.txbxSecIn);
            this.groupBox1.Controls.Add(this.cbxMasEx);
            this.groupBox1.Controls.Add(this.cbxMasIn);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(211, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 365);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quelles zones éditer ? (si non spécifié = tout)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbxSecEx
            // 
            this.txbxSecEx.Location = new System.Drawing.Point(331, 172);
            this.txbxSecEx.Name = "txbxSecEx";
            this.txbxSecEx.Size = new System.Drawing.Size(179, 29);
            this.txbxSecEx.TabIndex = 9;
            // 
            // txbxSecIn
            // 
            this.txbxSecIn.Location = new System.Drawing.Point(331, 68);
            this.txbxSecIn.Name = "txbxSecIn";
            this.txbxSecIn.Size = new System.Drawing.Size(179, 29);
            this.txbxSecIn.TabIndex = 8;
            // 
            // cbxMasEx
            // 
            this.cbxMasEx.FormattingEnabled = true;
            this.cbxMasEx.Location = new System.Drawing.Point(578, 231);
            this.cbxMasEx.Name = "cbxMasEx";
            this.cbxMasEx.Size = new System.Drawing.Size(288, 32);
            this.cbxMasEx.TabIndex = 7;
            // 
            // cbxMasIn
            // 
            this.cbxMasIn.FormattingEnabled = true;
            this.cbxMasIn.Location = new System.Drawing.Point(578, 110);
            this.cbxMasIn.Name = "cbxMasIn";
            this.cbxMasIn.Size = new System.Drawing.Size(288, 32);
            this.cbxMasIn.TabIndex = 5;
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
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(219, 557);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(184, 41);
            this.btValider.TabIndex = 18;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
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
            // txbxMasIn
            // 
            this.txbxMasIn.Location = new System.Drawing.Point(331, 115);
            this.txbxMasIn.Name = "txbxMasIn";
            this.txbxMasIn.Size = new System.Drawing.Size(179, 29);
            this.txbxMasIn.TabIndex = 10;
            // 
            // txbxMasEx
            // 
            this.txbxMasEx.Location = new System.Drawing.Point(331, 231);
            this.txbxMasEx.Name = "txbxMasEx";
            this.txbxMasEx.Size = new System.Drawing.Size(179, 29);
            this.txbxMasEx.TabIndex = 11;
            // 
            // Action_Form3_Suite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Annuler);
            this.Controls.Add(this.btValider);
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
        private System.Windows.Forms.TextBox txbxSecEx;
        private System.Windows.Forms.TextBox txbxSecIn;
        private System.Windows.Forms.ComboBox cbxMasEx;
        private System.Windows.Forms.ComboBox cbxMasIn;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_Annuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button bt_Effacer;
        private System.Windows.Forms.TextBox txbxMasEx;
        private System.Windows.Forms.TextBox txbxMasIn;
    }
}