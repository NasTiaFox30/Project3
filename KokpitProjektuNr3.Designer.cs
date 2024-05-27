namespace Projekt_3
{
    partial class KokpitProjektuNr3
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNazwa1 = new System.Windows.Forms.Label();
            this.btnLaboratoriumNr3 = new System.Windows.Forms.Button();
            this.btnProjektIndywidualny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNazwa1
            // 
            this.labelNazwa1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNazwa1.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.labelNazwa1.Location = new System.Drawing.Point(0, 37);
            this.labelNazwa1.Name = "labelNazwa1";
            this.labelNazwa1.Size = new System.Drawing.Size(763, 92);
            this.labelNazwa1.TabIndex = 0;
            this.labelNazwa1.Text = "Projekt №3\r\nKreślenie figur, krzywych i linii geometrycznych";
            this.labelNazwa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLaboratoriumNr3
            // 
            this.btnLaboratoriumNr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaboratoriumNr3.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaboratoriumNr3.Location = new System.Drawing.Point(38, 165);
            this.btnLaboratoriumNr3.Name = "btnLaboratoriumNr3";
            this.btnLaboratoriumNr3.Size = new System.Drawing.Size(328, 109);
            this.btnLaboratoriumNr3.TabIndex = 1;
            this.btnLaboratoriumNr3.Text = "Laboratorium № 3\r\nKreślenie rzywych geometrycznych";
            this.btnLaboratoriumNr3.UseVisualStyleBackColor = true;
            this.btnLaboratoriumNr3.Click += new System.EventHandler(this.btnLaboratoriumNr3_Click);
            // 
            // btnProjektIndywidualny
            // 
            this.btnProjektIndywidualny.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProjektIndywidualny.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjektIndywidualny.Location = new System.Drawing.Point(389, 165);
            this.btnProjektIndywidualny.Name = "btnProjektIndywidualny";
            this.btnProjektIndywidualny.Size = new System.Drawing.Size(328, 109);
            this.btnProjektIndywidualny.TabIndex = 2;
            this.btnProjektIndywidualny.Text = "Projekt Indywidualny № 3\r\nKreślenie figur i linii geometrycznych";
            this.btnProjektIndywidualny.UseVisualStyleBackColor = true;
            this.btnProjektIndywidualny.Click += new System.EventHandler(this.btnProjektIndywidualny_Click);
            // 
            // KokpitProjektuNr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 323);
            this.Controls.Add(this.btnProjektIndywidualny);
            this.Controls.Add(this.btnLaboratoriumNr3);
            this.Controls.Add(this.labelNazwa1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(780, 370);
            this.Name = "KokpitProjektuNr3";
            this.Text = "KokpitProjektuNr3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitProjektuNr3_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KokpitProjektuNr3_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNazwa1;
        private System.Windows.Forms.Button btnLaboratoriumNr3;
        private System.Windows.Forms.Button btnProjektIndywidualny;
    }
}

