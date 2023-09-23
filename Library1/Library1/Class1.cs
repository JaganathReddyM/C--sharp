namespace Library1
{
    public class Book
    {
        public String Title=String.Empty;
        public String Author=String.Empty;
        public String Genre=String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages=300;
        public Book()
        {
            Console.WriteLine("Book obj is created");
        }
        public void Openbook()
        {
            Console.WriteLine("Book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No: {pageNo} Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r=new Random();
            return r.Next(TotalPages);
        }
    }
}