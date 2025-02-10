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

        private void stw�rz_plik_Click(object sender, EventArgs e)

        {

            if (!File.Exists(filePath))  // Sprawdzenie czy plik istnieje
            {
                string[] headers = { "Data", "Imi�", "Czynno��", "Czy Wykonane?" }; // Nag��wek pliku
                string csvContent = string.Join(",", headers); // ��czenie element�w tablicy 
                File.WriteAllText(filePath, csvContent + Environment.NewLine); // Zapisanie danych 
                MessageBox.Show("Plik zosta� utworzony", "Informacja"); // Okienko z informacj�

                Lista.View = View.Details; // Ustawienie widoku dla Listy

                // Dodanie kolumn do Listy
                Lista.Columns.Add("Data", 90);
                Lista.Columns.Add("Imi�", 90);
                Lista.Columns.Add("Czynno��", 100);
                Lista.Columns.Add("Wykonane?", 100);

                // Wyr�wnanie kolumn na �rodek
                Lista.Columns[0].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[1].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[2].TextAlign = HorizontalAlignment.Center;
                Lista.Columns[3].TextAlign = HorizontalAlignment.Center;
            }

            else

            {
                DialogResult pytanie = MessageBox.Show("Plik ju� istnieje. Czy chcesz stworzy� nowy plik?", "Potwierdzenie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question); // Okienko z pytaniem 

                if (pytanie == DialogResult.Yes) // Je�li tak
                {
                    File.Delete(filePath); // Usuwanie obecnego pliku i wykonanie czynno�ci zwi�zanych z nowym plikiem
                    string[] headers = { "Data", "Imi�", "Czynno��", "Czy Wykonane?" }; // Nag��wek pliku
                    Lista.Columns.Clear(); // Usuwamy Nag��wki
                    Lista.Items.Clear(); // Czy�cimy Liste zada�
                    string csvContent = string.Join(",", headers); // ��czenie element�w tablicy 
                    File.WriteAllText(filePath, csvContent + Environment.NewLine); // Zapisanie danych 

                    MessageBox.Show("Plik zosta� utworzony", "Informacja"); // Okienko z informacj�

                    Lista.View = View.Details; // Ustawienie widoku dla Listy

                    // Dodanie kolumn do Listy
                    Lista.Columns.Add("Data", 90);
                    Lista.Columns.Add("Imi�", 90);
                    Lista.Columns.Add("Czynno��", 100);
                    Lista.Columns.Add("Wykonane?", 100);

                    // Wyr�wnanie kolumn na �rodek
                    Lista.Columns[0].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[1].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[2].TextAlign = HorizontalAlignment.Center;
                    Lista.Columns[3].TextAlign = HorizontalAlignment.Center;
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

            // Tworzymy wiersz
            ListViewItem item = new ListViewItem(data);
            item.SubItems.Add(imie);
            item.SubItems.Add(czynnosc);
            item.SubItems.Add(czyWykonane);

            Lista.Items.Add(item); // Dodanie wiersza do Listy

            string newRow = $"{data},{imie},{czynnosc},{czyWykonane}";
            File.AppendAllText(filePath, newRow + Environment.NewLine); // Zapisanie do pliku

            MessageBox.Show("Zadanie zosta�o dodane do pliku", "Informacja"); // Okienko z informacj�
        }

        private void usu�_plik_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath)) // Czy plik istnieje? 
            {
                DialogResult pytanie_2 = MessageBox.Show("Czy na pewno chcesz usun�� ten plik?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning); // Pytanie czy usuwamy

                if (pytanie_2 == DialogResult.Yes) // Je�li tak
                {
                    File.Delete(filePath); // Usuwamy plik
                    Lista.Columns.Clear(); // Usuwamy Nag��wki
                    Lista.Items.Clear(); // Czy�cimy Liste zada�
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
            if (Lista.SelectedItems.Count > 0) // Czy zadanie wybrane?
            {
                ListViewItem item = Lista.SelectedItems[0]; // Pobranie wybranego zadania

                // Pobranie warto�ci przez kontrolki
                Data.Value = DateTime.Parse(item.SubItems[0].Text);
                Imie.Text = item.SubItems[1].Text;
                Czynno��.Text = item.SubItems[2].Text;
                Czy_wykonane.Checked = item.SubItems[3].Text == "Tak";

                // Usuni�cie zadania z listy
                Lista.Items.Remove(item);

            }
            else
            {
                MessageBox.Show("Prosz� wybra� zadanie do edycji", "B��d");
            }
        }

        private void wczytaj_plik_Click(object sender, EventArgs e)
        {

        }
        private void wyjscie_Click(object sender, EventArgs e)
        {
            DialogResult pytanie_3 = MessageBox.Show("Czy na pewno chcesz wyj��?", "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question); // Okienko z pytaniem

            if (pytanie_3 == DialogResult.Yes)
            {
                Application.Exit();  // Zamkni�cie aplikacji
            }
        }
    }
}



    
