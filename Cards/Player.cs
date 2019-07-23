using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards
{
	public class Player
	{
		private static Random rng = new Random();

		private List<Card> Hand;
		private List<Card> Deck; //The pile of cards being played with, can contain temporary cards
		private List<Card> DeckList; //The cards in your deck;

		public int MaxHP;
		public int MaxMP;
		public int StartingArmor;
		public int NumCardsPerTurn;
		public int HP;
		public int MP;
		public int Armour;

		public Player()
		{
			Hand = new List<Card>();
			Deck = new List<Card>();

			HP = MaxHP;
			MP = MaxMP;
			Armour = StartingArmor;
		}

		public void StartGame()
		{
			Hand = new List<Card>();
			LoadDeckFromDeckList();
			Shuffle(Deck);
		}

		public void LoadDeckFromDeckList()
		{
			foreach (var card in DeckList)
			{
				Deck.Add(card.Clone());
			}
		}

		public static void Shuffle(List<Card> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				Card value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public void StartTurn()
		{

		}



	}

}
