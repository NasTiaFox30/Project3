using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_3
{
    public partial class KokpitProjektuNr3 : Form
    {
        public KokpitProjektuNr3()
        {
            InitializeComponent();

        }

        private void btnLaboratoriumNr3_Click(object sender, EventArgs e)
        {
            PrzełączenieMiędzyOknami("LaboratoriumNr3");
            LaboratoriumNr3 FormularzLaboratoryjny = new LaboratoriumNr3();
            this.Hide();
            FormularzLaboratoryjny.Show();
        }

        private void btnProjektIndywidualny_Click(object sender, EventArgs e)
        {
            PrzełączenieMiędzyOknami("ProjektNr3");
            ProjektNr3 FormularzProjektowy = new ProjektNr3();
            this.Hide();
            FormularzProjektowy.Show();
        }

        private void KokpitProjektuNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MessageZamknięcie
                = MessageBox.Show("Napewno zamknąć program?", "Zamknięcie programu",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button3);

            if (MessageZamknięcie == DialogResult.Yes)
            {
                e.Cancel = false;
                this.Hide();
                Application.ExitThread();   //wyjście ze wszystkich procesów aplikacji

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void KokpitProjektuNr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B') //przycisk ESC
                Close();
        }

        public void PrzełączenieMiędzyOknami(string nazwaOkna)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == nazwaOkna)
                {
                    this.Hide();
                    Formularz.Show();
                    return;
                }
            }

        }

        
    }
}
