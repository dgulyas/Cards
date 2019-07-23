using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
	public class Card
	{

		public Card Clone()
		{
			return new Card();
		}

	    public delegate int Effect(Board board); //For when a card has a single onetime effect. Non-permanent.
	    public delegate int Setup(Board board); //For when a card is a permanent. Adds events to the event queue.
	    public delegate int TearDown(Board board); //For when a card is a permanent. Removed events it added to the event queue.
    }
}
