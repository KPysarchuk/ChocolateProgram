namespace Chocolates
{
    public class ChocolateStashes
    {
        public int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }

    public class Games
    {
        public static int GameOfChocolate(int n, ChocolateStashes[] stashes)
        {
            int val = 0;
            for (int i = 0; i < n; i++)
            {
                val ^= stashes[i].Quantity;
            }
            int answ = 0;
            for (int i = 0; i < n; i++)
            {
                if ((val ^ stashes[i].Quantity) < stashes[i].Quantity)
                {
                    answ++;
                }
            }
            return answ;
        }
    }
}