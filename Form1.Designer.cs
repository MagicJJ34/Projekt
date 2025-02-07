namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stwórz_plik = new Button();
            informacje_do_pliku = new ListBox();
            label1 = new Label();
            lista_poleceń = new Label();
            dodaj_zadanie = new Button();
            usuń_zadanie = new Button();
            edytuj_zadanie = new Button();
            wczytaj_plik = new Button();
            wyjście = new Button();
            label3 = new Label();
            Imie = new TextBox();
            Czynność = new TextBox();
            Czy_wykonane = new CheckBox();
            Data = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // stwórz_plik
            // 
            stwórz_plik.Location = new Point(614, 21);
            stwórz_plik.Name = "stwórz_plik";
            stwórz_plik.Size = new Size(140, 62);
            stwórz_plik.TabIndex = 0;
            stwórz_plik.Text = "Stwórz plik";
            stwórz_plik.UseVisualStyleBackColor = true;
            stwórz_plik.Click += stwórz_plik_Click;
            // 
            // informacje_do_pliku
            // 
            informacje_do_pliku.AllowDrop = true;
            informacje_do_pliku.FormattingEnabled = true;
            informacje_do_pliku.Location = new Point(38, 93);
            informacje_do_pliku.Name = "informacje_do_pliku";
            informacje_do_pliku.Size = new Size(309, 324);
            informacje_do_pliku.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 7;
            label1.Text = "WITAMY W PROGRAMIE";
            // 
            // lista_poleceń
            // 
            lista_poleceń.AutoSize = true;
            lista_poleceń.Location = new Point(38, 58);
            lista_poleceń.Name = "lista_poleceń";
            lista_poleceń.Size = new Size(96, 20);
            lista_poleceń.TabIndex = 8;
            lista_poleceń.Text = "Lista poleceń";
            // 
            // dodaj_zadanie
            // 
            dodaj_zadanie.Location = new Point(614, 93);
            dodaj_zadanie.Name = "dodaj_zadanie";
            dodaj_zadanie.Size = new Size(140, 62);
            dodaj_zadanie.TabIndex = 9;
            dodaj_zadanie.Text = "Dodaj zadanie";
            dodaj_zadanie.UseVisualStyleBackColor = true;
            dodaj_zadanie.Click += dodaj_zadanie_Click;
            // 
            // usuń_zadanie
            // 
            usuń_zadanie.Location = new Point(614, 230);
            usuń_zadanie.Name = "usuń_zadanie";
            usuń_zadanie.Size = new Size(140, 62);
            usuń_zadanie.TabIndex = 10;
            usuń_zadanie.Text = "Usuń zadanie";
            usuń_zadanie.UseVisualStyleBackColor = true;
            usuń_zadanie.Click += usuń_zadanie_Click;
            // 
            // edytuj_zadanie
            // 
            edytuj_zadanie.Location = new Point(614, 162);
            edytuj_zadanie.Name = "edytuj_zadanie";
            edytuj_zadanie.Size = new Size(140, 62);
            edytuj_zadanie.TabIndex = 11;
            edytuj_zadanie.Text = "Edytuj zadanie";
            edytuj_zadanie.UseVisualStyleBackColor = true;
            edytuj_zadanie.Click += edytuj_zadanie_Click;
            // 
            // wczytaj_plik
            // 
            wczytaj_plik.Location = new Point(614, 298);
            wczytaj_plik.Name = "wczytaj_plik";
            wczytaj_plik.Size = new Size(140, 62);
            wczytaj_plik.TabIndex = 12;
            wczytaj_plik.Text = "Wczytaj plik";
            wczytaj_plik.UseVisualStyleBackColor = true;
            wczytaj_plik.Click += wczytaj_plik_Click;
            // 
            // wyjście
            // 
            wyjście.Location = new Point(614, 366);
            wyjście.Name = "wyjście";
            wyjście.Size = new Size(140, 62);
            wyjście.TabIndex = 13;
            wyjście.Text = "Wyjście";
            wyjście.UseVisualStyleBackColor = true;
            wyjście.Click += wyjscie_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 105);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 14;
            label3.Text = "Data";
            // 
            // Imie
            // 
            Imie.Location = new Point(378, 197);
            Imie.Name = "Imie";
            Imie.Size = new Size(212, 27);
            Imie.TabIndex = 15;
            // 
            // Czynność
            // 
            Czynność.Location = new Point(378, 274);
            Czynność.Name = "Czynność";
            Czynność.Size = new Size(212, 27);
            Czynność.TabIndex = 16;
            // 
            // Czy_wykonane
            // 
            Czy_wykonane.AutoSize = true;
            Czy_wykonane.Location = new Point(378, 342);
            Czy_wykonane.Name = "Czy_wykonane";
            Czy_wykonane.Size = new Size(142, 24);
            Czy_wykonane.TabIndex = 17;
            Czy_wykonane.Text = "Zaznacz, jeśli tak";
            Czy_wykonane.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            Data.Location = new Point(378, 128);
            Data.Name = "Data";
            Data.Size = new Size(212, 27);
            Data.TabIndex = 18;
            Data.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 174);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 19;
            label4.Text = "Imię";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 251);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 20;
            label5.Text = "Czynność";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 319);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 21;
            label6.Text = "Czy wykonane?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Data);
            Controls.Add(Czy_wykonane);
            Controls.Add(Czynność);
            Controls.Add(Imie);
            Controls.Add(label3);
            Controls.Add(wyjście);
            Controls.Add(wczytaj_plik);
            Controls.Add(edytuj_zadanie);
            Controls.Add(usuń_zadanie);
            Controls.Add(dodaj_zadanie);
            Controls.Add(lista_poleceń);
            Controls.Add(label1);
            Controls.Add(informacje_do_pliku);
            Controls.Add(stwórz_plik);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stwórz_plik;
        private ListBox informacje_do_pliku;
        private Label label1;
        private Label lista_poleceń;
        private Button dodaj_zadanie;
        private Button usuń_zadanie;
        private Button edytuj_zadanie;
        private Button wczytaj_plik;
        private Button wyjście;
        private Label label3;
        private TextBox Imie;
        private TextBox Czynność;
        private CheckBox Czy_wykonane;
        private DateTimePicker Data;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
