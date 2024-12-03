namespace Weinachtsbaum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Stufe1:
			//
			//Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
			//Du kannst dir das Aussehen des Baums selber aussuchen
			//Nutze für die Ausgabe Schleifen.
			//
			//Beispiel:
			//       x
			//      xxx
			//     xxxxx
			//    xxxxxxx
			//	 xxxxxxxxx
			//	xxxxxxxxxxx
			//      xxx
			//      xxx

			//Stufe 2:
			//
			//Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
			//Nutze ggf. Farben.

			//Stufe 3: 
			//
			//Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

			//Stufe 4:
			//
			//Lass den Baum Blinken und Funkeln
			//Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.

			//Stufe1:

			string[] baum = { "       x", "      xxx", "     xxxxx", "    xxxxxxx", "   xxxxxxxxx", "  xxxxxxxxxxx", "      xxx", "      xxx" };

			foreach (string s in baum)
			{
				Console.WriteLine(s);
			}

			//Stufe2:

			string[] gruss = { "Frohe Weinachten!", "Es Weinachtet! OMG!", "Stille Nacht! Heilige Nacht!" };

			Random rand = new Random();
			int auswahl = rand.Next(0, gruss.Length);

			Console.ForegroundColor = (ConsoleColor)rand.Next(1,15);

			Console.WriteLine(gruss[auswahl]);

			//Stufe 3

			while (true)
			{
				Thread.Sleep(1000);
				Console.Clear();

				Console.ResetColor();

				foreach (string s in baum)
				{
					Console.WriteLine(s);
				}

				int letzteAuswahl = auswahl;
				while (true)
				{
					auswahl = rand.Next(0, gruss.Length);
					if(auswahl != letzteAuswahl)
					{
						break;
					}
				}
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.WriteLine(gruss[auswahl]);

				//Stufe 4:

				Console.SetCursorPosition(7, 1);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(6, 2);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(8, 2);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(5, 3);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(7, 3);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(9, 3);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(4, 4);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(6, 4);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(8, 4);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(10, 4);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(3, 5);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(5, 5);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(7, 5);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(9, 5);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");

				Console.SetCursorPosition(11, 5);
				Console.ForegroundColor = (ConsoleColor)rand.Next(1, 15);
				Console.Write("o");
			}

		}
	}
}
