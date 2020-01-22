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
            this.lbBasculPropAccord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasculPropAccord.Location = new System.Drawing.Point(297, 57);
            this.lbBasculPropAccord.Name = "lbBasculPropAccord";
            this.lbBasculPropAccord.Size = new System.Drawing.Size(610, 39);
            this.lbBasculPropAccord.TabIndex = 0;
            this.lbBasculPropAccord.Text = "Basculement  Proposés - > Accodés";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(276, 184);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(742, 120);
            this.lb.TabIndex = 1;
            this.lb.Text = resources.GetString("lb.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(878, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Si vous ne voulez opérer le basculement que sur certains massifs alors cliquez su" +
    "r le bouton ci-dessous";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btAction_Form1
            // 
            this.btAction_Form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAction_Form1.Location = new System.Drawing.Point(423, 399);
            this.btAction_Form1.Name = "btAction_Form1";
            this.btAction_Form1.Size = new System.Drawing.Size(448, 53);
            this.btAction_Form1.TabIndex = 3;
            this.btAction_Form1.Text = "Selcetion massifs  -> Tous les massifs";
            this.btAction_Form1.UseVisualStyleBackColor = true;
            this.btAction_Form1.Click += new System.EventHandler(this.btAction_Form1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(300, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Espèce à basculer :";
            // 
            // cbxEspecAbascul
            // 
            this.cbxEspecAbascul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecAbascul.FormattingEnabled = true;
            this.cbxEspecAbascul.Location = new System.Drawing.Point(582, 487);
            this.cbxEspecAbascul.Name = "cbxEspecAbascul";
            this.cbxEspecAbascul.Size = new System.Drawing.Size(186, 32);
            this.cbxEspecAbascul.TabIndex = 5;
            // 
            // btnLanceBascul
            // 
            this.btnLanceBascul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanceBascul.Location = new System.Drawing.Point(357, 596);
            this.btnLanceBascul.Name = "btnLanceBascul";
            this.btnLanceBascul.Size = new System.Drawing.Size(248, 37);
            this.btnLanceBascul.TabIndex = 6;
            this.btnLanceBascul.Text = "Lancer le basculement";
            this.btnLanceBascul.UseVisualStyleBackColor = true;
            // 
            // btnAnnule
            // 
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.Location = new System.Drawing.Point(701, 596);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(170, 37);
            this.btnAnnule.TabIndex = 7;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            // 
            // Action_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
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