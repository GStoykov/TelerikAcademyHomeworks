using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count == 5)
            {
                return true;
            }
            return false;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool isFoundOfAKind = false;
            if (IsValidHand(hand))
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    var cardsFound = hand.Cards.ToList().FindAll(x => x.Face == hand.Cards[i].Face);
                    if (cardsFound.Count == 4)
                    {
                        isFoundOfAKind = true;
                        break;
                    }
                }

            }
            return isFoundOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = true;
            if (IsValidHand(hand))
            {
                CardSuit cardSuit = hand.Cards[0].Suit;
                for (int i = 1; i < hand.Cards.Count; i++)
                {
                    if (cardSuit != hand.Cards[i].Suit)
                    {
                        isFlush = false;
                        break;
                    }
                }
            }
            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
