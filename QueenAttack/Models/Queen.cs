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
	}
}