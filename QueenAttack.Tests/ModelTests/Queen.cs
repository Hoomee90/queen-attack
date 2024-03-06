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
			Queen newQueen = new();
			Assert.AreEqual(typeof(Queen), newQueen.GetType());
		}
	}
}