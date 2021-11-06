
using System.Collections.Generic;

namespace model
{
	/// 
	/// <summary>
	/// @author bon98
	/// 
	/// </summary>
	public sealed class Values
	{
		public static readonly Values one = new Values("one", InnerEnum.one, 1);
		public static readonly Values two = new Values("two", InnerEnum.two, 2);
		public static readonly Values three = new Values("three", InnerEnum.three, 3);
		public static readonly Values four = new Values("four", InnerEnum.four, 4);
		public static readonly Values five = new Values("five", InnerEnum.five, 5);
		public static readonly Values six = new Values("six", InnerEnum.six, 6);
		public static readonly Values seven = new Values("seven", InnerEnum.seven, 7);
		public static readonly Values eight = new Values("eight", InnerEnum.eight, 8);
		public static readonly Values nine = new Values("nine", InnerEnum.nine, 9);
		public static readonly Values ten = new Values("ten", InnerEnum.ten, 10);
		public static readonly Values jack = new Values("jack", InnerEnum.jack, 10);
		public static readonly Values queen = new Values("queen", InnerEnum.queen, 10);
		public static readonly Values king = new Values("king", InnerEnum.king, 10);
		public static readonly Values ace = new Values("ace", InnerEnum.ace, 11);

		private static readonly List<Values> valueList = new List<Values>();

		static Values()
		{
			valueList.Add(one);
			valueList.Add(two);
			valueList.Add(three);
			valueList.Add(four);
			valueList.Add(five);
			valueList.Add(six);
			valueList.Add(seven);
			valueList.Add(eight);
			valueList.Add(nine);
			valueList.Add(ten);
			valueList.Add(jack);
			valueList.Add(queen);
			valueList.Add(king);
			valueList.Add(ace);
		}

		public enum InnerEnum
		{
			one,
			two,
			three,
			four,
			five,
			six,
			seven,
			eight,
			nine,
			ten,
			jack,
			queen,
			king,
			ace
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		private int v;

		internal Values(string name, InnerEnum innerEnum, int v)
		{
			// TODO Auto-generated constructor stub
			this.v = v;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}
		/// 
		/// <summary>
		/// @return
		/// </summary>
		public int V
		{
			get
			{
				return this.v;
			}
		}
		/// 
		/// <param name="value">
		/// @return </param>
		public static int getValues(Values value)
		{
			switch (value.innerEnumValue)
			{
				case model.Values.InnerEnum.one:
					return 1;
				case model.Values.InnerEnum.two:
					return 2;
				case model.Values.InnerEnum.three:
					return 3;
				case model.Values.InnerEnum.four:
					return 4;
				case model.Values.InnerEnum.five:
					return 5;
				case model.Values.InnerEnum.six:
					return 6;
				case model.Values.InnerEnum.seven:
					return 7;
				case model.Values.InnerEnum.eight:
					return 8;
				case model.Values.InnerEnum.nine:
					return 9;
				case model.Values.InnerEnum.ten:
					return 10;
				case model.Values.InnerEnum.jack:
					return 10;
				case model.Values.InnerEnum.queen:
					return 10;
				case model.Values.InnerEnum.king:
					return 10;
				case model.Values.InnerEnum.ace:
					return 11;
				default:
					return 0;
			}

		}
		/// 
		/// <param name="value">
		/// @return </param>
		public static Values getValue(int value)
		{
			switch (value)
			{
				case 1:
					return one;
				case 2:
					return two;
				case 3:
					return three;
				case 4:
					return four;
				case 5:
					return five;
				case 6:
					return six;
				case 7:
					return seven;
				case 8:
					return eight;
				case 9:
					return nine;
				case 10:
					return ten;
				case 11:
					return jack;
				case 12:
					return queen;
				case 13:
					return king;
				default:
					return ace;
			}
		}
	}
}