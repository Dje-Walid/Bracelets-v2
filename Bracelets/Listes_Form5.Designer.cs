namespace Bracelet
{
    partial class Listes_Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listes_Form5));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbTypeRegroupement = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chbx = new System.Windows.Forms.CheckBox();
            this.tlTypesPlansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.braceletBDD = new Bracelet.BraceletBDD();
            this.txbxNomCourt = new System.Windows.Forms.TextBox();
            this.txbxNomPlan = new System.Windows.Forms.TextBox();
            this.txbxCodeType = new System.Windows.Forms.TextBox();
            this.lbCheckbox = new System.Windows.Forms.Label();
            this.lbTypeDePlan = new System.Windows.Forms.Label();
            this.lbTypeGestion = new System.Windows.Forms.Label();
            this.lbLesPlanDeChasse = new System.Windows.Forms.Label();
            this.lbNomCourt = new System.Windows.Forms.Label();
            this.lbNomTypePlanChasse = new System.Windows.Forms.Label();
            this.lbCodeType = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environnementCourantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basculerProposésAccordésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basculerFDCYEnONFEDDAFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributionBraceletsAutomatiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationsDattributionManuellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnBraceletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageDesActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesDatesDesActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsSouscommissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsCommissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsDDAFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionsFédérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listingDétiquettesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesParZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesParCommunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesTypesDePlanDeChasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesEspècesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesSériesDeBraceletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesGibiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesRefusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesCampagnesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesCommunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sécuritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeBraceletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterBraceletToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlTypesPlansTableAdapter = new Bracelet.BraceletBDDTableAdapters.tlTypesPlansTableAdapter();
            this.ckbxModif = new System.Windows.Forms.CheckBox();
            this.lb_selection = new System.Windows.Forms.Label();
            this.cbxSelection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxTypeRegroupement = new System.Windows.Forms.TextBox();
            this.txbxGestCommun = new System.Windows.Forms.TextBox();
            this.txbxCommission = new System.Windows.Forms.TextBox();
            this.txbxTypePlanCConce = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlTypesPlansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.braceletBDD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(668, 475);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 5);
            this.pictureBox3.TabIndex = 171;
            this.pictureBox3.TabStop = false;
            // 
            // lbTypeRegroupement
            // 
            this.lbTypeRegroupement.AutoSize = true;
            this.lbTypeRegroupement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeRegroupement.Location = new System.Drawing.Point(32, 391);
            this.lbTypeRegroupement.Name = "lbTypeRegroupement";
            this.lbTypeRegroupement.Size = new System.Drawing.Size(408, 24);
            this.lbTypeRegroupement.TabIndex = 170;
            this.lbTypeRegroupement.Text = "Type de regroupement de gestion de NumPlan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(668, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 5);
            this.pictureBox2.TabIndex = 169;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(683, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 89);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // chbx
            // 
            this.chbx.AutoSize = true;
            this.chbx.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "ProfilGestSanglierGdGibier", true));
            this.chbx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tlTypesPlansBindingSource, "ProfilGestSanglierGdGibier", true));
            this.chbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbx.Location = new System.Drawing.Point(473, 610);
            this.chbx.Name = "chbx";
            this.chbx.Size = new System.Drawing.Size(15, 14);
            this.chbx.TabIndex = 167;
            this.chbx.UseVisualStyleBackColor = true;
            // 
            // tlTypesPlansBindingSource
            // 
            this.tlTypesPlansBindingSource.DataMember = "tlTypesPlans";
            this.tlTypesPlansBindingSource.DataSource = this.braceletBDD;
            // 
            // braceletBDD
            // 
            this.braceletBDD.DataSetName = "BraceletBDD";
            this.braceletBDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txbxNomCourt
            // 
            this.txbxNomCourt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.braceletBDD, "tlTypesPlans.LibTypePlanCourt", true));
            this.txbxNomCourt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "LibTypePlanCourt", true));
            this.txbxNomCourt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNomCourt.Location = new System.Drawing.Point(473, 342);
            this.txbxNomCourt.Name = "txbxNomCourt";
            this.txbxNomCourt.ReadOnly = true;
            this.txbxNomCourt.Size = new System.Drawing.Size(186, 29);
            this.txbxNomCourt.TabIndex = 166;
            // 
            // txbxNomPlan
            // 
            this.txbxNomPlan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.braceletBDD, "tlTypesPlans.LibTypePlan", true));
            this.txbxNomPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNomPlan.Location = new System.Drawing.Point(472, 294);
            this.txbxNomPlan.Name = "txbxNomPlan";
            this.txbxNomPlan.ReadOnly = true;
            this.txbxNomPlan.Size = new System.Drawing.Size(462, 29);
            this.txbxNomPlan.TabIndex = 165;
            // 
            // txbxCodeType
            // 
            this.txbxCodeType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tlTypesPlansBindingSource, "CdTypePlan", true));
            this.txbxCodeType.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.braceletBDD, "tlTypesPlans.CdTypePlan", true));
            this.txbxCodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCodeType.Location = new System.Drawing.Point(473, 249);
            this.txbxCodeType.Name = "txbxCodeType";
            this.txbxCodeType.ReadOnly = true;
            this.txbxCodeType.Size = new System.Drawing.Size(186, 29);
            this.txbxCodeType.TabIndex = 164;
            this.txbxCodeType.TextChanged += new System.EventHandler(this.txbxCodeType_TextChanged);
            // 
            // lbCheckbox
            // 
            this.lbCheckbox.AutoSize = true;
            this.lbCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckbox.Location = new System.Drawing.Point(74, 600);
            this.lbCheckbox.Name = "lbCheckbox";
            this.lbCheckbox.Size = new System.Drawing.Size(366, 24);
            this.lbCheckbox.TabIndex = 163;
            this.lbCheckbox.Text = "Ce type de plan gère-t-il les minimas à tuer";
            // 
            // lbTypeDePlan
            // 
            this.lbTypeDePlan.AutoSize = true;
            this.lbTypeDePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeDePlan.Location = new System.Drawing.Point(83, 548);
            this.lbTypeDePlan.Name = "lbTypeDePlan";
            this.lbTypeDePlan.Size = new System.Drawing.Size(357, 24);
            this.lbTypeDePlan.TabIndex = 162;
            this.lbTypeDePlan.Text = "Ce type de plan concerne principalement";
            // 
            // lbTypeGestion
            // 
            this.lbTypeGestion.AutoSize = true;
            this.lbTypeGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeGestion.Location = new System.Drawing.Point(20, 440);
            this.lbTypeGestion.Name = "lbTypeGestion";
            this.lbTypeGestion.Size = new System.Drawing.Size(420, 24);
            this.lbTypeGestion.TabIndex = 161;
            this.lbTypeGestion.Text = "Type des gestion des communes dans NumPlan";
            // 
            // lbLesPlanDeChasse
            // 
            this.lbLesPlanDeChasse.AutoSize = true;
            this.lbLesPlanDeChasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesPlanDeChasse.Location = new System.Drawing.Point(26, 484);
            this.lbLesPlanDeChasse.Name = "lbLesPlanDeChasse";
            this.lbLesPlanDeChasse.Size = new System.Drawing.Size(414, 48);
            this.lbLesPlanDeChasse.TabIndex = 160;
            this.lbLesPlanDeChasse.Text = "Les plans de chasse sont regroupés pour les \r\ndocuments sous-commission et commis" +
    "sion par";
            // 
            // lbNomCourt
            // 
            this.lbNomCourt.AutoSize = true;
            this.lbNomCourt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomCourt.Location = new System.Drawing.Point(207, 345);
            this.lbNomCourt.Name = "lbNomCourt";
            this.lbNomCourt.Size = new System.Drawing.Size(233, 24);
            this.lbNomCourt.TabIndex = 159;
            this.lbNomCourt.Text = "Nom court du type de plan";
            // 
            // lbNomTypePlanChasse
            // 
            this.lbNomTypePlanChasse.AutoSize = true;
            this.lbNomTypePlanChasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomTypePlanChasse.Location = new System.Drawing.Point(162, 294);
            this.lbNomTypePlanChasse.Name = "lbNomTypePlanChasse";
            this.lbNomTypePlanChasse.Size = new System.Drawing.Size(278, 24);
            this.lbNomTypePlanChasse.TabIndex = 158;
            this.lbNomTypePlanChasse.Text = "Nom du type de plan de chasse";
            // 
            // lbCodeType
            // 
            this.lbCodeType.AutoSize = true;
            this.lbCodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeType.Location = new System.Drawing.Point(344, 249);
            this.lbCodeType.Name = "lbCodeType";
            this.lbCodeType.Size = new System.Drawing.Size(96, 24);
            this.lbCodeType.TabIndex = 157;
            this.lbCodeType.Text = "Code type";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Bracelet.Properties.Resources.logout__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1101, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 156;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(116, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 39);
            this.label1.TabIndex = 154;
            this.label1.Text = "Paramétrage des types de plans de chasse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(398, 72);
            this.label10.TabIndex = 172;
            this.label10.Text = "Ces deux informations peuvent être modifiées \r\nseulement avant la première créati" +
    "on de plan \r\nde chasse pour ce type de plan de chasse !";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.editionsToolStripMenuItem,
            this.listesToolStripMenuItem,
            this.importExportToolStripMenuItem,
            this.sécuritéToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.quitterBraceletToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 179;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.environnementCourantToolStripMenuItem,
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem});
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saisieToolStripMenuItem.Text = "Saisie";
            // 
            // environnementCourantToolStripMenuItem
            // 
            this.environnementCourantToolStripMenuItem.Name = "environnementCourantToolStripMenuItem";
            this.environnementCourantToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.environnementCourantToolStripMenuItem.Text = "Environnement Courant";
            this.environnementCourantToolStripMenuItem.Click += new System.EventHandler(this.environnementCourantToolStripMenuItem_Click);
            // 
            // saisirConsulterLesPlanDeChasseToolStripMenuItem
            // 
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem.Name = "saisirConsulterLesPlanDeChasseToolStripMenuItem";
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem.Text = "Saisir/Consulter les plan de chasse";
            this.saisirConsulterLesPlanDeChasseToolStripMenuItem.Click += new System.EventHandler(this.saisirConsulterLesPlanDeChasseToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basculerProposésAccordésToolStripMenuItem,
            this.basculerFDCYEnONFEDDAFToolStripMenuItem,
            this.attributionBraceletsAutomatiqueToolStripMenuItem,
            this.modificationsDattributionManuellesToolStripMenuItem,
            this.paramétrageDesActionsToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // basculerProposésAccordésToolStripMenuItem
            // 
            this.basculerProposésAccordésToolStripMenuItem.Name = "basculerProposésAccordésToolStripMenuItem";
            this.basculerProposésAccordésToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.basculerProposésAccordésToolStripMenuItem.Text = "Basculer proposés / accordés";
            this.basculerProposésAccordésToolStripMenuItem.Click += new System.EventHandler(this.basculerProposésAccordésToolStripMenuItem_Click);
            // 
            // basculerFDCYEnONFEDDAFToolStripMenuItem
            // 
            this.basculerFDCYEnONFEDDAFToolStripMenuItem.Name = "basculerFDCYEnONFEDDAFToolStripMenuItem";
            this.basculerFDCYEnONFEDDAFToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.basculerFDCYEnONFEDDAFToolStripMenuItem.Text = "Basculer FDCY en ONF e DDAF";
            this.basculerFDCYEnONFEDDAFToolStripMenuItem.Click += new System.EventHandler(this.basculerFDCYEnONFEDDAFToolStripMenuItem_Click);
            // 
            // attributionBraceletsAutomatiqueToolStripMenuItem
            // 
            this.attributionBraceletsAutomatiqueToolStripMenuItem.Name = "attributionBraceletsAutomatiqueToolStripMenuItem";
            this.attributionBraceletsAutomatiqueToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.attributionBraceletsAutomatiqueToolStripMenuItem.Text = "Attribution bracelets automatique";
            this.attributionBraceletsAutomatiqueToolStripMenuItem.Click += new System.EventHandler(this.attributionBraceletsAutomatiqueToolStripMenuItem_Click);
            // 
            // modificationsDattributionManuellesToolStripMenuItem
            // 
            this.modificationsDattributionManuellesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem,
            this.supprimerUnBraceletToolStripMenuItem});
            this.modificationsDattributionManuellesToolStripMenuItem.Name = "modificationsDattributionManuellesToolStripMenuItem";
            this.modificationsDattributionManuellesToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.modificationsDattributionManuellesToolStripMenuItem.Text = "Modifications d\'attribution manuelles";
            // 
            // changerLeBénéficiaireDunBraceletToolStripMenuItem
            // 
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem.Name = "changerLeBénéficiaireDunBraceletToolStripMenuItem";
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem.Text = "Paramètrage des bracelets pour la campagne";
            this.changerLeBénéficiaireDunBraceletToolStripMenuItem.Click += new System.EventHandler(this.changerLeBénéficiaireDunBraceletToolStripMenuItem_Click);
            // 
            // supprimerUnBraceletToolStripMenuItem
            // 
            this.supprimerUnBraceletToolStripMenuItem.Name = "supprimerUnBraceletToolStripMenuItem";
            this.supprimerUnBraceletToolStripMenuItem.Size = new System.Drawing.Size(313, 22);
            this.supprimerUnBraceletToolStripMenuItem.Text = "Param. Minima à tuer par espèce et par zones";
            this.supprimerUnBraceletToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnBraceletToolStripMenuItem_Click);
            // 
            // paramétrageDesActionsToolStripMenuItem
            // 
            this.paramétrageDesActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem,
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem,
            this.historiqueDesDatesDesActionsToolStripMenuItem,
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem});
            this.paramétrageDesActionsToolStripMenuItem.Name = "paramétrageDesActionsToolStripMenuItem";
            this.paramétrageDesActionsToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.paramétrageDesActionsToolStripMenuItem.Text = "Paramétrage des actions";
            // 
            // paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem
            // 
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem.Name = "paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem";
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem.Text = "Paramétrage des bracelets pour les campagnes";
            this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem.Click += new System.EventHandler(this.paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem_Click);
            // 
            // paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem
            // 
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem.Name = "paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem";
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem.Text = "Param. Minima à tuer par espèces et par zones";
            this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem.Click += new System.EventHandler(this.paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem_Click);
            // 
            // historiqueDesDatesDesActionsToolStripMenuItem
            // 
            this.historiqueDesDatesDesActionsToolStripMenuItem.Name = "historiqueDesDatesDesActionsToolStripMenuItem";
            this.historiqueDesDatesDesActionsToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.historiqueDesDatesDesActionsToolStripMenuItem.Text = "Historique des dates des Actions";
            this.historiqueDesDatesDesActionsToolStripMenuItem.Click += new System.EventHandler(this.historiqueDesDatesDesActionsToolStripMenuItem_Click);
            // 
            // historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem
            // 
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem.Name = "historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem";
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem.Text = "Historique des modifs de numéros de plans de chasse";
            this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem.Click += new System.EventHandler(this.historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem_Click);
            // 
            // editionsToolStripMenuItem
            // 
            this.editionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsSouscommissionToolStripMenuItem,
            this.documentsCommissionToolStripMenuItem,
            this.editionsDDAFToolStripMenuItem,
            this.editionsFédérationToolStripMenuItem,
            this.statistiquesToolStripMenuItem});
            this.editionsToolStripMenuItem.Name = "editionsToolStripMenuItem";
            this.editionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.editionsToolStripMenuItem.Text = "Editions";
            // 
            // documentsSouscommissionToolStripMenuItem
            // 
            this.documentsSouscommissionToolStripMenuItem.Name = "documentsSouscommissionToolStripMenuItem";
            this.documentsSouscommissionToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.documentsSouscommissionToolStripMenuItem.Text = "Documents sous-commission";
            this.documentsSouscommissionToolStripMenuItem.Click += new System.EventHandler(this.documentsSouscommissionToolStripMenuItem_Click);
            // 
            // documentsCommissionToolStripMenuItem
            // 
            this.documentsCommissionToolStripMenuItem.Name = "documentsCommissionToolStripMenuItem";
            this.documentsCommissionToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.documentsCommissionToolStripMenuItem.Text = "Documents commission";
            this.documentsCommissionToolStripMenuItem.Click += new System.EventHandler(this.documentsCommissionToolStripMenuItem_Click);
            // 
            // editionsDDAFToolStripMenuItem
            // 
            this.editionsDDAFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem,
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem,
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem,
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem,
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem,
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem});
            this.editionsDDAFToolStripMenuItem.Name = "editionsDDAFToolStripMenuItem";
            this.editionsDDAFToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.editionsDDAFToolStripMenuItem.Text = "Editions DDAF";
            // 
            // arrêtésIndividuelsTirÀLapprocheToolStripMenuItem
            // 
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem.Name = "arrêtésIndividuelsTirÀLapprocheToolStripMenuItem";
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem.Text = "Arrêtés individuels tir à l\'approche";
            this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem.Click += new System.EventHandler(this.arrêtésIndividuelsTirÀLapprocheToolStripMenuItem_Click);
            // 
            // arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem
            // 
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem.Name = "arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem";
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem.Text = "Arrêtés récapitulatif de tir à l\'approche";
            this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem.Click += new System.EventHandler(this.arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem_Click);
            // 
            // arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem
            // 
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem.Name = "arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem";
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem.Text = "Arrêtés individuels d\'attribution de Bracelets";
            this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem.Click += new System.EventHandler(this.arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem_Click);
            // 
            // arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem
            // 
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem.Name = "arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem";
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem.Text = "Arrêtés individuels d\'attribution de Bracelets V2";
            this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem.Click += new System.EventHandler(this.arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem_Click);
            // 
            // arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem
            // 
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem.Name = "arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem";
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem.Text = "Arrêtés récapitulatif d\'attribution de bracelets";
            this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem.Click += new System.EventHandler(this.arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem_Click);
            // 
            // réponseAuxDemandesDePlanDeChasseToolStripMenuItem
            // 
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem.Name = "réponseAuxDemandesDePlanDeChasseToolStripMenuItem";
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem.Text = "Réponse aux demandes de plan de chasse";
            this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem.Click += new System.EventHandler(this.réponseAuxDemandesDePlanDeChasseToolStripMenuItem_Click);
            // 
            // editionsFédérationToolStripMenuItem
            // 
            this.editionsFédérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listingDétiquettesToolStripMenuItem});
            this.editionsFédérationToolStripMenuItem.Name = "editionsFédérationToolStripMenuItem";
            this.editionsFédérationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.editionsFédérationToolStripMenuItem.Text = "Editions Fédération";
            // 
            // listingDétiquettesToolStripMenuItem
            // 
            this.listingDétiquettesToolStripMenuItem.Name = "listingDétiquettesToolStripMenuItem";
            this.listingDétiquettesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.listingDétiquettesToolStripMenuItem.Text = "Listing d\'étiquettes";
            this.listingDétiquettesToolStripMenuItem.Click += new System.EventHandler(this.listingDétiquettesToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiquesParZoneToolStripMenuItem,
            this.statistiquesParCommunesToolStripMenuItem,
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // statistiquesParZoneToolStripMenuItem
            // 
            this.statistiquesParZoneToolStripMenuItem.Name = "statistiquesParZoneToolStripMenuItem";
            this.statistiquesParZoneToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.statistiquesParZoneToolStripMenuItem.Text = "Statistiques par zone";
            this.statistiquesParZoneToolStripMenuItem.Click += new System.EventHandler(this.statistiquesParZoneToolStripMenuItem_Click);
            // 
            // statistiquesParCommunesToolStripMenuItem
            // 
            this.statistiquesParCommunesToolStripMenuItem.Name = "statistiquesParCommunesToolStripMenuItem";
            this.statistiquesParCommunesToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.statistiquesParCommunesToolStripMenuItem.Text = "Statistiques par communes";
            this.statistiquesParCommunesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesParCommunesToolStripMenuItem_Click);
            // 
            // statistiquesRéalisésListésParCommunesToolStripMenuItem
            // 
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem.Name = "statistiquesRéalisésListésParCommunesToolStripMenuItem";
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem.Text = "Statistiques réalisés listés par communes";
            this.statistiquesRéalisésListésParCommunesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesRéalisésListésParCommunesToolStripMenuItem_Click);
            // 
            // listesToolStripMenuItem
            // 
            this.listesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem,
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem,
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem,
            this.codesZonesToolStripMenuItem,
            this.codesTypesDePlanDeChasseToolStripMenuItem,
            this.codesEspècesToolStripMenuItem,
            this.codesSériesDeBraceletsToolStripMenuItem,
            this.codesGibiersToolStripMenuItem,
            this.codesRefusToolStripMenuItem,
            this.codesCampagnesToolStripMenuItem,
            this.codesCommunesToolStripMenuItem});
            this.listesToolStripMenuItem.Name = "listesToolStripMenuItem";
            this.listesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.listesToolStripMenuItem.Text = "Listes";
            // 
            // recapitulatifDesAttributionsParZoneToolStripMenuItem
            // 
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem.Name = "recapitulatifDesAttributionsParZoneToolStripMenuItem";
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem.Text = "Recapitulatif des attributions par zone";
            this.recapitulatifDesAttributionsParZoneToolStripMenuItem.Click += new System.EventHandler(this.recapitulatifDesAttributionsParZoneToolStripMenuItem_Click);
            // 
            // lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem
            // 
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem.Name = "lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem";
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem.Text = "Lettre de relance Réalisés non renseignés";
            this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem.Click += new System.EventHandler(this.lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem_Click);
            // 
            // listeDesAttributionsAccordéesSousRéserveToolStripMenuItem
            // 
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem.Name = "listeDesAttributionsAccordéesSousRéserveToolStripMenuItem";
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem.Text = "Liste des attributions accordées sous réserve";
            this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem.Click += new System.EventHandler(this.listeDesAttributionsAccordéesSousRéserveToolStripMenuItem_Click);
            // 
            // codesZonesToolStripMenuItem
            // 
            this.codesZonesToolStripMenuItem.Name = "codesZonesToolStripMenuItem";
            this.codesZonesToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesZonesToolStripMenuItem.Text = "Codes zones";
            this.codesZonesToolStripMenuItem.Click += new System.EventHandler(this.codesZonesToolStripMenuItem_Click);
            // 
            // codesTypesDePlanDeChasseToolStripMenuItem
            // 
            this.codesTypesDePlanDeChasseToolStripMenuItem.Name = "codesTypesDePlanDeChasseToolStripMenuItem";
            this.codesTypesDePlanDeChasseToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesTypesDePlanDeChasseToolStripMenuItem.Text = "Codes types de plan de chasse";
            this.codesTypesDePlanDeChasseToolStripMenuItem.Click += new System.EventHandler(this.codesTypesDePlanDeChasseToolStripMenuItem_Click);
            // 
            // codesEspècesToolStripMenuItem
            // 
            this.codesEspècesToolStripMenuItem.Name = "codesEspècesToolStripMenuItem";
            this.codesEspècesToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesEspècesToolStripMenuItem.Text = "Codes espèces";
            this.codesEspècesToolStripMenuItem.Click += new System.EventHandler(this.codesEspècesToolStripMenuItem_Click);
            // 
            // codesSériesDeBraceletsToolStripMenuItem
            // 
            this.codesSériesDeBraceletsToolStripMenuItem.Name = "codesSériesDeBraceletsToolStripMenuItem";
            this.codesSériesDeBraceletsToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesSériesDeBraceletsToolStripMenuItem.Text = "Codes séries de bracelets";
            this.codesSériesDeBraceletsToolStripMenuItem.Click += new System.EventHandler(this.codesSériesDeBraceletsToolStripMenuItem_Click);
            // 
            // codesGibiersToolStripMenuItem
            // 
            this.codesGibiersToolStripMenuItem.Name = "codesGibiersToolStripMenuItem";
            this.codesGibiersToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesGibiersToolStripMenuItem.Text = "Codes gibiers";
            this.codesGibiersToolStripMenuItem.Click += new System.EventHandler(this.codesGibiersToolStripMenuItem_Click);
            // 
            // codesRefusToolStripMenuItem
            // 
            this.codesRefusToolStripMenuItem.Name = "codesRefusToolStripMenuItem";
            this.codesRefusToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesRefusToolStripMenuItem.Text = "Codes refus";
            this.codesRefusToolStripMenuItem.Click += new System.EventHandler(this.codesRefusToolStripMenuItem_Click);
            // 
            // codesCampagnesToolStripMenuItem
            // 
            this.codesCampagnesToolStripMenuItem.Name = "codesCampagnesToolStripMenuItem";
            this.codesCampagnesToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesCampagnesToolStripMenuItem.Text = "Codes campagnes";
            this.codesCampagnesToolStripMenuItem.Click += new System.EventHandler(this.codesCampagnesToolStripMenuItem_Click);
            // 
            // codesCommunesToolStripMenuItem
            // 
            this.codesCommunesToolStripMenuItem.Name = "codesCommunesToolStripMenuItem";
            this.codesCommunesToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.codesCommunesToolStripMenuItem.Text = "Codes communes";
            this.codesCommunesToolStripMenuItem.Click += new System.EventHandler(this.codesCommunesToolStripMenuItem_Click);
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.importExportToolStripMenuItem.Text = "Import/Export";
            this.importExportToolStripMenuItem.Click += new System.EventHandler(this.importExportToolStripMenuItem_Click);
            // 
            // sécuritéToolStripMenuItem
            // 
            this.sécuritéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDeMotDePasseToolStripMenuItem});
            this.sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            this.sécuritéToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sécuritéToolStripMenuItem.Text = "Sécurité";
            // 
            // changerDeMotDePasseToolStripMenuItem
            // 
            this.changerDeMotDePasseToolStripMenuItem.Name = "changerDeMotDePasseToolStripMenuItem";
            this.changerDeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.changerDeMotDePasseToolStripMenuItem.Text = "Changer de mot de passe";
            this.changerDeMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerDeMotDePasseToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportationExcelToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // exportationExcelToolStripMenuItem
            // 
            this.exportationExcelToolStripMenuItem.Name = "exportationExcelToolStripMenuItem";
            this.exportationExcelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exportationExcelToolStripMenuItem.Text = "Exportation Excel";
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurWordToolStripMenuItem,
            this.aProposDeBraceletToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // manuelUtilisateurWordToolStripMenuItem
            // 
            this.manuelUtilisateurWordToolStripMenuItem.Name = "manuelUtilisateurWordToolStripMenuItem";
            this.manuelUtilisateurWordToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.manuelUtilisateurWordToolStripMenuItem.Text = "Manuel utilisateur (Word)";
            this.manuelUtilisateurWordToolStripMenuItem.Click += new System.EventHandler(this.manuelUtilisateurWordToolStripMenuItem_Click);
            // 
            // aProposDeBraceletToolStripMenuItem
            // 
            this.aProposDeBraceletToolStripMenuItem.Name = "aProposDeBraceletToolStripMenuItem";
            this.aProposDeBraceletToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aProposDeBraceletToolStripMenuItem.Text = "A propos de Bracelet…";
            this.aProposDeBraceletToolStripMenuItem.Click += new System.EventHandler(this.aProposDeBraceletToolStripMenuItem_Click);
            // 
            // quitterBraceletToolStripMenuItem1
            // 
            this.quitterBraceletToolStripMenuItem1.Name = "quitterBraceletToolStripMenuItem1";
            this.quitterBraceletToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.quitterBraceletToolStripMenuItem1.Text = "Quitter Bracelet";
            this.quitterBraceletToolStripMenuItem1.Click += new System.EventHandler(this.quitterBraceletToolStripMenuItem1_Click);
            // 
            // tlTypesPlansTableAdapter
            // 
            this.tlTypesPlansTableAdapter.ClearBeforeFill = true;
            // 
            // ckbxModif
            // 
            this.ckbxModif.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbxModif.AutoSize = true;
            this.ckbxModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ckbxModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxModif.ForeColor = System.Drawing.Color.Black;
            this.ckbxModif.Location = new System.Drawing.Point(933, 106);
            this.ckbxModif.Name = "ckbxModif";
            this.ckbxModif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckbxModif.Size = new System.Drawing.Size(120, 34);
            this.ckbxModif.TabIndex = 180;
            this.ckbxModif.Text = "Modification";
            this.ckbxModif.UseVisualStyleBackColor = true;
            this.ckbxModif.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_selection
            // 
            this.lb_selection.AutoSize = true;
            this.lb_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selection.Location = new System.Drawing.Point(154, 167);
            this.lb_selection.Name = "lb_selection";
            this.lb_selection.Size = new System.Drawing.Size(286, 24);
            this.lb_selection.TabIndex = 181;
            this.lb_selection.Text = "Sélectionner un plan de chasse :";
            // 
            // cbxSelection
            // 
            this.cbxSelection.DataSource = this.tlTypesPlansBindingSource;
            this.cbxSelection.DisplayMember = "LibTypePlan";
            this.cbxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelection.FormattingEnabled = true;
            this.cbxSelection.Location = new System.Drawing.Point(549, 164);
            this.cbxSelection.Name = "cbxSelection";
            this.cbxSelection.Size = new System.Drawing.Size(385, 32);
            this.cbxSelection.TabIndex = 182;
            this.cbxSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tlTypesPlansBindingSource, "CdTypePlan", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 183;
            // 
            // txbxTypeRegroupement
            // 
            this.txbxTypeRegroupement.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "ProfilNumPlanTypeGroupe", true));
            this.txbxTypeRegroupement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.braceletBDD, "tlTypesPlans.ProfilNumPlanTypeGroupe", true));
            this.txbxTypeRegroupement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxTypeRegroupement.Location = new System.Drawing.Point(472, 391);
            this.txbxTypeRegroupement.Name = "txbxTypeRegroupement";
            this.txbxTypeRegroupement.ReadOnly = true;
            this.txbxTypeRegroupement.Size = new System.Drawing.Size(187, 29);
            this.txbxTypeRegroupement.TabIndex = 184;
            // 
            // txbxGestCommun
            // 
            this.txbxGestCommun.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "ProfilNumPlanCommune", true));
            this.txbxGestCommun.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tlTypesPlansBindingSource, "ProfilNumPlanCommune", true));
            this.txbxGestCommun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxGestCommun.Location = new System.Drawing.Point(472, 440);
            this.txbxGestCommun.Name = "txbxGestCommun";
            this.txbxGestCommun.ReadOnly = true;
            this.txbxGestCommun.Size = new System.Drawing.Size(187, 29);
            this.txbxGestCommun.TabIndex = 185;
            // 
            // txbxCommission
            // 
            this.txbxCommission.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "ProfilRegroupPlan", true));
            this.txbxCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tlTypesPlansBindingSource, "ProfilRegroupPlan", true));
            this.txbxCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxCommission.Location = new System.Drawing.Point(472, 494);
            this.txbxCommission.Name = "txbxCommission";
            this.txbxCommission.ReadOnly = true;
            this.txbxCommission.Size = new System.Drawing.Size(187, 29);
            this.txbxCommission.TabIndex = 186;
            // 
            // txbxTypePlanCConce
            // 
            this.txbxTypePlanCConce.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tlTypesPlansBindingSource, "ProfilLocaliTypePlan", true));
            this.txbxTypePlanCConce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.braceletBDD, "tlTypesPlans.ProfilLocaliTypePlan", true));
            this.txbxTypePlanCConce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxTypePlanCConce.Location = new System.Drawing.Point(472, 548);
            this.txbxTypePlanCConce.Name = "txbxTypePlanCConce";
            this.txbxTypePlanCConce.ReadOnly = true;
            this.txbxTypePlanCConce.Size = new System.Drawing.Size(187, 29);
            this.txbxTypePlanCConce.TabIndex = 187;
            // 
            // Listes_Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.txbxTypePlanCConce);
            this.Controls.Add(this.txbxCommission);
            this.Controls.Add(this.txbxGestCommun);
            this.Controls.Add(this.txbxTypeRegroupement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSelection);
            this.Controls.Add(this.lb_selection);
            this.Controls.Add(this.ckbxModif);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbTypeRegroupement);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chbx);
            this.Controls.Add(this.txbxNomCourt);
            this.Controls.Add(this.txbxNomPlan);
            this.Controls.Add(this.txbxCodeType);
            this.Controls.Add(this.lbCheckbox);
            this.Controls.Add(this.lbTypeDePlan);
            this.Controls.Add(this.lbTypeGestion);
            this.Controls.Add(this.lbLesPlanDeChasse);
            this.Controls.Add(this.lbNomCourt);
            this.Controls.Add(this.lbNomTypePlanChasse);
            this.Controls.Add(this.lbCodeType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listes_Form5";
            this.Text = "Codes types de plan de chasse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Listes_Form5_FormClosed);
            this.Load += new System.EventHandler(this.Listes_Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlTypesPlansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.braceletBDD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbTypeRegroupement;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chbx;
        private System.Windows.Forms.TextBox txbxNomCourt;
        private System.Windows.Forms.TextBox txbxNomPlan;
        private System.Windows.Forms.TextBox txbxCodeType;
        private System.Windows.Forms.Label lbCheckbox;
        private System.Windows.Forms.Label lbTypeDePlan;
        private System.Windows.Forms.Label lbTypeGestion;
        private System.Windows.Forms.Label lbLesPlanDeChasse;
        private System.Windows.Forms.Label lbNomCourt;
        private System.Windows.Forms.Label lbNomTypePlanChasse;
        private System.Windows.Forms.Label lbCodeType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environnementCourantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirConsulterLesPlanDeChasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basculerProposésAccordésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basculerFDCYEnONFEDDAFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributionBraceletsAutomatiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationsDattributionManuellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLeBénéficiaireDunBraceletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnBraceletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageDesActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDesDatesDesActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsSouscommissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsCommissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsDDAFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtésIndividuelsTirÀLapprocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réponseAuxDemandesDePlanDeChasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionsFédérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listingDétiquettesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesParZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesParCommunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesRéalisésListésParCommunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recapitulatifDesAttributionsParZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesAttributionsAccordéesSousRéserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesZonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesTypesDePlanDeChasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesEspècesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesSériesDeBraceletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesGibiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesRefusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesCampagnesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesCommunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sécuritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportationExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeBraceletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterBraceletToolStripMenuItem1;
        private BraceletBDD braceletBDD;
        private System.Windows.Forms.BindingSource tlTypesPlansBindingSource;
        private BraceletBDDTableAdapters.tlTypesPlansTableAdapter tlTypesPlansTableAdapter;
        private System.Windows.Forms.CheckBox ckbxModif;
        private System.Windows.Forms.Label lb_selection;
        private System.Windows.Forms.ComboBox cbxSelection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxTypeRegroupement;
        private System.Windows.Forms.TextBox txbxGestCommun;
        private System.Windows.Forms.TextBox txbxCommission;
        private System.Windows.Forms.TextBox txbxTypePlanCConce;
    }
}