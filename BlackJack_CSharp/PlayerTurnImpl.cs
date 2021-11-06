namespace controller
{
	using State = model.State;

	public class PlayerTurnImpl : PlayerTurn
	{

		private const int MIN_PLAYER_HAND_SIZE = 1;
		private const int MAX_PLAYER_HAND_SIZE = 5;
		private PlayerDraw playerDraw;
		private Game game;

		public PlayerTurnImpl()
		{
		}

		/// <summary>
		/// method to check a new turn
		/// </summary>
		public virtual void newTurnPlayer(PlayerDraw playerDraw2, Game game)
		{
			this.playerDraw = playerDraw2;
			this.game = game;
			this.playerDraw.DrawCard();

			if (this.playerDraw.PointPlayer > 21)
			{
				if (this.game.checkBalance())
				{
					this.game.State = State.broke;
				}
				else
				{
					this.game.State = State.lose;
				}

			}
			else if (this.playerDraw.PointPlayer < 22)
			{
				if (this.playerDraw.PlayerHand.Count > MIN_PLAYER_HAND_SIZE && this.playerDraw.PlayerHand.Count <= MAX_PLAYER_HAND_SIZE)
				{
					this.game.State = State.playerTurn;
					
				}
				else if (this.playerDraw.PlayerHand.Count == MAX_PLAYER_HAND_SIZE)
				{
					this.game.State = State.dealerTurn;
					
				}
			}
			else if (this.playerDraw.PlayerHand.Count == MAX_PLAYER_HAND_SIZE)
			{
				this.game.State = State.dealerTurn;
				
			}
		}



	}

}