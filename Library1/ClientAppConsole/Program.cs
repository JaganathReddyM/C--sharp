// See https://aka.ms/new-console-template for more information

using Library1;

Book book = new Book();
book.Title = "To kill a Mocking Bird";
book.Author = "Harper Lee";
book.Genre = "Social";
book.BookPrice = 200;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookmarkPage(125);
Console.WriteLine(book.GetCurrentPage());
Calculater calculater = new Calculater();
int addResult = calculater.Add(100, 40);
Console.WriteLine(addResult);
int multiplyResult = calculater.Multiply(100, 40);
Console.WriteLine(multiplyResult);
int divideResult = calculater.Divide(100, 40);
Console.WriteLine(divideResult);
