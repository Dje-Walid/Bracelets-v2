namespace Bracelet
{
    partial class ImportExport_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExport_Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Importer = new System.Windows.Forms.Button();
            this.cbxSelecFich = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exporter = new System.Windows.Forms.Button();
            this.cbxSelecType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxSelecFich2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import / Export";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Importer);
            this.groupBox1.Controls.Add(this.cbxSelecFich);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 675);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(269, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 32);
            this.comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Selection du Type";
            // 
            // Importer
            // 
            this.Importer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Importer.Location = new System.Drawing.Point(172, 320);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(165, 40);
            this.Importer.TabIndex = 2;
            this.Importer.Text = "Importer";
            this.Importer.UseVisualStyleBackColor = true;
            // 
            // cbxSelecFich
            // 
            this.cbxSelecFich.FormattingEnabled = true;
            this.cbxSelecFich.Location = new System.Drawing.Point(269, 200);
            this.cbxSelecFich.Name = "cbxSelecFich";
            this.cbxSelecFich.Size = new System.Drawing.Size(195, 32);
            this.cbxSelecFich.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selection du Fichier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exporter);
            this.groupBox2.Controls.Add(this.cbxSelecType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxSelecFich2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(607, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 675);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export";
            // 
            // Exporter
            // 
            this.Exporter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exporter.Location = new System.Drawing.Point(242, 320);
            this.Exporter.Name = "Exporter";
            this.Exporter.Size = new System.Drawing.Size(165, 40);
            this.Exporter.TabIndex = 6;
            this.Exporter.Text = "Exporter";
            this.Exporter.UseVisualStyleBackColor = true;
            // 
            // cbxSelecType
            // 
            this.cbxSelecType.FormattingEnabled = true;
            this.cbxSelecType.Location = new System.Drawing.Point(335, 217);
            this.cbxSelecType.Name = "cbxSelecType";
            this.cbxSelecType.Size = new System.Drawing.Size(195, 32);
            this.cbxSelecType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selection du Type";
            // 
            // cbxSelecFich2
            // 
            this.cbxSelecFich2.FormattingEnabled = true;
            this.cbxSelecFich2.Location = new System.Drawing.Point(335, 148);
            this.cbxSelecFich2.Name = "cbxSelecFich2";
            this.cbxSelecFich2.Size = new System.Drawing.Size(195, 32);
            this.cbxSelecFich2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selection du Fichier";
            // 
            // ImportExport_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportExport_Form1";
            this.Text = "Import / Export";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Importer;
        private System.Windows.Forms.ComboBox cbxSelecFich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Exporter;
        private System.Windows.Forms.ComboBox cbxSelecType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSelecFich2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}