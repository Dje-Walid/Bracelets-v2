namespace Bracelet
{
    partial class Action_Form5_F4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action_Form5_F4));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNumModif = new System.Windows.Forms.Label();
            this.lbNewNum = new System.Windows.Forms.Label();
            this.lbOldNum = new System.Windows.Forms.Label();
            this.lbDateModif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation des modifications de numéros de plans de chasse";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbNumModif
            // 
            this.lbNumModif.AutoSize = true;
            this.lbNumModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumModif.Location = new System.Drawing.Point(357, 228);
            this.lbNumModif.Name = "lbNumModif";
            this.lbNumModif.Size = new System.Drawing.Size(83, 24);
            this.lbNumModif.TabIndex = 2;
            this.lbNumModif.Text = "N°Modif";
            // 
            // lbNewNum
            // 
            this.lbNewNum.AutoSize = true;
            this.lbNewNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewNum.Location = new System.Drawing.Point(1355, 228);
            this.lbNewNum.Name = "lbNewNum";
            this.lbNewNum.Size = new System.Drawing.Size(172, 24);
            this.lbNewNum.TabIndex = 3;
            this.lbNewNum.Text = "Nouveau numéro";
            // 
            // lbOldNum
            // 
            this.lbOldNum.AutoSize = true;
            this.lbOldNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldNum.Location = new System.Drawing.Point(1025, 228);
            this.lbOldNum.Name = "lbOldNum";
            this.lbOldNum.Size = new System.Drawing.Size(154, 24);
            this.lbOldNum.TabIndex = 4;
            this.lbOldNum.Text = "Ancien numéro";
            // 
            // lbDateModif
            // 
            this.lbDateModif.AutoSize = true;
            this.lbDateModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateModif.Location = new System.Drawing.Point(606, 228);
            this.lbDateModif.Name = "lbDateModif";
            this.lbDateModif.Size = new System.Drawing.Size(200, 24);
            this.lbDateModif.TabIndex = 5;
            this.lbDateModif.Text = "Date de modification";
            // 
            // Action_Form5_F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.lbDateModif);
            this.Controls.Add(this.lbOldNum);
            this.Controls.Add(this.lbNewNum);
            this.Controls.Add(this.lbNumModif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Action_Form5_F4";
            this.Text = "Plan de Chasse Grand Gibier : Paramètres des bracelets par campagne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Action_Form5_F4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbNumModif;
        private System.Windows.Forms.Label lbNewNum;
        private System.Windows.Forms.Label lbOldNum;
        private System.Windows.Forms.Label lbDateModif;
    }
}