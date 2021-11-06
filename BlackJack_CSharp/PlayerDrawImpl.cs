using System.Collections.Generic;

namespace controller
{

	using Card = model.Card;
	using CardImpl = model.CardImpl;
	using Values = model.Values;

	public class PlayerDrawImpl : PlayerDraw
	{

		private const int ACE_VALUE = 11;
		private IList<CardImpl> playerHand = new List<CardImpl>();
		private int pointplayer;

		private PickCard pickCard = new PickCard();

		public PlayerDrawImpl()
		{

		}

		/// <summary>
		/// method to draw a new card
		/// </summary>
		public virtual void DrawCard()
		{
			CardImpl card = pickCard.pickedCard();
			if (card.Values == Values.one && PointPlayer + ACE_VALUE < 22)
			{
				card.AceOrNot = Values.getValue(14);
			}

			this.playerHand.Add(card);
			if (PointPlayer > 21)
			{
				this.setNoAce();
			}

		}

		public virtual IList<CardImpl> PlayerHand
		{
			get
			{
				return this.playerHand;
			}
		}

		public virtual int PlayerNumberCard
		{
			get
			{
				return this.playerHand.Count;
			}
		}

		public virtual void ResetPlayer()
		{
			this.playerHand.Clear();
		}

		/// <summary>
		/// method to get point of dealer
		/// </summary>
		public virtual int PointPlayer
		{
			get
			{
    
				this.pointplayer = 0;
				foreach (Card carta in this.playerHand)
				{
					this.pointplayer += Values.getValues(carta.Values);
				}
				return this.pointplayer;
			}
		}


		/// <summary>
		/// method to set value of ace to one
		/// </summary>
		public virtual void setNoAce()
		{
			for (int i = 0;i < this.playerHand.Count;i++)
			{
				if (playerHand[i].Values.V == ACE_VALUE)
				{
					playerHand[i].AceOrNot = Values.one;
					if (this.PointPlayer < 21)
					{
						break;
					}
				}
			}

		}


	}

}