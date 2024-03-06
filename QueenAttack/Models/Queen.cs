using System;

namespace QueenAttack.Models
{
	public class Queen
	{
		public int XCoord { get; set;}
		public int YCoord { get; set;}
		
		public Queen(int x, int y)
		{
			XCoord = x;
			YCoord = y;
		}
		
		public bool CanAttack(int x, int y)
		{
			if (x == XCoord || y == YCoord)
			{
				return true;
			}
			if (Math.Abs((y - YCoord) / (x - XCoord)) == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}