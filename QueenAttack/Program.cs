using System;
using QueenAttack.Models;
using QueenAttack.UserInterfaceModels;

namespace QueenAttack
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to QueenAttack");
			Console.WriteLine("We'll calculate if a chess Queen is able to attack another piece based on their positions");
			Console.WriteLine("First we need to crown the Queen");
			MakeQueen();
		}
		static void MakeQueen()
		{
			Console.WriteLine("Please enter a number for the new Queen's X coordinate");
			string QueenXCoord = Console.ReadLine();
			Console.WriteLine("And one for the Y coordinate");
			string QueenYCoord = Console.ReadLine();
			int y = int.Parse(QueenYCoord);
			int x = int.Parse(QueenXCoord);
			Queen queen = new(x, y);
			ConfirmOrEditQueen(queen);
		}
		static void ConfirmOrEditQueen(Queen queen) 
		{
			Console.WriteLine($"The Queen's coordinates are ({queen.XCoord}, {queen.YCoord})");
			Console.WriteLine("Do you want to continue, or change them?");
			Console.WriteLine("'y' to continue, or anything else to reenter coordinates");
			string userResponse = Console.ReadLine().ToLower();
			if (userResponse == "y")
			{
				DisplayQueenAttack(queen);
			} else {
				Console.WriteLine("The Queen is dead. Long live the Queen");
				MakeQueen();
			}
		}
		
		static void DisplayQueenAttack(Queen queen)
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Now place a piece and we'll see if the Queen can attack it");
			Console.WriteLine("Please enter a number for the nameless piece's X coordinate");
			int PieceX = int.Parse(Console.ReadLine());
			Console.WriteLine("And one for the Y coordinate");
			int PieceY = int.Parse(Console.ReadLine());
			bool result = queen.CanAttack(PieceX, PieceY);
			Console.WriteLine("-----------------------------------------");
			Display.Opening(PieceX, PieceY);
			if (result)
			{

			}
			else
			{
				Display.NoAttack(PieceX, PieceY);
			}
		}
	}
}