﻿namespace Projekt
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
            label1 = new Label();
            lista_zadań = new Label();
            dodaj_zadanie = new Button();
            usuń_plik = new Button();
            edytuj_zadanie = new Button();
            wyjście = new Button();
            label3 = new Label();
            Imie = new TextBox();
            Czynność = new TextBox();
            Czy_wykonane = new CheckBox();
            Data = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Lista = new ListView();
            SuspendLayout();
            // 
            // stwórz_plik
            // 
            stwórz_plik.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            stwórz_plik.BackColor = Color.SpringGreen;
            stwórz_plik.Location = new Point(781, 105);
            stwórz_plik.Name = "stwórz_plik";
            stwórz_plik.Size = new Size(140, 62);
            stwórz_plik.TabIndex = 0;
            stwórz_plik.Text = "Stwórz plik";
            stwórz_plik.UseVisualStyleBackColor = false;
            stwórz_plik.Click += stwórz_plik_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(381, 23);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 7;
            label1.Text = "WITAMY W PROGRAMIE";
            // 
            // lista_zadań
            // 
            lista_zadań.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lista_zadań.AutoSize = true;
            lista_zadań.Location = new Point(38, 58);
            lista_zadań.Name = "lista_zadań";
            lista_zadań.Size = new Size(83, 20);
            lista_zadań.TabIndex = 8;
            lista_zadań.Text = "Lista zadań";
            // 
            // dodaj_zadanie
            // 
            dodaj_zadanie.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dodaj_zadanie.BackColor = Color.Yellow;
            dodaj_zadanie.Location = new Point(781, 177);
            dodaj_zadanie.Name = "dodaj_zadanie";
            dodaj_zadanie.Size = new Size(140, 62);
            dodaj_zadanie.TabIndex = 9;
            dodaj_zadanie.Text = "Dodaj zadanie";
            dodaj_zadanie.UseVisualStyleBackColor = false;
            dodaj_zadanie.Click += dodaj_zadanie_Click;
            // 
            // usuń_plik
            // 
            usuń_plik.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usuń_plik.BackColor = Color.Red;
            usuń_plik.Location = new Point(781, 322);
            usuń_plik.Name = "usuń_plik";
            usuń_plik.Size = new Size(140, 62);
            usuń_plik.TabIndex = 10;
            usuń_plik.Text = "Usuń plik";
            usuń_plik.UseVisualStyleBackColor = false;
            usuń_plik.Click += usuń_plik_Click;
            // 
            // edytuj_zadanie
            // 
            edytuj_zadanie.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            edytuj_zadanie.BackColor = Color.Cyan;
            edytuj_zadanie.Location = new Point(781, 250);
            edytuj_zadanie.Name = "edytuj_zadanie";
            edytuj_zadanie.Size = new Size(140, 62);
            edytuj_zadanie.TabIndex = 11;
            edytuj_zadanie.Text = "Edytuj zadanie";
            edytuj_zadanie.UseVisualStyleBackColor = false;
            edytuj_zadanie.Click += edytuj_zadanie_Click;
            // 
            // wyjście
            // 
            wyjście.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            wyjście.BackColor = SystemColors.ActiveBorder;
            wyjście.Font = new Font("Segoe UI", 9F);
            wyjście.ForeColor = SystemColors.ActiveCaptionText;
            wyjście.Location = new Point(781, 394);
            wyjście.Name = "wyjście";
            wyjście.Size = new Size(140, 62);
            wyjście.TabIndex = 13;
            wyjście.Text = "Wyjście";
            wyjście.UseVisualStyleBackColor = false;
            wyjście.Click += wyjscie_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(509, 105);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 14;
            label3.Text = "Data";
            // 
            // Imie
            // 
            Imie.Anchor = AnchorStyles.Left;
            Imie.BackColor = SystemColors.GradientActiveCaption;
            Imie.Location = new Point(512, 195);
            Imie.Name = "Imie";
            Imie.Size = new Size(212, 27);
            Imie.TabIndex = 15;
            // 
            // Czynność
            // 
            Czynność.Anchor = AnchorStyles.Left;
            Czynność.BackColor = SystemColors.GradientActiveCaption;
            Czynność.Location = new Point(512, 273);
            Czynność.Name = "Czynność";
            Czynność.Size = new Size(212, 27);
            Czynność.TabIndex = 16;
            // 
            // Czy_wykonane
            // 
            Czy_wykonane.Anchor = AnchorStyles.Left;
            Czy_wykonane.AutoSize = true;
            Czy_wykonane.Location = new Point(512, 342);
            Czy_wykonane.Name = "Czy_wykonane";
            Czy_wykonane.Size = new Size(142, 24);
            Czy_wykonane.TabIndex = 17;
            Czy_wykonane.Text = "Zaznacz, jeśli tak";
            Czy_wykonane.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            Data.Anchor = AnchorStyles.Left;
            Data.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            Data.Location = new Point(512, 128);
            Data.Name = "Data";
            Data.Size = new Size(212, 27);
            Data.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(512, 172);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 19;
            label4.Text = "Imię";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(512, 250);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 20;
            label5.Text = "Czynność";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(509, 319);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 21;
            label6.Text = "Czy wykonane?";
            // 
            // Lista
            // 
            Lista.Anchor = AnchorStyles.Left;
            Lista.BackColor = SystemColors.GradientActiveCaption;
            Lista.FullRowSelect = true;
            Lista.Location = new Point(38, 83);
            Lista.MultiSelect = false;
            Lista.Name = "Lista";
            Lista.Size = new Size(377, 403);
            Lista.TabIndex = 22;
            Lista.UseCompatibleStateImageBehavior = false;
            Lista.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(933, 520);
            Controls.Add(Lista);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Data);
            Controls.Add(Czy_wykonane);
            Controls.Add(Czynność);
            Controls.Add(Imie);
            Controls.Add(label3);
            Controls.Add(wyjście);
            Controls.Add(edytuj_zadanie);
            Controls.Add(usuń_plik);
            Controls.Add(dodaj_zadanie);
            Controls.Add(lista_zadań);
            Controls.Add(label1);
            Controls.Add(stwórz_plik);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stwórz_plik;
        private Label label1;
        private Label lista_zadań;
        private Button dodaj_zadanie;
        private Button usuń_plik;
        private Button edytuj_zadanie;
        private Button wyjście;
        private Label label3;
        private TextBox Imie;
        private TextBox Czynność;
        private CheckBox Czy_wykonane;
        private DateTimePicker Data;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListView Lista;
    }
}
