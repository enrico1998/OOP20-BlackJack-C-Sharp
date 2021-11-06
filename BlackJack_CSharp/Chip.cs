using System.Collections.Generic;

namespace model
{
	/// 
	/// <summary>
	/// @author
	/// 
	/// </summary>
	public sealed class Chip
	{
		public static readonly Chip five = new Chip("five", InnerEnum.five, 5);
		public static readonly Chip twenty = new Chip("twenty", InnerEnum.twenty, 20);
		public static readonly Chip fifty = new Chip("fifty", InnerEnum.fifty, 50);
		public static readonly Chip hundred = new Chip("hundred", InnerEnum.hundred, 100);

		private static readonly List<Chip> valueList = new List<Chip>();
		private int chip;
		static Chip()
		{
			valueList.Add(five);
			valueList.Add(twenty);
			valueList.Add(fifty);
			valueList.Add(hundred);
		}

		public enum InnerEnum
		{
			five,
			twenty,
			fifty,
			hundred
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

        /// 
        /// <param name="i"> </param>
        internal Chip(string name, InnerEnum innerEnum, int i)
		{
			this.chip = i;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}
		/// 
		/// <param name="chip">
		/// @return </param>
		public static int getChipValue(Chip chip)
		{
			switch (chip.innerEnumValue)
			{
			case model.Chip.InnerEnum.five:
				return 5;
			case model.Chip.InnerEnum.twenty:
				return 20;
			case model.Chip.InnerEnum.fifty:
				return 50;
			case model.Chip.InnerEnum.hundred:
				return 100;
			default:
				return 0;
			}
		}
        /// 
        /// <summary>
        /// @return
        /// </summary>
        public int getChip { get; }
		public void setChip(int chip) { this.chip = chip; }

        public static Chip[] values()
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

		public static Chip valueOf(string name)
		{
			foreach (Chip enumInstance in Chip.valueList)
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