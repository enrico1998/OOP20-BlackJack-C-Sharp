using System.Collections.Generic;

namespace model
{
	/// 
	/// <summary>
	/// @author
	/// 
	/// </summary>
	public sealed class Suit
	{
		public static readonly Suit spades = new Suit("spades", InnerEnum.spades, 0);
		public static readonly Suit clubs = new Suit("clubs", InnerEnum.clubs, 1);
		public static readonly Suit diamods = new Suit("diamods", InnerEnum.diamods, 2);
		public static readonly Suit heart = new Suit("heart", InnerEnum.heart, 3);

		private static readonly List<Suit> valueList = new List<Suit>();

		static Suit()
		{
			valueList.Add(spades);
			valueList.Add(clubs);
			valueList.Add(diamods);
			valueList.Add(heart);
		}

		public enum InnerEnum
		{
			spades,
			clubs,
			diamods,
			heart
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private int value;

		internal Suit(string name, InnerEnum innerEnum, int value)
		{
			// TODO Auto-generated constructor stub
			this.value = value;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}
		/// 
		/// <summary>
		/// @return
		/// </summary>
		public int getvalue()
		{
			return this.value;
		}
		/// 
		/// <param name="suitvalue">
		/// @return </param>
		public Suit getSuit(int suitvalue)
		{
			switch (suitvalue)
			{
			case 0:
				return spades;
			case 1:
				return clubs;
			case 2:
				return diamods;
			case 3:
				return heart;
			default:
				return null;
			}
		}



		public static Suit[] values()
		{
			return valueList.ToArray();
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static Suit valueOf(string name)
		{
			foreach (Suit enumInstance in Suit.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}

}