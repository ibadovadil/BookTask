namespace StaticPractice.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, int price, string authorname, int pagecount, int count)
        {
            Name = name;
            Price = price;
            AuthorName = authorname;
            PageCount = pagecount;
            Count = count;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book Name: {Name} , Price : {Price} , Author Name : {AuthorName} , Page Count : {PageCount} Count : {Count} ,  TotalnCome :{TotalnCome}");
        }
        public override void Sell()
        {

        }


        public override void TotalnCome()
        {
            Console.WriteLine(Price * Count);
        }
    }


}
