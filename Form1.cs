using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Övning_4._3
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Skapa en lista av kontakter
        List<Kontakt> Kontakter = new List<Kontakt>();
        public Form()
        {
            InitializeComponent();
        }
        private void UppdateraKontaktLista()
        {
            // Tabort och skriv in kontakterna
            lbxKontakter.Items.Clear();
            foreach (Kontakt kontakt in Kontakter)
            {
                lbxKontakter.Items.Add(kontakt);
            }

            // Töm alla inputs
            tbxFörnamn.Text = "";
            tbxEfternamn.Text = "";
            tbxMail.Text = "";
            tbxTelefon.Text = "";
        }

        private void tsmSpara_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgSparaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                // Öppna ström
                FileStream utStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                // Skapa skrivare
                BinaryWriter skrivare = new BinaryWriter(utStröm);

                // Skriv ut en rad i taget
                foreach (Kontakt k in Kontakter)
                {
                    skrivare.Write(k.Förnamn);
                    skrivare.Write(k.Efternamn);
                    skrivare.Write(k.Mail);
                    skrivare.Write(k.Telefon);
                }

                // Sträng filen
                skrivare.Dispose();
            }
        }

        private void tsmÖppna_Click(object sender, EventArgs e)
        {
            // Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgÖppnaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                // Öppna ström
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);

                // Skapa läsare
                BinaryReader läsare = new BinaryReader(inStröm);

                // Skriv ut en string i taget
                while (läsare.BaseStream.Position != läsare.BaseStream.Length)
                {
                    Kontakter.Add(new Kontakt(läsare.ReadString(), läsare.ReadString(), läsare.ReadString(), läsare.ReadString()));
                }

                // Stäng filen  
                läsare.Dispose();
                UppdateraKontaktLista();
            }
        }

        private void tsmLäggTill_Click(object sender, EventArgs e)
        {
            try
            {
                // Lägg till kontakt i listan
                Kontakter.Add(new Kontakt(tbxFörnamn.Text, tbxEfternamn.Text, tbxMail.Text, tbxTelefon.Text));
                // Uppdatera listan
                UppdateraKontaktLista();
            }
            catch (FormatException)
            {
                // Ifall användaren har skrivit in fel input
                MessageBox.Show("Fel formaterad input!");
            }
        }

        private void tsmTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                // Ta bort vald kontakt från listan
                Kontakter.RemoveAt(lbxKontakter.SelectedIndex);
                // Uppdatera listan
                UppdateraKontaktLista();
            }
            catch (ArgumentOutOfRangeException)
            {
                // Ifall användaren inte har valt en kontakt i listan
                MessageBox.Show("Välj en kontakt!");
            }
        }

        private void lbxKontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Välj markerad
            var selected = lbxKontakter.SelectedItem as Kontakt;

            // Fyll alla inputs med markerad
            tbxFörnamn.Text = selected.Förnamn;
            tbxEfternamn.Text = selected.Efternamn;
            tbxMail.Text = selected.Mail;
            tbxTelefon.Text = selected.Telefon;
        }

        private void tsmStäng_Click(object sender, EventArgs e)
        {
            // Avsluta programmet
            Application.Exit();
        }
    }
}
