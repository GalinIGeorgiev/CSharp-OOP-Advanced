﻿using System;

namespace E05_CardCompareTo
{
    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.CardRank = rank;
            this.CardSuit = suit;
        }

        public CardRank CardRank { get; private set; }

        public CardSuit CardSuit { get; private set; }

        private int CardPower()
        {
            return (int)this.CardSuit + (int)this.CardRank + 1;
        }

        public int CompareTo(Card other)
        {
            return this.CardPower() - other.CardPower();
        }

        public override string ToString()
        {
            return $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {this.CardPower()}";
        }
    }
}
