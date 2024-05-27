using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_3
{
    public partial class ProjektNr3 : Form
    {   

        //Narzędzia rysowania
        Point abPunkt = Point.Empty;
        Graphics abRysownica;     //przestrzeń dla rysowania
        Pen abPióro;
        SolidBrush abPędzel;

        //Zmienne rozmiaru figur
        int abwidth1, abheight1;

        //Krzywa Beziera:
        int abliczbaPunktówBeziera, abliczbaPunktówKardynalnej;
        Point[] abpunkty;
        int abi;  //licznik
        string abliczbaPunktówTekst;


        public ProjektNr3()
        {
            InitializeComponent();
            
            //Utworz. egzempl. narzędzi graficznych:
            abPióro = new Pen(Color.Orange, 1.7f);
            abPióro.DashStyle = DashStyle.Solid;
            abPióro.StartCap = LineCap.Round;
            abPióro.EndCap = LineCap.Round;
            abPędzel = new SolidBrush(Color.LightGreen);

            abNowyBitMap();

              
        }

        //Zmiana radiobutton'a:
        private void chboxObramowanie_CheckedChanged(object sender, EventArgs e)
        {
            if (domUDLiczbaPunktów.Enabled)
                abKrzywaBeziera();

            if (numUDLiczbaPunktów.Enabled)
                abKrzywaKardunalna();



            if (rdbKrzywaBeziera.Checked || rdbKrzywaKardynalna.Checked)
            {
                grotyToolStripMenuItem.Enabled = true;
                chboxSklejana.Enabled = true;
                chboxObramowanie.Enabled = false;
                chboxWypełnienie.Enabled = false;
                numUDStopni.Enabled = false;

                if (rdbKrzywaBeziera.Checked)
                {
                    domUDLiczbaPunktów.Enabled = true;
                    numUDLiczbaPunktów.Enabled = false;
                }
                if (rdbKrzywaKardynalna.Checked)
                {
                    if (chboxSklejana.Checked)
                    {
                        chboxObramowanie.Enabled = true;
                        chboxWypełnienie.Enabled = true;
                    }
                    else
                    {
                        chboxObramowanie.Checked = true;
                        chboxWypełnienie.Checked = false;
                    }
                    numUDLiczbaPunktów.Enabled = true;
                    domUDLiczbaPunktów.Enabled = false;
                }
            }
            else    //reszta figur
            {
                abPióro.StartCap = LineCap.Round;
                abPióro.EndCap = LineCap.Round;

                grotyToolStripMenuItem.Enabled = false;
                chboxSklejana.Enabled = false;
                chboxObramowanie.Enabled = true;
                chboxWypełnienie.Enabled = true;

                domUDLiczbaPunktów.Enabled = false;
                numUDLiczbaPunktów.Enabled = false;
                numUDStopni.Enabled = false;

                if (rdbŁukElipsy.Checked)
                {
                    chboxObramowanie.Enabled = false;
                    chboxWypełnienie.Enabled = false;
                }
                if (rdbWycinekElipsy.Checked)
                {
                    numUDStopni.Enabled = true;
                }
            }


            //checkBox'y:
            if (chboxWypełnienie.Checked)
            {
                rdbProstokąt.Text = "Prostokąt\nwypełniony";
                rdbKwadrat.Text = "Kwadrat\nwypełniony";
                rdbElipsa.Text = "Elipsa\nwypełniona";
                rdbOkrąg.Text = "Koło";
                rdbWycinekElipsy.Text = "Wypełniony\nWycinek Elipsy";
                rdbKrzywaKardynalna.Text = "Wypełniona\nKrzywa Kardynalna";
            }
            else if (chboxObramowanie.Checked)
            {
                rdbProstokąt.Text = "Prostokąt";
                rdbKwadrat.Text = "Kwadrat";
                rdbElipsa.Text = "Elipsa";
                rdbOkrąg.Text = "Okrąg";
                rdbWycinekElipsy.Text = "Wycinek elipsy";
                rdbKrzywaKardynalna.Text = "Krzywa Kardynalna";
            }

            //Wyświetlenie błądu
            if (!chboxObramowanie.Checked && !chboxWypełnienie.Checked)
                errorProvider1.SetError(chboxObramowanie, "Wybierz choczby jedną opcje, żeby zacząć rysować");
            else
                errorProvider1.Clear();

        }

        //METODY:

        /// <summary>
        /// Krzywa Beziera
        /// </summary>
        public void abKrzywaBeziera()
        {
            //Console.WriteLine("BEZIER");
            abi = 0;
            abliczbaPunktówTekst = domUDLiczbaPunktów.Text.Replace("punkty", " ");
            abliczbaPunktówTekst = abliczbaPunktówTekst.Trim();
            abliczbaPunktówBeziera = Convert.ToInt32(abliczbaPunktówTekst);
            abpunkty = new Point[abliczbaPunktówBeziera];
        }
        /// <summary>
        /// Krzywa Kardynalna
        /// </summary>
        private void abKrzywaKardunalna()
        {
            //Console.WriteLine("KARDYNALNA");
            abi = 0;
            abliczbaPunktówKardynalnej = Convert.ToInt32(numUDLiczbaPunktów.Value);
            abpunkty = new Point[abliczbaPunktówKardynalnej];
        }

        /// <summary>
        /// Nowy BitMap
        /// </summary>
        private void abNowyBitMap()
        {
            //dodawanie do kontrolki "pbRysownica" - Bitmap (mapy bitowej)
            pbRycownica.Image = new Bitmap(pbRycownica.Width, pbRycownica.Height);  //Długość i szerokość taka jak pbRycownica
            //utworzenie egzemplarza powierzchni graficznej na Bitmap.
            abRysownica = Graphics.FromImage(pbRycownica.Image);

            pbRycownica.Refresh();
        }




        //RYSOWANIE:
        private void domUDLiczbaPunktów_SelectedItemChanged(object sender, EventArgs e)
        {
            abKrzywaBeziera();
        }
        private void numUDLiczbaPunktów_ValueChanged(object sender, EventArgs e)
        {
            abKrzywaKardunalna();
        }


        private void pbRycownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wyświetlanie X i Y
            lbWartośćX.Text = e.Location.X.ToString();
            lbWartośćY.Text = e.Location.Y.ToString();

        }
        private void pbRycownica_MouseDown(object sender, MouseEventArgs e)
        {
            //Sprawdzenie, jaki przycisk myszy był naciśnięty
            if (e.Button == MouseButtons.Left)
                abPunkt = e.Location;     //zapisywanie początkowego położenia myszy w punkcie


            //Krzywa Beziera:
            if (rdbKrzywaBeziera.Checked)
            {
                if (abi  == (abliczbaPunktówBeziera))
                {   //rysowanie
                    abi = 0;
                    if (chboxSklejana.Checked)  //Jeśli sklejana
                        abpunkty[abpunkty.Length - 1] = abpunkty[0];

                    abRysownica.DrawBeziers(abPióro, abpunkty);
                    pbRycownica.Refresh();
                }
                else
                {   //zapisywanie punktów
                    abRysownica.DrawString("P" + abi, new Font("Gill Sans MT", 14) , Brushes.Red, e.Location);
                    abpunkty[abi] = e.Location;
                    abi++;
                }
            }

            //KrzywaKardynalna
            if (rdbKrzywaKardynalna.Checked)
            {
                if (abi == (abliczbaPunktówKardynalnej))
                {
                    if (chboxWypełnienie.Checked)
                    {
                        abi = 0;
                        abRysownica.FillClosedCurve(abPędzel, abpunkty);
                    }
                    if (chboxSklejana.Checked && chboxObramowanie.Checked)
                    {
                        abi = 0;
                        abRysownica.DrawClosedCurve(abPióro, abpunkty);
                    }
                    else if (chboxObramowanie.Checked)
                    {
                        abi = 0;
                        abRysownica.DrawCurve(abPióro, abpunkty);
                    }
                }
                else
                {   //zapisywanie punktów
                    abRysownica.DrawString("P" + abi, new Font("Gill Sans MT", 14), Brushes.Red, e.Location);
                    abpunkty[abi] = e.Location;
                    abi++;
                }
            }
            pbRycownica.Refresh();
        }
        private void pbRycownica_MouseUp(object sender, MouseEventArgs e)
        {
            //Rozmiary figur
            abwidth1 = Math.Abs(e.Location.X - abPunkt.X);
            abheight1 = Math.Abs(e.Location.Y - abPunkt.Y);
            if (abwidth1 == 0 || abheight1 == 0)
            {
                abwidth1 = 10;
                abheight1 = 10;
            }


            //Rysowanie figur:
            if (e.Button == MouseButtons.Left)     
            {
                
                //Rysowanie figur w jakimkolwiek kierunku
                if ((abPunkt.X > e.Location.X) && (abPunkt.Y > e.Location.Y))
                {
                    abPunkt.X = abPunkt.X - abwidth1;
                    abPunkt.Y = abPunkt.Y - abheight1;
                }
                else if (abPunkt.Y > e.Location.Y)
                    abPunkt.Y = abPunkt.Y - abheight1;

                else if (abPunkt.X > e.Location.X)
                    abPunkt.X = abPunkt.X - abwidth1;


                int stopni = Convert.ToInt32(numUDStopni.Value); //Kąt w stopniach


                
                if (chboxWypełnienie.Checked)   //Wypęłnienie
                {
                    //Standartowe figury:
                    if (rdbProstokąt.Checked)
                        abRysownica.FillRectangle(abPędzel, abPunkt.X, abPunkt.Y, abwidth1, abheight1);

                    if (rdbKwadrat.Checked)
                        abRysownica.FillRectangle(abPędzel, abPunkt.X, abPunkt.Y, abwidth1, abwidth1);

                    if (rdbElipsa.Checked)
                        abRysownica.FillEllipse(abPędzel, abPunkt.X, abPunkt.Y, abwidth1, abheight1);

                    if (rdbOkrąg.Checked)
                        abRysownica.FillEllipse(abPędzel, abPunkt.X, abPunkt.Y, abwidth1, abwidth1);

                    //Inne
                    if (rdbWycinekElipsy.Checked)
                        abRysownica.FillPie(abPędzel, abPunkt.X, abPunkt.Y, abwidth1, abheight1, 270, stopni);

                    

                }
                if (chboxObramowanie.Checked)   //Obramowanie
                {
                    //Standartowe figury:
                    if (rdbProstokąt.Checked)
                        abRysownica.DrawRectangle(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abheight1);

                    if (rdbKwadrat.Checked)
                        abRysownica.DrawRectangle(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abwidth1);

                    if (rdbElipsa.Checked)
                        abRysownica.DrawEllipse(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abheight1);

                    if (rdbOkrąg.Checked)
                        abRysownica.DrawEllipse(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abwidth1);


                    //Inne:
                    if (rdbŁukElipsy.Checked)
                        abRysownica.DrawArc(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abheight1, 180, 180);

                    if (rdbWycinekElipsy.Checked)
                        abRysownica.DrawPie(abPióro, abPunkt.X, abPunkt.Y, abwidth1, abheight1, 270, stopni);

                }

            }
            pbRycownica.Refresh();
        }



        /// <summary>
        /// Zamykanie formularza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjektNr3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MessageZamknięcie
                = MessageBox.Show("Czy napewno chcesz przejść do okna głównego?" +
                "\n (wszystko biędzie nie zapisane!)", "Uwaga!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button3);
            if (MessageZamknięcie == DialogResult.Yes)
            {
                e.Cancel = false;
                foreach (Form Formularz in Application.OpenForms)
                {
                    if (Formularz.Name == "KokpitProjektuNr3")
                    {
                        this.Hide();
                        Formularz.Show();
                        return;
                    }
                }
                KokpitProjektuNr3 FormularzKokpitu = new KokpitProjektuNr3();
                FormularzKokpitu.Show();
                this.Hide();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ProjektNr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B') //przycisk ESC
                Close();
        }

        //Nowy rozmiar Bitmap'a
        private void ProjektNr3_SizeChanged(object sender, EventArgs e)
        {
            abNowyBitMap();
            pbRycownica.Refresh();

        }
        //Wyczyszcza rysunek, ale tło pozostaje wybranego koloru
        private void btnWyczyść_Click(object sender, EventArgs e)
        {
            abRysownica.Dispose();
            abNowyBitMap();

            if (domUDLiczbaPunktów.Enabled)
                abKrzywaBeziera();

            if (numUDLiczbaPunktów.Enabled)
                abKrzywaKardunalna();
        }






        //MENU

        /// <summary>
        /// Zapisanie pliku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Zapisanie rysunku...";
            saveFileDialog1.Filter = "New draw(*PNG)|*.PNG | All files(*.*)|*.*";
            saveFileDialog1.DefaultExt = ".PNG";
            saveFileDialog1.OverwritePrompt = true;   //jeśli istnieje już podobna nazwa pliku

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                //Save(saveFileDialog1.FileName);
                pbRycownica.Image.Save(saveFileDialog1.FileName);
                this.Close();
            }
        }

        //Kolory
        private void KolorPióra_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Zmień kolor pióra
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color kolor = colorDialog1.Color;
                abPióro.Color = kolor;
            }
        }
        private void KolorWypełnienia_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Zmień kolor pędzlu
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color kolor = colorDialog1.Color;
                abPędzel.Color = kolor;
            }
        }
        private void KolorTła_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Zmień kolor tła
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color kolor = colorDialog1.Color;
                pbRycownica.BackColor = kolor;
            }
        }

        
        //Atrybuty:

        //Grubość linii
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abPióro.Width = 1f;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abPióro.Width = 2f;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            abPióro.Width = 3f;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            abPióro.Width = 4f;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            abPióro.Width = 5f;
        }

        

        //Styl linii
        private void obecnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.DashStyle = DashStyle.Solid;
        }

        private void punktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.DashStyle = DashStyle.Dash;
        }


        //Groty linii
        private void strzałkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.StartCap = LineCap.ArrowAnchor;
        }

        private void strzałkaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abPióro.EndCap = LineCap.ArrowAnchor;
        }
        private void ObecnaKrawendźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.StartCap = LineCap.Round;
        }
        private void ObecnaKrawendź2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.EndCap = LineCap.Round;

        }
        private void okrągłyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.StartCap = LineCap.RoundAnchor;
        }
        private void okąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abPióro.EndCap = LineCap.RoundAnchor;
        }

    }
}
