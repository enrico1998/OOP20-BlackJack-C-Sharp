using System.Collections.Generic;

namespace controller
{

	using Card = model.Card;
	using CardImpl = model.CardImpl;
	using Values = model.Values;
	/// 
	/// <summary>
	/// @author 
	/// 
	/// </summary>

	public class DealerDrawImpl : DealerDraw
	{

		private const int ACE_VALUE = 11;
		private const int MAX_DEALER_HAND_SIZE = 6;
		private IList<CardImpl> dealerHand = new List<CardImpl>();
		private int pointdealer;
		private PickCard pickCard = new PickCard();

		public DealerDrawImpl()
		{

		}

		/*
		 * method to draw a new card
		 */
		public virtual void DrawCard()
		{
			CardImpl card = pickCard.pickedCard();
			if (card.Values == Values.one && PointDealer + ACE_VALUE < 22)
			{
				card.AceOrNot = Values.getValue(14);
				this.dealerHand.Add(card);
			}
			else if (card.Values == Values.one && PointDealer + ACE_VALUE > 22 && this.dealerHand.Count < MAX_DEALER_HAND_SIZE)
			{
				card.AceOrNot = Values.getValue(1);
				this.dealerHand.Add(card);
				this.setNoAce();
			}
			else
			{
				this.dealerHand.Add(card);
				if (PointDealer > 21)
				{
					this.setNoAce();
				}
			}
		}

		public virtual IList<CardImpl> DealerHand
		{
			get
			{
				return this.dealerHand;
			}
		}

		public virtual void ResetDealer()
		{
			this.dealerHand.Clear();
		}

		public virtual int DealerNumberCard
		{
			get
			{
				return this.dealerHand.Count;
			}
		}



		/// <summary>
		/// method to get point of dealer
		/// </summary>
		public virtual int PointDealer
		{
			get
			{
				this.pointdealer = 0;
				foreach (Card carta in this.dealerHand)
				{
					this.pointdealer += Values.getValues(carta.Values);
				}
				return this.pointdealer;
			}
		}

		/// <summary>
		/// method to set value of ace to one  
		/// </summary>
		public virtual void setNoAce()
		{
			for (int i = 0;i < this.dealerHand.Count;i++)
			{
				if (this.dealerHand[i].Values.V == ACE_VALUE)
				{
					this.dealerHand[i].AceOrNot = Values.one;
					if (this.PointDealer < 21)
					{
						break;
					}
				}
			}
		}


	}

}