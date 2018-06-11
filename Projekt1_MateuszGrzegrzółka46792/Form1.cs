using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie nowej przestrzeni nazw 
using System.Drawing.Drawing2D;

namespace Projekt1_MateuszGrzegrzółka46792
{
    public partial class Projekt1_46792 : Form
    {
        //deklaracja stalych
        const int mgMargines = 40; // odstęp od krawędzi formularza
        int mgPromienKulki = 5;
        //deklaracja zmiennej referencyjnej do egzemplarza powierzchni 
        Graphics mgRysownica;
        //deklaracja piór
        Pen mgPióroXY, mgPióroTor1, mgPióroTor2;
        //deklaracje pomocniczych zmiennych
        int mgXmax, mgYmax, mgXs, mgYs;
        float mgWspólczynnikSkaliDlaOsiOY;
        int mgPunktyWJednostkachMiaryOsiY;
        int mgPunktyWJednostkachMiaryOsiX;
        public void Projekt1_46792_Paint(object sender, PaintEventArgs e)
        {
            //ustalenie określonych linii osi układu wpółrzędych
            mgPióroXY.StartCap = LineCap.Flat;
            mgPióroXY.EndCap = LineCap.ArrowAnchor;
            //wykreślenie osi X i Y
            e.Graphics.DrawLine(mgPióroXY, mgXs - mgPunktyWJednostkachMiaryOsiX / 2, mgYmax / 2,
                mgXs + mgPunktyWJednostkachMiaryOsiX / 2, mgYmax / 2);
            e.Graphics.DrawLine(mgPióroXY, mgXs + mgMargines / 2, mgYmax - 2 * mgMargines,
                mgXs + mgMargines / 2, mgMargines);
            //wykreślenie torów animacji: 
            e.Graphics.DrawCurve(mgPióroTor1, mgPunktynaTorzeLiniTor1);
            e.Graphics.DrawCurve(mgPióroTor2, mgPunktynaTorzeLiniTor2);
            //wkreślenie kulek w nowym położeniu
            e.Graphics.FillEllipse(Brushes.Yellow, mgPunktynaTorzeLiniTor1[mgIndexPołożenieKulek].X - mgPromienKulki, 
                mgPunktynaTorzeLiniTor1[mgIndexPołożenieKulek].Y - mgPromienKulki, mgPromienKulki + mgPromienKulki,
                mgPromienKulki + mgPromienKulki);
            e.Graphics.FillEllipse(Brushes.Green, mgPunktynaTorzeLiniTor2[mgIndexPołożenieKulek].X - mgPromienKulki, 
                mgPunktynaTorzeLiniTor2[mgIndexPołożenieKulek].Y - mgPromienKulki, mgPromienKulki + mgPromienKulki,
                mgPromienKulki + mgPromienKulki);
        }
        
