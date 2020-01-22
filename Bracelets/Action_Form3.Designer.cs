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
            this.btAnnule_Action_Form1 = new System.Windows.Forms.Button();
            this.bt_lancer_Action_Form1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btActionForm3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbBasculPropAccord = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btAnnule_Action_Form1
            // 
            this.btAnnule_Action_Form1.Location = new System.Drawing.Point(443, 390);
            this.btAnnule_Action_Form1.Name = "btAnnule_Action_Form1";
            this.btAnnule_Action_Form1.Size = new System.Drawing.Size(102, 23);
            this.btAnnule_Action_Form1.TabIndex = 15;
            this.btAnnule_Action_Form1.Text = "Annuler";
            this.btAnnule_Action_Form1.UseVisualStyleBackColor = true;
            this.btAnnule_Action_Form1.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // bt_lancer_Action_Form1
            // 
            this.bt_lancer_Action_Form1.Location = new System.Drawing.Point(175, 390);
            this.bt_lancer_Action_Form1.Name = "bt_lancer_Action_Form1";
            this.bt_lancer_Action_Form1.Size = new System.Drawing.Size(182, 23);
            this.bt_lancer_Action_Form1.TabIndex = 14;
            this.bt_lancer_Action_Form1.Text = "Lancer l\'attribution automatique\r\n";
            this.bt_lancer_Action_Form1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(244, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date d\'attribution :";
            // 
            // btActionForm3
            // 
            this.btActionForm3.Location = new System.Drawing.Point(247, 268);
            this.btActionForm3.Name = "btActionForm3";
            this.btActionForm3.Size = new System.Drawing.Size(260, 33);
            this.btActionForm3.TabIndex = 11;
            this.btActionForm3.Text = "Selcetion massifs  -> Tous les massifs";
            this.btActionForm3.UseVisualStyleBackColor = true;
            this.btActionForm3.Click += new System.EventHandler(this.btnSelecMass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Si vous ne voulez opérer d\'attribution que sur certains massifs, alors cliquez su" +
    "r le bouton ci-dessous.\r\n";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(156, 92);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(454, 128);
            this.lb.TabIndex = 9;
            this.lb.Text = resources.GetString("lb.Text");
            // 
            // lbBasculPropAccord
            // 
            this.lbBasculPropAccord.AutoSize = true;
            this.lbBasculPropAccord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBasculPropAccord.Location = new System.Drawing.Point(229, 19);
            this.lbBasculPropAccord.Name = "lbBasculPropAccord";
            this.lbBasculPropAccord.Size = new System.Drawing.Size(316, 62);
            this.lbBasculPropAccord.TabIndex = 8;
            this.lbBasculPropAccord.Text = "Attribution automatique\r\nde Bracelets\r\n";
            this.lbBasculPropAccord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 323);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // Action_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btAnnule_Action_Form1);
            this.Controls.Add(this.bt_lancer_Action_Form1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btActionForm3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbBasculPropAccord);
            this.Name = "Action_Form3";
            this.Text = "Action_Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnule_Action_Form1;
        private System.Windows.Forms.Button bt_lancer_Action_Form1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btActionForm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbBasculPropAccord;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}