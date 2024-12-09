using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorzeFormApp
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
	public class MorseEncoder
	{
		// Slovník pre mapovanie znakov na Morseovky
		private readonly Dictionary<char, string> _morseCode = new Dictionary<char, string>()
		{
			{'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."},
			{'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
			{'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
			{'S', "..."}, {'T', "-"}, {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
			{'Y', "-.--"}, {'Z', "--.."},
			{'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
			{'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
			{'.', ".-.-.-"}, {',', "--..--"}, {'?', "..--.."}, {'\'', ".----."}, {'!', "-.-.--"},
			{'/', "-..-."}, {'(', "-.--."}, {')', "-.--.-"}, {'&', ".-..."}, {':', "---..."},
			{';', "-.-.-."}, {'=', "-...-"}, {'+', ".-.-."}, {'-', "-....-"}, {'_', "..--.-"},
			{'\"', ".-..-."}, {'$', "...-..-"}, {'@', ".--.-."}, {' ', "/"}
		};


		// Metóda pre zakódovanie textu do Morseovky
		public string Encode(string message)
		{
			message = message.ToUpper(); // Prevedie všetky písmená na veľké
			string encodedMessage = "";
			foreach (char character in message)
			{
				if (_morseCode.ContainsKey(character))
				{
					// Ak je znak v slovníku, pridaj jeho Morseovu reprezentáciu
					encodedMessage += _morseCode[character] + " ";
				}
				else
				{
					// Ak znak nie je priamo podporovaný v bežnom Morseovom kóde, skontrolujte pre špeciálne znaky
					string morseChar = EncodeSpecialCharacter(character);
					if (!string.IsNullOrEmpty(morseChar))
					{
						encodedMessage += morseChar + " "; // Pridá Morseov kód pre špeciálny znak
					}
					else
					{
						encodedMessage += character + " "; // Ak znak nie je kódovaný, ponechá ho ako je
					}
				}
			}
			return encodedMessage.Trim(); // Odstráni medzery na konci reťazca
		}


		// Metóda pre dekódovanie Morseovky späť na text
		/*public string Decode(string message)
		{
			string[] words = message.Split('/'); // Rozdelí Morseovku na slová
			string decodedMessage = "";
			foreach (string word in words)
			{
				string[] letters = word.Split(' '); // Rozdelí každé slovo na písmená
				foreach (string letter in letters)
				{
					foreach (KeyValuePair<char, string> kvp in _morseCode)
					{
						if (letter == kvp.Value)
						{
							// Nájde Morseovu reprezentáciu a preloží ju na znak
							decodedMessage += kvp.Key;
							break;
						}
					}
					char specialChar = DecodeSpecialCharacter(letter);
					if (specialChar != '\0')
					{
						decodedMessage += specialChar; // Pridá dekódovaný špeciálny znak do výsledného reťazca
					}
				}
				decodedMessage += " "; // Medzera za každým slovom
			}
			return decodedMessage.Trim(); // Odstráni medzery na konci reťazca
		}*/


		public string Decode(string message)
		{
			string[] words = message.Split('/'); // Rozdelenie Morseovej abecedy na slová podľa lomítka
			string decodedMessage = "";

			foreach (string word in words)
			{
				string[] letters = word.Split(' '); // Rozdelenie každého slova na písmená podľa medzery
				foreach (string letter in letters)
				{
					bool found = false;

					// Pokús sa najskôr dekódovať ako špeciálny znak
					char specialChar = DecodeSpecialCharacter(letter);
					if (specialChar != '\0')
					{
						decodedMessage += specialChar; // Pridaj dekódovaný špeciálny znak do výsledného reťazca
						found = true; // Označ, že sme našli odpovedajúci znak
					}

					// Ak sa nepodarilo nájsť špeciálny znak, hľadaj v Morseovej abecede
					if (!found)
					{
						foreach (KeyValuePair<char, string> kvp in _morseCode)
						{
							if (letter == kvp.Value)
							{
								// Nájdený Morseov kód, prelož ho na znak
								decodedMessage += kvp.Key;
								found = true; // Označ, že sme našli odpovedajúci znak
								break; // Ukonči hľadanie, keďže sme našli zhodu
							}
						}
					}
				}

				decodedMessage += " "; // Medzera za každým slovom
			}

			return decodedMessage.Trim(); // Odstráň medzery na konci výsledného reťazca
		}

		private string EncodeSpecialCharacter(char character)
		{
			// Implementujte kódovanie špeciálnych znakov do Morseovho kódu
			// Tu môžete mať ďalšie pravidlá pre kódovanie špeciálnych znakov
			//niektoré znaky chýbajú - sú rovnaké -> napríklad á a ä. nechal som viacej používané
			switch (character)
			{
				case 'Á':
					return ".-.-";
				case 'Č':
					return "-.-..";
				case 'Ď':
					return "..-..";
				
				case 'É':
					return "..-..";
				case 'Í':
					return "..";
				case 'Ľ':
					return ".-..-";
				case 'Ň':
					return "--.--";
				case 'Ó':
					return "---.";
				case 'Ô':
					return "---.";
				case 'Ŕ':
					return ".-.";
				case 'Š':
					return "...-";
				case 'Ť':
					return "--..";
				case 'Ú':
					return "..-";
				case 'Ý':
					return ".--";
				case 'Ž':
					return "--..";
				default:
					return ""; // Ak znak nie je podporovaný, vráťte prázdny reťazec
			}
		}


		private char DecodeSpecialCharacter(string morseChar)
		{
			// Implementujte dekódovanie špeciálnych znakov z Morseovho kódu
			// Tu môžete mať ďalšie pravidlá pre dekódovanie špeciálnych znakov, niektoré znaky sú rvnaké, preto som sa rozhodol nietkoré nepoužiť. preto možno sú v kóde preklepy
			switch (morseChar)
			{
				case ".-.-":
					return 'Á';
				case "-.-..":
					return 'Č';
				case "..-..":
					return 'É';
				case ".-..-":
					return 'Ľ';
				case "--.--":
					return 'Ň';
				case "---.":
					return 'Ó';
				default:
					return '\0'; // Ak znak nie je podporovaný, vráťte nulový znak
			}
		}

	}
}

