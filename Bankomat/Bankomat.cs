using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class PB_Bankomat : Form
    {
        public PB_Bankomat()
        {
            InitializeComponent();

            // wylaczenie wybranych zakłądek przy starcie programu 
            PB_ZakladkaZW.Enabled = false;
            PB_ZakladkaWN.Enabled = false;
        }

        // deklaracja zmiennych globalnych
        int PB_Waluta = 1;
        float PB_WyplacMiKwote;
        float[ , ] PB_KasetkaZKasą;
        int[ ] PB_WypłaconoKlientowi;
        float PB_PozostałoDoWypłaty;
        int PB_IlośćNominałówDoWypłaty;
        float PB_KapitałBankomatu;
        string [ ] PB_SymbolWaluty;


        // wywołanie metody uniemożliwiającej wybranie nieaktywnych zakładek
        private void PB_GrZakladek_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        // wywołanie metody rysującej elementy wizualne do wszystkich zakładek
        // po przełączeniu DrawMode na OwnerDrawFixed
        private void PB_GrZakladek_DrawItem(object sender, DrawItemEventArgs e)
        {
            // określenie koloru, stylu, ect dla zakładki aktywnej
            TabPage page = PB_GrZakladek.TabPages[e.Index];
            if (!page.Enabled)
            {
                using (SolidBrush brush = new SolidBrush(SystemColors.GrayText))
                {
                    e.Graphics.DrawString(page.Text, page.Font, brush, e.Bounds);
                }
            }

                // określenie koloru, stylu, ect dla zakładek nieaktywnych
            else
            {
                using (SolidBrush brush = new SolidBrush(page.ForeColor))
                {
                    e.Graphics.DrawString(page.Text, page.Font, brush, e.Bounds);
                }
            }
        }


        // Metoda pobierająca dane wejściowe i sprawdzająca poprawnosć ich wprowadzania
        bool PB_PobierzDaneDoBankomatu(out float PB_MinNominalow, out float PB_MaxNominalow)
        {
            PB_MinNominalow = 0.0F;
            PB_MaxNominalow = 0.0F;
            

            // sprawdzenie czy użytkownik ustawił losową, czy z góry zadeklarowaną ilośc nominałów w bankomacie
            if (PB_LiczbaNominalowRandom.Checked)
            {
                // jeśli wybrał własną konfigurację - aktywowanie kontrolek
                // do wczytania minimalnej i maksymalnej ilości nominałów
                PB_DolnaIloscNominalow.Enabled = true;
                PB_GornaIloscNominalow.Enabled = true;


                // Wczytanie wartości minimalnej nominałów wraz ze sprawdzeniem poprawności zapisu
                // sprawdzenie, czy wpisano cokolwiek do kontrolki PB_DolnaIloscNominalow
                if (string.IsNullOrEmpty(PB_DolnaIloscNominalow.Text))
                {
                    // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                    errorProvider1.SetError(PB_DolnaIloscNominalow,
                        "ERROR: Podaj dolną granicę pojemności kaset z nominałami");
                    return false;
                    // zakończenie sprawdzania czy wpisano cokolwiek jako zadeklarowaną wartość PB_DolnaIloscNominalow
                }
                errorProvider1.Dispose();


                // wczytanie wartości minimalnej z kontrolki PB_DolnaIloscNominalow
                if (!float.TryParse(PB_DolnaIloscNominalow.Text, out PB_MinNominalow))
                {
                    errorProvider1.SetError(PB_DolnaIloscNominalow,
                        "ERROR: Do określenia minimalnej ilości użyto niedozwolonych znaków. Wpisz wartośc ponownie");
                    return false;
                    // zakończenie sprawdzania poprawności wpisania wartości PB_DolnaIloscNominalow
                }
                errorProvider1.Dispose();


                // Wczytanie wartości minimalnej nominałów wraz ze sprawdzeniem poprawności zapisu
                // sprawdzenie, czy wpisano cokolwiek do kontrolki PB_GornaIloscNominalow
                if (string.IsNullOrEmpty(PB_GornaIloscNominalow.Text))
                {
                    // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                    errorProvider1.SetError(PB_GornaIloscNominalow,
                        "ERROR: Podaj górną granicę pojemności kaset z nominałami");
                    return false;
                    // zakończenie sprawdzania czy wpisano cokolwiek jako zadeklarowaną wartość PB_GornaIloscNominalow
                }
                errorProvider1.Dispose();


                // wczytanie wartości maksymalnej z kontrolki PB_GornaIloscNominalow
                if ((!float.TryParse(PB_GornaIloscNominalow.Text, out PB_MaxNominalow) && (PB_MinNominalow <= 0)))
                {
                    errorProvider1.SetError(PB_GornaIloscNominalow,
                        "ERROR: Do określenia maksymalnej ilości użyto niedozwolonych znaków. Wpisz wartośc ponownie");
                    return false;
                    // zakończenie sprawdzania poprawności wpisania wartości PB_GornaIloscNominalow
                }
                errorProvider1.Dispose();


                // sprawdzenie, czy minimalna ilośc nie jest większa lub równa maksymalnej ilości nominałów
                if (PB_MinNominalow >= PB_MaxNominalow)
                {
                    errorProvider1.SetError(PB_GornaIloscNominalow,
                        "ERROR: Minimalna ilośc nominałów powinna być mniejsza od maksymalnej");
                    return false;
                    // zakończenie sprawdzania czy wartość PB_MinNominalow >= PB_MaxNominalow
                }
                errorProvider1.Dispose();

               
            }
            return true;
        }


        // wywołanie metody obsługi zdażenia Click klawisza zatwierdzającego konfiguracje wstępną bankomatu
        private void PB_NapelnienieBankomatu_Click(object sender, EventArgs e)
        {
            // deklaracja zmiennych lokalnych
            float PB_MinNominalow;                              
            float PB_MaxNominalow;
            int PB_k = -1;                                      // ustawienie zmiennej przechowującej długosc obrabianej tablicy zgodnie z wolą użytkownika
            int PB_krok = -1;                                   // wywołanie pomocniczej zmiennej tablicowej PB_krok
            Random PB_LosowaIloscNominałów = new Random();      // wywołanie generatora liczb losowych i ustanowienie nazwy zmiennej dla wyników losowych
            PB_WyplacMiKwote = 0.0F;                            // wywołanie zmiennej przechowującej kwotę do wypłaty
            PB_KapitałBankomatu = 0;                            // zmienna przechowująca całkowitą kwotę wybranej waluty w bankomacie


            // sprawdzenie warunku wejściowego
            if (!PB_PobierzDaneDoBankomatu(out PB_MinNominalow, out PB_MaxNominalow))
                return;

            // wywołanie tablic nominałów poszczególnych walut
            float[] PB_NominałyPL = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5F, 0.2F, 0.1F };
            string[] PB_PL = { "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "gr", "gr", "gr" };
            float[] PB_NominałyEU = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5F, 0.2F, 0.1F };
            string[] PB_EU = { "€", "€", "€", "€", "€", "€", "€", "€", "€", "cent", "cent", "cent" };
            float[] PB_NominałyUS = { 1000.0F, 500.0F, 100.0F, 50.0F, 20.0F, 10.0F, 5.0F, 2.0F, 1.0F, 0.5F, 0.25F, 0.1F };
            string[] PB_US = { "$", "$", "$", "$", "$", "$", "$", "$", "$", "cent", "cent", "cent" };
            float[] PB_NominałyGB = { 50.0F, 20.0F, 10.0F, 5.0F, 2.0F, 1.0F, 0.5F, 0.2F, 0.1F };
            string[] PB_GB = { "£", "£", "£", "£", "£", "£", "pens", "pens", "pens" };
            
            
            


            // warunek wejściowy - jeśli użytkownik zdecydowa się na losowo generowaną ilośc nominałów
            if (PB_LiczbaNominalowRandom.Checked)
            {
                //Jeśli użytkownik zadeklarował wypłatę wde PLN
                if (PB_Waluta == 1)
                {
                    // wywołanie i utworzenie tablicy przechowującej pary nominał 
                    // + wygenerowana losowo ilość dla wybranej waluty PL
                    PB_WalutaInfo.Text = ("PLN");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty PLN
                    PB_k = PB_NominałyPL.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą                
                    PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                    PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie egzemplarza tablicy przechowującej symbole wybranej waluty
                    for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                    // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                    {
                        PB_KasetkaZKasą[PB_krok, 0] = PB_LosowaIloscNominałów.Next((int)PB_MinNominalow, (int)PB_MaxNominalow);
                        PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyPL[PB_krok];
                        PB_SymbolWaluty[PB_krok] = PB_PL[PB_krok];
                    }
                }
                else
                    //Jeśli użytkownik zadeklarował wypłatę wde USD
                    if (PB_Waluta == 2)
                    {
                        PB_WalutaInfo.Text = ("USD");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty USD
                        PB_k = PB_NominałyUS.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                        PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                        PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                        for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                        // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                        {
                            PB_KasetkaZKasą[PB_krok, 0] = PB_LosowaIloscNominałów.Next((int)PB_MinNominalow, (int)PB_MaxNominalow);
                            PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyUS[PB_krok];
                            PB_SymbolWaluty[PB_krok] = PB_US[PB_krok];
                        }
                    }
                    else
                        //Jeśli użytkownik zadeklarował wypłatę wde EUR
                        if (PB_Waluta == 3)
                        {
                            PB_WalutaInfo.Text = ("EUR");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty EUR
                            PB_k = PB_NominałyEU.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                            PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                            PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                            for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                            // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                            {
                                PB_KasetkaZKasą[PB_krok, 0] = PB_LosowaIloscNominałów.Next((int)PB_MinNominalow, (int)PB_MaxNominalow);
                                PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyEU[PB_krok];
                                PB_SymbolWaluty[PB_krok] = PB_EU[PB_krok];
                            }
                        }
                        else
                            //Jeśli użytkownik zadeklarował wypłatę wde GBP
                            if (PB_Waluta == 4)
                            {
                                PB_WalutaInfo.Text = ("GBP");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty GBP
                                PB_k = PB_NominałyGB.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                                PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                                // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                                {
                                    PB_KasetkaZKasą[PB_krok, 0] = PB_LosowaIloscNominałów.Next((int)PB_MinNominalow, (int)PB_MaxNominalow);
                                    PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyGB[PB_krok];
                                    PB_SymbolWaluty[PB_krok] = PB_GB[PB_krok];
                                }
                            }

                // podliczenie kwoty jaką dysponuje BANKOMAT
                int PB_j = -1;   // deklaracja zmiennej pomocniczej do obliczenia kapitału bankomatu
                int PB_WysokośćKolumny = PB_KasetkaZKasą.GetLength(0);
                do
                {
                    PB_j++;
                    PB_KapitałBankomatu = PB_KapitałBankomatu + PB_KasetkaZKasą[PB_j, 0] * PB_KasetkaZKasą[PB_j, 1];
                }
                while (PB_j < (PB_WysokośćKolumny - 1));

               

            }
            else
                if (PB_IloscNominalowDefault.Checked)

                {
                    const int PB_StałaIlość = 35;
                    //Jeśli użytkownik zadeklarował wypłatę wde PLN
                    if (PB_Waluta == 1)
                    {
                        PB_WalutaInfo.Text = ("PLN");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty PLN
                        PB_k = PB_NominałyPL.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą                
                        PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                        PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                        for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                        // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                        {
                            PB_KasetkaZKasą[PB_krok, 0] = PB_StałaIlość;
                            PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyPL[PB_krok];
                            PB_SymbolWaluty[PB_krok] = PB_PL[PB_krok];
                        }
                    }
                    else
                        //Jeśli użytkownik zadeklarował wypłatę wde USD
                        if (PB_Waluta == 2)
                        {
                            PB_WalutaInfo.Text = ("USD");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty USD
                            PB_k = PB_NominałyUS.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                            PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                            PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                            for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                            // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                            {
                                PB_KasetkaZKasą[PB_krok, 0] = PB_StałaIlość;
                                PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyUS[PB_krok];
                                PB_SymbolWaluty[PB_krok] = PB_US[PB_krok];
                            }
                        }
                        else
                            //Jeśli użytkownik zadeklarował wypłatę wde EUR
                            if (PB_Waluta == 3)
                            {
                                PB_WalutaInfo.Text = ("EUR");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty EUR
                                PB_k = PB_NominałyEU.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                                PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                                // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                                {
                                    PB_KasetkaZKasą[PB_krok, 0] = PB_StałaIlość;
                                    PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyEU[PB_krok];
                                    PB_SymbolWaluty[PB_krok] = PB_EU[PB_krok];
                                }
                            }
                            else
                                //Jeśli użytkownik zadeklarował wypłatę wde GBP
                                if (PB_Waluta == 4)
                                {
                                    PB_WalutaInfo.Text = ("GBP");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty GBP
                                    PB_k = PB_NominałyGB.Length;                        // ustalenie długości tablicy 2-wymiarowej PB_KasetkaZKasą
                                    PB_KasetkaZKasą = new float[PB_k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                    PB_SymbolWaluty = new string[PB_k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                    for (PB_krok = 0; PB_krok < PB_k; PB_krok++)        // zadeklarowanie kroku zmiennej tablicowej

                                    // wywołanie pętli wykonującej napełnienie tablicy PB_KasetkaZKasą
                                    {
                                        PB_KasetkaZKasą[PB_krok, 0] = PB_StałaIlość;
                                        PB_KasetkaZKasą[PB_krok, 1] = PB_NominałyGB[PB_krok];
                                        PB_SymbolWaluty[PB_krok] = PB_GB[PB_krok];
                                    }
                                }
                    // podliczenie kwoty jaką dysponuje BANKOMAT
                    int PB_j = -1;   // deklaracja zmiennej pomocniczej do obliczenia kapitału bankomatu
                    int PB_WysokośćKolumny = PB_KasetkaZKasą.GetLength(0);
                    do
                    {
                        PB_j++;
                        PB_KapitałBankomatu = PB_KapitałBankomatu + PB_KasetkaZKasą[PB_j, 0] * PB_KasetkaZKasą[PB_j, 1];
                    }
                    while (PB_j < (PB_WysokośćKolumny - 1));
                }

            ((Control)this.PB_ZakladkaK).Enabled = false;   // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.PB_ZakladkaZW).Enabled = true;   // aktywacja zakłądki "Zlecenie Wypłaty"
            PB_GrZakladek.SelectedTab = PB_ZakladkaZW;      // zmiana wybranej zakładki na "Zlecenie Wypłaty"
        }



        // wywołanie metody sprawdzającej jaką decyzję w sprawie zawartości ilości nominałów
        // w bankomacie podjął użytkownik
        private void PB_LiczbaNominalowRandom_CheckedChanged(object sender, EventArgs e)
        {
            // sprawdzenie czy użytkownik ustawił losową, czy z góry zadeklarowaną ilośc nominałów w bankomacie
            // i jeśli wybrał losowe wartości
            if (PB_LiczbaNominalowRandom.Checked)
            {
                PB_DolnaIloscNominalow.Enabled = true;  // aktywowanie kontrolki do pwrowadzenia minimalnej ilości nominałów
                PB_GornaIloscNominalow.Enabled = true;  // aktywowanie kontrolki do pwrowadzenia maksymalnej ilości nominałów
                
            }
            else
                // a jeśli domyślne
                if (PB_IloscNominalowDefault.Checked)
                {
                    PB_DolnaIloscNominalow.Enabled = false; // deaktywowanie kontrolki do pwrowadzenia minimalnej ilości nominałów
                    PB_GornaIloscNominalow.Enabled = false; // deaktywowanie kontrolki do pwrowadzenia maksymalnej ilości nominałów
                   
                }
            return;

            
        }
       
        // obsługa klawisza wprowadzenia kwoty do wypłaty
        private void PB_AkceptacjaKwoty_Click(object sender, EventArgs e)

            
        {
            
            float PB_MinNominalow;                              // wywołanie zmiennej przechowującej minimalną możliwa ilośc dla danego nominału
            float PB_MaxNominalow;                              // wywołanie zmiennej przechowującej maksymalną możliwa ilośc dla danego nominału
            int PB_krok = -1;                                   // wywołanie pomocniczej zmiennej tablicowej PB_krok
            
            

            // sprawdzenie warunku wejściowego
            if (!PB_PobierzDaneDoBankomatu(out PB_MinNominalow, out PB_MaxNominalow))
                return;

            


            // sprawdzenie czy w kontrolce PB_KwotaDoWyplaty wpisano cokolwiek
            if (string.IsNullOrEmpty(PB_KwotaDoWyplaty.Text))
            {
                // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                errorProvider1.SetError(PB_KwotaDoWyplaty,
                    "ERROR: Wpisz kwotę jaką chcesz pobrać");
                return;
                // zakończenie sprawdzania czy wpisano cokolwiek do kontrolki PB_KwotaDoWyplaty
            }
            errorProvider1.Dispose();


            // wczytanie wartości kwoty do wypłaty z kontrolą poprawności zapisu
            if (!float.TryParse(PB_KwotaDoWyplaty.Text, out PB_WyplacMiKwote) && (PB_WyplacMiKwote <= 0))
            {
                errorProvider1.SetError(PB_KwotaDoWyplaty,
                    "ERROR: W zapisie kwoty do wypłaty użyto niedozwolonych znaków");
                return;
                // zakończenie sprawdzania poprawności wpisania wartości PB_KwotaDoWyplaty
            }
            errorProvider1.Dispose();


            // sprawdzenie, czy kwota do wypłaty nie jest wieksza od stanu posiadania BANKOMATU
            if (PB_WyplacMiKwote > PB_KapitałBankomatu)
            {
                MessageBox.Show("Wypłata nie może być zrealizowana, ponieważ BANKOMAT"
                      + "\n        nie posiada odpowiedniej kombinacji nominałów"
                      + " \n          lub  nie posiada wystarczającej ilości gotówki");
            }

            else

            // obliczenie ile i jakich nominałów zostanie użyte do wypłaty
            {
                float PB_NiepełnaWypłata = 0;   // wywołanie zmiennej pomocniczej przechowującej kwotę jeśli zabraknie szt danego nominału
                PB_krok = 0;                    // ustawienie wartości początkowej dla zmiennej PB_krok

                PB_WypłaconoKlientowi = new int[PB_KasetkaZKasą.GetLength(0)];      // stworzenie egzemplarza tabeli do przechowywania wyników wypłaty
                PB_PozostałoDoWypłaty = PB_WyplacMiKwote;                           // ustawienie wartości początkowej kwoty do wypłaty

                // wywołanie pętli obliczającej 
                while ((PB_krok < PB_KasetkaZKasą.GetLength(0)) && (PB_PozostałoDoWypłaty >= 0.1F))
                {
                    PB_IlośćNominałówDoWypłaty = (int)(Math.Round((PB_PozostałoDoWypłaty / PB_KasetkaZKasą[PB_krok, 1]), 2));
                    while (PB_KasetkaZKasą[PB_krok, 0] == 0)
                    {
                        PB_krok++;
                    }


                    if (PB_KasetkaZKasą[PB_krok, 0] <= PB_IlośćNominałówDoWypłaty)
                    {
                            PB_IlośćNominałówDoWypłaty = (int)PB_KasetkaZKasą[PB_krok, 0];
                            PB_KasetkaZKasą[PB_krok, 0] = 0;
                            PB_NiepełnaWypłata = (PB_IlośćNominałówDoWypłaty * PB_KasetkaZKasą[PB_krok, 1]);
                            PB_PozostałoDoWypłaty = (PB_PozostałoDoWypłaty - PB_NiepełnaWypłata);
                            PB_WypłaconoKlientowi[PB_krok] = PB_IlośćNominałówDoWypłaty;
                            PB_krok++;
                    }

                    else
                        if (PB_KasetkaZKasą[PB_krok, 0] > PB_IlośćNominałówDoWypłaty)
                        {
                            PB_WypłaconoKlientowi[PB_krok] = PB_IlośćNominałówDoWypłaty;
                            PB_PozostałoDoWypłaty = (PB_PozostałoDoWypłaty - (PB_IlośćNominałówDoWypłaty * PB_KasetkaZKasą[PB_krok, 1]));
                            PB_KasetkaZKasą[PB_krok, 0] = PB_KasetkaZKasą[PB_krok, 0] - PB_IlośćNominałówDoWypłaty;
                            PB_krok++;
                        }
                }
                
                PB_KapitałBankomatu = PB_KapitałBankomatu - PB_WyplacMiKwote;


                // Napełnianie kontrolki DataGridView PB_WypłaconoKlientowi kolekcją danych
                
                int PB_Tabela = 0;                      // zmienna pomocnicza trzymająca krok wszystkich źródłowych obiektów
                PB_ZestawienieWypłaty.RowCount = 0;     // ustawienie artości początkowej dla liczby wierszy PB_WypłaconoKlientowi

                // pętla łącząca dane z 3 tablic w jednej kontrolce DataGridView PB_WypłaconoKlientowi
                do
                {
                    PB_ZestawienieWypłaty.Rows.Add();
                    PB_ZestawienieWypłaty.Rows[PB_Tabela].Cells[0].Value = PB_WypłaconoKlientowi[PB_Tabela].ToString();
                    PB_ZestawienieWypłaty.Rows[PB_Tabela].Cells[1].Value = PB_KasetkaZKasą[PB_Tabela, 1].ToString();
                    PB_ZestawienieWypłaty.Rows[PB_Tabela].Cells[2].Value = PB_SymbolWaluty[PB_Tabela];
                    PB_Tabela++;
                }
                while (PB_Tabela < PB_WypłaconoKlientowi.Length);   // warunek zakończenia pętli


                // usuwanie z kontrolki DataGridView wierszy z zerowymi danymi
                for (int PB_usuń = 0; PB_usuń < PB_ZestawienieWypłaty.Rows.Count; PB_usuń++)
                {
                    if (string.Equals(PB_ZestawienieWypłaty[0, PB_usuń].Value as string, "0"))
                    {
                        PB_ZestawienieWypłaty.Rows.RemoveAt(PB_usuń);
                        PB_usuń--;
                    }
                }
         }
                



            
                

            ((Control)this.PB_ZakladkaZW).Enabled = false;   // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.PB_ZakladkaWN).Enabled = true;   // aktywacja zakłądki "Zlecenie Wypłaty"
            PB_GrZakladek.SelectedTab = PB_ZakladkaWN;      // zmiana wybranej zakładki na "Zlecenie Wypłaty"
        }


        private void PB_WybranaWalutaWyplaty_SelectedIndexChanged(object sender, EventArgs e)
        {

            int PB_SelectedIndex = PB_WybranaWalutaWyplaty.SelectedIndex;
            Object PB_SelectedItem = PB_WybranaWalutaWyplaty.SelectedItem;

            // użytkownik określił walutę
            switch (PB_SelectedIndex)
            {
                case 0:
                    PB_Waluta = 1;
                    break;
                case 1:
                    PB_Waluta = 2;
                    break;
                case 2:
                    PB_Waluta = 3;
                    break;
                case 3:
                    PB_Waluta = 4;
                    break;
            }
        }

        private void PB_Resetuj_Click(object sender, EventArgs e)
        {
            ((Control)this.PB_ZakladkaZW).Enabled = true;   // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.PB_ZakladkaWN).Enabled = false;   // aktywacja zakłądki "Zlecenie Wypłaty"
            PB_GrZakladek.SelectedTab = PB_ZakladkaZW;      // zmiana wybranej zakładki na "Zlecenie Wy;płaty"
            PB_KwotaDoWyplaty.Text = ("");
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego minimalna ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr i znak backspace
        private void PB_DolnaIloscNominalow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego maksymalną ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr i znak backspace
        private void PB_GornaIloscNominalow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego maksymalną ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr , znak backspace i przecinek
        private void PB_KwotaDoWyplaty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44;
        }

        private void PB_Koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
