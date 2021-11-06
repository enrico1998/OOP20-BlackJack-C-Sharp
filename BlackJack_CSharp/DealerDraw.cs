using System.Collections.Generic;

namespace controller
{

	using CardImpl = model.CardImpl;
	/// 
	/// <summary>
	/// @author 
	/// 
	/// </summary>
	public interface DealerDraw
	{
		void DrawCard();
		IList<CardImpl> DealerHand {get;}
		void ResetDealer();
		int DealerNumberCard {get;}
		int PointDealer {get;}
		void setNoAce();

	}
}