        //suwak do prędkości ruchu 
        private void mgPrędkośćRuchu_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = mgPrędkośćRuchu.Value;
        }
        //styl linii toru 1
        private void mgWybranyStylTor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgPióroTor1.DashStyle = mgWybranyStylLiniiTor1();
        }
        //styl linii toru 2
        private void mgWybranyStylTor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mgPióroTor2.DashStyle = mgWybranyStylLiniiTor2();
        }
        //wybieranie stylów linii poszczególnych torów
        DashStyle mgWybranyStylLiniiTor1()
        {
            switch (mgWybranyStylTor1.SelectedIndex)
            {
                case 0: return DashStyle.Dash;
                case 1: return DashStyle.DashDot;
                case 2: return DashStyle.DashDotDot;
                case 3: return DashStyle.Dot;
                case 4: return DashStyle.Solid;
                default: return DashStyle.Solid;
            }
        }
        DashStyle mgWybranyStylLiniiTor2()
        {
            switch (mgWybranyStylTor2.SelectedIndex)
            {
                case 0: return DashStyle.Dash;
                case 1: return DashStyle.DashDot;
                case 2: return DashStyle.DashDotDot;
                case 3: return DashStyle.Dot;
                case 4: return DashStyle.Solid;
                default: return DashStyle.Solid;
            }
        }
        //ustawianie grubości linii torów
        private void mgGrubośćLiniiTorów_Scroll(object sender, EventArgs e)
        {
            mgPióroTor1.Width = mgGrubośćLiniiTorów.Value;
            mgPióroTor2.Width = mgGrubośćLiniiTorów.Value;
        }
        //zmiany kolorów toru 1 oraz podglądu legendy
        private void mgZmianaKoloruTor1_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = mgPióroTor1.Color;
            mgOknoKolorów.Color = mgWziernikTor1.BackColor;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                //ustawienie nowego koloru linii wykresu
                mgPióroTor1.Color = mgOknoKolorów.Color;
                mgWziernikTor1.BackColor = mgOknoKolorów.Color;
            }
        }
        //zmiany kolorów toru 2 oraz podglądu legendy
        private void mgZmianaKoloruTor2_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = mgPióroTor2.Color;
            mgOknoKolorów.Color = mgWziernikTor2.BackColor;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                //ustawienie nowego koloru linii wykresu
                mgPióroTor2.Color = mgOknoKolorów.Color;
                mgWziernikTor2.BackColor = mgOknoKolorów.Color;
            }
        }
        //ustawienie grubości linii układu współrzędnych
        private void mgGrubośćLiniiUkładuWsp_Scroll(object sender, EventArgs e)
        {
            mgPióroXY.Width= mgGrubośćLiniiUkładuWsp.Value;
        }
        //ustawienie wielkości obiektu
        private void mgWielkośćObiektu_Scroll(object sender, EventArgs e)
        {
            mgPromienKulki = mgWielkośćObiektu.Value;
        }
        //wybieranie stylu osi układu współrzędnych
        private void mgStylOsi_SelectedIndexChanged(object sender, EventArgs e)
        {

            mgPióroXY.DashStyle = mgWybranyStylLiniiOsi();
        }
        DashStyle mgWybranyStylLiniiOsi()
        {
            switch (mgStylOsi.SelectedIndex)
            {
                case 0: return DashStyle.Dash;
                case 1: return DashStyle.DashDot;
                case 2: return DashStyle.DashDotDot;
                case 3: return DashStyle.Dot;
                case 4: return DashStyle.Solid;
                default: return DashStyle.Solid;
            }
        }
        //zmiana kolorów osi układu współrzędnych
        private void mgZmianaKoloruOsi_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = mgPióroXY.Color;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                //ustawienie nowego koloru linii wykresu
                mgPióroXY.Color = mgOknoKolorów.Color;
            }
        }
        //zmiana koloru głównego tła
        private void mgZmianaKoloruTła_Click(object sender, EventArgs e)
        {
            
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = Color.WhiteSmoke; 
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = mgOknoKolorów.Color;
            }
        }

        private void Projekt1_46792_Load(object sender, EventArgs e)
        {
           
        }

        private void mgWziernikTor2_Click(object sender, EventArgs e)
        {

        }
           //zmiana koloru czcionki dla legendy powstałej animacji
        private void mgZmianaKoloruCzcionki_Click(object sender, EventArgs e)
        {
            ColorDialog mgOknoKolorów = new ColorDialog();
            mgOknoKolorów.Color = Color.Black;
            if (mgOknoKolorów.ShowDialog() == DialogResult.OK)
            {
                mgLegendaLab.ForeColor = mgOknoKolorów.Color;
                mgLiniaTor1Lab.ForeColor = mgOknoKolorów.Color;
                mgLiniaTor2Lab.ForeColor = mgOknoKolorów.Color;
            }
        }
        //zmiana czcionki dla legendy powstałej animacji
        private void mgZmianaCzcionki_Click(object sender, EventArgs e)
        {
            /* utworzenie instancji (egzemplarza) klasy FontDialog, która umożliwia formatowanie czcionki*/
            FontDialog mgOknoFormatowaniaCzcionki = new FontDialog();
            /*wyświetlenie okna dialogowego formatowania czcionki i przypisanie kontrolce DataGridView tych ustawień*/
            if (mgOknoFormatowaniaCzcionki.ShowDialog() == DialogResult.OK)
            {
                mgLegendaLab.Font = mgOknoFormatowaniaCzcionki.Font;
                mgLiniaTor1Lab.Font = mgOknoFormatowaniaCzcionki.Font;
                mgLiniaTor2Lab.Font = mgOknoFormatowaniaCzcionki.Font;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (mgIndexPołożenieKulek < mgPunktyWJednostkachMiaryOsiX)
                mgIndexPołożenieKulek++;
            else
                mgIndexPołożenieKulek = 0;
            //oswieżenie obrazu
            this.Refresh();
        }

        int mgIndexPołożenieKulek;
        //deklaracja tablic (wektorów)
        Point[] mgPunktynaTorzeLiniTor1;
        Point[] mgPunktynaTorzeLiniTor2;
        private void mgRysownica_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult mgPytanieDoUżytkownika = MessageBox.Show("Czy jesteś pewny/a, że chcesz zakończyć działanie programu?",
                this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);
            if (mgPytanieDoUżytkownika == DialogResult.Yes)
            {
                MessageBox.Show("Żegnaj! Mam nadzieję, że jeszcze wrócisz");
                /* zdarzenie FormClosing powinno być zrealizowane, (czyli okno musi być zamknięte)*/
                e.Cancel = false;
            }
            else
                if (mgPytanieDoUżytkownika == DialogResult.No)
                /* zdarzenie FormClosing zostało wygenerowane przypadkowo, czyli okno (formularz) powinno zostać otwarte*/
                e.Cancel = true;
            else
                //anulowanie zdarzenia FormClosing
                e.Cancel = true;
        }


        public Projekt1_46792()
        {
            InitializeComponent();
           
            //lokalizacja i zwymiarowanie formularza
            this.Location = new Point(10, 10);
            //this.Width = (int)(150 * 0.6F);
           // this.Height = (int)(100 * 0.6F);
            this.StartPosition = FormStartPosition.Manual;
            // utworzenie egzemplarza powierzchni graficznej
            mgRysownica = this.CreateGraphics();
            //utworzenie egzemplarzy piór
            mgPióroTor1 = new Pen(Color.Red, 1F);
            mgWziernikTor1.BackColor = Color.Red;
           //mgPióroTor1.DashStyle = DashStyle.Solid;
            mgPióroTor2 = new Pen(Color.RoyalBlue, 1F);
            mgWziernikTor2.BackColor = Color.RoyalBlue;
           //mgPióroTor2.DashStyle = DashStyle.Solid;
            mgPióroXY = new Pen(Color.SandyBrown, 1F);
           // mgPióroXY.DashStyle = DashStyle.Solid;
            //wyznaczenie maksymalnych wartosći współrzędnych X i Y
            mgXmax = this.Size.Width - mgMargines;
            mgYmax = this.Size.Height - mgMargines;
            mgXs = mgXmax / 2;
            mgYs = mgYmax / 2;
            //określenie wartości współczynnika skali osi Y
            mgWspólczynnikSkaliDlaOsiOY = mgYmax / 8;
            mgPunktyWJednostkachMiaryOsiY = (int)(mgWspólczynnikSkaliDlaOsiOY * Math.PI);
            mgPunktyWJednostkachMiaryOsiX = 4 * mgPunktyWJednostkachMiaryOsiY;
            // utworzenie egzemplarzy dla tablic dla przechowania współrzędnych
            mgPunktynaTorzeLiniTor1 = new Point[mgPunktyWJednostkachMiaryOsiX + 1];
            mgPunktynaTorzeLiniTor2 = new Point[mgPunktyWJednostkachMiaryOsiX + 1];
            // ustawienie indeksu położenia początowego kulek
            mgIndexPołożenieKulek = 0;
            //ustalenie przyrostu zmian kąta FI na osi X
            int mgDx = (mgXmax - (mgMargines * 2)) / mgPunktyWJednostkachMiaryOsiX;
            //deklaracja zmiennej dla FI
            int mgFi;
            //deklaracja zmiennej Fi w radianach
            float mgFi_w_Radianach;
            //wyznaczenie współrzędnyh punktów
            //deklaracja indeksu zapisu współrzędnych punktu w tablicach
            int mgIndexPunktówOsiX;
            for (mgFi = mgXs - mgPunktyWJednostkachMiaryOsiX / 2, mgIndexPunktówOsiX = 0; 
                mgIndexPunktówOsiX <= mgPunktyWJednostkachMiaryOsiX; mgFi += mgDx)
            {
                //przeliczenie kąta Fi na radiany
                mgFi_w_Radianach = (float)((mgFi * Math.PI) / 180);
                //wyznaczenie współrzędnej Y na liniach toru i wpisanie pary Fi oraz Y do odpowiedniej tablicy: 
                mgPunktynaTorzeLiniTor1[mgIndexPunktówOsiX] = new Point(mgFi, mgYs - 
                    (int)(mgWspólczynnikSkaliDlaOsiOY * (2-Math.Cosh(Math.Log(mgFi_w_Radianach/4)))));
                mgPunktynaTorzeLiniTor2[mgIndexPunktówOsiX] = new Point(mgFi, mgYs - 
                    (int)(mgWspólczynnikSkaliDlaOsiOY * Math.Cos(mgFi_w_Radianach *3) + (Math.Pow(mgFi_w_Radianach, 1.75))));
                mgIndexPunktówOsiX++;
            }
            //włączenie podwójnego buforowania dla minimalizacji migotania obrazu
            this.DoubleBuffered = true;
            //ustalenie interwału dla zegara PRĘDKOŚĆ KULEK
            //timer1.Interval = 1;
            //włączenie zegara
            timer1.Enabled = true;
        }
    }
}
