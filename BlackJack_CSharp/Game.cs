namespace controller
{
	using Chip = model.Chip;
	using State = model.State;
	/// 
	/// <summary>
	/// @author
	/// 
	/// </summary>
	public interface Game
	{


		void newGame();
		
		State State {get;set;}

		void CheckResult();

		Chip Bet {set;get;}

		void setBalanceAfterBet();

		bool checkBalance();


		void ResetAll();

		void playAgain();

		

	}
}