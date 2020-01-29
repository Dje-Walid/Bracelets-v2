namespace Bracelet
{
    partial class Action_Form5_F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form5_F1));
            this.lbTitre = new System.Windows.Forms.Label();
            this.dgvBrac = new System.Windows.Forms.DataGridView();
            this.lbCodeBrac = new System.Windows.Forms.Label();
            this.lbPrix = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNumLastBrac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrac)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTitre.Location = new System.Drawing.Point(566, 9);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(799, 39);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "Paramétrage des bracelets pour les campagnes";
            // 
            // dgvBrac
            // 
            this.dgvBrac.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBrac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrac.Location = new System.Drawing.Point(398, 332);
            this.dgvBrac.Name = "dgvBrac";
            this.dgvBrac.Size = new System.Drawing.Size(1118, 434);
            this.dgvBrac.TabIndex = 1;
            // 
            // lbCodeBrac
            // 
            this.lbCodeBrac.AutoSize = true;
            this.lbCodeBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeBrac.Location = new System.Drawing.Point(404, 305);
            this.lbCodeBrac.Name = "lbCodeBrac";
            this.lbCodeBrac.Size = new System.Drawing.Size(141, 24);
            this.lbCodeBrac.TabIndex = 2;
            this.lbCodeBrac.Text = "Code bracelet";
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.Location = new System.Drawing.Point(1013, 305);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(46, 24);
            this.lbPrix.TabIndex = 3;
            this.lbPrix.Text = "Prix";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(703, 305);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(165, 24);
            this.lbNom.TabIndex = 4;
            this.lbNom.Text = "Nom du bracelet";
            // 
            // lbNumLastBrac
            // 
            this.lbNumLastBrac.AutoSize = true;
            this.lbNumLastBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumLastBrac.Location = new System.Drawing.Point(1187, 305);
            this.lbNumLastBrac.Name = "lbNumLastBrac";
            this.lbNumLastBrac.Size = new System.Drawing.Size(329, 24);
            this.lbNumLastBrac.TabIndex = 5;
            this.lbNumLastBrac.Text = "Numéro du dernier bracelet utilisé";
            // 
            // Action_Form5_F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1904, 575);
            this.Controls.Add(this.lbNumLastBrac);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.lbCodeBrac);
            this.Controls.Add(this.dgvBrac);
            this.Controls.Add(this.lbTitre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Action_Form5_F1";
            this.Text = "Plan de Chasse Grand Gibier : Paramétrage des bracelets pour les campagnes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Action_Form5_F1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.DataGridView dgvBrac;
        private System.Windows.Forms.Label lbCodeBrac;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbNumLastBrac;
    }
}