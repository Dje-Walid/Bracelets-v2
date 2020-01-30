namespace Bracelet
{
    partial class Action_Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAction_Form2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEspecAbascul = new System.Windows.Forms.ComboBox();
            this.btnLanceBascul = new System.Windows.Forms.Button();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "        Basculement\r\nFDCY -> ONF et DDAF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(276, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(728, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(883, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Si vous ne voulez opérer le basculement que sur certains massifs alors cliquez su" +
    "r le bouton ci-dessous.";
            // 
            // btAction_Form2
            // 
            this.btAction_Form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAction_Form2.Location = new System.Drawing.Point(363, 405);
            this.btAction_Form2.Name = "btAction_Form2";
            this.btAction_Form2.Size = new System.Drawing.Size(516, 66);
            this.btAction_Form2.TabIndex = 3;
            this.btAction_Form2.Text = "Sélection Massif  -> Tous les Massifs";
            this.btAction_Form2.UseVisualStyleBackColor = true;
            this.btAction_Form2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(327, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Espèce à Basculer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxEspecAbascul
            // 
            this.cbxEspecAbascul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecAbascul.FormattingEnabled = true;
            this.cbxEspecAbascul.Location = new System.Drawing.Point(547, 565);
            this.cbxEspecAbascul.Name = "cbxEspecAbascul";
            this.cbxEspecAbascul.Size = new System.Drawing.Size(246, 32);
            this.cbxEspecAbascul.TabIndex = 5;
            // 
            // btnLanceBascul
            // 
            this.btnLanceBascul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanceBascul.ForeColor = System.Drawing.Color.Red;
            this.btnLanceBascul.Location = new System.Drawing.Point(317, 700);
            this.btnLanceBascul.Name = "btnLanceBascul";
            this.btnLanceBascul.Size = new System.Drawing.Size(263, 37);
            this.btnLanceBascul.TabIndex = 6;
            this.btnLanceBascul.Text = "Lancer le basculement";
            this.btnLanceBascul.UseVisualStyleBackColor = true;
            // 
            // btnAnnule
            // 
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.Location = new System.Drawing.Point(720, 700);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(168, 37);
            this.btnAnnule.TabIndex = 7;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            // 
            // Action_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.btnLanceBascul);
            this.Controls.Add(this.cbxEspecAbascul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btAction_Form2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Action_Form2";
            this.Text = "Basculer FDCY en ONF e DDAF";
            this.Load += new System.EventHandler(this.Action_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAction_Form2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEspecAbascul;
        private System.Windows.Forms.Button btnLanceBascul;
        private System.Windows.Forms.Button btnAnnule;
    }
}