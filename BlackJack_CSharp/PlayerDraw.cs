using System.Collections.Generic;

namespace controller
{

	using CardImpl = model.CardImpl;
	/// 
	/// <summary>
	/// @author 
	/// 
	/// </summary>
	public interface PlayerDraw
	{

		void DrawCard();

		IList<CardImpl> PlayerHand {get;}

		int PlayerNumberCard {get;}

		void ResetPlayer();

		int PointPlayer {get;}

		void setNoAce();

	}
}