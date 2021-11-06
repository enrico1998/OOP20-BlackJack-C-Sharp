using System;

namespace controller
{
	using CardImpl = model.CardImpl;
	using Suit = model.Suit;
	using Values = model.Values;

	public class PickCard
	{

		private const int NUMBER_SUIT = 4;
		private const int NUMBER_VALUE = 13;
		private CardImpl cardpicked;
		private Random random = new Random();

		public PickCard()
		{

		}

		/// <summary>
		/// method that draws a new card </summary>
		/// <returns> new card </returns>
		public virtual CardImpl pickedCard()
		{

			int pickedCardNum = random.Next(NUMBER_SUIT) + 1;
			int pickedCardValue = random.Next(NUMBER_VALUE) + 1;
	//		spade 0
	//		club 1 
	//		diamonds 2 
	//		heart 3
			switch (pickedCardNum)
			{
			case 1: //spade
				this.cardpicked = new CardImpl(Suit.spades, Values.getValue(pickedCardValue));
				break;
			case 2: //club
				this.cardpicked = new CardImpl(Suit.clubs, Values.getValue(pickedCardValue));
				break;
			case 3: //diamonds
				this.cardpicked = new CardImpl(Suit.diamods, Values.getValue(pickedCardValue));
				break;
			case 4: //heart
				this.cardpicked = new CardImpl(Suit.heart, Values.getValue(pickedCardValue));
				break;
			}

			return cardpicked;

		}

	}

}