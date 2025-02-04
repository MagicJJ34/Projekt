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
            Dodaj_zadanie_do_pliku = new ListBox();
            label1 = new Label();
            label2 = new Label();
            dodaj_zadanie = new Button();
            usuń_zadanie = new Button();
            edytuj_zadanie = new Button();
            zapisz_plik = new Button();
            wyjście = new Button();
            SuspendLayout();
            // 
            // stwórz_plik
            // 
            stwórz_plik.Location = new Point(422, 93);
            stwórz_plik.Name = "stwórz_plik";
            stwórz_plik.Size = new Size(140, 62);
            stwórz_plik.TabIndex = 0;
            stwórz_plik.Text = "Stwórz plik";
            stwórz_plik.UseVisualStyleBackColor = true;
            stwórz_plik.Click += stwórz_plik_Click;
            // 
            // Dodaj_zadanie_do_pliku
            // 
            Dodaj_zadanie_do_pliku.AllowDrop = true;
            Dodaj_zadanie_do_pliku.FormattingEnabled = true;
            Dodaj_zadanie_do_pliku.Location = new Point(38, 93);
            Dodaj_zadanie_do_pliku.Name = "Dodaj_zadanie_do_pliku";
            Dodaj_zadanie_do_pliku.Size = new Size(309, 324);
            Dodaj_zadanie_do_pliku.TabIndex = 6;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 58);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Lista zadań";
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
            usuń_zadanie.Location = new Point(422, 224);
            usuń_zadanie.Name = "usuń_zadanie";
            usuń_zadanie.Size = new Size(140, 62);
            usuń_zadanie.TabIndex = 10;
            usuń_zadanie.Text = "Usuń zadanie";
            usuń_zadanie.UseVisualStyleBackColor = true;
            usuń_zadanie.Click += usuń_zadanie_Click;
            // 
            // edytuj_zadanie
            // 
            edytuj_zadanie.Location = new Point(614, 224);
            edytuj_zadanie.Name = "edytuj_zadanie";
            edytuj_zadanie.Size = new Size(140, 62);
            edytuj_zadanie.TabIndex = 11;
            edytuj_zadanie.Text = "Edytuj zadanie";
            edytuj_zadanie.UseVisualStyleBackColor = true;
            edytuj_zadanie.Click += edytuj_zadanie_Click;
            // 
            // zapisz_plik
            // 
            zapisz_plik.Location = new Point(422, 355);
            zapisz_plik.Name = "zapisz_plik";
            zapisz_plik.Size = new Size(140, 62);
            zapisz_plik.TabIndex = 12;
            zapisz_plik.Text = "Zapisz plik";
            zapisz_plik.UseVisualStyleBackColor = true;
            zapisz_plik.Click += zapisz_plik_Click;
            // 
            // wyjście
            // 
            wyjście.Location = new Point(614, 355);
            wyjście.Name = "wyjście";
            wyjście.Size = new Size(140, 62);
            wyjście.TabIndex = 13;
            wyjście.Text = "Wyjście";
            wyjście.UseVisualStyleBackColor = true;
            wyjście.Click += wyjście_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wyjście);
            Controls.Add(zapisz_plik);
            Controls.Add(edytuj_zadanie);
            Controls.Add(usuń_zadanie);
            Controls.Add(dodaj_zadanie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dodaj_zadanie_do_pliku);
            Controls.Add(stwórz_plik);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stwórz_plik;
        private ListBox Dodaj_zadanie_do_pliku;
        private Label label1;
        private Label label2;
        private Button dodaj_zadanie;
        private Button usuń_zadanie;
        private Button edytuj_zadanie;
        private Button zapisz_plik;
        private Button wyjście;
    }
}
