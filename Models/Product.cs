namespace StaticPractice.Models
{

    public abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public string id { get => id; }

        public abstract int TotalnCome();
        //{
        //    Console.WriteLine(Price * Count);
        //}

        public abstract void Sell();

        public abstract void ShowInfo();
    }
}
