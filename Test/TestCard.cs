using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace test
{
	using Card = model.Card;
	using CardImpl = model.CardImpl;
	using Suit = model.Suit;
	using Values = model.Values;

	[TestClass]
	public class TestCard
	{

		[TestMethod]
		public virtual void testCard()
		{

			Card carta = new CardImpl(Suit.clubs, Values.ace);

			Assert.AreEqual(Values.ace,carta.Values);
			Assert.AreEqual(Suit.clubs,carta.Suit);
			Assert.AreNotEqual(Values.ten, carta.Values);
			Assert.AreNotEqual(Suit.heart, carta.Suit);
			carta.AceOrNot = Values.one;
			Assert.AreEqual(Values.one, carta.Values);

		}
	}

}