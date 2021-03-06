using System;
using System.Collections.Generic;



namespace MiniVille
{
	public class Pile
	{
		public List<Card> Cards { get; private set; }
		public Pile()
		{
			this.Cards = new List<Card>();
		}
		private void BuildDeck(List<Card> p)
		{
			foreach (Utils.CardName cName in Enum.GetValues(typeof(Utils.CardName)))
			{
				p.Add(new Card(cName, 6));
			}
		}
	}
}

