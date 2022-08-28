using System.Collections.Generic;
using Godot;

namespace SET
{
    public class Deck
    {
        private List<CardProperties> _cards = new List<CardProperties>();

        public Deck()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            _cards.Add(new CardProperties(i, j, k, l));
                        }
                    }
                }
            }
        }

        public Card Draw()
        {
            int cardNumber = (int)GD.Randi() % _cards.Count;
            var card = _cards[cardNumber];
            _cards.RemoveAt(cardNumber);
            return new Card(card);
        }
    }
}