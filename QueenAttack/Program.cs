using System;
using System.Threading;
using QueenAttack.Models;

namespace QueenAttack
{
	class Program
	{
		static void Main()
		{
			Queen queen = new(0, 0);
			CheckQueenAttack(queen);
			// Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			// Console.WriteLine("Welcome to QueenAttack");
			// Console.WriteLine("We'll calculate if the Queen is able to attack a piece on the chess board based on their positions");
			// Console.WriteLine("First we need to crown the Queen");
			// MakeQueen();
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
			Console.WriteLine("'y' to continue, anything else to reenter coordinates");
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
			Console.WriteLine("Now place a piece and we'll see if the queen can attack it");
			Console.WriteLine("Please enter a number for the nameless piece's X coordinate");
			// int PieceX = int.Parse(Console.ReadLine());
			string first = Console.ReadLine();
			Console.WriteLine("And one for the Y coordinate");
			// int PieceY = int.Parse(Console.ReadLine());
			// bool result = queen.CanAttack(PieceX, PieceY);
			string second = Console.ReadLine();
			Console.WriteLine("-----------------------------------------");
			TypeLine($"The freshfaced nameless chess piece has received their first assignment. They are to secure the area of ({0}, {0}) and hold it until further instruction.");
			TypeLine("\"This is a very special mission,\" their superiors tell them \"You must go alone.\"");
			TypeLine("It is a long and grueling trek. These are wartorn lands, hostile down to their very dirt.");
			TypeLine("Those who walk them are no longer taught to forage; the only plants left are just as dangerous as anything else.", true);
			
			TypeLine("Not that the nameless piece would know any different. They are a child of battle, born and raised to fight.");
			TypeLine("Their brain is full of tactics, their heart the desire to make their nation proud.");
			TypeLine("They have been waiting all their life for this: enter stage left the nameless piece, script written in blood and not a single spoken line." , true);
			
			TypeLine("They are not afraid.");
			TypeLine("They cannot be afraid.");
		}
		
		static void TypeLine(string text, bool blockEnd = false)
		{
			foreach (char letter in text)
			{
				Console.Write(letter);
				Thread.Sleep(20);
			}
			if (blockEnd) {
				_ = Console.ReadLine();
			} else {
				Thread.Sleep(200);
			}
			Console.WriteLine();
		}
	}
}