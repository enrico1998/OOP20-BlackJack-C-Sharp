using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace test
{

	using DealerDraw = controller.DealerDraw;
	using DealerDrawImpl = controller.DealerDrawImpl;
	using Game = controller.Game;
	using GameImpl = controller.GameImpl;

	/// <summary>
	/// @author bon98
	/// 
	/// </summary>

	[TestClass]
	public class TestDealerTurn
	{
		internal Game game = new GameImpl();
		internal DealerDraw dealerDraw = new DealerDrawImpl();

		[TestMethod]
		public virtual void turnDealer()
		{
			dealerDraw.DrawCard();
			Assert.AreEqual(dealerDraw.DealerHand.Count,1);
			dealerDraw.DrawCard();
			Assert.AreEqual(dealerDraw.DealerHand.Count,2);
			dealerDraw.ResetDealer();
			Assert.AreEqual(dealerDraw.DealerHand.Count,0);


		}

	}

}