namespace Bankomat
{
    partial class Bankomat
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
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zakladkaK = new System.Windows.Forms.TabPage();
            this.lb_copyrightZ1 = new System.Windows.Forms.Label();
            this.bt_napelnienieBankomatu = new System.Windows.Forms.Button();
            this.tb_gornaIloscNominalow = new System.Windows.Forms.TextBox();
            this.tb_dolnaIloscNominalow = new System.Windows.Forms.TextBox();
            this.lb_opis5 = new System.Windows.Forms.Label();
            this.lb_opis4 = new System.Windows.Forms.Label();
            this.gb_ustalenieSposobuNapelnianiaBankomatu = new System.Windows.Forms.GroupBox();
            this.rb_liczbaNominalowRandom = new System.Windows.Forms.RadioButton();
            this.rb_iloscNominalowDefault = new System.Windows.Forms.RadioButton();
            this.lb_opis3 = new System.Windows.Forms.Label();
            this.lb_opis2 = new System.Windows.Forms.Label();
            this.lb_opis1 = new System.Windows.Forms.Label();
            this.cb_wybranaWalutaWyplaty = new System.Windows.Forms.ComboBox();
            this.grZakladek = new System.Windows.Forms.TabControl();
            this.zakladkaZW = new System.Windows.Forms.TabPage();
            this.walutaInfo = new System.Windows.Forms.Label();
            this.lb_copyrightZ2 = new System.Windows.Forms.Label();
            this.bt_akceptacjaKwoty = new System.Windows.Forms.Button();
            this.tb_kwotaDoWyplaty = new System.Windows.Forms.TextBox();
            this.lb_opis8 = new System.Windows.Forms.Label();
            this.lb_opis7 = new System.Windows.Forms.Label();
            this.lb_opis6 = new System.Windows.Forms.Label();
            this.zakladkaWN = new System.Windows.Forms.TabPage();
            this.lb_copyrightZ3 = new System.Windows.Forms.Label();
            this.bt_koniec = new System.Windows.Forms.Button();
            this.bt_resetuj = new System.Windows.Forms.Button();
            this.lb_opis13 = new System.Windows.Forms.Label();
            this.lb_opis12 = new System.Windows.Forms.Label();
            this.dgw_zestawienieWypłaty = new System.Windows.Forms.DataGridView();
            this.Nominał = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_opis11 = new System.Windows.Forms.Label();
            this.lb_opis9 = new System.Windows.Forms.Label();
            this.lb_opis10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.zakladkaK.SuspendLayout();
            this.gb_ustalenieSposobuNapelnianiaBankomatu.SuspendLayout();
            this.grZakladek.SuspendLayout();
            this.zakladkaZW.SuspendLayout();
            this.zakladkaWN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_zestawienieWypłaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // zakladkaK
            // 
            this.zakladkaK.BackColor = System.Drawing.Color.SeaShell;
            this.zakladkaK.Controls.Add(this.lb_copyrightZ1);
            this.zakladkaK.Controls.Add(this.bt_napelnienieBankomatu);
            this.zakladkaK.Controls.Add(this.tb_gornaIloscNominalow);
            this.zakladkaK.Controls.Add(this.tb_dolnaIloscNominalow);
            this.zakladkaK.Controls.Add(this.lb_opis5);
            this.zakladkaK.Controls.Add(this.lb_opis4);
            this.zakladkaK.Controls.Add(this.gb_ustalenieSposobuNapelnianiaBankomatu);
            this.zakladkaK.Controls.Add(this.lb_opis3);
            this.zakladkaK.Controls.Add(this.lb_opis2);
            this.zakladkaK.Controls.Add(this.lb_opis1);
            this.zakladkaK.Controls.Add(this.cb_wybranaWalutaWyplaty);
            this.zakladkaK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zakladkaK.Location = new System.Drawing.Point(4, 22);
            this.zakladkaK.Name = "zakladkaK";
            this.zakladkaK.Padding = new System.Windows.Forms.Padding(3);
            this.zakladkaK.Size = new System.Drawing.Size(617, 409);
            this.zakladkaK.TabIndex = 0;
            this.zakladkaK.Text = "Konfiguracja Bankomatu";
            // 
            // lb_copyrightZ1
            // 
            this.lb_copyrightZ1.AutoSize = true;
            this.lb_copyrightZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_copyrightZ1.Location = new System.Drawing.Point(398, 385);
            this.lb_copyrightZ1.Name = "lb_copyrightZ1";
            this.lb_copyrightZ1.Size = new System.Drawing.Size(164, 13);
            this.lb_copyrightZ1.TabIndex = 10;
            this.lb_copyrightZ1.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // bt_napelnienieBankomatu
            // 
            this.bt_napelnienieBankomatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_napelnienieBankomatu.Location = new System.Drawing.Point(412, 315);
            this.bt_napelnienieBankomatu.Name = "bt_napelnienieBankomatu";
            this.bt_napelnienieBankomatu.Size = new System.Drawing.Size(140, 40);
            this.bt_napelnienieBankomatu.TabIndex = 9;
            this.bt_napelnienieBankomatu.Text = "Napełnij bankomat";
            this.bt_napelnienieBankomatu.UseVisualStyleBackColor = true;
            this.bt_napelnienieBankomatu.Click += new System.EventHandler(this.NapelnienieBankomatu_Click);
            // 
            // tb_gornaIloscNominalow
            // 
            this.tb_gornaIloscNominalow.Enabled = false;
            this.tb_gornaIloscNominalow.Location = new System.Drawing.Point(75, 335);
            this.tb_gornaIloscNominalow.Name = "tb_gornaIloscNominalow";
            this.tb_gornaIloscNominalow.Size = new System.Drawing.Size(100, 20);
            this.tb_gornaIloscNominalow.TabIndex = 8;
            // 
            // tb_dolnaIloscNominalow
            // 
            this.tb_dolnaIloscNominalow.Enabled = false;
            this.tb_dolnaIloscNominalow.Location = new System.Drawing.Point(75, 277);
            this.tb_dolnaIloscNominalow.Name = "tb_dolnaIloscNominalow";
            this.tb_dolnaIloscNominalow.Size = new System.Drawing.Size(100, 20);
            this.tb_dolnaIloscNominalow.TabIndex = 7;
            // 
            // lb_opis5
            // 
            this.lb_opis5.AutoSize = true;
            this.lb_opis5.Location = new System.Drawing.Point(72, 319);
            this.lb_opis5.Name = "lb_opis5";
            this.lb_opis5.Size = new System.Drawing.Size(181, 13);
            this.lb_opis5.TabIndex = 6;
            this.lb_opis5.Text = "Maksymalna ilość każdego nominału";
            // 
            // lb_opis4
            // 
            this.lb_opis4.AutoSize = true;
            this.lb_opis4.Location = new System.Drawing.Point(72, 261);
            this.lb_opis4.Name = "lb_opis4";
            this.lb_opis4.Size = new System.Drawing.Size(169, 13);
            this.lb_opis4.TabIndex = 5;
            this.lb_opis4.Text = "Minimalna ilość każdego nominału";
            // 
            // gb_ustalenieSposobuNapelnianiaBankomatu
            // 
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Controls.Add(this.rb_liczbaNominalowRandom);
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Controls.Add(this.rb_iloscNominalowDefault);
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Location = new System.Drawing.Point(321, 138);
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Name = "gb_ustalenieSposobuNapelnianiaBankomatu";
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Size = new System.Drawing.Size(231, 94);
            this.gb_ustalenieSposobuNapelnianiaBankomatu.TabIndex = 4;
            this.gb_ustalenieSposobuNapelnianiaBankomatu.TabStop = false;
            this.gb_ustalenieSposobuNapelnianiaBankomatu.Text = "Wybierz sposób napełnienia bankomatu";
            // 
            // rb_liczbaNominalowRandom
            // 
            this.rb_liczbaNominalowRandom.AutoSize = true;
            this.rb_liczbaNominalowRandom.Location = new System.Drawing.Point(23, 61);
            this.rb_liczbaNominalowRandom.Name = "rb_liczbaNominalowRandom";
            this.rb_liczbaNominalowRandom.Size = new System.Drawing.Size(141, 17);
            this.rb_liczbaNominalowRandom.TabIndex = 1;
            this.rb_liczbaNominalowRandom.Text = "Losowa ilość nominałów";
            this.rb_liczbaNominalowRandom.UseVisualStyleBackColor = true;
            this.rb_liczbaNominalowRandom.CheckedChanged += new System.EventHandler(this.LiczbaNominalowRandom_CheckedChanged);
            // 
            // rb_iloscNominalowDefault
            // 
            this.rb_iloscNominalowDefault.AutoSize = true;
            this.rb_iloscNominalowDefault.Checked = true;
            this.rb_iloscNominalowDefault.Location = new System.Drawing.Point(23, 29);
            this.rb_iloscNominalowDefault.Name = "rb_iloscNominalowDefault";
            this.rb_iloscNominalowDefault.Size = new System.Drawing.Size(173, 17);
            this.rb_iloscNominalowDefault.TabIndex = 0;
            this.rb_iloscNominalowDefault.TabStop = true;
            this.rb_iloscNominalowDefault.Text = "Domyślne Wartości Nominałów";
            this.rb_iloscNominalowDefault.UseVisualStyleBackColor = true;
            // 
            // lb_opis3
            // 
            this.lb_opis3.AutoSize = true;
            this.lb_opis3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis3.Location = new System.Drawing.Point(55, 138);
            this.lb_opis3.Name = "lb_opis3";
            this.lb_opis3.Size = new System.Drawing.Size(160, 13);
            this.lb_opis3.TabIndex = 3;
            this.lb_opis3.Text = "Wybierz walutę do wypłaty";
            // 
            // lb_opis2
            // 
            this.lb_opis2.AutoSize = true;
            this.lb_opis2.Location = new System.Drawing.Point(319, 66);
            this.lb_opis2.Name = "lb_opis2";
            this.lb_opis2.Size = new System.Drawing.Size(233, 13);
            this.lb_opis2.TabIndex = 2;
            this.lb_opis2.Text = "Zarządzanie parametrami startowymi bankomatu";
            // 
            // lb_opis1
            // 
            this.lb_opis1.AutoSize = true;
            this.lb_opis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis1.Location = new System.Drawing.Point(373, 42);
            this.lb_opis1.Name = "lb_opis1";
            this.lb_opis1.Size = new System.Drawing.Size(125, 24);
            this.lb_opis1.TabIndex = 1;
            this.lb_opis1.Text = "BANKOMAT";
            // 
            // cb_wybranaWalutaWyplaty
            // 
            this.cb_wybranaWalutaWyplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_wybranaWalutaWyplaty.FormattingEnabled = true;
            this.cb_wybranaWalutaWyplaty.Items.AddRange(new object[] {
            "PLN",
            "USD",
            "EUR",
            "GBP"});
            this.cb_wybranaWalutaWyplaty.Location = new System.Drawing.Point(75, 154);
            this.cb_wybranaWalutaWyplaty.Name = "cb_wybranaWalutaWyplaty";
            this.cb_wybranaWalutaWyplaty.Size = new System.Drawing.Size(121, 21);
            this.cb_wybranaWalutaWyplaty.TabIndex = 0;
            this.cb_wybranaWalutaWyplaty.Text = "PLN";
            this.cb_wybranaWalutaWyplaty.SelectedIndexChanged += new System.EventHandler(this.WybranaWalutaWyplaty_SelectedIndexChanged);
            // 
            // grZakladek
            // 
            this.grZakladek.Controls.Add(this.zakladkaK);
            this.grZakladek.Controls.Add(this.zakladkaZW);
            this.grZakladek.Controls.Add(this.zakladkaWN);
            this.grZakladek.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.grZakladek.Location = new System.Drawing.Point(0, 0);
            this.grZakladek.Name = "grZakladek";
            this.grZakladek.SelectedIndex = 0;
            this.grZakladek.Size = new System.Drawing.Size(625, 435);
            this.grZakladek.TabIndex = 0;
            this.grZakladek.TabStop = false;
            this.grZakladek.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.GrZakladek_DrawItem);
            this.grZakladek.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.GrZakladek_Selecting);
            // 
            // zakladkaZW
            // 
            this.zakladkaZW.BackColor = System.Drawing.Color.Beige;
            this.zakladkaZW.Controls.Add(this.walutaInfo);
            this.zakladkaZW.Controls.Add(this.lb_copyrightZ2);
            this.zakladkaZW.Controls.Add(this.bt_akceptacjaKwoty);
            this.zakladkaZW.Controls.Add(this.tb_kwotaDoWyplaty);
            this.zakladkaZW.Controls.Add(this.lb_opis8);
            this.zakladkaZW.Controls.Add(this.lb_opis7);
            this.zakladkaZW.Controls.Add(this.lb_opis6);
            this.zakladkaZW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zakladkaZW.Location = new System.Drawing.Point(4, 22);
            this.zakladkaZW.Name = "zakladkaZW";
            this.zakladkaZW.Padding = new System.Windows.Forms.Padding(3);
            this.zakladkaZW.Size = new System.Drawing.Size(617, 409);
            this.zakladkaZW.TabIndex = 1;
            this.zakladkaZW.Text = "Zlecenie Wypłaty";
            // 
            // walutaInfo
            // 
            this.walutaInfo.AutoSize = true;
            this.walutaInfo.Location = new System.Drawing.Point(481, 174);
            this.walutaInfo.Name = "walutaInfo";
            this.walutaInfo.Size = new System.Drawing.Size(0, 13);
            this.walutaInfo.TabIndex = 12;
            // 
            // lb_copyrightZ2
            // 
            this.lb_copyrightZ2.AutoSize = true;
            this.lb_copyrightZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_copyrightZ2.Location = new System.Drawing.Point(355, 374);
            this.lb_copyrightZ2.Name = "lb_copyrightZ2";
            this.lb_copyrightZ2.Size = new System.Drawing.Size(164, 13);
            this.lb_copyrightZ2.TabIndex = 11;
            this.lb_copyrightZ2.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // bt_akceptacjaKwoty
            // 
            this.bt_akceptacjaKwoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_akceptacjaKwoty.Location = new System.Drawing.Point(377, 290);
            this.bt_akceptacjaKwoty.Name = "bt_akceptacjaKwoty";
            this.bt_akceptacjaKwoty.Size = new System.Drawing.Size(121, 34);
            this.bt_akceptacjaKwoty.TabIndex = 6;
            this.bt_akceptacjaKwoty.Text = "AKCEPTUJĘ";
            this.bt_akceptacjaKwoty.UseVisualStyleBackColor = true;
            this.bt_akceptacjaKwoty.Click += new System.EventHandler(this.AkceptacjaKwoty_Click);
            // 
            // tb_kwotaDoWyplaty
            // 
            this.tb_kwotaDoWyplaty.Location = new System.Drawing.Point(391, 171);
            this.tb_kwotaDoWyplaty.Name = "tb_kwotaDoWyplaty";
            this.tb_kwotaDoWyplaty.Size = new System.Drawing.Size(84, 20);
            this.tb_kwotaDoWyplaty.TabIndex = 5;
            this.tb_kwotaDoWyplaty.Text = "0 000,0";
            this.tb_kwotaDoWyplaty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KwotaDoWyplaty_KeyPress);
            // 
            // lb_opis8
            // 
            this.lb_opis8.AutoSize = true;
            this.lb_opis8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis8.Location = new System.Drawing.Point(101, 172);
            this.lb_opis8.Name = "lb_opis8";
            this.lb_opis8.Size = new System.Drawing.Size(133, 15);
            this.lb_opis8.TabIndex = 4;
            this.lb_opis8.Text = "Podaj kwotę do wypłaty";
            // 
            // lb_opis7
            // 
            this.lb_opis7.AutoSize = true;
            this.lb_opis7.Location = new System.Drawing.Point(355, 66);
            this.lb_opis7.Name = "lb_opis7";
            this.lb_opis7.Size = new System.Drawing.Size(154, 13);
            this.lb_opis7.TabIndex = 3;
            this.lb_opis7.Text = "Definiowanie kwoty do wypłaty";
            // 
            // lb_opis6
            // 
            this.lb_opis6.AutoSize = true;
            this.lb_opis6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis6.Location = new System.Drawing.Point(373, 42);
            this.lb_opis6.Name = "lb_opis6";
            this.lb_opis6.Size = new System.Drawing.Size(125, 24);
            this.lb_opis6.TabIndex = 2;
            this.lb_opis6.Text = "BANKOMAT";
            // 
            // zakladkaWN
            // 
            this.zakladkaWN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.zakladkaWN.Controls.Add(this.lb_copyrightZ3);
            this.zakladkaWN.Controls.Add(this.bt_koniec);
            this.zakladkaWN.Controls.Add(this.bt_resetuj);
            this.zakladkaWN.Controls.Add(this.lb_opis13);
            this.zakladkaWN.Controls.Add(this.lb_opis12);
            this.zakladkaWN.Controls.Add(this.dgw_zestawienieWypłaty);
            this.zakladkaWN.Controls.Add(this.lb_opis11);
            this.zakladkaWN.Controls.Add(this.lb_opis9);
            this.zakladkaWN.Controls.Add(this.lb_opis10);
            this.zakladkaWN.Location = new System.Drawing.Point(4, 22);
            this.zakladkaWN.Name = "zakladkaWN";
            this.zakladkaWN.Padding = new System.Windows.Forms.Padding(3);
            this.zakladkaWN.Size = new System.Drawing.Size(617, 409);
            this.zakladkaWN.TabIndex = 2;
            this.zakladkaWN.Text = "Wypłata Nominałów";
            // 
            // lb_copyrightZ3
            // 
            this.lb_copyrightZ3.AutoSize = true;
            this.lb_copyrightZ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_copyrightZ3.Location = new System.Drawing.Point(435, 377);
            this.lb_copyrightZ3.Name = "lb_copyrightZ3";
            this.lb_copyrightZ3.Size = new System.Drawing.Size(164, 13);
            this.lb_copyrightZ3.TabIndex = 11;
            this.lb_copyrightZ3.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // bt_koniec
            // 
            this.bt_koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_koniec.Location = new System.Drawing.Point(477, 309);
            this.bt_koniec.Name = "bt_koniec";
            this.bt_koniec.Size = new System.Drawing.Size(75, 23);
            this.bt_koniec.TabIndex = 10;
            this.bt_koniec.Text = "KONIEC";
            this.bt_koniec.UseVisualStyleBackColor = true;
            this.bt_koniec.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // bt_resetuj
            // 
            this.bt_resetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_resetuj.Location = new System.Drawing.Point(477, 280);
            this.bt_resetuj.Name = "bt_resetuj";
            this.bt_resetuj.Size = new System.Drawing.Size(75, 23);
            this.bt_resetuj.TabIndex = 9;
            this.bt_resetuj.Text = "RESETUJ";
            this.bt_resetuj.UseVisualStyleBackColor = true;
            this.bt_resetuj.Click += new System.EventHandler(this.Resetuj_Click);
            // 
            // lb_opis13
            // 
            this.lb_opis13.AutoSize = true;
            this.lb_opis13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis13.Location = new System.Drawing.Point(107, 377);
            this.lb_opis13.Name = "lb_opis13";
            this.lb_opis13.Size = new System.Drawing.Size(245, 13);
            this.lb_opis13.TabIndex = 8;
            this.lb_opis13.Text = "b) koniec pracy bankomatu kliknij: KONIEC";
            // 
            // lb_opis12
            // 
            this.lb_opis12.AutoSize = true;
            this.lb_opis12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis12.Location = new System.Drawing.Point(107, 360);
            this.lb_opis12.Name = "lb_opis12";
            this.lb_opis12.Size = new System.Drawing.Size(251, 13);
            this.lb_opis12.TabIndex = 7;
            this.lb_opis12.Text = "a) nowe polecenie wypłaty kliknij: RESETUJ";
            // 
            // dgw_zestawienieWypłaty
            // 
            this.dgw_zestawienieWypłaty.AllowUserToAddRows = false;
            this.dgw_zestawienieWypłaty.AllowUserToDeleteRows = false;
            this.dgw_zestawienieWypłaty.AllowUserToResizeColumns = false;
            this.dgw_zestawienieWypłaty.AllowUserToResizeRows = false;
            this.dgw_zestawienieWypłaty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_zestawienieWypłaty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgw_zestawienieWypłaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_zestawienieWypłaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominał,
            this.Ilość,
            this.Waluta});
            this.dgw_zestawienieWypłaty.Location = new System.Drawing.Point(20, 143);
            this.dgw_zestawienieWypłaty.Name = "dgw_zestawienieWypłaty";
            this.dgw_zestawienieWypłaty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgw_zestawienieWypłaty.Size = new System.Drawing.Size(413, 189);
            this.dgw_zestawienieWypłaty.TabIndex = 6;
            this.dgw_zestawienieWypłaty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Nominał
            // 
            this.Nominał.HeaderText = "Nominał";
            this.Nominał.Name = "Nominał";
            // 
            // Ilość
            // 
            this.Ilość.HeaderText = "Ilość";
            this.Ilość.Name = "Ilość";
            // 
            // Waluta
            // 
            this.Waluta.HeaderText = "Waluta";
            this.Waluta.Name = "Waluta";
            // 
            // lb_opis11
            // 
            this.lb_opis11.AutoSize = true;
            this.lb_opis11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis11.Location = new System.Drawing.Point(128, 123);
            this.lb_opis11.Name = "lb_opis11";
            this.lb_opis11.Size = new System.Drawing.Size(206, 17);
            this.lb_opis11.TabIndex = 5;
            this.lb_opis11.Text = "Tabela wypłaconych nominałów";
            // 
            // lb_opis9
            // 
            this.lb_opis9.AutoSize = true;
            this.lb_opis9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_opis9.Location = new System.Drawing.Point(373, 42);
            this.lb_opis9.Name = "lb_opis9";
            this.lb_opis9.Size = new System.Drawing.Size(125, 24);
            this.lb_opis9.TabIndex = 4;
            this.lb_opis9.Text = "BANKOMAT";
            // 
            // lb_opis10
            // 
            this.lb_opis10.AutoSize = true;
            this.lb_opis10.Location = new System.Drawing.Point(319, 66);
            this.lb_opis10.Name = "lb_opis10";
            this.lb_opis10.Size = new System.Drawing.Size(238, 13);
            this.lb_opis10.TabIndex = 3;
            this.lb_opis10.Text = "Podsumowanie transakcji wypłaty zadanej kwoty";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 434);
            this.Controls.Add(this.grZakladek);
            this.Name = "Bankomat";
            this.Text = "Projekt BANKOMAT";
            this.zakladkaK.ResumeLayout(false);
            this.zakladkaK.PerformLayout();
            this.gb_ustalenieSposobuNapelnianiaBankomatu.ResumeLayout(false);
            this.gb_ustalenieSposobuNapelnianiaBankomatu.PerformLayout();
            this.grZakladek.ResumeLayout(false);
            this.zakladkaZW.ResumeLayout(false);
            this.zakladkaZW.PerformLayout();
            this.zakladkaWN.ResumeLayout(false);
            this.zakladkaWN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_zestawienieWypłaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage zakladkaK;
        private System.Windows.Forms.Button bt_napelnienieBankomatu;
        private System.Windows.Forms.TextBox tb_gornaIloscNominalow;
        private System.Windows.Forms.TextBox tb_dolnaIloscNominalow;
        private System.Windows.Forms.Label lb_opis5;
        private System.Windows.Forms.Label lb_opis4;
        private System.Windows.Forms.GroupBox gb_ustalenieSposobuNapelnianiaBankomatu;
        private System.Windows.Forms.RadioButton rb_liczbaNominalowRandom;
        private System.Windows.Forms.RadioButton rb_iloscNominalowDefault;
        private System.Windows.Forms.Label lb_opis3;
        private System.Windows.Forms.Label lb_opis1;
        private System.Windows.Forms.ComboBox cb_wybranaWalutaWyplaty;
        private System.Windows.Forms.TabControl grZakladek;
        private System.Windows.Forms.TabPage zakladkaZW;
        private System.Windows.Forms.TabPage zakladkaWN;
        private System.Windows.Forms.Label lb_opis2;
        private System.Windows.Forms.Label lb_opis7;
        private System.Windows.Forms.Label lb_opis6;
        private System.Windows.Forms.Label lb_opis9;
        private System.Windows.Forms.Label lb_opis10;
        private System.Windows.Forms.Button bt_akceptacjaKwoty;
        private System.Windows.Forms.TextBox tb_kwotaDoWyplaty;
        private System.Windows.Forms.Label lb_opis8;
        private System.Windows.Forms.Label lb_opis11;
        private System.Windows.Forms.Button bt_koniec;
        private System.Windows.Forms.Button bt_resetuj;
        private System.Windows.Forms.Label lb_opis13;
        private System.Windows.Forms.Label lb_opis12;
        private System.Windows.Forms.DataGridView dgw_zestawienieWypłaty;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominał;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilość;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waluta;
        private System.Windows.Forms.Label lb_copyrightZ1;
        private System.Windows.Forms.Label lb_copyrightZ2;
        private System.Windows.Forms.Label lb_copyrightZ3;
        private System.Windows.Forms.Label walutaInfo;

    }
}

