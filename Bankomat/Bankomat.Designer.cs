namespace Bankomat
{
    partial class PB_Bankomat
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
            this.PB_ZakladkaK = new System.Windows.Forms.TabPage();
            this.PB_CopyrightZ1 = new System.Windows.Forms.Label();
            this.PB_NapelnienieBankomatu = new System.Windows.Forms.Button();
            this.PB_GornaIloscNominalow = new System.Windows.Forms.TextBox();
            this.PB_DolnaIloscNominalow = new System.Windows.Forms.TextBox();
            this.PB_Opis5 = new System.Windows.Forms.Label();
            this.PB_Opis4 = new System.Windows.Forms.Label();
            this.PB_UstalenieSposobuNapelnianiaBankomatu = new System.Windows.Forms.GroupBox();
            this.PB_LiczbaNominalowRandom = new System.Windows.Forms.RadioButton();
            this.PB_IloscNominalowDefault = new System.Windows.Forms.RadioButton();
            this.PB_Opis3 = new System.Windows.Forms.Label();
            this.PB_Opis2 = new System.Windows.Forms.Label();
            this.PB_Opis1 = new System.Windows.Forms.Label();
            this.PB_WybranaWalutaWyplaty = new System.Windows.Forms.ComboBox();
            this.PB_GrZakladek = new System.Windows.Forms.TabControl();
            this.PB_ZakladkaZW = new System.Windows.Forms.TabPage();
            this.PB_WalutaInfo = new System.Windows.Forms.Label();
            this.PB_CopyrightZ2 = new System.Windows.Forms.Label();
            this.PB_AkceptacjaKwoty = new System.Windows.Forms.Button();
            this.PB_KwotaDoWyplaty = new System.Windows.Forms.TextBox();
            this.PB_Opis8 = new System.Windows.Forms.Label();
            this.PB_Opis7 = new System.Windows.Forms.Label();
            this.PB_Opis6 = new System.Windows.Forms.Label();
            this.PB_ZakladkaWN = new System.Windows.Forms.TabPage();
            this.PB_CopyrightZ3 = new System.Windows.Forms.Label();
            this.PB_Koniec = new System.Windows.Forms.Button();
            this.PB_Resetuj = new System.Windows.Forms.Button();
            this.PB_Opis13 = new System.Windows.Forms.Label();
            this.PB_Opis12 = new System.Windows.Forms.Label();
            this.PB_ZestawienieWypłaty = new System.Windows.Forms.DataGridView();
            this.Nominał = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_Opis11 = new System.Windows.Forms.Label();
            this.PB_Opis9 = new System.Windows.Forms.Label();
            this.PB_Opis10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PB_ZakladkaK.SuspendLayout();
            this.PB_UstalenieSposobuNapelnianiaBankomatu.SuspendLayout();
            this.PB_GrZakladek.SuspendLayout();
            this.PB_ZakladkaZW.SuspendLayout();
            this.PB_ZakladkaWN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ZestawienieWypłaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_ZakladkaK
            // 
            this.PB_ZakladkaK.BackColor = System.Drawing.Color.SeaShell;
            this.PB_ZakladkaK.Controls.Add(this.PB_CopyrightZ1);
            this.PB_ZakladkaK.Controls.Add(this.PB_NapelnienieBankomatu);
            this.PB_ZakladkaK.Controls.Add(this.PB_GornaIloscNominalow);
            this.PB_ZakladkaK.Controls.Add(this.PB_DolnaIloscNominalow);
            this.PB_ZakladkaK.Controls.Add(this.PB_Opis5);
            this.PB_ZakladkaK.Controls.Add(this.PB_Opis4);
            this.PB_ZakladkaK.Controls.Add(this.PB_UstalenieSposobuNapelnianiaBankomatu);
            this.PB_ZakladkaK.Controls.Add(this.PB_Opis3);
            this.PB_ZakladkaK.Controls.Add(this.PB_Opis2);
            this.PB_ZakladkaK.Controls.Add(this.PB_Opis1);
            this.PB_ZakladkaK.Controls.Add(this.PB_WybranaWalutaWyplaty);
            this.PB_ZakladkaK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PB_ZakladkaK.Location = new System.Drawing.Point(4, 22);
            this.PB_ZakladkaK.Name = "PB_ZakladkaK";
            this.PB_ZakladkaK.Padding = new System.Windows.Forms.Padding(3);
            this.PB_ZakladkaK.Size = new System.Drawing.Size(617, 409);
            this.PB_ZakladkaK.TabIndex = 0;
            this.PB_ZakladkaK.Text = "Konfiguracja Bankomatu";
            // 
            // PB_CopyrightZ1
            // 
            this.PB_CopyrightZ1.AutoSize = true;
            this.PB_CopyrightZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_CopyrightZ1.Location = new System.Drawing.Point(398, 385);
            this.PB_CopyrightZ1.Name = "PB_CopyrightZ1";
            this.PB_CopyrightZ1.Size = new System.Drawing.Size(164, 13);
            this.PB_CopyrightZ1.TabIndex = 10;
            this.PB_CopyrightZ1.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // PB_NapelnienieBankomatu
            // 
            this.PB_NapelnienieBankomatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_NapelnienieBankomatu.Location = new System.Drawing.Point(412, 315);
            this.PB_NapelnienieBankomatu.Name = "PB_NapelnienieBankomatu";
            this.PB_NapelnienieBankomatu.Size = new System.Drawing.Size(140, 40);
            this.PB_NapelnienieBankomatu.TabIndex = 9;
            this.PB_NapelnienieBankomatu.Text = "Napełnij bankomat";
            this.PB_NapelnienieBankomatu.UseVisualStyleBackColor = true;
            this.PB_NapelnienieBankomatu.Click += new System.EventHandler(this.PB_NapelnienieBankomatu_Click);
            // 
            // PB_GornaIloscNominalow
            // 
            this.PB_GornaIloscNominalow.Enabled = false;
            this.PB_GornaIloscNominalow.Location = new System.Drawing.Point(75, 335);
            this.PB_GornaIloscNominalow.Name = "PB_GornaIloscNominalow";
            this.PB_GornaIloscNominalow.Size = new System.Drawing.Size(100, 20);
            this.PB_GornaIloscNominalow.TabIndex = 8;
            // 
            // PB_DolnaIloscNominalow
            // 
            this.PB_DolnaIloscNominalow.Enabled = false;
            this.PB_DolnaIloscNominalow.Location = new System.Drawing.Point(75, 277);
            this.PB_DolnaIloscNominalow.Name = "PB_DolnaIloscNominalow";
            this.PB_DolnaIloscNominalow.Size = new System.Drawing.Size(100, 20);
            this.PB_DolnaIloscNominalow.TabIndex = 7;
            // 
            // PB_Opis5
            // 
            this.PB_Opis5.AutoSize = true;
            this.PB_Opis5.Location = new System.Drawing.Point(72, 319);
            this.PB_Opis5.Name = "PB_Opis5";
            this.PB_Opis5.Size = new System.Drawing.Size(181, 13);
            this.PB_Opis5.TabIndex = 6;
            this.PB_Opis5.Text = "Maksymalna ilość każdego nominału";
            // 
            // PB_Opis4
            // 
            this.PB_Opis4.AutoSize = true;
            this.PB_Opis4.Location = new System.Drawing.Point(72, 261);
            this.PB_Opis4.Name = "PB_Opis4";
            this.PB_Opis4.Size = new System.Drawing.Size(169, 13);
            this.PB_Opis4.TabIndex = 5;
            this.PB_Opis4.Text = "Minimalna ilość każdego nominału";
            // 
            // PB_UstalenieSposobuNapelnianiaBankomatu
            // 
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Controls.Add(this.PB_LiczbaNominalowRandom);
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Controls.Add(this.PB_IloscNominalowDefault);
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Location = new System.Drawing.Point(321, 138);
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Name = "PB_UstalenieSposobuNapelnianiaBankomatu";
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Size = new System.Drawing.Size(231, 94);
            this.PB_UstalenieSposobuNapelnianiaBankomatu.TabIndex = 4;
            this.PB_UstalenieSposobuNapelnianiaBankomatu.TabStop = false;
            this.PB_UstalenieSposobuNapelnianiaBankomatu.Text = "Wybierz sposób napełnienia bankomatu";
            // 
            // PB_LiczbaNominalowRandom
            // 
            this.PB_LiczbaNominalowRandom.AutoSize = true;
            this.PB_LiczbaNominalowRandom.Location = new System.Drawing.Point(23, 61);
            this.PB_LiczbaNominalowRandom.Name = "PB_LiczbaNominalowRandom";
            this.PB_LiczbaNominalowRandom.Size = new System.Drawing.Size(141, 17);
            this.PB_LiczbaNominalowRandom.TabIndex = 1;
            this.PB_LiczbaNominalowRandom.Text = "Losowa ilość nominałów";
            this.PB_LiczbaNominalowRandom.UseVisualStyleBackColor = true;
            this.PB_LiczbaNominalowRandom.CheckedChanged += new System.EventHandler(this.PB_LiczbaNominalowRandom_CheckedChanged);
            // 
            // PB_IloscNominalowDefault
            // 
            this.PB_IloscNominalowDefault.AutoSize = true;
            this.PB_IloscNominalowDefault.Checked = true;
            this.PB_IloscNominalowDefault.Location = new System.Drawing.Point(23, 29);
            this.PB_IloscNominalowDefault.Name = "PB_IloscNominalowDefault";
            this.PB_IloscNominalowDefault.Size = new System.Drawing.Size(173, 17);
            this.PB_IloscNominalowDefault.TabIndex = 0;
            this.PB_IloscNominalowDefault.TabStop = true;
            this.PB_IloscNominalowDefault.Text = "Domyślne Wartości Nominałów";
            this.PB_IloscNominalowDefault.UseVisualStyleBackColor = true;
            // 
            // PB_Opis3
            // 
            this.PB_Opis3.AutoSize = true;
            this.PB_Opis3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis3.Location = new System.Drawing.Point(55, 138);
            this.PB_Opis3.Name = "PB_Opis3";
            this.PB_Opis3.Size = new System.Drawing.Size(160, 13);
            this.PB_Opis3.TabIndex = 3;
            this.PB_Opis3.Text = "Wybierz walutę do wypłaty";
            // 
            // PB_Opis2
            // 
            this.PB_Opis2.AutoSize = true;
            this.PB_Opis2.Location = new System.Drawing.Point(319, 66);
            this.PB_Opis2.Name = "PB_Opis2";
            this.PB_Opis2.Size = new System.Drawing.Size(233, 13);
            this.PB_Opis2.TabIndex = 2;
            this.PB_Opis2.Text = "Zarządzanie parametrami startowymi bankomatu";
            // 
            // PB_Opis1
            // 
            this.PB_Opis1.AutoSize = true;
            this.PB_Opis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis1.Location = new System.Drawing.Point(373, 42);
            this.PB_Opis1.Name = "PB_Opis1";
            this.PB_Opis1.Size = new System.Drawing.Size(125, 24);
            this.PB_Opis1.TabIndex = 1;
            this.PB_Opis1.Text = "BANKOMAT";
            // 
            // PB_WybranaWalutaWyplaty
            // 
            this.PB_WybranaWalutaWyplaty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_WybranaWalutaWyplaty.FormattingEnabled = true;
            this.PB_WybranaWalutaWyplaty.Items.AddRange(new object[] {
            "PLN",
            "USD",
            "EUR",
            "GBP"});
            this.PB_WybranaWalutaWyplaty.Location = new System.Drawing.Point(75, 154);
            this.PB_WybranaWalutaWyplaty.Name = "PB_WybranaWalutaWyplaty";
            this.PB_WybranaWalutaWyplaty.Size = new System.Drawing.Size(121, 21);
            this.PB_WybranaWalutaWyplaty.TabIndex = 0;
            this.PB_WybranaWalutaWyplaty.Text = "PLN";
            this.PB_WybranaWalutaWyplaty.SelectedIndexChanged += new System.EventHandler(this.PB_WybranaWalutaWyplaty_SelectedIndexChanged);
            // 
            // PB_GrZakladek
            // 
            this.PB_GrZakladek.Controls.Add(this.PB_ZakladkaK);
            this.PB_GrZakladek.Controls.Add(this.PB_ZakladkaZW);
            this.PB_GrZakladek.Controls.Add(this.PB_ZakladkaWN);
            this.PB_GrZakladek.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.PB_GrZakladek.Location = new System.Drawing.Point(0, 0);
            this.PB_GrZakladek.Name = "PB_GrZakladek";
            this.PB_GrZakladek.SelectedIndex = 0;
            this.PB_GrZakladek.Size = new System.Drawing.Size(625, 435);
            this.PB_GrZakladek.TabIndex = 0;
            this.PB_GrZakladek.TabStop = false;
            this.PB_GrZakladek.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.PB_GrZakladek_DrawItem);
            this.PB_GrZakladek.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.PB_GrZakladek_Selecting);
            // 
            // PB_ZakladkaZW
            // 
            this.PB_ZakladkaZW.BackColor = System.Drawing.Color.Beige;
            this.PB_ZakladkaZW.Controls.Add(this.PB_WalutaInfo);
            this.PB_ZakladkaZW.Controls.Add(this.PB_CopyrightZ2);
            this.PB_ZakladkaZW.Controls.Add(this.PB_AkceptacjaKwoty);
            this.PB_ZakladkaZW.Controls.Add(this.PB_KwotaDoWyplaty);
            this.PB_ZakladkaZW.Controls.Add(this.PB_Opis8);
            this.PB_ZakladkaZW.Controls.Add(this.PB_Opis7);
            this.PB_ZakladkaZW.Controls.Add(this.PB_Opis6);
            this.PB_ZakladkaZW.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PB_ZakladkaZW.Location = new System.Drawing.Point(4, 22);
            this.PB_ZakladkaZW.Name = "PB_ZakladkaZW";
            this.PB_ZakladkaZW.Padding = new System.Windows.Forms.Padding(3);
            this.PB_ZakladkaZW.Size = new System.Drawing.Size(617, 409);
            this.PB_ZakladkaZW.TabIndex = 1;
            this.PB_ZakladkaZW.Text = "Zlecenie Wypłaty";
            // 
            // PB_WalutaInfo
            // 
            this.PB_WalutaInfo.AutoSize = true;
            this.PB_WalutaInfo.Location = new System.Drawing.Point(481, 174);
            this.PB_WalutaInfo.Name = "PB_WalutaInfo";
            this.PB_WalutaInfo.Size = new System.Drawing.Size(0, 13);
            this.PB_WalutaInfo.TabIndex = 12;
            // 
            // PB_CopyrightZ2
            // 
            this.PB_CopyrightZ2.AutoSize = true;
            this.PB_CopyrightZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_CopyrightZ2.Location = new System.Drawing.Point(355, 374);
            this.PB_CopyrightZ2.Name = "PB_CopyrightZ2";
            this.PB_CopyrightZ2.Size = new System.Drawing.Size(164, 13);
            this.PB_CopyrightZ2.TabIndex = 11;
            this.PB_CopyrightZ2.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // PB_AkceptacjaKwoty
            // 
            this.PB_AkceptacjaKwoty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_AkceptacjaKwoty.Location = new System.Drawing.Point(377, 290);
            this.PB_AkceptacjaKwoty.Name = "PB_AkceptacjaKwoty";
            this.PB_AkceptacjaKwoty.Size = new System.Drawing.Size(121, 34);
            this.PB_AkceptacjaKwoty.TabIndex = 6;
            this.PB_AkceptacjaKwoty.Text = "AKCEPTUJĘ";
            this.PB_AkceptacjaKwoty.UseVisualStyleBackColor = true;
            this.PB_AkceptacjaKwoty.Click += new System.EventHandler(this.PB_AkceptacjaKwoty_Click);
            // 
            // PB_KwotaDoWyplaty
            // 
            this.PB_KwotaDoWyplaty.Location = new System.Drawing.Point(391, 171);
            this.PB_KwotaDoWyplaty.Name = "PB_KwotaDoWyplaty";
            this.PB_KwotaDoWyplaty.Size = new System.Drawing.Size(84, 20);
            this.PB_KwotaDoWyplaty.TabIndex = 5;
            this.PB_KwotaDoWyplaty.Text = "0 000,0";
            this.PB_KwotaDoWyplaty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PB_KwotaDoWyplaty_KeyPress);
            // 
            // PB_Opis8
            // 
            this.PB_Opis8.AutoSize = true;
            this.PB_Opis8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis8.Location = new System.Drawing.Point(101, 172);
            this.PB_Opis8.Name = "PB_Opis8";
            this.PB_Opis8.Size = new System.Drawing.Size(133, 15);
            this.PB_Opis8.TabIndex = 4;
            this.PB_Opis8.Text = "Podaj kwotę do wypłaty";
            // 
            // PB_Opis7
            // 
            this.PB_Opis7.AutoSize = true;
            this.PB_Opis7.Location = new System.Drawing.Point(355, 66);
            this.PB_Opis7.Name = "PB_Opis7";
            this.PB_Opis7.Size = new System.Drawing.Size(154, 13);
            this.PB_Opis7.TabIndex = 3;
            this.PB_Opis7.Text = "Definiowanie kwoty do wypłaty";
            // 
            // PB_Opis6
            // 
            this.PB_Opis6.AutoSize = true;
            this.PB_Opis6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis6.Location = new System.Drawing.Point(373, 42);
            this.PB_Opis6.Name = "PB_Opis6";
            this.PB_Opis6.Size = new System.Drawing.Size(125, 24);
            this.PB_Opis6.TabIndex = 2;
            this.PB_Opis6.Text = "BANKOMAT";
            // 
            // PB_ZakladkaWN
            // 
            this.PB_ZakladkaWN.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.PB_ZakladkaWN.Controls.Add(this.PB_CopyrightZ3);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Koniec);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Resetuj);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Opis13);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Opis12);
            this.PB_ZakladkaWN.Controls.Add(this.PB_ZestawienieWypłaty);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Opis11);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Opis9);
            this.PB_ZakladkaWN.Controls.Add(this.PB_Opis10);
            this.PB_ZakladkaWN.Location = new System.Drawing.Point(4, 22);
            this.PB_ZakladkaWN.Name = "PB_ZakladkaWN";
            this.PB_ZakladkaWN.Padding = new System.Windows.Forms.Padding(3);
            this.PB_ZakladkaWN.Size = new System.Drawing.Size(617, 409);
            this.PB_ZakladkaWN.TabIndex = 2;
            this.PB_ZakladkaWN.Text = "Wypłata Nominałów";
            // 
            // PB_CopyrightZ3
            // 
            this.PB_CopyrightZ3.AutoSize = true;
            this.PB_CopyrightZ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_CopyrightZ3.Location = new System.Drawing.Point(435, 377);
            this.PB_CopyrightZ3.Name = "PB_CopyrightZ3";
            this.PB_CopyrightZ3.Size = new System.Drawing.Size(164, 13);
            this.PB_CopyrightZ3.TabIndex = 11;
            this.PB_CopyrightZ3.Text = "Autor: Piotr Bilski nr indexu 43335";
            // 
            // PB_Koniec
            // 
            this.PB_Koniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Koniec.Location = new System.Drawing.Point(477, 309);
            this.PB_Koniec.Name = "PB_Koniec";
            this.PB_Koniec.Size = new System.Drawing.Size(75, 23);
            this.PB_Koniec.TabIndex = 10;
            this.PB_Koniec.Text = "KONIEC";
            this.PB_Koniec.UseVisualStyleBackColor = true;
            this.PB_Koniec.Click += new System.EventHandler(this.PB_Koniec_Click);
            // 
            // PB_Resetuj
            // 
            this.PB_Resetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Resetuj.Location = new System.Drawing.Point(477, 280);
            this.PB_Resetuj.Name = "PB_Resetuj";
            this.PB_Resetuj.Size = new System.Drawing.Size(75, 23);
            this.PB_Resetuj.TabIndex = 9;
            this.PB_Resetuj.Text = "RESETUJ";
            this.PB_Resetuj.UseVisualStyleBackColor = true;
            this.PB_Resetuj.Click += new System.EventHandler(this.PB_Resetuj_Click);
            // 
            // PB_Opis13
            // 
            this.PB_Opis13.AutoSize = true;
            this.PB_Opis13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis13.Location = new System.Drawing.Point(107, 377);
            this.PB_Opis13.Name = "PB_Opis13";
            this.PB_Opis13.Size = new System.Drawing.Size(245, 13);
            this.PB_Opis13.TabIndex = 8;
            this.PB_Opis13.Text = "b) koniec pracy bankomatu kliknij: KONIEC";
            // 
            // PB_Opis12
            // 
            this.PB_Opis12.AutoSize = true;
            this.PB_Opis12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis12.Location = new System.Drawing.Point(107, 360);
            this.PB_Opis12.Name = "PB_Opis12";
            this.PB_Opis12.Size = new System.Drawing.Size(251, 13);
            this.PB_Opis12.TabIndex = 7;
            this.PB_Opis12.Text = "a) nowe polecenie wypłaty kliknij: RESETUJ";
            // 
            // PB_ZestawienieWypłaty
            // 
            this.PB_ZestawienieWypłaty.AllowUserToAddRows = false;
            this.PB_ZestawienieWypłaty.AllowUserToDeleteRows = false;
            this.PB_ZestawienieWypłaty.AllowUserToResizeColumns = false;
            this.PB_ZestawienieWypłaty.AllowUserToResizeRows = false;
            this.PB_ZestawienieWypłaty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PB_ZestawienieWypłaty.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PB_ZestawienieWypłaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PB_ZestawienieWypłaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominał,
            this.Ilość,
            this.Waluta});
            this.PB_ZestawienieWypłaty.Location = new System.Drawing.Point(20, 143);
            this.PB_ZestawienieWypłaty.Name = "PB_ZestawienieWypłaty";
            this.PB_ZestawienieWypłaty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PB_ZestawienieWypłaty.Size = new System.Drawing.Size(413, 189);
            this.PB_ZestawienieWypłaty.TabIndex = 6;
            this.PB_ZestawienieWypłaty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // PB_Opis11
            // 
            this.PB_Opis11.AutoSize = true;
            this.PB_Opis11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis11.Location = new System.Drawing.Point(128, 123);
            this.PB_Opis11.Name = "PB_Opis11";
            this.PB_Opis11.Size = new System.Drawing.Size(206, 17);
            this.PB_Opis11.TabIndex = 5;
            this.PB_Opis11.Text = "Tabela wypłaconych nominałów";
            // 
            // PB_Opis9
            // 
            this.PB_Opis9.AutoSize = true;
            this.PB_Opis9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PB_Opis9.Location = new System.Drawing.Point(373, 42);
            this.PB_Opis9.Name = "PB_Opis9";
            this.PB_Opis9.Size = new System.Drawing.Size(125, 24);
            this.PB_Opis9.TabIndex = 4;
            this.PB_Opis9.Text = "BANKOMAT";
            // 
            // PB_Opis10
            // 
            this.PB_Opis10.AutoSize = true;
            this.PB_Opis10.Location = new System.Drawing.Point(319, 66);
            this.PB_Opis10.Name = "PB_Opis10";
            this.PB_Opis10.Size = new System.Drawing.Size(238, 13);
            this.PB_Opis10.TabIndex = 3;
            this.PB_Opis10.Text = "Podsumowanie transakcji wypłaty zadanej kwoty";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PB_Bankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 434);
            this.Controls.Add(this.PB_GrZakladek);
            this.Name = "PB_Bankomat";
            this.Text = "Projekt BANKOMAT";
            this.PB_ZakladkaK.ResumeLayout(false);
            this.PB_ZakladkaK.PerformLayout();
            this.PB_UstalenieSposobuNapelnianiaBankomatu.ResumeLayout(false);
            this.PB_UstalenieSposobuNapelnianiaBankomatu.PerformLayout();
            this.PB_GrZakladek.ResumeLayout(false);
            this.PB_ZakladkaZW.ResumeLayout(false);
            this.PB_ZakladkaZW.PerformLayout();
            this.PB_ZakladkaWN.ResumeLayout(false);
            this.PB_ZakladkaWN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ZestawienieWypłaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage PB_ZakladkaK;
        private System.Windows.Forms.Button PB_NapelnienieBankomatu;
        private System.Windows.Forms.TextBox PB_GornaIloscNominalow;
        private System.Windows.Forms.TextBox PB_DolnaIloscNominalow;
        private System.Windows.Forms.Label PB_Opis5;
        private System.Windows.Forms.Label PB_Opis4;
        private System.Windows.Forms.GroupBox PB_UstalenieSposobuNapelnianiaBankomatu;
        private System.Windows.Forms.RadioButton PB_LiczbaNominalowRandom;
        private System.Windows.Forms.RadioButton PB_IloscNominalowDefault;
        private System.Windows.Forms.Label PB_Opis3;
        private System.Windows.Forms.Label PB_Opis1;
        private System.Windows.Forms.ComboBox PB_WybranaWalutaWyplaty;
        private System.Windows.Forms.TabControl PB_GrZakladek;
        private System.Windows.Forms.TabPage PB_ZakladkaZW;
        private System.Windows.Forms.TabPage PB_ZakladkaWN;
        private System.Windows.Forms.Label PB_Opis2;
        private System.Windows.Forms.Label PB_Opis7;
        private System.Windows.Forms.Label PB_Opis6;
        private System.Windows.Forms.Label PB_Opis9;
        private System.Windows.Forms.Label PB_Opis10;
        private System.Windows.Forms.Button PB_AkceptacjaKwoty;
        private System.Windows.Forms.TextBox PB_KwotaDoWyplaty;
        private System.Windows.Forms.Label PB_Opis8;
        private System.Windows.Forms.Label PB_Opis11;
        private System.Windows.Forms.Button PB_Koniec;
        private System.Windows.Forms.Button PB_Resetuj;
        private System.Windows.Forms.Label PB_Opis13;
        private System.Windows.Forms.Label PB_Opis12;
        private System.Windows.Forms.DataGridView PB_ZestawienieWypłaty;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominał;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilość;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waluta;
        private System.Windows.Forms.Label PB_CopyrightZ1;
        private System.Windows.Forms.Label PB_CopyrightZ2;
        private System.Windows.Forms.Label PB_CopyrightZ3;
        private System.Windows.Forms.Label PB_WalutaInfo;

    }
}

