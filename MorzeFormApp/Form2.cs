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
	public partial class Form2 : Form
	{
		private MorseEncoder morseEncoder;// Inštancia triedy MorseEncoder pre kódovanie a dekódovanie

		public Form2()
		{
			InitializeComponent();
			morseEncoder = new MorseEncoder();// Inicializácia inštancie MorseEncoder pri vytvorení formulára
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		//otvorenie a výber súboru
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile1 = new OpenFileDialog();
			openFile1.Title = "Vyber súbor";
			openFile1.InitialDirectory = @"C:\";//--"C:\\"
			openFile1.Filter = "Text|*.txt|All|*.*";
			openFile1.FilterIndex = 0;
			openFile1.ShowDialog();
			if (openFile1.FileName != "")
			{
				textBox1.Text = openFile1.FileName;
			}
			else { textBox1.Text = ""; }
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}

		//tlačidlo kódovania do Morzeovky
		private void button2_Click(object sender, EventArgs e)
		{
			// Skontroluj, či je vybraný nejaký súbor v textBox1
			if (string.IsNullOrEmpty(textBox1.Text))
			{
				// Ak nie je vybraný žiadny súbor, zobraz hlásenie
				MessageBox.Show("Vyberte súbor na zakódovanie do Morseovej abecedy.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Ukonči metódu
			}

			try
			{
				// Načítaj obsah vybraného súboru
				string fileTocode = System.IO.File.ReadAllText(textBox1.Text);

				// Zakóduj obsah súboru do Morseovej abecedy
				string morseCode = morseEncoder.Encode(fileTocode);

				// Vytvorenie inštancie SaveFileDialog pre výber umiestnenia a názvu uloženia súboru
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Title = "Uložiť zakódovaný súbor";
				saveFileDialog1.Filter = "Textové súbory|*.txt|Všetky súbory|*.*";

				// Zobrazenie dialógového okna pre uloženie súboru
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					// Získanie názvu a cesty vybraného súboru zo SaveFileDialog
					string selectedFileName = saveFileDialog1.FileName;

					// Ulož zakódovaný text do vybraného súboru
					System.IO.File.WriteAllText(selectedFileName, morseCode);
													
					
					// Vytvorte úplnú cestu k archívnemu priečinku
					string fullArchivePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MorseCodeArchive");

					// Ak archívny priečinok neexistuje, vytvorte ho
					if (!Directory.Exists(fullArchivePath))
					{
						Directory.CreateDirectory(fullArchivePath);
					}

					// Získajte názov súboru bez cesty
					string selectedFileNameA = Path.GetFileName(textBox1.Text);

					// Vytvorte úplnú cestu k archívnemu súboru
					string archivedFilePath = Path.Combine(fullArchivePath, selectedFileNameA + " ArchiveCode.txt");

					// Uložte zakódovaný text do archívneho súboru
					System.IO.File.WriteAllText(archivedFilePath, morseCode);
					

					// Zobrazenie potvrzovacieho hlásenia
					MessageBox.Show($"Zakódovaný text bol úspešne uložený do:\n{selectedFileName}", "Uložené", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				// Ak nastane chyba pri načítaní súboru alebo pri zakódovaní, zobraz chybové hlásenie
				MessageBox.Show($"Chyba pri spracovaní súboru: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
	}

