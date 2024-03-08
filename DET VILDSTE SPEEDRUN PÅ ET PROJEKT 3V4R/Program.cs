namespace DET_VILDSTE_SPEEDRUN_PÅ_ET_PROJEKT_3V4R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.AddJokerTolist();

            Console.WriteLine(deck);

            deck.Shuffle();

            Console.WriteLine(deck);
            Console.ReadKey();
        }
    }
}
