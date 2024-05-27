using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
namespace Projekt_3
{
    public partial class LaboratoriumNr3 : Form
    {
        //Deklaracja stałych:
        const ushort PromieńPunktu = 2;

        

        //Deklaracja zmiennych referencyjnych narzędzi graficznych:
        Graphics Rysownica;     //przestrzeń dla rysowania
        Pen Pióro;
        SolidBrush Pędzel;
        Point Punkt = Point.Empty;      //pusty punkt wspówrzędnych (X,Y)


        public LaboratoriumNr3() //konstruktor 
        {
            InitializeComponent();


            //dodawanie do kontrolki "pbRysownica" - Bitmap (mapy bitowej)
            pbRycownica.Image = new Bitmap(pbRycownica.Width, pbRycownica.Height);  //Długość i szerokość taka jak pbRycownica
            //utworzenie egzemplarza powierzchni graficznej na Bitmap.
            Rysownica = Graphics.FromImage(pbRycownica.Image);

            //Utworz. egzempl. narzędzi graficznych:
            Pióro = new Pen(Color.Orange, 1.7f);
            Pióro.DashStyle = DashStyle.Dash;
            //zaokrąglone krawędzie:
            Pióro.StartCap = LineCap.Round; 
            Pióro.EndCap = LineCap.Round;

            Pędzel = new SolidBrush(Color.Green);
        }

        private void pbRycownica_MouseDown(object sender, MouseEventArgs e)     //Pobierania położenia myszy
        {
            //wyświetlanie X i Y
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            //Sprawdzenie, jaki przycisk myszy był naciśnięty
            if (e.Button == MouseButtons.Left)
            {
                Punkt = e.Location; //zapisywanie położenia myszy
            }
        }

        private void pbRycownica_MouseUp(object sender, MouseEventArgs e)
        {
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)      //Rysowanie figur
            {
                if (rdbPunkt.Checked)
                {
                    Rysownica.FillEllipse(Pędzel, Punkt.X - PromieńPunktu, Punkt.Y - PromieńPunktu, 2* PromieńPunktu, 2* PromieńPunktu);
                }

                if (rdbLinia.Checked)
                {
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                }
                
                if (rdbLiniaKreślonaMyszką.Checked)
                {
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                }

                if (rdbWielokąt.Checked)
                {
                    //Lokalizacja myszy
                    int LewyGórnyNaróżnikX = e.Location.X,
                        LewyGórnyNaróżnikY = e.Location.Y;
                    //radius
                    int Szerokość = Math.Abs(Punkt.X - e.Location.X);



                    if (numUDLiczbaKątów.Value <= 2)
                    {
                        errorProvider1.SetIconAlignment(numUDLiczbaKątów, ErrorIconAlignment.MiddleLeft);
                        errorProvider1.SetError(numUDLiczbaKątów, "Wartość powinna być większa od 2!");
                        

                    }

                    else if (numUDLiczbaKątów.Value > 1)
                    {
                        errorProvider1.Clear();

                        ushort StopieńWielokąta;
                        int PromieńWielokąta;       //promień okręgu opisanego na wierzchołkach 
                        numUDLiczbaKątów.Enabled = false;   //dezaktywować po wniesieniu zmian
                                                            //odczytanie:
                        StopieńWielokąta = (ushort)numUDLiczbaKątów.Value;

                        double KątMiędzyWierzchołkamiWielokąta = 360.0f / StopieńWielokąta;
                        double KątPołożeniaPierwszegoWierzchołkaWielokąta = 0.0f;

                        PromieńWielokąta = Szerokość;
                        //współrzędne wierzchołków  wielokąta
                        Point[] WierzchołkiWielokąta = new Point[StopieńWielokąta]; //zarezerwowzno 360 stopni miejsca 

                        for (int i = 0; i < StopieńWielokąta; i++)
                        {
                            WierzchołkiWielokąta[i].X = LewyGórnyNaróżnikX +
                                (int)(PromieńWielokąta * Math.Cos(Math.PI * (KątPołożeniaPierwszegoWierzchołkaWielokąta + i * KątMiędzyWierzchołkamiWielokąta) / 180));
                            WierzchołkiWielokąta[i].Y = LewyGórnyNaróżnikY -
                                (int)(PromieńWielokąta * Math.Sin(Math.PI * (KątPołożeniaPierwszegoWierzchołkaWielokąta + i * KątMiędzyWierzchołkamiWielokąta) / 180));
                        }
                        //Wykreślenie wielokąta:
                        Rysownica.DrawPolygon(Pióro, WierzchołkiWielokąta);
                    }
                }
            }
            pbRycownica.Refresh();

        }

