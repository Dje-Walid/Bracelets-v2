namespace Bracelet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form1_suite));
            this.label1 = new System.Windows.Forms.Label();
            this.btEffacer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbxSecEx = new System.Windows.Forms.TextBox();
            this.txbxSecIn = new System.Windows.Forms.TextBox();
            this.cbxMasEx = new System.Windows.Forms.ComboBox();
            this.cbxMasIn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSecEx = new System.Windows.Forms.Label();
            this.lbMasIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tlMassifsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlMassifsBindingSource)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txbxSecEx);
            this.groupBox1.Controls.Add(this.txbxSecIn);
            this.groupBox1.Controls.Add(this.cbxMasEx);
            this.groupBox1.Controls.Add(this.cbxMasIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbSecEx);
            this.groupBox1.Controls.Add(this.lbMasIn);
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
            // txbxSecEx
            // 
            this.txbxSecEx.Location = new System.Drawing.Point(285, 236);
            this.txbxSecEx.Name = "txbxSecEx";
            this.txbxSecEx.Size = new System.Drawing.Size(179, 29);
            this.txbxSecEx.TabIndex = 9;
            // 
            // txbxSecIn
            // 
            this.txbxSecIn.Location = new System.Drawing.Point(285, 83);
            this.txbxSecIn.Name = "txbxSecIn";
            this.txbxSecIn.Size = new System.Drawing.Size(179, 29);
            this.txbxSecIn.TabIndex = 8;
            // 
            // cbxMasEx
            // 
            this.cbxMasEx.DataSource = this.tlMassifsBindingSource;
            this.cbxMasEx.DisplayMember = "LibMassif";
            this.cbxMasEx.FormattingEnabled = true;
            this.cbxMasEx.Location = new System.Drawing.Point(285, 310);
            this.cbxMasEx.Name = "cbxMasEx";
            this.cbxMasEx.Size = new System.Drawing.Size(179, 32);
            this.cbxMasEx.TabIndex = 7;
            // 
            // cbxMasIn
            // 
            this.cbxMasIn.DataSource = this.tlMassifsBindingSource;
            this.cbxMasIn.DisplayMember = "LibMassif";
            this.cbxMasIn.FormattingEnabled = true;
            this.cbxMasIn.Location = new System.Drawing.Point(285, 158);
            this.cbxMasIn.Name = "cbxMasIn";
            this.cbxMasIn.Size = new System.Drawing.Size(179, 32);
            this.cbxMasIn.TabIndex = 5;
            this.cbxMasIn.ValueMember = "CdMassif";
            this.cbxMasIn.SelectedIndexChanged += new System.EventHandler(this.cbxMasIn_SelectedIndexChanged);
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
            // lbSecEx
            // 
            this.lbSecEx.AutoSize = true;
            this.lbSecEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecEx.Location = new System.Drawing.Point(24, 241);
            this.lbSecEx.Name = "lbSecEx";
            this.lbSecEx.Size = new System.Drawing.Size(255, 24);
            this.lbSecEx.TabIndex = 2;
            this.lbSecEx.Text = "Liste des secteurs à Exclure :";
            // 
            // lbMasIn
            // 
            this.lbMasIn.AutoSize = true;
            this.lbMasIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMasIn.Location = new System.Drawing.Point(24, 158);
            this.lbMasIn.Name = "lbMasIn";
            this.lbMasIn.Size = new System.Drawing.Size(237, 24);
            this.lbMasIn.TabIndex = 1;
            this.lbMasIn.Text = "Liste des massifs à Inclure :";
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
            // braceletBDDDataSet4
            // 
            // 
            // tlMassifsBindingSource
            // 
            this.tlMassifsBindingSource.DataMember = "tlMassifs";
            // 
            // tlMassifsTableAdapter
            // 
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
            this.Load += new System.EventHandler(this.Action_Form1_suite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlMassifsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEffacer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSecEx;
        private System.Windows.Forms.Label lbMasIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbxSecEx;
        private System.Windows.Forms.TextBox txbxSecIn;
        private System.Windows.Forms.ComboBox cbxMasEx;
        private System.Windows.Forms.ComboBox cbxMasIn;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.BindingSource tlMassifsBindingSource;
    }
}