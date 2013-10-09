using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            if (this.Cards.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            foreach (ICard card in this.Cards)
            {
                sb.AppendFormat("{0} ", card.ToString());
            }
            sb.Length--;
            return sb.ToString();
        }
    }
}
