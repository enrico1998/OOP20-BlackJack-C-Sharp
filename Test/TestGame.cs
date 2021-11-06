using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace test
{

	using Game = controller.Game;
	using GameImpl = controller.GameImpl;
	using State = model.State;
	[TestClass]
	public class TestGame
	{


		[TestMethod]
		public virtual void testInitialBalance()
		{

			Game game = new GameImpl();
			Assert.IsFalse(game.checkBalance());
		}

		public virtual void testBet()
		{
			Game game = new GameImpl();

			Assert.AreEqual(0, game.Bet);
		}

		[TestMethod]
		public virtual void testStateOfGame()
		{

			Game game = new GameImpl();

			game.State = State.bet;
			Assert.AreEqual(State.bet, game.State);
			game.State = State.nobet;
			Assert.AreEqual(State.nobet, game.State);
			game.State = State.playerTurn;
			Assert.AreEqual(State.playerTurn, game.State);
			game.State = State.dealerTurn;
			Assert.AreEqual(State.dealerTurn, game.State);
			game.State = State.win;
			Assert.AreEqual(State.win, game.State);
			game.State = State.lose;
			Assert.AreEqual(State.lose, game.State);
			game.State = State.drow;
			Assert.AreEqual(State.drow, game.State);
			game.State = State.broke;
			Assert.AreEqual(State.broke, game.State);
		}

	}

}