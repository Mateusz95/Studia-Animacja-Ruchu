namespace Projekt1_MateuszGrzegrzółka46792
{
    partial class Projekt1_46792
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projekt1_46792));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mgGrubośćLiniiTorów = new System.Windows.Forms.TrackBar();
            this.mgGrubośćLiniiLab = new System.Windows.Forms.Label();
            this.mgZmianaStyluTor1Lab = new System.Windows.Forms.Label();
            this.mgZmianaStyluTor2Lab = new System.Windows.Forms.Label();
            this.mgZmianaKoloruTor1 = new System.Windows.Forms.Button();
            this.mgZmianaKoloruTor2 = new System.Windows.Forms.Button();
            this.mgPrędkośćRuchu = new System.Windows.Forms.TrackBar();
            this.mgPrędkośćRuchuLab = new System.Windows.Forms.Label();
            this.mgWybranyStylTor1 = new System.Windows.Forms.ComboBox();
            this.mgWybranyStylTor2 = new System.Windows.Forms.ComboBox();
            this.mgGrubośćLiniiUkładu = new System.Windows.Forms.Label();
            this.mgGrubośćLiniiUkładuWsp = new System.Windows.Forms.TrackBar();
            this.mgWielkośćObiektuLab = new System.Windows.Forms.Label();
            this.mgWielkośćObiektu = new System.Windows.Forms.TrackBar();
            this.mgStylOsiLab = new System.Windows.Forms.Label();
            this.mgStylOsi = new System.Windows.Forms.ComboBox();
            this.mgZmianaKoloruOsi = new System.Windows.Forms.Button();
            this.mgZmianaKoloruTła = new System.Windows.Forms.Button();
            this.mgLegendaLab = new System.Windows.Forms.Label();
            this.mgLiniaTor1Lab = new System.Windows.Forms.Label();
            this.mgLiniaTor2Lab = new System.Windows.Forms.Label();
            this.mgWziernikTor1 = new System.Windows.Forms.Label();
            this.mgWziernikTor2 = new System.Windows.Forms.Label();
            this.mgZmianaKoloruCzcionki = new System.Windows.Forms.Button();
            this.mgZmianaCzcionki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mgGrubośćLiniiTorów)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgPrędkośćRuchu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgGrubośćLiniiUkładuWsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgWielkośćObiektu)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // mgGrubośćLiniiTorów
            // 
            this.mgGrubośćLiniiTorów.Location = new System.Drawing.Point(12, 29);
            this.mgGrubośćLiniiTorów.Minimum = 1;
            this.mgGrubośćLiniiTorów.Name = "mgGrubośćLiniiTorów";
            this.mgGrubośćLiniiTorów.Size = new System.Drawing.Size(157, 56);
            this.mgGrubośćLiniiTorów.TabIndex = 0;
            this.mgGrubośćLiniiTorów.Value = 1;
            this.mgGrubośćLiniiTorów.Scroll += new System.EventHandler(this.mgGrubośćLiniiTorów_Scroll);
            // 
            // mgGrubośćLiniiLab
            // 
            this.mgGrubośćLiniiLab.AutoSize = true;
            this.mgGrubośćLiniiLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgGrubośćLiniiLab.Location = new System.Drawing.Point(28, 9);
            this.mgGrubośćLiniiLab.Name = "mgGrubośćLiniiLab";
            this.mgGrubośćLiniiLab.Size = new System.Drawing.Size(130, 19);
            this.mgGrubośćLiniiLab.TabIndex = 1;
            this.mgGrubośćLiniiLab.Text = "Grubość linii torów ";
            // 
            // mgZmianaStyluTor1Lab
            // 
            this.mgZmianaStyluTor1Lab.AutoSize = true;
            this.mgZmianaStyluTor1Lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgZmianaStyluTor1Lab.Location = new System.Drawing.Point(206, 9);
            this.mgZmianaStyluTor1Lab.Name = "mgZmianaStyluTor1Lab";
            this.mgZmianaStyluTor1Lab.Size = new System.Drawing.Size(156, 19);
            this.mgZmianaStyluTor1Lab.TabIndex = 2;
            this.mgZmianaStyluTor1Lab.Text = "Zmień styl linii toru nr.1";
            // 
            // mgZmianaStyluTor2Lab
            // 
            this.mgZmianaStyluTor2Lab.AutoSize = true;
            this.mgZmianaStyluTor2Lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgZmianaStyluTor2Lab.Location = new System.Drawing.Point(206, 57);
            this.mgZmianaStyluTor2Lab.Name = "mgZmianaStyluTor2Lab";
            this.mgZmianaStyluTor2Lab.Size = new System.Drawing.Size(156, 19);
            this.mgZmianaStyluTor2Lab.TabIndex = 3;
            this.mgZmianaStyluTor2Lab.Text = "Zmień styl linii toru nr.2";
            // 
            // mgZmianaKoloruTor1
            // 
            this.mgZmianaKoloruTor1.Location = new System.Drawing.Point(366, 29);
            this.mgZmianaKoloruTor1.Name = "mgZmianaKoloruTor1";
            this.mgZmianaKoloruTor1.Size = new System.Drawing.Size(189, 23);
            this.mgZmianaKoloruTor1.TabIndex = 4;
            this.mgZmianaKoloruTor1.Text = "Zmiana koloru linii toru 1";
            this.mgZmianaKoloruTor1.UseVisualStyleBackColor = true;
            this.mgZmianaKoloruTor1.Click += new System.EventHandler(this.mgZmianaKoloruTor1_Click);
            // 
            // mgZmianaKoloruTor2
            // 
            this.mgZmianaKoloruTor2.Location = new System.Drawing.Point(366, 77);
            this.mgZmianaKoloruTor2.Name = "mgZmianaKoloruTor2";
            this.mgZmianaKoloruTor2.Size = new System.Drawing.Size(189, 23);
            this.mgZmianaKoloruTor2.TabIndex = 5;
            this.mgZmianaKoloruTor2.Text = "Zmiana koloru linii toru 2";
            this.mgZmianaKoloruTor2.UseVisualStyleBackColor = true;
            this.mgZmianaKoloruTor2.Click += new System.EventHandler(this.mgZmianaKoloruTor2_Click);
            // 
            // mgPrędkośćRuchu
            // 
            this.mgPrędkośćRuchu.Location = new System.Drawing.Point(181, 494);
            this.mgPrędkośćRuchu.Maximum = 200;
            this.mgPrędkośćRuchu.Minimum = 10;
            this.mgPrędkośćRuchu.Name = "mgPrędkośćRuchu";
            this.mgPrędkośćRuchu.Size = new System.Drawing.Size(157, 56);
            this.mgPrędkośćRuchu.SmallChange = 5;
            this.mgPrędkośćRuchu.TabIndex = 6;
            this.mgPrędkośćRuchu.Value = 10;
            this.mgPrędkośćRuchu.Scroll += new System.EventHandler(this.mgPrędkośćRuchu_Scroll);
            // 
            // mgPrędkośćRuchuLab
            // 
            this.mgPrędkośćRuchuLab.BackColor = System.Drawing.Color.MintCream;
            this.mgPrędkośćRuchuLab.Location = new System.Drawing.Point(163, 437);
            this.mgPrędkośćRuchuLab.Name = "mgPrędkośćRuchuLab";
            this.mgPrędkośćRuchuLab.Size = new System.Drawing.Size(199, 46);
            this.mgPrędkośćRuchuLab.TabIndex = 7;
            this.mgPrędkośćRuchuLab.Text = "Prędkość ruchu obiektów od największej do najmniejszej";
            this.mgPrędkośćRuchuLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgWybranyStylTor1
            // 
            this.mgWybranyStylTor1.FormattingEnabled = true;
            this.mgWybranyStylTor1.Items.AddRange(new object[] {
            "Kreskowa (Dash)",
            "KreskowoKropkowa (DashDot)",
            "KreskowoKropkowaKropkowa (DashDotDot)",
            "Kropkowa (Dot)",
            "Ciągła (Solid)"});
            this.mgWybranyStylTor1.Location = new System.Drawing.Point(209, 30);
            this.mgWybranyStylTor1.Name = "mgWybranyStylTor1";
            this.mgWybranyStylTor1.Size = new System.Drawing.Size(151, 24);
            this.mgWybranyStylTor1.TabIndex = 8;
            this.mgWybranyStylTor1.Text = "Wybierz styl linii";
            this.mgWybranyStylTor1.SelectedIndexChanged += new System.EventHandler(this.mgWybranyStylTor1_SelectedIndexChanged);
            // 
            // mgWybranyStylTor2
            // 
            this.mgWybranyStylTor2.FormattingEnabled = true;
            this.mgWybranyStylTor2.Items.AddRange(new object[] {
            "Kreskowa (Dash)",
            "KreskowoKropkowa (DashDot)",
            "KreskowoKropkowaKropkowa (DashDotDot)",
            "Kropkowa (Dot)",
            "Ciągła (Solid)"});
            this.mgWybranyStylTor2.Location = new System.Drawing.Point(209, 77);
            this.mgWybranyStylTor2.Name = "mgWybranyStylTor2";
            this.mgWybranyStylTor2.Size = new System.Drawing.Size(151, 24);
            this.mgWybranyStylTor2.TabIndex = 9;
            this.mgWybranyStylTor2.Text = "Wybierz styl linii";
            this.mgWybranyStylTor2.SelectedIndexChanged += new System.EventHandler(this.mgWybranyStylTor2_SelectedIndexChanged);
            // 
            // mgGrubośćLiniiUkładu
            // 
            this.mgGrubośćLiniiUkładu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgGrubośćLiniiUkładu.Location = new System.Drawing.Point(15, 67);
            this.mgGrubośćLiniiUkładu.Name = "mgGrubośćLiniiUkładu";
            this.mgGrubośćLiniiUkładu.Size = new System.Drawing.Size(141, 42);
            this.mgGrubośćLiniiUkładu.TabIndex = 10;
            this.mgGrubośćLiniiUkładu.Text = "Grubość linii układu współrzędnych";
            this.mgGrubośćLiniiUkładu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgGrubośćLiniiUkładuWsp
            // 
            this.mgGrubośćLiniiUkładuWsp.Location = new System.Drawing.Point(17, 112);
            this.mgGrubośćLiniiUkładuWsp.Minimum = 1;
            this.mgGrubośćLiniiUkładuWsp.Name = "mgGrubośćLiniiUkładuWsp";
            this.mgGrubośćLiniiUkładuWsp.Size = new System.Drawing.Size(157, 56);
            this.mgGrubośćLiniiUkładuWsp.TabIndex = 11;
            this.mgGrubośćLiniiUkładuWsp.Value = 1;
            this.mgGrubośćLiniiUkładuWsp.Scroll += new System.EventHandler(this.mgGrubośćLiniiUkładuWsp_Scroll);
            // 
            // mgWielkośćObiektuLab
            // 
            this.mgWielkośćObiektuLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgWielkośćObiektuLab.Location = new System.Drawing.Point(12, 437);
            this.mgWielkośćObiektuLab.Name = "mgWielkośćObiektuLab";
            this.mgWielkośćObiektuLab.Size = new System.Drawing.Size(141, 42);
            this.mgWielkośćObiektuLab.TabIndex = 12;
            this.mgWielkośćObiektuLab.Text = "Wielkość obiektów";
            this.mgWielkośćObiektuLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mgWielkośćObiektu
            // 
            this.mgWielkośćObiektu.Location = new System.Drawing.Point(12, 494);
            this.mgWielkośćObiektu.Maximum = 20;
            this.mgWielkośćObiektu.Minimum = 5;
            this.mgWielkośćObiektu.Name = "mgWielkośćObiektu";
            this.mgWielkośćObiektu.Size = new System.Drawing.Size(139, 56);
            this.mgWielkośćObiektu.TabIndex = 13;
            this.mgWielkośćObiektu.Value = 5;
            this.mgWielkośćObiektu.Scroll += new System.EventHandler(this.mgWielkośćObiektu_Scroll);
            // 
            // mgStylOsiLab
            // 
            this.mgStylOsiLab.AutoSize = true;
            this.mgStylOsiLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgStylOsiLab.Location = new System.Drawing.Point(206, 104);
            this.mgStylOsiLab.Name = "mgStylOsiLab";
            this.mgStylOsiLab.Size = new System.Drawing.Size(120, 19);
            this.mgStylOsiLab.TabIndex = 14;
            this.mgStylOsiLab.Text = "Zmień styl linii osi";
            // 
            // mgStylOsi
            // 
            this.mgStylOsi.FormattingEnabled = true;
            this.mgStylOsi.Items.AddRange(new object[] {
            "Kreskowa (Dash)",
            "KreskowoKropkowa (DashDot)",
            "KreskowoKropkowaKropkowa (DashDotDot)",
            "Kropkowa (Dot)",
            "Ciągła (Solid)"});
            this.mgStylOsi.Location = new System.Drawing.Point(209, 125);
            this.mgStylOsi.Name = "mgStylOsi";
            this.mgStylOsi.Size = new System.Drawing.Size(151, 24);
            this.mgStylOsi.TabIndex = 15;
            this.mgStylOsi.Text = "Wybierz styl linii osi";
            this.mgStylOsi.SelectedIndexChanged += new System.EventHandler(this.mgStylOsi_SelectedIndexChanged);
            // 
            // mgZmianaKoloruOsi
            // 
            this.mgZmianaKoloruOsi.Location = new System.Drawing.Point(366, 126);
            this.mgZmianaKoloruOsi.Name = "mgZmianaKoloruOsi";
            this.mgZmianaKoloruOsi.Size = new System.Drawing.Size(189, 23);
            this.mgZmianaKoloruOsi.TabIndex = 16;
            this.mgZmianaKoloruOsi.Text = "Zmiana koloru linii osi";
            this.mgZmianaKoloruOsi.UseVisualStyleBackColor = true;
            this.mgZmianaKoloruOsi.Click += new System.EventHandler(this.mgZmianaKoloruOsi_Click);
            // 
            // mgZmianaKoloruTła
            // 
            this.mgZmianaKoloruTła.BackColor = System.Drawing.SystemColors.Control;
            this.mgZmianaKoloruTła.Location = new System.Drawing.Point(1002, 532);
            this.mgZmianaKoloruTła.Name = "mgZmianaKoloruTła";
            this.mgZmianaKoloruTła.Size = new System.Drawing.Size(189, 46);
            this.mgZmianaKoloruTła.TabIndex = 17;
            this.mgZmianaKoloruTła.Text = "Zmiana koloru tła";
            this.mgZmianaKoloruTła.UseVisualStyleBackColor = false;
            this.mgZmianaKoloruTła.Click += new System.EventHandler(this.mgZmianaKoloruTła_Click);
            // 
            // mgLegendaLab
            // 
            this.mgLegendaLab.AutoSize = true;
            this.mgLegendaLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mgLegendaLab.Location = new System.Drawing.Point(705, 340);
            this.mgLegendaLab.Name = "mgLegendaLab";
            this.mgLegendaLab.Size = new System.Drawing.Size(203, 18);
            this.mgLegendaLab.TabIndex = 18;
            this.mgLegendaLab.Text = "Legenda linii toru animacji";
            // 
            // mgLiniaTor1Lab
            // 
            this.mgLiniaTor1Lab.AutoSize = true;
            this.mgLiniaTor1Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mgLiniaTor1Lab.Location = new System.Drawing.Point(705, 377);
            this.mgLiniaTor1Lab.Name = "mgLiniaTor1Lab";
            this.mgLiniaTor1Lab.Size = new System.Drawing.Size(79, 17);
            this.mgLiniaTor1Lab.TabIndex = 19;
            this.mgLiniaTor1Lab.Text = "Linia toru 1";
            // 
            // mgLiniaTor2Lab
            // 
            this.mgLiniaTor2Lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mgLiniaTor2Lab.AutoSize = true;
            this.mgLiniaTor2Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mgLiniaTor2Lab.Location = new System.Drawing.Point(705, 408);
            this.mgLiniaTor2Lab.Name = "mgLiniaTor2Lab";
            this.mgLiniaTor2Lab.Size = new System.Drawing.Size(79, 17);
            this.mgLiniaTor2Lab.TabIndex = 20;
            this.mgLiniaTor2Lab.Text = "Linia toru 2";
            // 
            // mgWziernikTor1
            // 
            this.mgWziernikTor1.BackColor = System.Drawing.Color.Gray;
            this.mgWziernikTor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mgWziernikTor1.Location = new System.Drawing.Point(873, 391);
            this.mgWziernikTor1.Name = "mgWziernikTor1";
            this.mgWziernikTor1.Size = new System.Drawing.Size(90, 3);
            this.mgWziernikTor1.TabIndex = 21;
            // 
            // mgWziernikTor2
            // 
            this.mgWziernikTor2.BackColor = System.Drawing.Color.Gray;
            this.mgWziernikTor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.mgWziernikTor2.Location = new System.Drawing.Point(873, 422);
            this.mgWziernikTor2.Name = "mgWziernikTor2";
            this.mgWziernikTor2.Size = new System.Drawing.Size(90, 3);
            this.mgWziernikTor2.TabIndex = 22;
            this.mgWziernikTor2.Click += new System.EventHandler(this.mgWziernikTor2_Click);
            // 
            // mgZmianaKoloruCzcionki
            // 
            this.mgZmianaKoloruCzcionki.BackColor = System.Drawing.SystemColors.Control;
            this.mgZmianaKoloruCzcionki.Location = new System.Drawing.Point(1002, 480);
            this.mgZmianaKoloruCzcionki.Name = "mgZmianaKoloruCzcionki";
            this.mgZmianaKoloruCzcionki.Size = new System.Drawing.Size(189, 46);
            this.mgZmianaKoloruCzcionki.TabIndex = 23;
            this.mgZmianaKoloruCzcionki.Text = "Zmiana koloru czcionki opisów";
            this.mgZmianaKoloruCzcionki.UseVisualStyleBackColor = false;
            this.mgZmianaKoloruCzcionki.Click += new System.EventHandler(this.mgZmianaKoloruCzcionki_Click);
            // 
            // mgZmianaCzcionki
            // 
            this.mgZmianaCzcionki.BackColor = System.Drawing.SystemColors.Control;
            this.mgZmianaCzcionki.Location = new System.Drawing.Point(1002, 428);
            this.mgZmianaCzcionki.Name = "mgZmianaCzcionki";
            this.mgZmianaCzcionki.Size = new System.Drawing.Size(189, 46);
            this.mgZmianaCzcionki.TabIndex = 24;
            this.mgZmianaCzcionki.Text = "Zmiana czcionki opisów";
            this.mgZmianaCzcionki.UseVisualStyleBackColor = false;
            this.mgZmianaCzcionki.Click += new System.EventHandler(this.mgZmianaCzcionki_Click);
            // 
            // Projekt1_46792
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1211, 583);
            this.Controls.Add(this.mgZmianaCzcionki);
            this.Controls.Add(this.mgZmianaKoloruCzcionki);
            this.Controls.Add(this.mgWziernikTor2);
            this.Controls.Add(this.mgWziernikTor1);
            this.Controls.Add(this.mgLiniaTor2Lab);
            this.Controls.Add(this.mgLiniaTor1Lab);
            this.Controls.Add(this.mgLegendaLab);
            this.Controls.Add(this.mgZmianaKoloruTła);
            this.Controls.Add(this.mgZmianaKoloruOsi);
            this.Controls.Add(this.mgStylOsi);
            this.Controls.Add(this.mgStylOsiLab);
            this.Controls.Add(this.mgWielkośćObiektu);
            this.Controls.Add(this.mgWielkośćObiektuLab);
            this.Controls.Add(this.mgGrubośćLiniiUkładuWsp);
            this.Controls.Add(this.mgGrubośćLiniiUkładu);
            this.Controls.Add(this.mgWybranyStylTor2);
            this.Controls.Add(this.mgWybranyStylTor1);
            this.Controls.Add(this.mgPrędkośćRuchuLab);
            this.Controls.Add(this.mgPrędkośćRuchu);
            this.Controls.Add(this.mgZmianaKoloruTor2);
            this.Controls.Add(this.mgZmianaKoloruTor1);
            this.Controls.Add(this.mgZmianaStyluTor2Lab);
            this.Controls.Add(this.mgZmianaStyluTor1Lab);
            this.Controls.Add(this.mgGrubośćLiniiLab);
            this.Controls.Add(this.mgGrubośćLiniiTorów);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Projekt1_46792";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizualizacja ruchu po torze linii";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mgRysownica_FormClosing);
            this.Load += new System.EventHandler(this.Projekt1_46792_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Projekt1_46792_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.mgGrubośćLiniiTorów)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgPrędkośćRuchu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgGrubośćLiniiUkładuWsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgWielkośćObiektu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar mgGrubośćLiniiTorów;
        private System.Windows.Forms.Label mgGrubośćLiniiLab;
        private System.Windows.Forms.Label mgZmianaStyluTor1Lab;
        private System.Windows.Forms.Label mgZmianaStyluTor2Lab;
        private System.Windows.Forms.Button mgZmianaKoloruTor1;
        private System.Windows.Forms.Button mgZmianaKoloruTor2;
        private System.Windows.Forms.TrackBar mgPrędkośćRuchu;
        private System.Windows.Forms.Label mgPrędkośćRuchuLab;
        private System.Windows.Forms.ComboBox mgWybranyStylTor1;
        private System.Windows.Forms.ComboBox mgWybranyStylTor2;
        private System.Windows.Forms.Label mgGrubośćLiniiUkładu;
        private System.Windows.Forms.TrackBar mgGrubośćLiniiUkładuWsp;
        private System.Windows.Forms.Label mgWielkośćObiektuLab;
        private System.Windows.Forms.TrackBar mgWielkośćObiektu;
        private System.Windows.Forms.Label mgStylOsiLab;
        private System.Windows.Forms.ComboBox mgStylOsi;
        private System.Windows.Forms.Button mgZmianaKoloruOsi;
        private System.Windows.Forms.Button mgZmianaKoloruTła;
        private System.Windows.Forms.Label mgLegendaLab;
        private System.Windows.Forms.Label mgLiniaTor1Lab;
        private System.Windows.Forms.Label mgLiniaTor2Lab;
        private System.Windows.Forms.Label mgWziernikTor1;
        private System.Windows.Forms.Label mgWziernikTor2;
        private System.Windows.Forms.Button mgZmianaKoloruCzcionki;
        private System.Windows.Forms.Button mgZmianaCzcionki;
    }
}

