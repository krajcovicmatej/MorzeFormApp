using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorzeFormApp
{
	public partial class Form3 : Form
	{
		private MorseEncoder morseEncoder; // Inštancia triedy MorseEncoder pre kódovanie a dekódovanie

		public Form3()
		{
			InitializeComponent();
			morseEncoder = new MorseEncoder(); // Inicializácia inštancie MorseEncoder pri vytvorení formulára
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		//otvorenie súboru
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile2 = new OpenFileDialog();
			openFile2.Title = "Vyber súbor";
			openFile2.InitialDirectory = @"C:\";//--"C:\\"
			openFile2.Filter = "Text|*.txt|All|*.*";
			openFile2.FilterIndex = 0;
			openFile2.ShowDialog();
			if (openFile2.FileName != "")
			{
				textBox1.Text = openFile2.FileName;
			}
			else { textBox1.Text = ""; }
		}

		//tlačidlo späť
		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}

		//tlačidlo na dekódovanie z Morseovej abecedy
		private void button2_Click(object sender, EventArgs e)
		{
			// Skontroluj, či je vybraný nejaký súbor v textBox1
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				// Ak nie je vybraný žiadny súbor, zobraz hlásenie
				MessageBox.Show("Vyberte súbor na dekódovanie z Morseovej abecedy.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Ukonči metódu
			}

			try
			{
				// Načítaj obsah vybraného súboru
				string fileTocode = System.IO.File.ReadAllText(textBox1.Text);

				// Dekóduj obsah súboru z Morseovej abecedy
				string morseCode = morseEncoder.Decode(fileTocode);

				// Vytvorenie inštancie SaveFileDialog pre výber umiestnenia a názvu uloženia súboru
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Title = "Uložiť dekódovaný súbor";
				saveFileDialog1.Filter = "Textové súbory|*.txt|Všetky súbory|*.*";

				// Zobrazenie dialógového okna pre uloženie súboru
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					// Získanie názvu a cesty vybraného súboru zo SaveFileDialog
					string selectedFileName = saveFileDialog1.FileName;

					// Ulož dekódovaný text do vybraného súboru
					System.IO.File.WriteAllText(selectedFileName, morseCode);

					// Vytvorte úplnú cestu k archívnemu priečinku
					string fullArchivePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MorseDecodeArchive");

					// Ak archívny priečinok neexistuje, vytvorte ho
					if (!Directory.Exists(fullArchivePath))
					{
						Directory.CreateDirectory(fullArchivePath);
					}

					// Získajte názov súboru bez cesty
					string selectedFileNameA = Path.GetFileName(textBox1.Text);

					// Vytvorte úplnú cestu k archívnemu súboru
					string archivedFilePath = Path.Combine(fullArchivePath, selectedFileNameA + " ArchiveDecode.txt");

					// Uložte zakódovaný text do archívneho súboru
					System.IO.File.WriteAllText(archivedFilePath, morseCode);


					// Zobrazenie potvrzovacieho hlásenia
					MessageBox.Show($"Dekódovaný text bol úspešne uložený do:\n{selectedFileName}", "Uložené", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				// Ak nastane chyba pri načítaní súboru alebo pri dekódovaní, zobraz chybové hlásenie
				MessageBox.Show($"Chyba pri spracovaní súboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}

