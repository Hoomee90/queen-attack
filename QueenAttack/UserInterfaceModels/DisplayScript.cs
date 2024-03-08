using System;
using System.Threading;

namespace QueenAttack.UserInterfaceModels
{
	class Display
	{
		internal static void Opening(int x, int y)
		{
			TypeLine($"The freshfaced nameless chess piece has received their first assignment. They are to scout and secure the area of ({x}, {y}) and hold it until further instruction.");
			TypeLine("\"This is a very special mission,\" their superiors tell them \"You must go alone.\"");
			TypeLine("It is a long and grueling trek. These are wartorn lands, hostile down to their very dirt.");
			TypeLine("Those who walk them are no longer taught to forage; the only surviving plants are just as dangerous as anything else.", true);
			
			TypeLine("Not that the nameless piece would know any different. They are a child of battle, born and raised to fight.");
			TypeLine("Their head contains only tactics, their heart the desire to make their nation proud.");
			TypeLine("They have been waiting all their life for this: enter stage left the nameless piece, script written in blood and not a single spoken line.", true);
			
			TypeLine("They are not afraid.");
			TypeLine("They cannot be afraid.", true);
			
			TypeLine("Despite what they have been told to expect in this theater of war, the nameless piece finds their journey almost disconcertingly uneventful.");
			TypeLine("They have very little intel; they are headed to territory they themselves will be responsible for exploring.");
			TypeLine("But surely they should have encountered something by now. An enemy fighter. A squad of friendlies. Even the wild noncombatants they've heard whispers of.");
			TypeLine("There is nothing. They travel through monotonous plains, tedium broken only by the land's transition from black to white and back again.", true);
			
			TypeLine("...", true);
			TypeLine("...", true);
			TypeLine("...", true);
			
			TypeLine("Until they make it.");
			TypeLine($"({x}, {y}) looks just the same as every square they have seen thus far, but it is not the nameless piece's place to question orders.");
			TypeLine("They get to work. Securing the area, deploying accommodations.");
			TypeLine("Preparing themselves for whatever may come next.", true);
		}
		
		internal static void TypeLine(string text, bool blockEnd = false)
		{
			foreach (char letter in text)
			{
				Console.Write(letter);
				Thread.Sleep(20);
			}
			if (blockEnd) {
				_ = Console.ReadLine();
			} else {
				Thread.Sleep(250);
			}
			Console.WriteLine();
		}
	}
}