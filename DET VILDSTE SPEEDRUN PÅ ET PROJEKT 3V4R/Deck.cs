using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DET_VILDSTE_SPEEDRUN_PÅ_ET_PROJEKT_3V4R
{
    public class Deck
    {
        private int _id = 0 ;
        private static int _idcounter;
        Random _random = new Random();
        //Dictionary<string, Deck> deck1 = new Dictionary<string, Deck>();
        List<Card> _cards = new List<Card>()
        {
            new Card ("Roder Es") ,
            new Card ("Roder 2") ,
            new Card ("Roder 3") ,
            new Card ("Roder 4") ,
            new Card ("Roder 5") ,
            new Card ("Roder 6") ,
            new Card ("Roder 7") ,
            new Card ("Roder 8") ,
            new Card ("Roder 9") ,
            new Card ("Roder 10") ,
            new Card ("Roder Knægt") ,
            new Card ("Roder Dronning") ,
            new Card ("Roder Konge") ,
            new Card ("klør Es") ,
            new Card ("klør 2") ,
            new Card ("klør 3") ,
            new Card ("klør 4") ,
            new Card ("klør 5") ,
            new Card ("klør 6") ,
            new Card ("klør 7") ,
            new Card ("klør 8") ,
            new Card ("klør 9") ,
            new Card ("klør 10") ,
            new Card ("klør Knægt") ,
            new Card ("klør Dronning") ,
            new Card ("klør Konge") ,
            new Card ("Spar Es") ,
            new Card ("Spar 2") ,
            new Card ("Spar 3") ,
            new Card ("Spar 4") ,
            new Card ("Spar 5") ,
            new Card ("Spar 6") ,
            new Card ("Spar 7") ,
            new Card ("Spar 8") ,
            new Card ("Spar 9") ,
            new Card ("Spar 10") ,
            new Card ("Spar Knægt") ,
            new Card ("Spar Dronning") ,
            new Card ("Spar Konge") ,
            new Card ("Hjerter Es") ,
            new Card ("Hjerter 2") ,
            new Card ("Hjerter 3") ,
            new Card ("Hjerter 4") ,
            new Card ("Hjerter 5") ,
            new Card ("Hjerter 6") ,
            new Card ("Hjerter 7") ,
            new Card ("Hjerter 8") ,
            new Card ("Hjerter 9") ,
            new Card ("Hjerter 10") ,
            new Card ("Hjerter Knægt") ,
            new Card ("Hjerter Dronning") ,
            new Card ("Hjerter Konge") ,
        };


        public Deck()
        {
            
        _id = ++ _idcounter;
        }
        public int iD
        {
            get { return _id; }
        }
        public List<Card>  cards
        {
            get { return _cards; }
 
        }


        public void AddJokerTolist()
        {
            _cards.Add(new Card("joker1"));
            _cards.Add(new Card("joker2"));
            _cards.Add(new Card("joker3"));

        }
        public List<Card> Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int k = _random.Next(i + 1);
                var value = cards[k];
                cards[k] = cards[i];
                cards[i] = value;
            }
            return cards;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Card cards in _cards)
            {
                sb.AppendLine(cards.ToString());
            }
            sb.AppendLine("");

            return sb.ToString();

        }
    }
}
