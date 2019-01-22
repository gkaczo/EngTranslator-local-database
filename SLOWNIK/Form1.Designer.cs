namespace SLOWNIK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dsBaza1 = new SLOWNIK.dsBaza();
            this.tEnTableAdapter1 = new SLOWNIK.dsBazaTableAdapters.TEnTableAdapter();
            this.tKategorieTableAdapter1 = new SLOWNIK.dsBazaTableAdapters.TKategorieTableAdapter();
            this.tPolTableAdapter1 = new SLOWNIK.dsBazaTableAdapters.TPolTableAdapter();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabSlownik = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tscbRodzjSlownika = new System.Windows.Forms.ToolStripComboBox();
            this.tsbToSpeech = new System.Windows.Forms.ToolStripButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxWyrazy = new System.Windows.Forms.ListBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtWyszukaj = new System.Windows.Forms.TextBox();
            this.tabNauka = new System.Windows.Forms.TabPage();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveToNauka = new System.Windows.Forms.Button();
            this.btnAddToNauka = new System.Windows.Forms.Button();
            this.lbxKategorieWybrane = new System.Windows.Forms.ListBox();
            this.lbxKategorie = new System.Windows.Forms.ListBox();
            this.rdbnopowt = new System.Windows.Forms.RadioButton();
            this.rdbpowt = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSlownik = new System.Windows.Forms.ComboBox();
            this.btnSprawdz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBledy = new System.Windows.Forms.Label();
            this.lbxPodsumowanie = new System.Windows.Forms.ListBox();
            this.btnKoniec = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtZle = new System.Windows.Forms.TextBox();
            this.lbxNaukaEn = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDobrze = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSlowko = new System.Windows.Forms.TextBox();
            this.txtZnaczenie = new System.Windows.Forms.TextBox();
            this.tabBaza = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDodaneSlowka = new System.Windows.Forms.DataGridView();
            this.wyrazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwakatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znaczenie1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znaczenie2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znaczenie3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtUwagi = new System.Windows.Forms.TextBox();
            this.txtxZnaczenie3 = new System.Windows.Forms.TextBox();
            this.txtZnaczenie2 = new System.Windows.Forms.TextBox();
            this.txtZnaczenie1 = new System.Windows.Forms.TextBox();
            this.txtWyraz = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNowaKategoria = new System.Windows.Forms.TextBox();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsBaza1)).BeginInit();
            this.tab.SuspendLayout();
            this.tabSlownik.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabNauka.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabBaza.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaneSlowka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsBaza1
            // 
            this.dsBaza1.DataSetName = "dsBaza";
            this.dsBaza1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEnTableAdapter1
            // 
            this.tEnTableAdapter1.ClearBeforeFill = true;
            // 
            // tKategorieTableAdapter1
            // 
            this.tKategorieTableAdapter1.ClearBeforeFill = true;
            // 
            // tPolTableAdapter1
            // 
            this.tPolTableAdapter1.ClearBeforeFill = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabSlownik);
            this.tab.Controls.Add(this.tabNauka);
            this.tab.Controls.Add(this.tabBaza);
            this.tab.Location = new System.Drawing.Point(3, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(554, 418);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // tabSlownik
            // 
            this.tabSlownik.Controls.Add(this.toolStrip1);
            this.tabSlownik.Controls.Add(this.btnStart);
            this.tabSlownik.Controls.Add(this.label1);
            this.tabSlownik.Controls.Add(this.lbxWyrazy);
            this.tabSlownik.Controls.Add(this.txtOpis);
            this.tabSlownik.Controls.Add(this.txtWyszukaj);
            this.tabSlownik.Location = new System.Drawing.Point(4, 22);
            this.tabSlownik.Name = "tabSlownik";
            this.tabSlownik.Padding = new System.Windows.Forms.Padding(3);
            this.tabSlownik.Size = new System.Drawing.Size(546, 392);
            this.tabSlownik.TabIndex = 0;
            this.tabSlownik.Text = "Slownik";
            this.tabSlownik.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbRodzjSlownika,
            this.tsbToSpeech});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(540, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tscbRodzjSlownika
            // 
            this.tscbRodzjSlownika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbRodzjSlownika.Items.AddRange(new object[] {
            "ang-pol",
            "pol-ang"});
            this.tscbRodzjSlownika.Name = "tscbRodzjSlownika";
            this.tscbRodzjSlownika.Size = new System.Drawing.Size(121, 25);
            this.tscbRodzjSlownika.SelectedIndexChanged += new System.EventHandler(this.tscbRodzjSlownika_SelectedIndexChanged);
            // 
            // tsbToSpeech
            // 
            this.tsbToSpeech.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbToSpeech.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tsbToSpeech.Image = ((System.Drawing.Image)(resources.GetObject("tsbToSpeech.Image")));
            this.tsbToSpeech.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToSpeech.Name = "tsbToSpeech";
            this.tsbToSpeech.Size = new System.Drawing.Size(66, 22);
            this.tsbToSpeech.Text = "ToSpeech";
            this.tsbToSpeech.Click += new System.EventHandler(this.tsbToSpeech_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(222, 55);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wyszukaj S≥Ûwko";
            // 
            // lbxWyrazy
            // 
            this.lbxWyrazy.DataSource = this.bindingSource1;
            this.lbxWyrazy.DisplayMember = "wyraz";
            this.lbxWyrazy.FormattingEnabled = true;
            this.lbxWyrazy.Location = new System.Drawing.Point(52, 102);
            this.lbxWyrazy.Name = "lbxWyrazy";
            this.lbxWyrazy.Size = new System.Drawing.Size(177, 147);
            this.lbxWyrazy.TabIndex = 2;
            this.lbxWyrazy.ValueMember = "wyraz";
            this.lbxWyrazy.SelectedIndexChanged += new System.EventHandler(this.lbxWyrazy_SelectedIndexChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(273, 102);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.Size = new System.Drawing.Size(175, 149);
            this.txtOpis.TabIndex = 1;
            // 
            // txtWyszukaj
            // 
            this.txtWyszukaj.Location = new System.Drawing.Point(52, 59);
            this.txtWyszukaj.Name = "txtWyszukaj";
            this.txtWyszukaj.Size = new System.Drawing.Size(148, 20);
            this.txtWyszukaj.TabIndex = 0;
            this.txtWyszukaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWyszukaj_KeyDown);
            // 
            // tabNauka
            // 
            this.tabNauka.Controls.Add(this.btnRemoveAll);
            this.tabNauka.Controls.Add(this.btnAddAll);
            this.tabNauka.Controls.Add(this.btnRemoveToNauka);
            this.tabNauka.Controls.Add(this.btnAddToNauka);
            this.tabNauka.Controls.Add(this.lbxKategorieWybrane);
            this.tabNauka.Controls.Add(this.lbxKategorie);
            this.tabNauka.Controls.Add(this.rdbnopowt);
            this.tabNauka.Controls.Add(this.rdbpowt);
            this.tabNauka.Controls.Add(this.label13);
            this.tabNauka.Controls.Add(this.label10);
            this.tabNauka.Controls.Add(this.cbSlownik);
            this.tabNauka.Controls.Add(this.btnSprawdz);
            this.tabNauka.Controls.Add(this.groupBox3);
            this.tabNauka.Location = new System.Drawing.Point(4, 22);
            this.tabNauka.Name = "tabNauka";
            this.tabNauka.Padding = new System.Windows.Forms.Padding(3);
            this.tabNauka.Size = new System.Drawing.Size(546, 392);
            this.tabNauka.TabIndex = 1;
            this.tabNauka.Text = "Nauka";
            this.tabNauka.UseVisualStyleBackColor = true;
            this.tabNauka.Enter += new System.EventHandler(this.tabNauka_Enter);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveAll.Location = new System.Drawing.Point(280, 129);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(42, 23);
            this.btnRemoveAll.TabIndex = 23;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddAll.Location = new System.Drawing.Point(280, 91);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(42, 23);
            this.btnAddAll.TabIndex = 22;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveToNauka
            // 
            this.btnRemoveToNauka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveToNauka.Location = new System.Drawing.Point(280, 60);
            this.btnRemoveToNauka.Name = "btnRemoveToNauka";
            this.btnRemoveToNauka.Size = new System.Drawing.Size(42, 23);
            this.btnRemoveToNauka.TabIndex = 21;
            this.btnRemoveToNauka.Text = "<";
            this.btnRemoveToNauka.UseVisualStyleBackColor = true;
            this.btnRemoveToNauka.Click += new System.EventHandler(this.btnRemoveToNauka_Click);
            // 
            // btnAddToNauka
            // 
            this.btnAddToNauka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddToNauka.Location = new System.Drawing.Point(280, 31);
            this.btnAddToNauka.Name = "btnAddToNauka";
            this.btnAddToNauka.Size = new System.Drawing.Size(42, 23);
            this.btnAddToNauka.TabIndex = 20;
            this.btnAddToNauka.Text = ">";
            this.btnAddToNauka.UseVisualStyleBackColor = true;
            this.btnAddToNauka.Click += new System.EventHandler(this.btnAddToNauka_Click);
            // 
            // lbxKategorieWybrane
            // 
            this.lbxKategorieWybrane.FormattingEnabled = true;
            this.lbxKategorieWybrane.Location = new System.Drawing.Point(337, 31);
            this.lbxKategorieWybrane.Name = "lbxKategorieWybrane";
            this.lbxKategorieWybrane.Size = new System.Drawing.Size(75, 121);
            this.lbxKategorieWybrane.TabIndex = 19;
            // 
            // lbxKategorie
            // 
            this.lbxKategorie.DataSource = this.dsBaza1;
            this.lbxKategorie.DisplayMember = "TKategorie.nazwa";
            this.lbxKategorie.FormattingEnabled = true;
            this.lbxKategorie.Location = new System.Drawing.Point(194, 31);
            this.lbxKategorie.Name = "lbxKategorie";
            this.lbxKategorie.Size = new System.Drawing.Size(71, 121);
            this.lbxKategorie.TabIndex = 18;
            // 
            // rdbnopowt
            // 
            this.rdbnopowt.AutoSize = true;
            this.rdbnopowt.Location = new System.Drawing.Point(15, 94);
            this.rdbnopowt.Name = "rdbnopowt";
            this.rdbnopowt.Size = new System.Drawing.Size(171, 17);
            this.rdbnopowt.TabIndex = 12;
            this.rdbnopowt.Text = "wyrazy nie moga sie powtarzac";
            this.rdbnopowt.UseVisualStyleBackColor = true;
            // 
            // rdbpowt
            // 
            this.rdbpowt.AutoSize = true;
            this.rdbpowt.Checked = true;
            this.rdbpowt.Location = new System.Drawing.Point(15, 71);
            this.rdbpowt.Name = "rdbpowt";
            this.rdbpowt.Size = new System.Drawing.Size(154, 17);
            this.rdbpowt.TabIndex = 11;
            this.rdbpowt.TabStop = true;
            this.rdbpowt.Text = "wyrazy moga sie powtarzac";
            this.rdbpowt.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "kategoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "s≥ownik";
            // 
            // cbSlownik
            // 
            this.cbSlownik.FormattingEnabled = true;
            this.cbSlownik.Items.AddRange(new object[] {
            "ang-pol",
            "pol-ang"});
            this.cbSlownik.Location = new System.Drawing.Point(15, 31);
            this.cbSlownik.Name = "cbSlownik";
            this.cbSlownik.Size = new System.Drawing.Size(121, 21);
            this.cbSlownik.TabIndex = 0;
            this.cbSlownik.SelectedIndexChanged += new System.EventHandler(this.cbSlownik_SelectedIndexChanged);
            // 
            // btnSprawdz
            // 
            this.btnSprawdz.Enabled = false;
            this.btnSprawdz.Location = new System.Drawing.Point(429, 103);
            this.btnSprawdz.Name = "btnSprawdz";
            this.btnSprawdz.Size = new System.Drawing.Size(75, 23);
            this.btnSprawdz.TabIndex = 2;
            this.btnSprawdz.Text = "START";
            this.btnSprawdz.UseVisualStyleBackColor = true;
            this.btnSprawdz.Click += new System.EventHandler(this.btnSprawdz_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBledy);
            this.groupBox3.Controls.Add(this.lbxPodsumowanie);
            this.groupBox3.Controls.Add(this.btnKoniec);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtZle);
            this.groupBox3.Controls.Add(this.lbxNaukaEn);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDobrze);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.txtSlowko);
            this.groupBox3.Controls.Add(this.txtZnaczenie);
            this.groupBox3.Location = new System.Drawing.Point(0, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 214);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nauka";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblBledy
            // 
            this.lblBledy.AutoSize = true;
            this.lblBledy.Location = new System.Drawing.Point(321, 34);
            this.lblBledy.Name = "lblBledy";
            this.lblBledy.Size = new System.Drawing.Size(91, 13);
            this.lblBledy.TabIndex = 19;
            this.lblBledy.Text = "pope≥nione b≥edy";
            this.lblBledy.Visible = false;
            // 
            // lbxPodsumowanie
            // 
            this.lbxPodsumowanie.Enabled = false;
            this.lbxPodsumowanie.FormattingEnabled = true;
            this.lbxPodsumowanie.Location = new System.Drawing.Point(324, 46);
            this.lbxPodsumowanie.Name = "lbxPodsumowanie";
            this.lbxPodsumowanie.Size = new System.Drawing.Size(118, 147);
            this.lbxPodsumowanie.TabIndex = 18;
            this.lbxPodsumowanie.Visible = false;
            // 
            // btnKoniec
            // 
            this.btnKoniec.Enabled = false;
            this.btnKoniec.Location = new System.Drawing.Point(190, 84);
            this.btnKoniec.Name = "btnKoniec";
            this.btnKoniec.Size = new System.Drawing.Size(75, 23);
            this.btnKoniec.TabIndex = 17;
            this.btnKoniec.Text = "Koniec";
            this.btnKoniec.UseVisualStyleBackColor = true;
            this.btnKoniec.Click += new System.EventHandler(this.btnKoniec_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Dobrze";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "èle";
            // 
            // txtZle
            // 
            this.txtZle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtZle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZle.Enabled = false;
            this.txtZle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZle.Location = new System.Drawing.Point(235, 154);
            this.txtZle.Name = "txtZle";
            this.txtZle.Size = new System.Drawing.Size(40, 22);
            this.txtZle.TabIndex = 16;
            this.txtZle.Text = "0";
            this.txtZle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZle.TextChanged += new System.EventHandler(this.txtZle_TextChanged);
            // 
            // lbxNaukaEn
            // 
            this.lbxNaukaEn.FormattingEnabled = true;
            this.lbxNaukaEn.Location = new System.Drawing.Point(21, 113);
            this.lbxNaukaEn.Name = "lbxNaukaEn";
            this.lbxNaukaEn.Size = new System.Drawing.Size(120, 95);
            this.lbxNaukaEn.TabIndex = 9;
            this.lbxNaukaEn.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "znaczenie";
            // 
            // txtDobrze
            // 
            this.txtDobrze.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDobrze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDobrze.Enabled = false;
            this.txtDobrze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDobrze.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDobrze.Location = new System.Drawing.Point(163, 154);
            this.txtDobrze.Name = "txtDobrze";
            this.txtDobrze.Size = new System.Drawing.Size(40, 22);
            this.txtDobrze.TabIndex = 15;
            this.txtDobrze.Text = "0";
            this.txtDobrze.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "slowko";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(18, 84);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtSlowko
            // 
            this.txtSlowko.Enabled = false;
            this.txtSlowko.Location = new System.Drawing.Point(18, 46);
            this.txtSlowko.Name = "txtSlowko";
            this.txtSlowko.Size = new System.Drawing.Size(100, 20);
            this.txtSlowko.TabIndex = 5;
            // 
            // txtZnaczenie
            // 
            this.txtZnaczenie.Location = new System.Drawing.Point(165, 46);
            this.txtZnaczenie.Name = "txtZnaczenie";
            this.txtZnaczenie.Size = new System.Drawing.Size(100, 20);
            this.txtZnaczenie.TabIndex = 6;
            this.txtZnaczenie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZnaczenie_KeyDown);
            // 
            // tabBaza
            // 
            this.tabBaza.Controls.Add(this.groupBox2);
            this.tabBaza.Controls.Add(this.groupBox1);
            this.tabBaza.Controls.Add(this.bindingNavigator1);
            this.tabBaza.Location = new System.Drawing.Point(4, 22);
            this.tabBaza.Name = "tabBaza";
            this.tabBaza.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaza.Size = new System.Drawing.Size(546, 392);
            this.tabBaza.TabIndex = 2;
            this.tabBaza.Text = "Baza";
            this.tabBaza.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dgvDodaneSlowka);
            this.groupBox2.Controls.Add(this.txtUwagi);
            this.groupBox2.Controls.Add(this.txtxZnaczenie3);
            this.groupBox2.Controls.Add(this.txtZnaczenie2);
            this.groupBox2.Controls.Add(this.txtZnaczenie1);
            this.groupBox2.Controls.Add(this.txtWyraz);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "S≥Ûwka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Dodane Slowka";
            // 
            // dgvDodaneSlowka
            // 
            this.dgvDodaneSlowka.AllowUserToAddRows = false;
            this.dgvDodaneSlowka.AutoGenerateColumns = false;
            this.dgvDodaneSlowka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodaneSlowka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wyrazDataGridViewTextBoxColumn,
            this.nazwakatDataGridViewTextBoxColumn,
            this.znaczenie1DataGridViewTextBoxColumn,
            this.znaczenie2DataGridViewTextBoxColumn,
            this.znaczenie3DataGridViewTextBoxColumn,
            this.uwagiDataGridViewTextBoxColumn});
            this.dgvDodaneSlowka.DataSource = this.bindingSource1;
            this.dgvDodaneSlowka.Location = new System.Drawing.Point(6, 110);
            this.dgvDodaneSlowka.Name = "dgvDodaneSlowka";
            this.dgvDodaneSlowka.ReadOnly = true;
            this.dgvDodaneSlowka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDodaneSlowka.Size = new System.Drawing.Size(230, 92);
            this.dgvDodaneSlowka.TabIndex = 10;
            // 
            // wyrazDataGridViewTextBoxColumn
            // 
            this.wyrazDataGridViewTextBoxColumn.DataPropertyName = "wyraz";
            this.wyrazDataGridViewTextBoxColumn.HeaderText = "wyraz";
            this.wyrazDataGridViewTextBoxColumn.Name = "wyrazDataGridViewTextBoxColumn";
            this.wyrazDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwakatDataGridViewTextBoxColumn
            // 
            this.nazwakatDataGridViewTextBoxColumn.DataPropertyName = "nazwakat";
            this.nazwakatDataGridViewTextBoxColumn.HeaderText = "nazwakat";
            this.nazwakatDataGridViewTextBoxColumn.Name = "nazwakatDataGridViewTextBoxColumn";
            this.nazwakatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znaczenie1DataGridViewTextBoxColumn
            // 
            this.znaczenie1DataGridViewTextBoxColumn.DataPropertyName = "znaczenie1";
            this.znaczenie1DataGridViewTextBoxColumn.HeaderText = "znaczenie1";
            this.znaczenie1DataGridViewTextBoxColumn.Name = "znaczenie1DataGridViewTextBoxColumn";
            this.znaczenie1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znaczenie2DataGridViewTextBoxColumn
            // 
            this.znaczenie2DataGridViewTextBoxColumn.DataPropertyName = "znaczenie2";
            this.znaczenie2DataGridViewTextBoxColumn.HeaderText = "znaczenie2";
            this.znaczenie2DataGridViewTextBoxColumn.Name = "znaczenie2DataGridViewTextBoxColumn";
            this.znaczenie2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // znaczenie3DataGridViewTextBoxColumn
            // 
            this.znaczenie3DataGridViewTextBoxColumn.DataPropertyName = "znaczenie3";
            this.znaczenie3DataGridViewTextBoxColumn.HeaderText = "znaczenie3";
            this.znaczenie3DataGridViewTextBoxColumn.Name = "znaczenie3DataGridViewTextBoxColumn";
            this.znaczenie3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "uwagi";
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            this.uwagiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TEn";
            this.bindingSource1.DataSource = this.dsBaza1;
            // 
            // txtUwagi
            // 
            this.txtUwagi.Location = new System.Drawing.Point(264, 94);
            this.txtUwagi.Multiline = true;
            this.txtUwagi.Name = "txtUwagi";
            this.txtUwagi.Size = new System.Drawing.Size(213, 51);
            this.txtUwagi.TabIndex = 9;
            // 
            // txtxZnaczenie3
            // 
            this.txtxZnaczenie3.Location = new System.Drawing.Point(338, 45);
            this.txtxZnaczenie3.Name = "txtxZnaczenie3";
            this.txtxZnaczenie3.Size = new System.Drawing.Size(100, 20);
            this.txtxZnaczenie3.TabIndex = 8;
            // 
            // txtZnaczenie2
            // 
            this.txtZnaczenie2.Location = new System.Drawing.Point(219, 45);
            this.txtZnaczenie2.Name = "txtZnaczenie2";
            this.txtZnaczenie2.Size = new System.Drawing.Size(100, 20);
            this.txtZnaczenie2.TabIndex = 7;
            // 
            // txtZnaczenie1
            // 
            this.txtZnaczenie1.Location = new System.Drawing.Point(102, 45);
            this.txtZnaczenie1.Name = "txtZnaczenie1";
            this.txtZnaczenie1.Size = new System.Drawing.Size(100, 20);
            this.txtZnaczenie1.TabIndex = 6;
            // 
            // txtWyraz
            // 
            this.txtWyraz.Location = new System.Drawing.Point(6, 45);
            this.txtWyraz.Name = "txtWyraz";
            this.txtWyraz.Size = new System.Drawing.Size(80, 20);
            this.txtWyraz.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dodatkowe Informacje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "znaczenie3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "znaczenie2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "znaczenie1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "wyraz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNowaKategoria);
            this.groupBox1.Controls.Add(this.cbKategorie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kategorie s≥Ûwek";
            // 
            // txtNowaKategoria
            // 
            this.txtNowaKategoria.Location = new System.Drawing.Point(115, 52);
            this.txtNowaKategoria.Name = "txtNowaKategoria";
            this.txtNowaKategoria.Size = new System.Drawing.Size(121, 20);
            this.txtNowaKategoria.TabIndex = 3;
            // 
            // cbKategorie
            // 
            this.cbKategorie.DataSource = this.dsBaza1;
            this.cbKategorie.DisplayMember = "TKategorie.nazwa";
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(115, 20);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(121, 21);
            this.cbKategorie.TabIndex = 2;
            this.cbKategorie.ValueMember = "TKategorie.nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "nowa kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "wybierz kategorie";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(540, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(26, 22);
            this.toolStripButton1.Text = "DK";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(26, 22);
            this.toolStripButton2.Text = "UK";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton3.Text = "DS";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 22);
            this.toolStripButton4.Text = "US";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 442);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Slownik ang-pol pol-ang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBaza1)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabSlownik.ResumeLayout(false);
            this.tabSlownik.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabNauka.ResumeLayout(false);
            this.tabNauka.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabBaza.ResumeLayout(false);
            this.tabBaza.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodaneSlowka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SLOWNIK.dsBazaTableAdapters.TEnTableAdapter tEnTableAdapter1;
        private SLOWNIK.dsBazaTableAdapters.TKategorieTableAdapter tKategorieTableAdapter1;
        private SLOWNIK.dsBazaTableAdapters.TPolTableAdapter tPolTableAdapter1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabSlownik;
        private System.Windows.Forms.TabPage tabNauka;
        private System.Windows.Forms.TabPage tabBaza;
        private System.Windows.Forms.ListBox lbxWyrazy;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbRodzjSlownika;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNowaKategoria;
        private System.Windows.Forms.ComboBox cbKategorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUwagi;
        private System.Windows.Forms.TextBox txtxZnaczenie3;
        private System.Windows.Forms.TextBox txtZnaczenie2;
        private System.Windows.Forms.TextBox txtZnaczenie1;
        private System.Windows.Forms.TextBox txtWyraz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDodaneSlowka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSlownik;
        private System.Windows.Forms.Button btnSprawdz;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtZnaczenie;
        private System.Windows.Forms.TextBox txtSlowko;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbxNaukaEn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rdbnopowt;
        private System.Windows.Forms.RadioButton rdbpowt;
        private System.Windows.Forms.TextBox txtZle;
        private System.Windows.Forms.TextBox txtDobrze;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbToSpeech;
        private System.Windows.Forms.ListBox lbxKategorie;
        private System.Windows.Forms.ListBox lbxKategorieWybrane;
        private System.Windows.Forms.Button btnAddToNauka;
        private System.Windows.Forms.Button btnKoniec;
        private System.Windows.Forms.ListBox lbxPodsumowanie;
        private System.Windows.Forms.Label lblBledy;
        private System.Windows.Forms.Button btnRemoveToNauka;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveAll;
        private dsBaza dsBaza1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wyrazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwakatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znaczenie1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znaczenie2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znaczenie3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
    }
}

