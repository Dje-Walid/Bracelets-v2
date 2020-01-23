namespace Bracelet
{
    partial class Saisie_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saisie_Form1));
            this.cbxCampCour = new System.Windows.Forms.ComboBox();
            this.lbPlanChassCour = new System.Windows.Forms.Label();
            this.lbCampCour = new System.Windows.Forms.Label();
            this.CbxPlanChassCour = new System.Windows.Forms.ComboBox();
            this.lbComm1 = new System.Windows.Forms.Label();
            this.lbParamCour = new System.Windows.Forms.Label();
            this.lbComm2 = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.btModif = new System.Windows.Forms.Button();
            this.btSortir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCampCour
            // 
            this.cbxCampCour.FormattingEnabled = true;
            this.cbxCampCour.Location = new System.Drawing.Point(423, 259);
            this.cbxCampCour.Name = "cbxCampCour";
            this.cbxCampCour.Size = new System.Drawing.Size(179, 21);
            this.cbxCampCour.TabIndex = 0;
            // 
            // lbPlanChassCour
            // 
            this.lbPlanChassCour.AutoSize = true;
            this.lbPlanChassCour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlanChassCour.Location = new System.Drawing.Point(154, 410);
            this.lbPlanChassCour.Name = "lbPlanChassCour";
            this.lbPlanChassCour.Size = new System.Drawing.Size(244, 24);
            this.lbPlanChassCour.TabIndex = 1;
            this.lbPlanChassCour.Text = "Plan de Chasse courant :";
            // 
            // lbCampCour
            // 
            this.lbCampCour.AutoSize = true;
            this.lbCampCour.BackColor = System.Drawing.SystemColors.Control;
            this.lbCampCour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampCour.Location = new System.Drawing.Point(154, 254);
            this.lbCampCour.Name = "lbCampCour";
            this.lbCampCour.Size = new System.Drawing.Size(218, 24);
            this.lbCampCour.TabIndex = 2;
            this.lbCampCour.Text = "Campagne courrante :";
            this.lbCampCour.Click += new System.EventHandler(this.label2_Click);
            // 
            // CbxPlanChassCour
            // 
            this.CbxPlanChassCour.FormattingEnabled = true;
            this.CbxPlanChassCour.Location = new System.Drawing.Point(423, 413);
            this.CbxPlanChassCour.Name = "CbxPlanChassCour";
            this.CbxPlanChassCour.Size = new System.Drawing.Size(179, 21);
            this.CbxPlanChassCour.TabIndex = 3;
            // 
            // lbComm1
            // 
            this.lbComm1.AutoSize = true;
            this.lbComm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComm1.Location = new System.Drawing.Point(204, 296);
            this.lbComm1.Name = "lbComm1";
            this.lbComm1.Size = new System.Drawing.Size(233, 18);
            this.lbComm1.TabIndex = 4;
            this.lbComm1.Text = "(sur laquelle vous voulez travailler)";
            this.lbComm1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbParamCour
            // 
            this.lbParamCour.AutoSize = true;
            this.lbParamCour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParamCour.Location = new System.Drawing.Point(389, 74);
            this.lbParamCour.Name = "lbParamCour";
            this.lbParamCour.Size = new System.Drawing.Size(360, 39);
            this.lbParamCour.TabIndex = 5;
            this.lbParamCour.Text = "Paramètres courants";
            this.lbParamCour.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbComm2
            // 
            this.lbComm2.AutoSize = true;
            this.lbComm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComm2.Location = new System.Drawing.Point(204, 451);
            this.lbComm2.Name = "lbComm2";
            this.lbComm2.Size = new System.Drawing.Size(222, 18);
            this.lbComm2.TabIndex = 6;
            this.lbComm2.Text = "(sur lequel vous voulez travailler)";
            this.lbComm2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotes.Location = new System.Drawing.Point(638, 206);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(544, 288);
            this.lbNotes.TabIndex = 7;
            this.lbNotes.Text = resources.GetString("lbNotes.Text");
            this.lbNotes.Click += new System.EventHandler(this.label6_Click);
            // 
            // btModif
            // 
            this.btModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModif.Location = new System.Drawing.Point(423, 651);
            this.btModif.Name = "btModif";
            this.btModif.Size = new System.Drawing.Size(161, 34);
            this.btModif.TabIndex = 8;
            this.btModif.Text = "Modification";
            this.btModif.UseVisualStyleBackColor = true;
            // 
            // btSortir
            // 
            this.btSortir.Image = global::Bracelet.Properties.Resources.logout__1_;
            this.btSortir.Location = new System.Drawing.Point(628, 651);
            this.btSortir.Name = "btSortir";
            this.btSortir.Size = new System.Drawing.Size(161, 34);
            this.btSortir.TabIndex = 9;
            this.btSortir.UseVisualStyleBackColor = true;
            // 
            // Saisie_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.btSortir);
            this.Controls.Add(this.btModif);
            this.Controls.Add(this.lbNotes);
            this.Controls.Add(this.lbComm2);
            this.Controls.Add(this.lbParamCour);
            this.Controls.Add(this.lbComm1);
            this.Controls.Add(this.CbxPlanChassCour);
            this.Controls.Add(this.lbCampCour);
            this.Controls.Add(this.lbPlanChassCour);
            this.Controls.Add(this.cbxCampCour);
            this.Name = "Saisie_Form1";
            this.Text = "Saisie_Form1";
            this.Load += new System.EventHandler(this.Saisie_Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCampCour;
        private System.Windows.Forms.Label lbPlanChassCour;
        private System.Windows.Forms.Label lbCampCour;
        private System.Windows.Forms.ComboBox CbxPlanChassCour;
        private System.Windows.Forms.Label lbComm1;
        private System.Windows.Forms.Label lbParamCour;
        private System.Windows.Forms.Label lbComm2;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Button btModif;
        private System.Windows.Forms.Button btSortir;
    }
}