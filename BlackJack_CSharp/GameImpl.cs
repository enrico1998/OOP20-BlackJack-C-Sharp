
namespace controller
{
	using Chip = model.Chip;
	using State = model.State;


	/*
	 * main class that controls the entire game
	 */

	public class GameImpl : Game
	{
		
		private int balance = 0;
		private int bet = 0;
		private DealerDraw dealerDraw = new DealerDrawImpl();
		private PlayerDraw playerDraw = new PlayerDrawImpl();
		private PlayerTurn playerTurn = new PlayerTurnImpl();
		private DealerTurn dealerTurn = new DealerTurnImpl();

		private State currentState;



		public GameImpl()
		{
			this.balance = 1000;
		}


		/*
		 * method that controls the first turn of the game
		 */
		public virtual void newGame()
		{
			this.dealerDraw.DrawCard();
			this.playerDraw.DrawCard();
			this.dealerDraw.DrawCard();
			this.playerDraw.DrawCard();


			if (this.playerDraw.PlayerHand.Count == 2 && this.playerDraw.PointPlayer == 21)
			{ //&& this.dealerDraw.getDealerHand().get(0).getValues().getV() != 10) {
				this.currentState = State.natural;
				this.balance += (int)(this.bet * 2.5);
			}
			else if (this.playerDraw.PointPlayer < 22)
			{
				this.currentState = State.playerTurn;
			}
		}

		/*
		 * method to update the view
		 */

		public virtual State State
		{
			get
			{
				return this.currentState;
			}
			set
			{
				this.currentState = value;
			}
		}


		/*
		 * method that checks the final result
		 */
		public virtual void CheckResult()
		{
			if (this.dealerDraw.PointDealer > this.playerDraw.PointPlayer && this.dealerDraw.PointDealer < 22 || this.playerDraw.PointPlayer > 21)
			{
				if (this.checkBalance())
				{
					this.State = State.broke;
				}
				else
				{
					this.State = State.lose;
				}
			}
			else if (this.dealerDraw.PointDealer < this.playerDraw.PointPlayer)
			{
				this.State = State.win;
				this.balance += this.bet * 2;
			}
			else if (this.dealerDraw.PointDealer == this.playerDraw.PointPlayer && this.playerDraw.PointPlayer < 21 && this.dealerDraw.PointDealer < 21)
			{
				this.State = State.drow;
				this.balance += this.bet;
			}
			else if (this.dealerDraw.PointDealer > 21)
			{
				this.State = State.win;
				this.balance += this.bet * 2;
			}

			
		}


		public virtual Chip Bet
		{
			set
			{
				this.bet += Chip.getChipValue(value);
				this.State = State.bet;
				
			}
			get
			{
				return this.Bet;
			}
		}


		public virtual void setBalanceAfterBet()
		{
			this.balance -= this.bet;
		}

		public virtual bool checkBalance()
		{
			if (this.balance <= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/*
		 * method that checks that the bet made is valid
		 */

		/// <summary>
		/// method that cleans the table
		/// </summary>
		public void ResetAll()
		{
			this.playerDraw.ResetPlayer();
			this.dealerDraw.ResetDealer();
			this.bet = 0;
			//this.newGame();
		}


		/// <summary>
		/// method that sets up a new game
		/// </summary>
		public void playAgain()
		{
			this.playerDraw.ResetPlayer();
			this.dealerDraw.ResetDealer();
			this.balance = 1000;
			this.bet = 0;
			
		}

	}
}