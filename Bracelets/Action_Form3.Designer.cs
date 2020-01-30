namespace Bracelet
{
    partial class Action_Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form3));
            this.bt_Annule = new System.Windows.Forms.Button();
            this.bt_lancer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Action_Form3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbBasculPropAccord = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bt_Annule
            // 
            this.bt_Annule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Annule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Annule.Location = new System.Drawing.Point(516, 558);
            this.bt_Annule.Name = "bt_Annule";
            this.bt_Annule.Size = new System.Drawing.Size(142, 40);
            this.bt_Annule.TabIndex = 15;
            this.bt_Annule.Text = "Annuler";
            this.bt_Annule.UseVisualStyleBackColor = true;
            this.bt_Annule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // bt_lancer
            // 
            this.bt_lancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_lancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lancer.Location = new System.Drawing.Point(234, 558);
            this.bt_lancer.Name = "bt_lancer";
            this.bt_lancer.Size = new System.Drawing.Size(204, 40);
            this.bt_lancer.TabIndex = 14;
            this.bt_lancer.Text = "Lancer l\'attribution automatique\r\n";
            this.bt_lancer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(264, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date d\'attribution :";
            // 
            // bt_Action_Form3
            // 
            this.bt_Action_Form3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Action_Form3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Action_Form3.Location = new System.Drawing.Point(268, 482);
            this.bt_Action_Form3.Name = "bt_Action_Form3";
            this.bt_Action_Form3.Size = new System.Drawing.Size(368, 33);
            this.bt_Action_Form3.TabIndex = 11;
            this.bt_Action_Form3.Text = "Selcetion massifs  -> Tous les massifs";
            this.bt_Action_Form3.UseVisualStyleBackColor = true;
            this.bt_Action_Form3.Click += new System.EventHandler(this.btnSelecMass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(855, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Si vous ne voulez opérer d\'attribution que sur certains massifs, alors cliquez su" +
    "r le bouton ci-dessous.\r\n";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(155, 137);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(641, 192);
            this.lb.TabIndex = 9;
            this.lb.Text = resources.GetString("lb.Text");
            // 
            // lbBasculPropAccord
            // 
            this.lbBasculPropAccord.AutoSize = true;
            this.lbBasculPropAccord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasculPropAccord.Location = new System.Drawing.Point(213, 9);
            this.lbBasculPropAccord.Name = "lbBasculPropAccord";
            this.lbBasculPropAccord.Size = new System.Drawing.Size(397, 78);
            this.lbBasculPropAccord.TabIndex = 8;
            this.lbBasculPropAccord.Text = "Attribution automatique\r\nde Bracelets\r\n";
            this.lbBasculPropAccord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(438, 424);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(132, 29);
            this.date1.TabIndex = 16;
            // 
            // Action_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.bt_Annule);
            this.Controls.Add(this.bt_lancer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Action_Form3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbBasculPropAccord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Action_Form3";
            this.Text = "Attribution automatique de Bracelets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Annule;
        private System.Windows.Forms.Button bt_lancer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Action_Form3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbBasculPropAccord;
        private System.Windows.Forms.DateTimePicker date1;
    }
}