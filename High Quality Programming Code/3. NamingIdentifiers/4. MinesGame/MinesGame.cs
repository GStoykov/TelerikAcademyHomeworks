using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesGame
{
	public class MinesGame
	{
		public class Score
		{
			string name;
			int points;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}

			public int Points
			{
				get { return points; }
				set { points = value; }
			}


			public Score() 
            {
            }

            public Score(string name, int points)
			{
				this.Name = name;
				this.Points = points;
			}
		}

		static void Main()
		{
			string command = string.Empty;
			char[,] field = CreateField();
			char[,] bombs = GenerateBombs();
			int counter = 0;
			bool hasExplosion = false;
			List<Score> champions = new List<Score>(6);
			int rows = 0;
			int cols = 0;
			const int MAX = 35;
            bool startNewGame = true;
			bool isFieldCleared = false;
			
            do
			{
				if (startNewGame)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" \nKomanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					ActivateBombs(field);
					startNewGame = false;
				}
				Console.Write("Daj red i kolona : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out rows) &&
					    int.TryParse(command[2].ToString(), out cols) &&
						rows <= field.GetLength(0) && cols <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						RankList(champions);
						break;
					case "restart":
						field = CreateField();
						bombs = GenerateBombs();
						ActivateBombs(field);
						hasExplosion = false;
						startNewGame = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[rows, cols] != '*')
						{
							if (bombs[rows, cols] == '-')
							{
								NextTurn(field, bombs, rows, cols);
								counter++;
							}
							if (MAX == counter)
							{
								isFieldCleared = true;
							}
							else
							{
								ActivateBombs(field);
							}
						}
						else
						{
							hasExplosion = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (hasExplosion)
				{
					ActivateBombs(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", counter);
					string nickname = Console.ReadLine();
					Score playerScore = new Score(nickname, counter);
					if (champions.Count < 5)
					{
						champions.Add(playerScore);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
                            if (champions[i].Points < playerScore.Points)
							{
								champions.Insert(i, playerScore);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
					champions.Sort((Score firstResult, Score secondResult) => secondResult.Name.CompareTo(firstResult.Name));
                    champions.Sort((Score firstResult, Score secondResult) => secondResult.Points.CompareTo(firstResult.Points));
					RankList(champions);

					field = CreateField();
					bombs = GenerateBombs();
					counter = 0;
					hasExplosion = false;
					startNewGame = true;
				}
				if (isFieldCleared)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					ActivateBombs(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string name = Console.ReadLine();
					Score points = new Score(name, counter);
					champions.Add(points);
					RankList(champions);
                    field = CreateField();
					bombs = GenerateBombs();
					counter = 0;
					isFieldCleared = false;
					startNewGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void RankList(List<Score> scores)
		{
			Console.WriteLine("\nTo4KI:");
			if (scores.Count > 0)
			{
				for (int i = 0; i < scores.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, scores[i].Name, scores[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void NextTurn(char[,] field, char[,] bombs, int row, int col)
		{
			char bombsAround = CalculateHowManyBombsHasAround(bombs, row, col);
			bombs[row, col] = bombsAround;
			field[row, col] = bombsAround;
		}

		private static void ActivateBombs(char[,] field)
		{
			int rows = field.GetLength(0);
			int cols = field.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < cols; j++)
				{
					Console.Write(string.Format("{0} ", field[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateField()
		{
			int fieldRows = 5;
			int fieldCols = 10;
            char[,] field = new char[fieldRows, fieldCols];
            for (int i = 0; i < fieldRows; i++)
			{
                for (int j = 0; j < fieldCols; j++)
				{
                    field[i, j] = '?';
				}
			}
            return field;
		}

		private static char[,] GenerateBombs()
		{
			int rows = 5;
			int cols = 10;
			char[,] field = new char[rows, cols];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					field[i, j] = '-';
				}
			}

			List<int> listOfBombs = new List<int>();
			while (listOfBombs.Count < 15)
			{
				Random random = new Random();
				int bombID = random.Next(50);
				if (!listOfBombs.Contains(bombID))
				{
					listOfBombs.Add(bombID);
				}
			}

			foreach (int bomb in listOfBombs)
			{
				int col = (bomb / cols);
				int row = (bomb % cols);
				if (row == 0 && bomb != 0)
				{
					col--;
					row = cols;
				}
				else
				{
					row++;
				}
				field[col, row - 1] = '*';
			}

			return field;
		}

		private static void CalculateCellNumber(char[,] field)
		{
			int cols = field.GetLength(0);
			int rows = field.GetLength(1);

			for (int i = 0; i < cols; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					if (field[i, j] != '*')
					{
						char bombsAround = CalculateHowManyBombsHasAround(field, i, j);
						field[i, j] = bombsAround;
					}
				}
			}
		}

		private static char CalculateHowManyBombsHasAround(char[,] field, int row, int col)
		{
			int bombsCounter = 0;
			int rows = field.GetLength(0);
			int cols = field.GetLength(1);

			if (row - 1 >= 0)
			{
				if (field[row - 1, col] == '*')
				{ 
					bombsCounter++; 
				}
			}
			if (row + 1 < rows)
			{
				if (field[row + 1, col] == '*')
				{ 
					bombsCounter++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (field[row, col - 1] == '*')
				{ 
					bombsCounter++;
				}
			}
			if (col + 1 < cols)
			{
				if (field[row, col + 1] == '*')
				{ 
					bombsCounter++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (field[row - 1, col - 1] == '*')
				{ 
					bombsCounter++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (field[row - 1, col + 1] == '*')
				{ 
					bombsCounter++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (field[row + 1, col - 1] == '*')
				{ 
					bombsCounter++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (field[row + 1, col + 1] == '*')
				{ 
					bombsCounter++; 
				}
			}
			return char.Parse(bombsCounter.ToString());
		}
	}
}
