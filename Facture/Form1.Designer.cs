namespace Facture
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.MHT = new MetroFramework.Controls.MetroTextBox();
            this.TTVABox = new MetroFramework.Controls.MetroTextBox();
            this.THTCBox = new MetroFramework.Controls.MetroTextBox();
            this.metroFileValider = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devisNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devisNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Facture.Database1DataSet();
            this.devisTableAdapter = new Facture.Database1DataSetTableAdapters.DevisTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.crystalOpenFileDialog1 = new CrystalDecisions.Shared.Interop.CrystalOpenFileDialog();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(694, 286);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Montant Total(Dh)";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(684, 339);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(130, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Tva(7% ou 20%) (Dh)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(694, 396);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(111, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Total à Payer (Dh)";
            // 
            // MHT
            // 
            // 
            // 
            // 
            this.MHT.CustomButton.Image = null;
            this.MHT.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.MHT.CustomButton.Name = "";
            this.MHT.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.MHT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MHT.CustomButton.TabIndex = 1;
            this.MHT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MHT.CustomButton.UseSelectable = true;
            this.MHT.CustomButton.Visible = false;
            this.MHT.Lines = new string[] {
        "0"};
            this.MHT.Location = new System.Drawing.Point(726, 318);
            this.MHT.Margin = new System.Windows.Forms.Padding(2);
            this.MHT.MaxLength = 32767;
            this.MHT.Name = "MHT";
            this.MHT.PasswordChar = '\0';
            this.MHT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MHT.SelectedText = "";
            this.MHT.SelectionLength = 0;
            this.MHT.SelectionStart = 0;
            this.MHT.ShortcutsEnabled = true;
            this.MHT.Size = new System.Drawing.Size(56, 19);
            this.MHT.TabIndex = 18;
            this.MHT.Text = "0";
            this.MHT.UseSelectable = true;
            this.MHT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MHT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TTVABox
            // 
            // 
            // 
            // 
            this.TTVABox.CustomButton.Image = null;
            this.TTVABox.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.TTVABox.CustomButton.Name = "";
            this.TTVABox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TTVABox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TTVABox.CustomButton.TabIndex = 1;
            this.TTVABox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TTVABox.CustomButton.UseSelectable = true;
            this.TTVABox.CustomButton.Visible = false;
            this.TTVABox.Lines = new string[] {
        "0"};
            this.TTVABox.Location = new System.Drawing.Point(726, 370);
            this.TTVABox.Margin = new System.Windows.Forms.Padding(2);
            this.TTVABox.MaxLength = 32767;
            this.TTVABox.Name = "TTVABox";
            this.TTVABox.PasswordChar = '\0';
            this.TTVABox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TTVABox.SelectedText = "";
            this.TTVABox.SelectionLength = 0;
            this.TTVABox.SelectionStart = 0;
            this.TTVABox.ShortcutsEnabled = true;
            this.TTVABox.Size = new System.Drawing.Size(56, 19);
            this.TTVABox.TabIndex = 19;
            this.TTVABox.Text = "0";
            this.TTVABox.UseSelectable = true;
            this.TTVABox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TTVABox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // THTCBox
            // 
            // 
            // 
            // 
            this.THTCBox.CustomButton.Image = null;
            this.THTCBox.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.THTCBox.CustomButton.Name = "";
            this.THTCBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.THTCBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.THTCBox.CustomButton.TabIndex = 1;
            this.THTCBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.THTCBox.CustomButton.UseSelectable = true;
            this.THTCBox.CustomButton.Visible = false;
            this.THTCBox.Lines = new string[] {
        "0"};
            this.THTCBox.Location = new System.Drawing.Point(726, 432);
            this.THTCBox.Margin = new System.Windows.Forms.Padding(2);
            this.THTCBox.MaxLength = 32767;
            this.THTCBox.Name = "THTCBox";
            this.THTCBox.PasswordChar = '\0';
            this.THTCBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.THTCBox.SelectedText = "";
            this.THTCBox.SelectionLength = 0;
            this.THTCBox.SelectionStart = 0;
            this.THTCBox.ShortcutsEnabled = true;
            this.THTCBox.Size = new System.Drawing.Size(56, 19);
            this.THTCBox.TabIndex = 20;
            this.THTCBox.Text = "0";
            this.THTCBox.UseSelectable = true;
            this.THTCBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.THTCBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroFileValider
            // 
            this.metroFileValider.Location = new System.Drawing.Point(17, 184);
            this.metroFileValider.Margin = new System.Windows.Forms.Padding(2);
            this.metroFileValider.Name = "metroFileValider";
            this.metroFileValider.Size = new System.Drawing.Size(105, 37);
            this.metroFileValider.TabIndex = 11;
            this.metroFileValider.Text = "Ajouter produit";
            this.metroFileValider.UseSelectable = true;
            this.metroFileValider.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(136, 184);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(113, 37);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Supprimer produit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(267, 184);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(106, 37);
            this.metroButton3.TabIndex = 13;
            this.metroButton3.Text = "Nouveau client";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 23);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Devis N";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(569, 150);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(57, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Client Id";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(291, 149);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(65, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "ICE Client";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(17, 148);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(56, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "IF Client";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(291, 55);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(59, 19);
            this.metroLabel13.TabIndex = 28;
            this.metroLabel13.Text = "Quantité";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(291, 86);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(31, 19);
            this.metroLabel14.TabIndex = 29;
            this.metroLabel14.Text = "Prix";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(291, 120);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(71, 19);
            this.metroLabel15.TabIndex = 30;
            this.metroLabel15.Text = "Reference ";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(291, 24);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(77, 19);
            this.metroLabel16.TabIndex = 31;
            this.metroLabel16.Text = "Designation";
            this.metroLabel16.Click += new System.EventHandler(this.metroLabel16_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(13, 54);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(61, 19);
            this.metroLabel17.TabIndex = 32;
            this.metroLabel17.Text = "RS Client";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(651, 148);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox1.TabIndex = 33;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(110, 23);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox2.TabIndex = 34;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(383, 149);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.ReadOnly = true;
            this.maskedTextBox3.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox3.TabIndex = 35;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(110, 147);
            this.maskedTextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.ReadOnly = true;
            this.maskedTextBox4.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox4.TabIndex = 36;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(383, 25);
            this.maskedTextBox5.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox5.TabIndex = 37;
            this.maskedTextBox5.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox5_MaskInputRejected);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(383, 55);
            this.maskedTextBox6.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox6.TabIndex = 38;
            this.maskedTextBox6.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(383, 86);
            this.maskedTextBox7.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox7.TabIndex = 39;
            this.maskedTextBox7.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(383, 120);
            this.maskedTextBox8.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBox8.TabIndex = 40;
            this.maskedTextBox8.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox8_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.maskedTextBox8);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.maskedTextBox7);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.maskedTextBox6);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.maskedTextBox5);
            this.panel1.Controls.Add(this.metroLabel13);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.maskedTextBox4);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroLabel14);
            this.panel1.Controls.Add(this.metroFileValider);
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.metroLabel15);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.metroLabel16);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.metroLabel17);
            this.panel1.Location = new System.Drawing.Point(4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 235);
            this.panel1.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(651, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(569, 71);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 44;
            this.metroLabel2.Text = "Date";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 87);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "RS Client";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Tan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView1.Location = new System.Drawing.Point(4, 286);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(661, 181);
            this.listView1.TabIndex = 43;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Designation";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prix";
            this.columnHeader8.Width = 54;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quantité";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Montant HT";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Montant TVA";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Montant TTC";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Reference";
            this.columnHeader13.Width = 100;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.devisNDataGridViewTextBoxColumn,
            this.rSDataGridViewTextBoxColumn,
            this.quantitéeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.devisNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 472);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 212);
            this.dataGridView1.TabIndex = 44;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // devisNDataGridViewTextBoxColumn
            // 
            this.devisNDataGridViewTextBoxColumn.DataPropertyName = "DevisN";
            this.devisNDataGridViewTextBoxColumn.HeaderText = "DevisN";
            this.devisNDataGridViewTextBoxColumn.Name = "devisNDataGridViewTextBoxColumn";
            // 
            // rSDataGridViewTextBoxColumn
            // 
            this.rSDataGridViewTextBoxColumn.DataPropertyName = "RS";
            this.rSDataGridViewTextBoxColumn.HeaderText = "RS";
            this.rSDataGridViewTextBoxColumn.Name = "rSDataGridViewTextBoxColumn";
            // 
            // quantitéeDataGridViewTextBoxColumn
            // 
            this.quantitéeDataGridViewTextBoxColumn.DataPropertyName = "Quantitée";
            this.quantitéeDataGridViewTextBoxColumn.HeaderText = "Quantitée";
            this.quantitéeDataGridViewTextBoxColumn.Name = "quantitéeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // devisNumberDataGridViewTextBoxColumn
            // 
            this.devisNumberDataGridViewTextBoxColumn.DataPropertyName = "DevisNumber";
            this.devisNumberDataGridViewTextBoxColumn.HeaderText = "DevisNumber";
            this.devisNumberDataGridViewTextBoxColumn.Name = "devisNumberDataGridViewTextBoxColumn";
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataMember = "Devis";
            this.devisBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devisTableAdapter
            // 
            this.devisTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // crystalOpenFileDialog1
            // 
            this.crystalOpenFileDialog1.FileName = "crystalOpenFileDialog1";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(707, 563);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(45, 15);
            this.metroRadioButton1.TabIndex = 46;
            this.metroRadioButton1.Text = "20%";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(707, 600);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(39, 15);
            this.metroRadioButton2.TabIndex = 47;
            this.metroRadioButton2.Text = "7%";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 788);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.THTCBox);
            this.Controls.Add(this.TTVABox);
            this.Controls.Add(this.MHT);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox MHT;
        private MetroFramework.Controls.MetroTextBox TTVABox;
        private MetroFramework.Controls.MetroTextBox THTCBox;
        private MetroFramework.Controls.MetroButton metroFileValider;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private Database1DataSetTableAdapters.DevisTableAdapter devisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devisNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devisNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Shared.Interop.CrystalOpenFileDialog crystalOpenFileDialog1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
    }
}

