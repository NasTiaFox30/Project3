namespace Projekt_3
{
    partial class LaboratoriumNr3
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
            this.pbRycownica = new System.Windows.Forms.PictureBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKolorWypelnienia = new System.Windows.Forms.Button();
            this.lblLiczbaKątów = new System.Windows.Forms.Label();
            this.lblPoziomRekurencji = new System.Windows.Forms.Label();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.numUDLiczbaKątów = new System.Windows.Forms.NumericUpDown();
            this.rdbTrójkątSierpińskiego = new System.Windows.Forms.RadioButton();
            this.rdbWielokątWypełniony = new System.Windows.Forms.RadioButton();
            this.rdbWielokąt = new System.Windows.Forms.RadioButton();
            this.rdbLiniaKreślonaMyszką = new System.Windows.Forms.RadioButton();
            this.rdbLinia = new System.Windows.Forms.RadioButton();
            this.rdbPunkt = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorRysownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorWypełnieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrybutyLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubośćLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obecnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punktowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grotyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PoczątekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KoniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.kwadratowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okrągłyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strzałkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwadratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strzałkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRycownica)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLiczbaKątów)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRycownica
            // 
            this.pbRycownica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRycownica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRycownica.Location = new System.Drawing.Point(20, 65);
            this.pbRycownica.Name = "pbRycownica";
            this.pbRycownica.Size = new System.Drawing.Size(620, 350);
            this.pbRycownica.TabIndex = 0;
            this.pbRycownica.TabStop = false;
            this.pbRycownica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbRycownica_MouseDown);
            this.pbRycownica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbRycownica_MouseMove);
            this.pbRycownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbRycownica_MouseUp);
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Gill Sans MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNazwa.Location = new System.Drawing.Point(36, 35);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(310, 27);
            this.lblNazwa.TabIndex = 1;
            this.lblNazwa.Text = "Współrzędne (x,y) położenia myszy:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Gill Sans MT", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblX.Location = new System.Drawing.Point(531, 41);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 21);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Gill Sans MT", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblY.Location = new System.Drawing.Point(589, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 21);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnKolorWypelnienia);
            this.groupBox1.Controls.Add(this.lblLiczbaKątów);
            this.groupBox1.Controls.Add(this.lblPoziomRekurencji);
            this.groupBox1.Controls.Add(this.numUD);
            this.groupBox1.Controls.Add(this.numUDLiczbaKątów);
            this.groupBox1.Controls.Add(this.rdbTrójkątSierpińskiego);
            this.groupBox1.Controls.Add(this.rdbWielokątWypełniony);
            this.groupBox1.Controls.Add(this.rdbWielokąt);
            this.groupBox1.Controls.Add(this.rdbLiniaKreślonaMyszką);
            this.groupBox1.Controls.Add(this.rdbLinia);
            this.groupBox1.Controls.Add(this.rdbPunkt);
            this.groupBox1.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(666, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz kliknięciem odpowiedni kontrolkę poniżej:";
            // 
            // btnKolorWypelnienia
            // 
            this.btnKolorWypelnienia.Font = new System.Drawing.Font("Gill Sans MT", 8F, System.Drawing.FontStyle.Bold);
            this.btnKolorWypelnienia.Location = new System.Drawing.Point(153, 322);
            this.btnKolorWypelnienia.Name = "btnKolorWypelnienia";
            this.btnKolorWypelnienia.Size = new System.Drawing.Size(115, 50);
            this.btnKolorWypelnienia.TabIndex = 8;
            this.btnKolorWypelnienia.Text = "Kolor\r\nWypełnienia";
            this.btnKolorWypelnienia.UseVisualStyleBackColor = true;
            // 
            // lblLiczbaKątów
            // 
            this.lblLiczbaKątów.AutoSize = true;
            this.lblLiczbaKątów.Location = new System.Drawing.Point(173, 158);
            this.lblLiczbaKątów.Name = "lblLiczbaKątów";
            this.lblLiczbaKątów.Size = new System.Drawing.Size(102, 21);
            this.lblLiczbaKątów.TabIndex = 5;
            this.lblLiczbaKątów.Text = "LiczbaKątów";
            this.lblLiczbaKątów.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPoziomRekurencji
            // 
            this.lblPoziomRekurencji.AutoSize = true;
            this.lblPoziomRekurencji.Location = new System.Drawing.Point(189, 246);
            this.lblPoziomRekurencji.Name = "lblPoziomRekurencji";
            this.lblPoziomRekurencji.Size = new System.Drawing.Size(85, 42);
            this.lblPoziomRekurencji.TabIndex = 6;
            this.lblPoziomRekurencji.Text = "Poziom\r\nRekurencji";
            this.lblPoziomRekurencji.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(177, 291);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(91, 25);
            this.numUD.TabIndex = 7;
            // 
            // numUDLiczbaKątów
            // 
            this.numUDLiczbaKątów.Location = new System.Drawing.Point(178, 182);
            this.numUDLiczbaKątów.Name = "numUDLiczbaKątów";
            this.numUDLiczbaKątów.Size = new System.Drawing.Size(91, 25);
            this.numUDLiczbaKątów.TabIndex = 6;
            // 
            // rdbTrójkątSierpińskiego
            // 
            this.rdbTrójkątSierpińskiego.AutoSize = true;
            this.rdbTrójkątSierpińskiego.Location = new System.Drawing.Point(6, 246);
            this.rdbTrójkątSierpińskiego.Name = "rdbTrójkątSierpińskiego";
            this.rdbTrójkątSierpińskiego.Size = new System.Drawing.Size(181, 25);
            this.rdbTrójkątSierpińskiego.TabIndex = 5;
            this.rdbTrójkątSierpińskiego.TabStop = true;
            this.rdbTrójkątSierpińskiego.Text = "Trójkąt Sierpińskiego";
            this.rdbTrójkątSierpińskiego.UseVisualStyleBackColor = true;
            // 
            // rdbWielokątWypełniony
            // 
            this.rdbWielokątWypełniony.AutoSize = true;
            this.rdbWielokątWypełniony.Location = new System.Drawing.Point(6, 184);
            this.rdbWielokątWypełniony.Name = "rdbWielokątWypełniony";
            this.rdbWielokątWypełniony.Size = new System.Drawing.Size(111, 46);
            this.rdbWielokątWypełniony.TabIndex = 4;
            this.rdbWielokątWypełniony.TabStop = true;
            this.rdbWielokątWypełniony.Text = "Wielokąt\r\nwypełniony";
            this.rdbWielokątWypełniony.UseVisualStyleBackColor = true;
            // 
            // rdbWielokąt
            // 
            this.rdbWielokąt.AutoSize = true;
            this.rdbWielokąt.Location = new System.Drawing.Point(6, 158);
            this.rdbWielokąt.Name = "rdbWielokąt";
            this.rdbWielokąt.Size = new System.Drawing.Size(96, 25);
            this.rdbWielokąt.TabIndex = 3;
            this.rdbWielokąt.TabStop = true;
            this.rdbWielokąt.Text = "Wielokąt";
            this.rdbWielokąt.UseVisualStyleBackColor = true;
            // 
            // rdbLiniaKreślonaMyszką
            // 
            this.rdbLiniaKreślonaMyszką.AutoSize = true;
            this.rdbLiniaKreślonaMyszką.Location = new System.Drawing.Point(6, 101);
            this.rdbLiniaKreślonaMyszką.Name = "rdbLiniaKreślonaMyszką";
            this.rdbLiniaKreślonaMyszką.Size = new System.Drawing.Size(186, 25);
            this.rdbLiniaKreślonaMyszką.TabIndex = 2;
            this.rdbLiniaKreślonaMyszką.TabStop = true;
            this.rdbLiniaKreślonaMyszką.Text = "Linia Kreślona Myszką";
            this.rdbLiniaKreślonaMyszką.UseVisualStyleBackColor = true;
            // 
            // rdbLinia
            // 
            this.rdbLinia.AutoSize = true;
            this.rdbLinia.Location = new System.Drawing.Point(6, 75);
            this.rdbLinia.Name = "rdbLinia";
            this.rdbLinia.Size = new System.Drawing.Size(65, 25);
            this.rdbLinia.TabIndex = 1;
            this.rdbLinia.TabStop = true;
            this.rdbLinia.Text = "Linia";
            this.rdbLinia.UseVisualStyleBackColor = true;
            // 
            // rdbPunkt
            // 
            this.rdbPunkt.AutoSize = true;
            this.rdbPunkt.Location = new System.Drawing.Point(6, 49);
            this.rdbPunkt.Name = "rdbPunkt";
            this.rdbPunkt.Size = new System.Drawing.Size(73, 25);
            this.rdbPunkt.TabIndex = 0;
            this.rdbPunkt.TabStop = true;
            this.rdbPunkt.Text = "Punkt";
            this.rdbPunkt.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.atrybutyLiniiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorLiniiToolStripMenuItem,
            this.kolorRysownicyToolStripMenuItem,
            this.kolorWypełnieniaToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorLiniiToolStripMenuItem
            // 
            this.kolorLiniiToolStripMenuItem.Name = "kolorLiniiToolStripMenuItem";
            this.kolorLiniiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.kolorLiniiToolStripMenuItem.Text = "Kolor linii";
            this.kolorLiniiToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiToolStripMenuItem_Click);
            // 
            // kolorRysownicyToolStripMenuItem
            // 
            this.kolorRysownicyToolStripMenuItem.Name = "kolorRysownicyToolStripMenuItem";
            this.kolorRysownicyToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.kolorRysownicyToolStripMenuItem.Text = "Kolor rysownicy";
            this.kolorRysownicyToolStripMenuItem.Click += new System.EventHandler(this.kolorRysownicyToolStripMenuItem_Click);
            // 
            // kolorWypełnieniaToolStripMenuItem
            // 
            this.kolorWypełnieniaToolStripMenuItem.Name = "kolorWypełnieniaToolStripMenuItem";
            this.kolorWypełnieniaToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.kolorWypełnieniaToolStripMenuItem.Text = "Kolor wypełnienia";
            // 
            // atrybutyLiniiToolStripMenuItem
            // 
            this.atrybutyLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grubośćLiniiToolStripMenuItem,
            this.stylLiniiToolStripMenuItem,
            this.grotyToolStripMenuItem});
            this.atrybutyLiniiToolStripMenuItem.Name = "atrybutyLiniiToolStripMenuItem";
            this.atrybutyLiniiToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.atrybutyLiniiToolStripMenuItem.Text = "Atrybuty linii";
            // 
            // grubośćLiniiToolStripMenuItem
            // 
            this.grubośćLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.grubośćLiniiToolStripMenuItem.Name = "grubośćLiniiToolStripMenuItem";
            this.grubośćLiniiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grubośćLiniiToolStripMenuItem.Text = "Grubość linii";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // stylLiniiToolStripMenuItem
            // 
            this.stylLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obecnyToolStripMenuItem,
            this.punktowyToolStripMenuItem});
            this.stylLiniiToolStripMenuItem.Name = "stylLiniiToolStripMenuItem";
            this.stylLiniiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stylLiniiToolStripMenuItem.Text = "Styl linii";
            // 
            // obecnyToolStripMenuItem
            // 
            this.obecnyToolStripMenuItem.Name = "obecnyToolStripMenuItem";
            this.obecnyToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.obecnyToolStripMenuItem.Text = "Obecny";
            this.obecnyToolStripMenuItem.Click += new System.EventHandler(this.obecnyToolStripMenuItem_Click);
            // 
            // punktowyToolStripMenuItem
            // 
            this.punktowyToolStripMenuItem.Name = "punktowyToolStripMenuItem";
            this.punktowyToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.punktowyToolStripMenuItem.Text = "Punktowy";
            this.punktowyToolStripMenuItem.Click += new System.EventHandler(this.punktowyToolStripMenuItem_Click);
            // 
            // grotyToolStripMenuItem
            // 
            this.grotyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PoczątekToolStripMenuItem,
            this.KoniecToolStripMenuItem});
            this.grotyToolStripMenuItem.Name = "grotyToolStripMenuItem";
            this.grotyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grotyToolStripMenuItem.Text = "Groty";
            // 
            // PoczątekToolStripMenuItem
            // 
            this.PoczątekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kwadratowyToolStripMenuItem,
            this.okrągłyToolStripMenuItem,
            this.strzałkaToolStripMenuItem});
            this.PoczątekToolStripMenuItem.Name = "PoczątekToolStripMenuItem";
            this.PoczątekToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.PoczątekToolStripMenuItem.Text = "Początek";
            // 
            // KoniecToolStripMenuItem
            // 
            this.KoniecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kwadratToolStripMenuItem,
            this.okąToolStripMenuItem,
            this.strzałkaToolStripMenuItem1});
            this.KoniecToolStripMenuItem.Name = "KoniecToolStripMenuItem";
            this.KoniecToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.KoniecToolStripMenuItem.Text = "Koniec";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // kwadratowyToolStripMenuItem
            // 
            this.kwadratowyToolStripMenuItem.Name = "kwadratowyToolStripMenuItem";
            this.kwadratowyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kwadratowyToolStripMenuItem.Text = "Kwadratowy";
            this.kwadratowyToolStripMenuItem.Click += new System.EventHandler(this.kwadratowyToolStripMenuItem_Click);
            // 
            // okrągłyToolStripMenuItem
            // 
            this.okrągłyToolStripMenuItem.Name = "okrągłyToolStripMenuItem";
            this.okrągłyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.okrągłyToolStripMenuItem.Text = "Okrągły";
            this.okrągłyToolStripMenuItem.Click += new System.EventHandler(this.okrągłyToolStripMenuItem_Click);
            // 
            // strzałkaToolStripMenuItem
            // 
            this.strzałkaToolStripMenuItem.Name = "strzałkaToolStripMenuItem";
            this.strzałkaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.strzałkaToolStripMenuItem.Text = "Strzałka";
            this.strzałkaToolStripMenuItem.Click += new System.EventHandler(this.strzałkaToolStripMenuItem_Click);
            // 
            // kwadratToolStripMenuItem
            // 
            this.kwadratToolStripMenuItem.Name = "kwadratToolStripMenuItem";
            this.kwadratToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kwadratToolStripMenuItem.Text = "Kwadratowy";
            this.kwadratToolStripMenuItem.Click += new System.EventHandler(this.kwadratToolStripMenuItem_Click);
            // 
            // okąToolStripMenuItem
            // 
            this.okąToolStripMenuItem.Name = "okąToolStripMenuItem";
            this.okąToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.okąToolStripMenuItem.Text = "Okrągły";
            this.okąToolStripMenuItem.Click += new System.EventHandler(this.okąToolStripMenuItem_Click);
            // 
            // strzałkaToolStripMenuItem1
            // 
            this.strzałkaToolStripMenuItem1.Name = "strzałkaToolStripMenuItem1";
            this.strzałkaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.strzałkaToolStripMenuItem1.Text = "Strzałka";
            this.strzałkaToolStripMenuItem1.Click += new System.EventHandler(this.strzałkaToolStripMenuItem1_Click);
            // 
            // LaboratoriumNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.pbRycownica);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(970, 450);
            this.Name = "LaboratoriumNr3";
            this.Text = "Laboratorium";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LaboratoriumNr3_FormClosing);
            this.SizeChanged += new System.EventHandler(this.LaboratoriumNr3_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbRycownica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLiczbaKątów)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRycownica;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.NumericUpDown numUDLiczbaKątów;
        private System.Windows.Forms.RadioButton rdbTrójkątSierpińskiego;
        private System.Windows.Forms.RadioButton rdbWielokątWypełniony;
        private System.Windows.Forms.RadioButton rdbWielokąt;
        private System.Windows.Forms.RadioButton rdbLiniaKreślonaMyszką;
        private System.Windows.Forms.RadioButton rdbLinia;
        private System.Windows.Forms.RadioButton rdbPunkt;
        private System.Windows.Forms.Label lblLiczbaKątów;
        private System.Windows.Forms.Label lblPoziomRekurencji;
        private System.Windows.Forms.Button btnKolorWypelnienia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorRysownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorWypełnieniaToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrybutyLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubośćLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grotyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PoczątekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KoniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem obecnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punktowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwadratowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okrągłyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strzałkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwadratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strzałkaToolStripMenuItem1;
    }
}