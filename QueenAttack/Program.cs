using System;
using QueenAttack.Models;

namespace QueenAttack
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to QueenAttack");
			Console.WriteLine("We'll calculate if a piece on a chessboard is able to attack be attacked by a queen based on their positions");
			Console.WriteLine("First we need to place the Queen");
			MakeQueen();
		}
		
		static void MakeQueen()
		{
			Console.WriteLine("Please enter a number for the new Queen's Y coordinate");
			string QueenYCoord = Console.ReadLine();
			Console.WriteLine("And one for the X coordinate");
			string QueenXCoord = Console.ReadLine();
			int y = int.Parse(QueenYCoord);
			int x = int.Parse(QueenXCoord);
			Queen queen = new(y, x);
			ConfirmOrEditQueen(queen);
		}
		static void ConfirmOrEditQueen(Queen queen) 
		{
			Console.WriteLine($"The Queen's coordinates are (${queen.YCoord}, ${queen.XCoord})");
			Console.WriteLine("Do you want to continue, or change them?");
			Console.WriteLine("y to continue, anything else to reenter coordinates");
			string userResponse = Console.ReadLine().ToLower();
			if (userResponse == "y")
			{
				CheckQueenAttack(queen);
			} else {
				Console.WriteLine("The Queen is dead. Long live the Queen");
				MakeQueen();
			}
		}
		
		static void CheckQueenAttack(Queen queen)
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Now place a piece and we'll see if it'll survive to see the sun");
			Console.WriteLine("Please enter a number for the nameless piece's Y coordinate");
			string PieceYCoord = Console.ReadLine();
			Console.WriteLine("And one for the X coordinate");
			string PieceXCoord = Console.ReadLine();
		}
	}
}