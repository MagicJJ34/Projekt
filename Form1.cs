using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Projekt

{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\Plik\plik.csv";   // Tworzenie pliku
        public Form1()
        {
            InitializeComponent();
        }

        private void stwórz_plik_Click(object sender, EventArgs e)

        {

            if (!File.Exists(filePath))  // Sprawdzenie czy plik istnieje
            {
                string[] headers = { "Data", "Imiê", "Czynnoœæ", "Czy Wykonane?" }; // Nag³ówek pliku
                string csvContent = string.Join(",", headers); // £¹czenie elementów tablicy 
                File.WriteAllText(filePath, csvContent + Environment.NewLine); // Zapisanie danych 
                MessageBox.Show("Plik zosta³ utworzony", "Informacja"); // Okienko z informacj¹

                Lista.View = View.Details; // Ustawienie widoku dla Listy

                // Dodanie kolumn do Listy
                Lista.Columns.Add("Data", 90);
                Lista.Columns.Add("Imiê", 90);
                Lista.Columns.Add("Czynnoœæ", 100);
                Lista.Columns.Add("Wykonane?", 100);

                // Wyrównanie kolumn na œrodek
                Lista.Columns[0].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[1].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[2].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[3].TextAlign = HorizontalAlignment.Center;
            }

            else

            {
                DialogResult pytanie = MessageBox.Show("Plik ju¿ istnieje. Czy chcesz stworzyæ nowy plik?", "Potwierdzenie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question); // Okienko z pytaniem 

                if (pytanie == DialogResult.Yes) // Jeœli tak
                {
                    File.Delete(filePath); // Usuwanie obecnego pliku i wykonanie czynnoœci zwi¹zanych z nowym plikiem
                    string[] headers = { "Data", "Imiê", "Czynnoœæ", "Czy Wykonane?" }; // Nag³ówek pliku
                    Lista.Columns.Clear(); // Usuwamy Nag³ówki
                    Lista.Items.Clear(); // Czyœcimy Liste zadañ
                    string csvContent = string.Join(",", headers); // £¹czenie elementów tablicy 
                    File.WriteAllText(filePath, csvContent + Environment.NewLine); // Zapisanie danych 

                    MessageBox.Show("Plik zosta³ utworzony", "Informacja"); // Okienko z informacj¹

                    Lista.View = View.Details; // Ustawienie widoku dla Listy

                    // Dodanie kolumn do Listy
                    Lista.Columns.Add("Data", 90);
                    Lista.Columns.Add("Imiê", 90);
                    Lista.Columns.Add("Czynnoœæ", 100);
                    Lista.Columns.Add("Wykonane?", 100);

                    // Wyrównanie kolumn na œrodek
                    Lista.Columns[0].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[1].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[2].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[3].TextAlign = HorizontalAlignment.Center;
                }

                else // Jeœli nie
                {
                    MessageBox.Show("Plik nie zosta³ utworzony", "Informacja"); // Okienko z informacj¹
                }
            }
        }

        private void dodaj_zadanie_Click(object sender, EventArgs e)
        {
            string data = Data.Value.ToString("yyyy-MM-dd"); // Pobranie daty zadania
            string imie = Imie.Text; // Pobranie osoby do zadania
            string czynnosc = Czynnoœæ.Text; // Pobranie czynnoœci
            string czyWykonane = Czy_wykonane.Checked ? "Tak" : "Nie"; // Czy zadanie wykonane?

            // Tworzymy wiersz
            ListViewItem item = new ListViewItem(data);
            item.SubItems.Add(imie);
            item.SubItems.Add(czynnosc);
            item.SubItems.Add(czyWykonane);

            Lista.Items.Add(item); // Dodanie wiersza do Listy

            string newRow = $"{data},{imie},{czynnosc},{czyWykonane}";
            File.AppendAllText(filePath, newRow + Environment.NewLine); // Zapisanie do pliku

            MessageBox.Show("Zadanie zosta³o dodane do pliku", "Informacja"); // Okienko z informacj¹
        }

        private void usuñ_plik_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) // Czy plik istnieje? 
            {
                DialogResult pytanie_2 = MessageBox.Show("Czy na pewno chcesz usun¹æ ten plik?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); // Pytanie czy usuwamy

                if (pytanie_2 == DialogResult.Yes) // Jeœli tak
                {
                    File.Delete(filePath); // Usuwamy plik
                    Lista.Columns.Clear(); // Usuwamy Nag³ówki
                    Lista.Items.Clear(); // Czyœcimy Liste zadañ
                    MessageBox.Show("Plik zosta³ usuniêty", "Informacja"); // Okienko z informacj¹
                }

                else // Jeœli nie
                {
                    MessageBox.Show("Anulowano", "Informacja"); // Okienko z informacj¹ 
                }
            }

            else // Jeœli nie
            {
                MessageBox.Show("Plik nie istnieje"); // Okienko z informacj¹
            }

        }

        private void edytuj_zadanie_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedItems.Count > 0) // Czy zadanie wybrane?
            {
                ListViewItem item = Lista.SelectedItems[0]; // Pobranie wybranego zadania

                // Pobranie wartoœci przez kontrolki
                Data.Value = DateTime.Parse(item.SubItems[0].Text);
                Imie.Text = item.SubItems[1].Text;
                Czynnoœæ.Text = item.SubItems[2].Text;
                Czy_wykonane.Checked = item.SubItems[3].Text == "Tak";

                // Usuniêcie zadania z listy
                Lista.Items.Remove(item);

            }
            else
            {
                MessageBox.Show("Proszê wybraæ zadanie do edycji", "B³¹d");
            }
        }

        private void wczytaj_plik_Click(object sender, EventArgs e)
        {

        }
        private void wyjscie_Click(object sender, EventArgs e)
        {
            DialogResult pytanie_3 = MessageBox.Show("Czy na pewno chcesz wyjœæ?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question); // Okienko z pytaniem

            if (pytanie_3 == DialogResult.Yes)
            {
                Application.Exit();  // Zamkniêcie aplikacji
            }
        }
    }
}



    
