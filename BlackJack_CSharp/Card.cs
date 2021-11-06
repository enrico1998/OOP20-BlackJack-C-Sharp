namespace model
{
	/// 
	/// <summary>
	/// @author bon98
	/// 
	/// </summary>
	public interface Card
	{
		/// 
		/// <summary>
		/// @return
		/// </summary>
		Suit Suit {get;}
		/// 
		/// <summary>
		/// @return
		/// </summary>
		Values Values {get;}
		/// 
		/// <param name="values"> </param>
		Values AceOrNot {set;}

	}
}