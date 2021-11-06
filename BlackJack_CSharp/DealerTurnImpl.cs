namespace controller
{
	/// 
	/// <summary>
	/// @author 
	/// 
	/// </summary>
	public class DealerTurnImpl : DealerTurn
	{

		private const int DEALER_MAX_VALUE = 17;
		private const int DEALER_MAX_CARD = 5;
		private DealerDraw dealerDraw;
		private Game game;
		public DealerTurnImpl()
		{
		}

		/*
		 * method to check a new turn
		 */
		public virtual void newTurnDealer(DealerDraw dealerDraw, Game game)
		{
			this.dealerDraw = dealerDraw;
			this.game = game;
			bool turndealerfinish = true;

			while (turndealerfinish)
			{
				if (this.dealerDraw.PointDealer < DEALER_MAX_VALUE)
				{
					this.dealerDraw.DrawCard();

					if (this.dealerDraw.DealerHand.Count == DEALER_MAX_CARD || this.dealerDraw.PointDealer >= DEALER_MAX_VALUE)
					{
						turndealerfinish = false;
					}
				}
				else
				{
					turndealerfinish = false;
				}
			}

			if (!turndealerfinish)
			{
				this.game.CheckResult();
			}
		}
	}

}