        private void pbRycownica_MouseMove(object sender, MouseEventArgs e)
        {
            //wyświetlanie X i Y
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)      
            {
                if (rdbLiniaKreślonaMyszką.Checked)
                {
                    Rysownica.DrawLine(Pióro, Punkt.X, Punkt.Y, e.Location.X, e.Location.Y);
                    Punkt = e.Location;
                }
            }

            pbRycownica.Refresh();

        }





        private void LaboratoriumNr3_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult MessageZamknięcie
                = MessageBox.Show("Czy napewno chcesz przejść do okna głównego?" +
                "\n (Upewnij się, że przed zamknięciem plik był zapisany!)", "Uwaga!",
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

        private void LaboratoriumNr3_SizeChanged(object sender, EventArgs e)
        {
            
            //dodawanie do kontrolki "pbRysownica" - Bitmap (mapy bitowej)
            pbRycownica.Image = new Bitmap(pbRycownica.Width, pbRycownica.Height);
            //utworzenie egzemplarza powierzchni graficznej na Bitmap.
            Rysownica = Graphics.FromImage(pbRycownica.Image);
            pbRycownica.Refresh();
            
        }





        //MENU
        private void kolorLiniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kolorLinii_result = colorDialog1.ShowDialog();

            if (kolorLinii_result == DialogResult.OK)
            {
                Color kolor = colorDialog1.Color;
                Pióro.Color = kolor;
            }
        }

        private void kolorRysownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult kolorLinii_result = colorDialog1.ShowDialog();

            if (kolorLinii_result == DialogResult.OK)
            {
                Color kolor = colorDialog1.Color;
                pbRycownica.BackColor = kolor;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pióro.Width = 1f;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pióro.Width = 2f;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pióro.Width = 3f;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Pióro.Width = 4f;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Pióro.Width = 5f;
        }
        
        private void obecnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.DashStyle = DashStyle.Solid;
        }

        private void punktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.DashStyle = DashStyle.Dash;
        }

        //Groty
        private void kwadratowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.StartCap = LineCap.Square;
        }

        private void okrągłyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.StartCap = LineCap.Round;
        }

        private void strzałkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.StartCap = LineCap.ArrowAnchor;
        }

        private void kwadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.EndCap = LineCap.Square;
        }

        private void okąToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pióro.EndCap = LineCap.Round;
        }

        private void strzałkaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pióro.EndCap = LineCap.ArrowAnchor;
        }

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

            //Sposób 2
            /*
            SaveFileDialog zapisanie = new SaveFileDialog();
            zapisanie.Title = "Zapisanie rysunku...";
            zapisanie.OverwritePrompt = true;   //jeśli istnieje już podobna nazwa pliku
            zapisanie.Filter = "New draw(*.PNG)|*.PNG|All files(*.*)|*.*";
            zapisanie.DefaultExt = ".PNG";

            if (zapisanie.ShowDialog() == DialogResult.OK && zapisanie.FileName.Length > 0)
            {
                try
                {
                    pbRycownica.Image.Save(zapisanie.FileName);
                }
                catch (Exception)   //jeśli wystąpi błąd
                {
                    DialogResult message = MessageBox.Show("Nie prawidlowy szlak", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            */

        }
    }
}
