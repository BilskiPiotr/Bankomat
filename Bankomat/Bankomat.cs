using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Bankomat : Form
    {
        public Bankomat()
        {
            InitializeComponent();

            // wylaczenie wybranych zakłądek przy starcie programu 
            zakladkaZW.Enabled = false;
            zakladkaWN.Enabled = false;
        }

        // deklaracja zmiennych globalnych
        int waluta = 1;
        float wyplacMiKwote;
        float[ , ] kasetkaZKasą;
        int[ ] wypłaconoKlientowi;
        float pozostałoDoWypłaty;
        int ilośćNominałówDoWypłaty;
        float kapitałBankomatu;
        string [ ] symbolWaluty;


        // wywołanie metody uniemożliwiającej wybranie nieaktywnych zakładek
        private void GrZakladek_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        // wywołanie metody rysującej elementy wizualne do wszystkich zakładek
        // po przełączeniu DrawMode na OwnerDrawFixed
        private void GrZakladek_DrawItem(object sender, DrawItemEventArgs e)
        {
            // określenie koloru, stylu, ect dla zakładki aktywnej
            TabPage page = grZakladek.TabPages[e.Index];
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
        bool PobierzDaneDoBankomatu(out float minNominalow, out float maxNominalow)
        {
            minNominalow = 0.0F;
            maxNominalow = 0.0F;
            

            // sprawdzenie czy użytkownik ustawił losową, czy z góry zadeklarowaną ilośc nominałów w bankomacie
            if (rb_liczbaNominalowRandom.Checked)
            {
                // jeśli wybrał własną konfigurację - aktywowanie kontrolek
                // do wczytania minimalnej i maksymalnej ilości nominałów
                tb_dolnaIloscNominalow.Enabled = true;
                tb_gornaIloscNominalow.Enabled = true;


                // Wczytanie wartości minimalnej nominałów wraz ze sprawdzeniem poprawności zapisu
                // sprawdzenie, czy wpisano cokolwiek do kontrolki tb_dolnaIloscNominalow
                if (string.IsNullOrEmpty(tb_dolnaIloscNominalow.Text))
                {
                    // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                    errorProvider1.SetError(tb_dolnaIloscNominalow,
                        "ERROR: Podaj dolną granicę pojemności kaset z nominałami");
                    return false;
                    // zakończenie sprawdzania czy wpisano cokolwiek jako zadeklarowaną wartość tb_dolnaIloscNominalow
                }
                errorProvider1.Dispose();


                // wczytanie wartości minimalnej z kontrolki tb_dolnaIloscNominalow
                if (!float.TryParse(tb_dolnaIloscNominalow.Text, out minNominalow))
                {
                    errorProvider1.SetError(tb_dolnaIloscNominalow,
                        "ERROR: Do określenia minimalnej ilości użyto niedozwolonych znaków. Wpisz wartośc ponownie");
                    return false;
                    // zakończenie sprawdzania poprawności wpisania wartości tb_dolnaIloscNominalow
                }
                errorProvider1.Dispose();


                // Wczytanie wartości minimalnej nominałów wraz ze sprawdzeniem poprawności zapisu
                // sprawdzenie, czy wpisano cokolwiek do kontrolki tb_gornaIloscNominalow
                if (string.IsNullOrEmpty(tb_gornaIloscNominalow.Text))
                {
                    // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                    errorProvider1.SetError(tb_gornaIloscNominalow,
                        "ERROR: Podaj górną granicę pojemności kaset z nominałami");
                    return false;
                    // zakończenie sprawdzania czy wpisano cokolwiek jako zadeklarowaną wartość tb_gornaIloscNominalow
                }
                errorProvider1.Dispose();


                // wczytanie wartości maksymalnej z kontrolki tb_gornaIloscNominalow
                if ((!float.TryParse(tb_gornaIloscNominalow.Text, out maxNominalow) && (minNominalow <= 0)))
                {
                    errorProvider1.SetError(tb_gornaIloscNominalow,
                        "ERROR: Do określenia maksymalnej ilości użyto niedozwolonych znaków. Wpisz wartośc ponownie");
                    return false;
                    // zakończenie sprawdzania poprawności wpisania wartości tb_gornaIloscNominalow
                }
                errorProvider1.Dispose();


                // sprawdzenie, czy minimalna ilośc nie jest większa lub równa maksymalnej ilości nominałów
                if (minNominalow >= maxNominalow)
                {
                    errorProvider1.SetError(tb_gornaIloscNominalow,
                        "ERROR: Minimalna ilośc nominałów powinna być mniejsza od maksymalnej");
                    return false;
                    // zakończenie sprawdzania czy wartość minNominalow >= maxNominalow
                }
                errorProvider1.Dispose();

               
            }
            return true;
        }


        // wywołanie metody obsługi zdażenia Click klawisza zatwierdzającego konfiguracje wstępną bankomatu
        private void NapelnienieBankomatu_Click(object sender, EventArgs e)
        {
            // deklaracja zmiennych lokalnych

            int k = -1;                                         // ustawienie zmiennej przechowującej długosc obrabianej tablicy zgodnie z wolą użytkownika
            int krok = -1;                                      // wywołanie pomocniczej zmiennej tablicowej krok
            Random losowaIloscNominałów = new Random();         // wywołanie generatora liczb losowych i ustanowienie nazwy zmiennej dla wyników losowych
            wyplacMiKwote = 0.0F;                               // wywołanie zmiennej przechowującej kwotę do wypłaty
            kapitałBankomatu = 0;                               // zmienna przechowująca całkowitą kwotę wybranej waluty w bankomacie


            // sprawdzenie warunku wejściowego
            if (!PobierzDaneDoBankomatu(out float minNominalow, out float maxNominalow))
                return;

            // wywołanie tablic nominałów poszczególnych walut
            float[] nominałyPL = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5F, 0.2F, 0.1F };
            string[] pl = { "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "ZŁ", "gr", "gr", "gr" };
            float[] nominałyEU = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5F, 0.2F, 0.1F };
            string[] eu = { "€", "€", "€", "€", "€", "€", "€", "€", "€", "cent", "cent", "cent" };
            float[] nominałyUS = { 1000.0F, 500.0F, 100.0F, 50.0F, 20.0F, 10.0F, 5.0F, 2.0F, 1.0F, 0.5F, 0.25F, 0.1F };
            string[] us = { "$", "$", "$", "$", "$", "$", "$", "$", "$", "cent", "cent", "cent" };
            float[] nominałyGB = { 50.0F, 20.0F, 10.0F, 5.0F, 2.0F, 1.0F, 0.5F, 0.2F, 0.1F };
            string[] gb = { "£", "£", "£", "£", "£", "£", "pens", "pens", "pens" };
            
            
            


            // warunek wejściowy - jeśli użytkownik zdecydowa się na losowo generowaną ilośc nominałów
            if (rb_liczbaNominalowRandom.Checked)
            {
                //Jeśli użytkownik zadeklarował wypłatę wde PLN
                if (waluta == 1)
                {
                    // wywołanie i utworzenie tablicy przechowującej pary nominał 
                    // + wygenerowana losowo ilość dla wybranej waluty PL
                    walutaInfo.Text = ("PLN");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty PLN
                    k = nominałyPL.Length;                           // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą                
                    kasetkaZKasą = new float[k, 2];                  // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                    symbolWaluty = new string[k];                    // deklaracja i utworzenie egzemplarza tablicy przechowującej symbole wybranej waluty
                    for (krok = 0; krok < k; krok++)                 // zadeklarowanie kroku zmiennej tablicowej

                    // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                    {
                        kasetkaZKasą[krok, 0] = losowaIloscNominałów.Next((int)minNominalow, (int)maxNominalow);
                        kasetkaZKasą[krok, 1] = nominałyPL[krok];
                        symbolWaluty[krok] = pl[krok];
                    }
                }
                else
                    //Jeśli użytkownik zadeklarował wypłatę wde USD
                    if (waluta == 2)
                    {
                        walutaInfo.Text = ("USD");                       // ustawienie tekstu w kontrolce informacyjnej dla waluty USD
                        k = nominałyUS.Length;                           // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                        kasetkaZKasą = new float[k, 2];                  // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                        symbolWaluty = new string[k];                    // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                        for (krok = 0; krok < k; krok++)                 // zadeklarowanie kroku zmiennej tablicowej

                        // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                        {
                            kasetkaZKasą[krok, 0] = losowaIloscNominałów.Next((int)minNominalow, (int)maxNominalow);
                            kasetkaZKasą[krok, 1] = nominałyUS[krok];
                            symbolWaluty[krok] = us[krok];
                        }
                    }
                    else
                        //Jeśli użytkownik zadeklarował wypłatę wde EUR
                        if (waluta == 3)
                        {
                            walutaInfo.Text = ("EUR");                    // ustawienie tekstu w kontrolce informacyjnej dla waluty EUR
                            k = nominałyEU.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                            kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                            symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                            for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                            // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                            {
                                kasetkaZKasą[krok, 0] = losowaIloscNominałów.Next((int)minNominalow, (int)maxNominalow);
                                kasetkaZKasą[krok, 1] = nominałyEU[krok];
                                symbolWaluty[krok] = eu[krok];
                            }
                        }
                        else
                            //Jeśli użytkownik zadeklarował wypłatę wde GBP
                            if (waluta == 4)
                            {
                                walutaInfo.Text = ("GBP");                    // ustawienie tekstu w kontrolce informacyjnej dla waluty GBP
                                k = nominałyGB.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                                kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                                // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                                {
                                    kasetkaZKasą[krok, 0] = losowaIloscNominałów.Next((int)minNominalow, (int)maxNominalow);
                                    kasetkaZKasą[krok, 1] = nominałyGB[krok];
                                    symbolWaluty[krok] = gb[krok];
                                }
                            }

                // podliczenie kwoty jaką dysponuje BANKOMAT
                int j = -1;   // deklaracja zmiennej pomocniczej do obliczenia kapitału bankomatu
                int wysokośćKolumny = kasetkaZKasą.GetLength(0);
                do
                {
                    j++;
                    kapitałBankomatu = kapitałBankomatu + kasetkaZKasą[j, 0] * kasetkaZKasą[j, 1];
                }
                while (j < (wysokośćKolumny - 1));

               

            }
            else
                if (rb_iloscNominalowDefault.Checked)

                {
                    const int stałaIlość = 35;
                    //Jeśli użytkownik zadeklarował wypłatę wde PLN
                    if (waluta == 1)
                    {
                        walutaInfo.Text = ("PLN");                     // ustawienie tekstu w kontrolce informacyjnej dla waluty PLN
                        k = nominałyPL.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą                
                        kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                        symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                        for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                        // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                        {
                            kasetkaZKasą[krok, 0] = stałaIlość;
                            kasetkaZKasą[krok, 1] = nominałyPL[krok];
                            symbolWaluty[krok] = pl[krok];
                        }
                    }
                    else
                        //Jeśli użytkownik zadeklarował wypłatę wde USD
                        if (waluta == 2)
                        {
                            walutaInfo.Text = ("USD");                    // ustawienie tekstu w kontrolce informacyjnej dla waluty USD
                            k = nominałyUS.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                            kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                            symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                            for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                            // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                            {
                                kasetkaZKasą[krok, 0] = stałaIlość;
                                kasetkaZKasą[krok, 1] = nominałyUS[krok];
                                symbolWaluty[krok] = us[krok];
                            }
                        }
                        else
                            //Jeśli użytkownik zadeklarował wypłatę wde EUR
                            if (waluta == 3)
                            {
                                walutaInfo.Text = ("EUR");                    // ustawienie tekstu w kontrolce informacyjnej dla waluty EUR
                                k = nominałyEU.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                                kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                                // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                                {
                                    kasetkaZKasą[krok, 0] = stałaIlość;
                                    kasetkaZKasą[krok, 1] = nominałyEU[krok];
                                    symbolWaluty[krok] = eu[krok];
                                }
                            }
                            else
                                //Jeśli użytkownik zadeklarował wypłatę wde GBP
                                if (waluta == 4)
                                {
                                    walutaInfo.Text = ("GBP");                    // ustawienie tekstu w kontrolce informacyjnej dla waluty GBP
                                    k = nominałyGB.Length;                        // ustalenie długości tablicy 2-wymiarowej KasetkaZKasą
                                    kasetkaZKasą = new float[k, 2];               // deklaracja i utworzenie egzemplarza tablicy przechowującej pary nominał + ilość
                                    symbolWaluty = new string[k];                 // deklaracja i utworzenie nowego egzemplarza tablicy przechowującej symbol waluty
                                    for (krok = 0; krok < k; krok++)              // zadeklarowanie kroku zmiennej tablicowej

                                    // wywołanie pętli wykonującej napełnienie tablicy KasetkaZKasą
                                    {
                                        kasetkaZKasą[krok, 0] = stałaIlość;
                                        kasetkaZKasą[krok, 1] = nominałyGB[krok];
                                        symbolWaluty[krok] = gb[krok];
                                    }
                                }
                    // podliczenie kwoty jaką dysponuje BANKOMAT
                    int j = -1;   // deklaracja zmiennej pomocniczej do obliczenia kapitału bankomatu
                    int WysokośćKolumny = kasetkaZKasą.GetLength(0);
                    do
                    {
                        j++;
                        kapitałBankomatu = kapitałBankomatu + kasetkaZKasą[j, 0] * kasetkaZKasą[j, 1];
                    }
                    while (j < (WysokośćKolumny - 1));
                }

            ((Control)this.zakladkaK).Enabled = false;   // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.zakladkaZW).Enabled = true;   // aktywacja zakłądki "Zlecenie Wypłaty"
            grZakladek.SelectedTab = zakladkaZW;         // zmiana wybranej zakładki na "Zlecenie Wypłaty"
        }



        // wywołanie metody sprawdzającej jaką decyzję w sprawie zawartości ilości nominałów
        // w bankomacie podjął użytkownik
        private void LiczbaNominalowRandom_CheckedChanged(object sender, EventArgs e)
        {
            // sprawdzenie czy użytkownik ustawił losową, czy z góry zadeklarowaną ilośc nominałów w bankomacie
            // i jeśli wybrał losowe wartości
            if (rb_liczbaNominalowRandom.Checked)
            {
                tb_dolnaIloscNominalow.Enabled = true;  // aktywowanie kontrolki do pwrowadzenia minimalnej ilości nominałów
                tb_gornaIloscNominalow.Enabled = true;  // aktywowanie kontrolki do pwrowadzenia maksymalnej ilości nominałów
                
            }
            else
                // a jeśli domyślne
                if (rb_iloscNominalowDefault.Checked)
                {
                    tb_dolnaIloscNominalow.Enabled = false; // deaktywowanie kontrolki do pwrowadzenia minimalnej ilości nominałów
                    tb_gornaIloscNominalow.Enabled = false; // deaktywowanie kontrolki do pwrowadzenia maksymalnej ilości nominałów
                   
                }
            return;

            
        }
       
        // obsługa klawisza wprowadzenia kwoty do wypłaty
        private void AkceptacjaKwoty_Click(object sender, EventArgs e)

            
        {

            int krok = -1;                                   // wywołanie pomocniczej zmiennej tablicowej PB_krok
            
            

            // sprawdzenie warunku wejściowego
            if (!PobierzDaneDoBankomatu(out float minNominalow, out float maxNominalow))
                return;

            


            // sprawdzenie czy w kontrolce PB_KwotaDoWyplaty wpisano cokolwiek
            if (string.IsNullOrEmpty(tb_kwotaDoWyplaty.Text))
            {
                // zapalenie kontrolki errorProvider i zasygnalizowanie błędu urzytkownikowi
                errorProvider1.SetError(tb_kwotaDoWyplaty,
                    "ERROR: Wpisz kwotę jaką chcesz pobrać");
                return;
                // zakończenie sprawdzania czy wpisano cokolwiek do kontrolki kwotaDoWyplaty
            }
            errorProvider1.Dispose();


            // wczytanie wartości kwoty do wypłaty z kontrolą poprawności zapisu
            if (!float.TryParse(tb_kwotaDoWyplaty.Text, out wyplacMiKwote) && (wyplacMiKwote <= 0))
            {
                errorProvider1.SetError(tb_kwotaDoWyplaty,
                    "ERROR: W zapisie kwoty do wypłaty użyto niedozwolonych znaków");
                return;
                // zakończenie sprawdzania poprawności wpisania wartości PB_KwotaDoWyplaty
            }
            errorProvider1.Dispose();


            // sprawdzenie, czy kwota do wypłaty nie jest wieksza od stanu posiadania BANKOMATU
            if (wyplacMiKwote > kapitałBankomatu)
            {
                MessageBox.Show("Wypłata nie może być zrealizowana, ponieważ BANKOMAT"
                      + "\n        nie posiada odpowiedniej kombinacji nominałów"
                      + " \n          lub  nie posiada wystarczającej ilości gotówki");
            }

            else

            // obliczenie ile i jakich nominałów zostanie użyte do wypłaty
            {
                float niepełnaWypłata = 0;      // wywołanie zmiennej pomocniczej przechowującej kwotę jeśli zabraknie szt danego nominału
                krok = 0;                       // ustawienie wartości początkowej dla zmiennej krok

                wypłaconoKlientowi = new int[kasetkaZKasą.GetLength(0)];      // stworzenie egzemplarza tabeli do przechowywania wyników wypłaty
                pozostałoDoWypłaty = wyplacMiKwote;                           // ustawienie wartości początkowej kwoty do wypłaty

                // wywołanie pętli obliczającej 
                while ((krok < kasetkaZKasą.GetLength(0)) && (pozostałoDoWypłaty >= 0.1F))
                {
                    ilośćNominałówDoWypłaty = (int)(Math.Round((pozostałoDoWypłaty / kasetkaZKasą[krok, 1]), 2));
                    while (kasetkaZKasą[krok, 0] == 0)
                    {
                        krok++;
                    }


                    if (kasetkaZKasą[krok, 0] <= ilośćNominałówDoWypłaty)
                    {
                            ilośćNominałówDoWypłaty = (int)kasetkaZKasą[krok, 0];
                            kasetkaZKasą[krok, 0] = 0;
                            niepełnaWypłata = (ilośćNominałówDoWypłaty * kasetkaZKasą[krok, 1]);
                            pozostałoDoWypłaty = (pozostałoDoWypłaty - niepełnaWypłata);
                            wypłaconoKlientowi[krok] = ilośćNominałówDoWypłaty;
                            krok++;
                    }

                    else
                        if (kasetkaZKasą[krok, 0] > ilośćNominałówDoWypłaty)
                        {
                            wypłaconoKlientowi[krok] = ilośćNominałówDoWypłaty;
                            pozostałoDoWypłaty = (pozostałoDoWypłaty - (ilośćNominałówDoWypłaty * kasetkaZKasą[krok, 1]));
                            kasetkaZKasą[krok, 0] = kasetkaZKasą[krok, 0] - ilośćNominałówDoWypłaty;
                            krok++;
                        }
                }
                
                kapitałBankomatu = kapitałBankomatu - wyplacMiKwote;


                // Napełnianie kontrolki DataGridView wypłaconoKlientowi kolekcją danych
                
                int tabela = 0;                          // zmienna pomocnicza trzymająca krok wszystkich źródłowych obiektów
                dgw_zestawienieWypłaty.RowCount = 0;     // ustawienie artości początkowej dla liczby wierszy wypłaconoKlientowi

                // pętla łącząca dane z 3 tablic w jednej kontrolce DataGridView wypłaconoKlientowi
                do
                {
                    dgw_zestawienieWypłaty.Rows.Add();
                    dgw_zestawienieWypłaty.Rows[tabela].Cells[0].Value = wypłaconoKlientowi[tabela].ToString();
                    dgw_zestawienieWypłaty.Rows[tabela].Cells[1].Value = kasetkaZKasą[tabela, 1].ToString();
                    dgw_zestawienieWypłaty.Rows[tabela].Cells[2].Value = symbolWaluty[tabela];
                    tabela++;
                }
                while (tabela < wypłaconoKlientowi.Length);   // warunek zakończenia pętli


                // usuwanie z kontrolki DataGridView wierszy z zerowymi danymi
                for (int usuń = 0; usuń < dgw_zestawienieWypłaty.Rows.Count; usuń++)
                {
                    if (string.Equals(dgw_zestawienieWypłaty[0, usuń].Value as string, "0"))
                    {
                        dgw_zestawienieWypłaty.Rows.RemoveAt(usuń);
                        usuń--;
                    }
                }
         }
                



            
                

            ((Control)this.zakladkaZW).Enabled = false;   // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.zakladkaWN).Enabled = true;    // aktywacja zakłądki "Zlecenie Wypłaty"
            grZakladek.SelectedTab = zakladkaWN;          // zmiana wybranej zakładki na "Zlecenie Wypłaty"
        }


        private void WybranaWalutaWyplaty_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = cb_wybranaWalutaWyplaty.SelectedIndex;
            Object selectedItem = cb_wybranaWalutaWyplaty.SelectedItem;

            // użytkownik określił walutę
            switch (selectedIndex)
            {
                case 0:
                    waluta = 1;
                    break;
                case 1:
                    waluta = 2;
                    break;
                case 2:
                    waluta = 3;
                    break;
                case 3:
                    waluta = 4;
                    break;
            }
        }

        private void Resetuj_Click(object sender, EventArgs e)
        {
            ((Control)this.zakladkaZW).Enabled = true;    // deaktywacja zakładki "Konfiguracja Bankomatu"
            ((Control)this.zakladkaWN).Enabled = false;   // aktywacja zakłądki "Zlecenie Wypłaty"
            grZakladek.SelectedTab = zakladkaZW;          // zmiana wybranej zakładki na "Zlecenie Wy;płaty"
            tb_kwotaDoWyplaty.Text = ("");
           

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego minimalna ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr i znak backspace
        private void DolnaIloscNominalow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego maksymalną ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr i znak backspace
        private void GornaIloscNominalow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }


        // ograniczenie możliwości wpisywania do pola tekstowego pobierającego maksymalną ilość
        // nominałów - dopuszczalne są jedynie znaki cyfr , znak backspace i przecinek
        private void KwotaDoWyplaty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44;
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
