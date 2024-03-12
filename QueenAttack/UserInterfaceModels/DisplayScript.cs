using System;
using System.Net.Http.Headers;
using System.Threading;

namespace QueenAttack.UserInterfaceModels
{
	
	class Display
	{
		
		internal static void TypeLine(string text, bool blockEnd = false, ConsoleColor textColor = ConsoleColor.Gray)
		{
			foreach (char letter in text)
			{
				if (letter == '"' && !(textColor == ConsoleColor.Gray))
				{	
					if (!(Console.ForegroundColor == ConsoleColor.Gray))
					{
						Console.Write(letter);
						Thread.Sleep(20);
						Console.ResetColor();
						continue;
					}
					else
					{
						Console.ForegroundColor = textColor;
					}
				}
				Console.Write(letter);
				Thread.Sleep(20);
			}
			if (blockEnd) 
			{
				_ = Console.ReadLine();
			} 
			else 
			{
				Thread.Sleep(250);
			}
			Console.WriteLine();
		}
		internal static void Opening(int x, int y)
		{
			TypeLine($"The freshfaced nameless chess piece has received their first assignment. They are to scout and secure the area of ({x}, {y}) and hold it until further instruction.");
			TypeLine("\"This is a very special mission,\" their superiors tell them \"You must go alone\"", false, ConsoleColor.DarkRed);
			TypeLine("It is a long and grueling trek. These are wartorn lands, hostile down to their very dirt.");
			TypeLine("Those who walk them are no longer taught to forage; the only surviving plants are just as dangerous as anything else.", true);
			
			TypeLine("Not that the nameless piece would know any different. They are a child of battle, born and raised to fight.");
			TypeLine("Their head contains only tactics, their heart the desire to make their nation proud.");
			TypeLine("They have been waiting all their life for this: enter stage left the nameless piece, script written in blood and not a single spoken line.", true);
			
			TypeLine("They are not afraid.");
			TypeLine("They cannot be afraid.", true);
			
			TypeLine("Despite what they have been told to expect in this theater of war, the nameless piece finds their journey almost disconcertingly uneventful.");
			TypeLine("They have very little intel; they are headed to territory they themselves will be responsible for exploring.");
			TypeLine("But surely they should have encountered something by now. An enemy fighter.");
			TypeLine("A squad of friendlies. Even the wild noncombatants they've heard whispers of.");
			TypeLine("There is nothing. They travel through monotonous plains, tedium broken only by the land's transition from black to white and back again.", true);
			
			TypeLine("...", true);
			TypeLine("...", true);
			
			TypeLine("Until they make it.");
			TypeLine($"({x}, {y}) looks just the same as every square they have seen thus far, but it is not the nameless piece's place to question orders.");
			TypeLine("They get to work. Securing the area, deploying accommodations.");
			TypeLine("Preparing themself for whatever may come next.", true);
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
		}
		
		internal static void NoAttack(int x, int y)
		{
			TypeLine("Time passes, and the nameless chess piece waits. They eat rations and explore the parameter.");
			TypeLine("They do their best to feel accomplished.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine($"Time passes, and the nameless chess piece waits. They have gained an exhaustive understanding of nearly the entirety of ({x}, {y})");
			TypeLine("Not a single stone has been left unturned.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece waits. They score marks in the ground to make imaginary infantry lines.");
			TypeLine("Move pebbles around like troops, act out famous battles.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece waits. They think fondly of their fellow cadets, who must be out on assignment now too.");
			TypeLine("What are they doing? Fighting, surely. Their own mission is different, special. How lucky they are.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece waits. They were sure they spotted something on the horizon, but it disappeared.");
			TypeLine("They must be seeing things.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece waits. They've lost track of the date. There was no calender in their supplies.");
			TypeLine("What day is it? What month?");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece waits. This is important work. This is making their nation proud. This is...");
			TypeLine("This is their last day of rations.");
			TypeLine("They are ready for new orders.");
			TypeLine("Whenever they will receive some.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece is confused. What is the purpose of this mission? Why are they really here?");
			TypeLine("The hunger gnaws at their sanity.");
			TypeLine("They are ready for new orders.");
			TypeLine("Please, let them receive some soon.", true);
			TypeLine("...", true);
			TypeLine("Time passes, and the nameless chess piece falls. They are so hungry. Nothing makes sense.");
			TypeLine("Are they going to die here?");
			TypeLine("They don't think new orders are coming.");
			TypeLine("Their script has come to an end.", true);
			TypeLine("...", true);
			TypeLine("Time passes, but is there is no longer a nameless chess piece to wait.");
			TypeLine("It is over. The orders were followed to perfection.");
			TypeLine("The data is invaluable, is it not?");
			TypeLine($"The Queen was unable to attack the location of ({x}, {y})", true);
			TypeLine("...", true);
		}
	}
}