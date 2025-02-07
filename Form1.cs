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

        private void stw�rz_plik_Click(object sender, EventArgs e)

        {

            if (!File.Exists(filePath))  // Sprawdzenie czy plik istnieje
            {
                string[] headers = { "Data", "Imi�", "Czynno��", "Wykonane?" + Environment.NewLine }; // Nag��wek pliku
                informacje_do_pliku.Items.Add(string.Join("   ", headers)); // Dodanie do Listy zada�
                string csvContent = string.Join(",", headers); // ��czenie element�w tablicy
                File.WriteAllText(filePath, csvContent); // Zapisanie danych 
                MessageBox.Show("Plik zosta� utworzony", "Informacja"); // Okienko z informacj�
            }

            else
            {
                DialogResult pytanie = MessageBox.Show("Plik ju� istnieje. Czy chcesz stworzy� nowy plik?", "Potwierdzenie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question); // Okienko z pytaniem 

                if (pytanie == DialogResult.Yes) // Je�li tak
                {
                    File.Delete(filePath); // Usuwanie obecnego pliku i wykonanie czynno�ci zwi�zanych z nowym plikiem
                    string[] headers = { "Data", "Imi�", "Czynno��", "Czy wykonane?" + Environment.NewLine }; 
                    informacje_do_pliku.Items.Clear(); // Czy�cimy Liste zada� 
                    informacje_do_pliku.Items.Add(string.Join("      ", headers));
                    string csvContent = string.Join(",", headers);
                    File.WriteAllText(filePath, csvContent);
                    MessageBox.Show("Nowy plik zosta� utworzony", "Informacja");
                }

                else // Je�li nie
                {
                    MessageBox.Show("Plik nie zosta� utworzony", "Informacja"); // Okienko z informacj�
                }
            }
        }

        private void dodaj_zadanie_Click(object sender, EventArgs e)
        {
            string data = Data.Value.ToString("yyyy-MM-dd"); // Pobranie daty zadania
            string imie = Imie.Text; // Pobranie osoby do zadania
            string czynnosc = Czynno��.Text; // Pobranie czynno�ci
            string czyWykonane = Czy_wykonane.Checked ? "Tak" : "Nie"; // Czy zadanie wykonane?

            string newRow = $"{data}\t{imie}\t{czynnosc}\t{czyWykonane}"; // Utworzenie wiersza

            File.AppendAllText(filePath, newRow + Environment.NewLine); // Dodanie wiersza do pliku

            informacje_do_pliku.Items.Add(newRow); // Dodanie wiersza do Listy zada�

            MessageBox.Show("Zadanie zosta�o dodane do pliku", "Informacja"); // Okienko z informacj�
        }

        private void usu�_zadanie_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) // Czy plik istnieje? 
            {
                DialogResult Pytanie = MessageBox.Show("Czy na pewno chcesz usun�� ten plik?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); // Pytanie czy usuwamy

                if (Pytanie == DialogResult.Yes) // Je�li tak
                {
                    File.Delete(filePath); // Usuwamy plik
                    informacje_do_pliku.Items.Clear(); // Czy�cimy Liste zada�
                    MessageBox.Show("Plik zosta� usuni�ty", "Informacja"); // Okienko z informacj�
                }

                else // Je�li nie
                {
                    MessageBox.Show("Anulowano", "Informacja"); // Okienko z informacj� 
                }
            }

            else // Je�li nie
            {
                MessageBox.Show("Plik nie istnieje"); // Okienko z informacj�
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
    
