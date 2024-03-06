using System.Security.Cryptography.X509Certificates;

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
			if ((y == x - (XCoord - YCoord)) || (y == -x + (XCoord + YCoord)))
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