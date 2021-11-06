using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test
{
	using PlayerDraw = controller.PlayerDraw;
	using PlayerDrawImpl = controller.PlayerDrawImpl;
	
	[TestClass]
	public class TestPlayerTurn
	{
		[TestMethod]
		public virtual void testTurnPlayer()
		{
			PlayerDraw playerDraw = new PlayerDrawImpl();

			playerDraw.DrawCard();
			Assert.AreEqual(1, playerDraw.PlayerHand.Count);
			playerDraw.DrawCard();
			Assert.AreEqual(2,playerDraw.PlayerHand.Count);
			playerDraw.DrawCard();
			Assert.AreEqual(3,playerDraw.PlayerHand.Count);
			playerDraw.ResetPlayer();
			Assert.AreEqual(0,playerDraw.PlayerHand.Count);
		}
	}

}