using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
	[TestClass]
	public class QueenTests
	{
		[TestMethod]
		public void QueenConstructor_CreateInstanceOfQueen_Queen()
		{
			Queen newQueen = new(10, 0);
			Assert.AreEqual(typeof(Queen), newQueen.GetType());
		}
		
		[TestMethod]
		public void GetXCoord_ReturnsCoordX_Int()
		{
			int Coordinate = 3;
			Queen newQueen = new(Coordinate, 0);
			int result = newQueen.XCoord;
			Assert.AreEqual(Coordinate, result);
		}
		
		[TestMethod]
		public void SetXCoord_SetsValueOfCoordX_Void()
		{
			Queen newQueen = new(3, 0);
			int newCoordinate = 6;
			newQueen.XCoord = newCoordinate;
			Assert.AreEqual(newCoordinate, newQueen.XCoord);
		}
		
		[TestMethod]
		public void GetYCoord_ReturnsCoordY_Int()
		{
			int Coordinate = 3;
			Queen newQueen = new(0, Coordinate);
			int result = newQueen.YCoord;
			Assert.AreEqual(Coordinate, result);
		}
		
		[TestMethod]
		public void SetYCoord_SetsValueOfCoordY_Void()
		{
			Queen newQueen = new(0, 3);
			int newCoordinate = 7;
			newQueen.YCoord = newCoordinate;
			Assert.AreEqual(newCoordinate, newQueen.YCoord);
		}
		
		[TestMethod]
		public void CanAttack_DetermineWhenNoAttack_Bool()
		{
			Queen newQueen = new(10, 3);
			int XPiece = 5;
			int YPiece = 7;
			bool result = newQueen.CanAttack(XPiece, YPiece);
			Assert.IsFalse(result);
		}
		
		[TestMethod]
		public void CanAttack_DetermineWhenXAttack_Bool()
		{
			Queen newQueen = new(10, 3);
			int XPiece = 10;
			int YPiece = 7;
			bool result = newQueen.CanAttack(XPiece, YPiece);
			Assert.IsTrue(result);
		}
	}
}