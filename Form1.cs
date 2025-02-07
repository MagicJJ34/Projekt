using System;
using System.IO;
using System.Windows.Forms;
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
                string[] headers = { "Data", "Imiê", "Czynnoœæ", "Wykonane?" + Environment.NewLine }; // Nag³ówek pliku
                informacje_do_pliku.Items.Add(string.Join("   ", headers)); // Dodanie do Listy zadañ
                string csvContent = string.Join(",", headers); // £¹czenie elementów tablicy
                File.WriteAllText(filePath, csvContent); // Zapisanie danych 
                MessageBox.Show("Plik zosta³ utworzony", "Informacja"); // Okienko z informacj¹
            }

            else
            {
                DialogResult pytanie = MessageBox.Show("Plik ju¿ istnieje. Czy chcesz stworzyæ nowy plik?", "Potwierdzenie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question); // Okienko z pytaniem 

                if (pytanie == DialogResult.Yes) // Jeœli tak
                {
                    File.Delete(filePath); // Usuwanie obecnego pliku i wykonanie czynnoœci zwi¹zanych z nowym plikiem
                    string[] headers = { "Data", "Imiê", "Czynnoœæ", "Czy wykonane?" + Environment.NewLine }; 
                    informacje_do_pliku.Items.Clear(); // Czyœcimy Liste zadañ 
                    informacje_do_pliku.Items.Add(string.Join("      ", headers));
                    string csvContent = string.Join(",", headers);
                    File.WriteAllText(filePath, csvContent);
                    MessageBox.Show("Nowy plik zosta³ utworzony", "Informacja");
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

            string newRow = $"{data}\t{imie}\t{czynnosc}\t{czyWykonane}"; // Utworzenie wiersza

            File.AppendAllText(filePath, newRow + Environment.NewLine); // Dodanie wiersza do pliku

            informacje_do_pliku.Items.Add(newRow); // Dodanie wiersza do Listy zadañ

            MessageBox.Show("Zadanie zosta³o dodane do pliku", "Informacja"); // Okienko z informacj¹
        }

        private void usuñ_zadanie_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) // Czy plik istnieje? 
            {
                DialogResult Pytanie = MessageBox.Show("Czy na pewno chcesz usun¹æ ten plik?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); // Pytanie czy usuwamy

                if (Pytanie == DialogResult.Yes) // Jeœli tak
                {
                    File.Delete(filePath); // Usuwamy plik
                    informacje_do_pliku.Items.Clear(); // Czyœcimy Liste zadañ
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

        }

        private void wczytaj_plik_Click(object sender, EventArgs e)
        {

        }

        private void wyjscie_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    
