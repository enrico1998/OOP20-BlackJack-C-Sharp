namespace model
{
	/// 
	/// <summary>
	/// @author 
	/// 
	/// </summary>
	public class CardImpl : Card
	{

		private Suit suit;
		private Values values;
		/// 
		/// <param name="suit"> </param>
		/// <param name="values"> </param>
		public CardImpl(Suit suit, Values values)
		{
			this.suit = suit;
			this.values = values;
		}

		public virtual Suit Suit
		{
			get
			{
				return suit;
			}
		}

		public virtual Values Values
		{
			get
			{
				return values;
			}
		}

		public virtual Values AceOrNot
		{
			set
			{
				this.values = value;
			}
		}



	}

}