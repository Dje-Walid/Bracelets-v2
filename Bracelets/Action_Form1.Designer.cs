namespace Bracelet
{
    partial class Action_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form1));
            this.lbBasculPropAccord = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAction_Form1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEspecAbascul = new System.Windows.Forms.ComboBox();
            this.btnLanceBascul = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBasculPropAccord
            // 
            this.lbBasculPropAccord.AutoSize = true;
            this.lbBasculPropAccord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasculPropAccord.Location = new System.Drawing.Point(111, 22);
            this.lbBasculPropAccord.Name = "lbBasculPropAccord";
            this.lbBasculPropAccord.Size = new System.Drawing.Size(434, 29);
            this.lbBasculPropAccord.TabIndex = 0;
            this.lbBasculPropAccord.Text = "Basculement  Proposés - > Accodés";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(113, 76);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(422, 65);
            this.lb.TabIndex = 1;
            this.lb.Text = resources.GetString("lb.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Si vous ne voulez opérer le basculement que sur certains massifs alors cliquez su" +
    "r le bouton ci-dessous";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btAction_Form1
            // 
            this.btAction_Form1.Location = new System.Drawing.Point(225, 211);
            this.btAction_Form1.Name = "btAction_Form1";
            this.btAction_Form1.Size = new System.Drawing.Size(260, 33);
            this.btAction_Form1.TabIndex = 3;
            this.btAction_Form1.Text = "Selcetion massifs  -> Tous les massifs";
            this.btAction_Form1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(162, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Espèce à basculer :";
            // 
            // cbxEspecAbascul
            // 
            this.cbxEspecAbascul.FormattingEnabled = true;
            this.cbxEspecAbascul.Location = new System.Drawing.Point(329, 268);
            this.cbxEspecAbascul.Name = "cbxEspecAbascul";
            this.cbxEspecAbascul.Size = new System.Drawing.Size(140, 21);
            this.cbxEspecAbascul.TabIndex = 5;
            // 
            // btnLanceBascul
            // 
            this.btnLanceBascul.Location = new System.Drawing.Point(165, 337);
            this.btnLanceBascul.Name = "btnLanceBascul";
            this.btnLanceBascul.Size = new System.Drawing.Size(168, 23);
            this.btnLanceBascul.TabIndex = 6;
            this.btnLanceBascul.Text = "Lancer le basculement";
            this.btnLanceBascul.UseVisualStyleBackColor = true;
            // 
            // btnAnnule
            // 
            this.btnAnnule.Location = new System.Drawing.Point(443, 336);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(102, 23);
            this.btnAnnule.TabIndex = 7;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            // 
            // Action_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 379);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnLanceBascul);
            this.Controls.Add(this.cbxEspecAbascul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAction_Form1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbBasculPropAccord);
            this.Name = "Action_Form1";
            this.Text = "Action_Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBasculPropAccord;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAction_Form1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEspecAbascul;
        private System.Windows.Forms.Button btnLanceBascul;
        private System.Windows.Forms.Button btnAnnule;
    }
}