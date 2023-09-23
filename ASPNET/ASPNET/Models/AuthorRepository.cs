using Microsoft.AspNetCore.Authorization.Policy;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ASPNET.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionay()
        {
            string fName = @"C:\temp\Author.csv";
            Dictionary<int, Author>list=new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName)) 
                {
                    String strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Id, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data=strAuthor.Split(',');
                            if(data.Length== 5){
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Id, author);
                            }
                        }
                    }

                    }

                }
                return list;
            }
        public static Author FindAuthor (int id)
        {
            return new Author();
        }
        public static Author  FindAuthorById(int Id)
        {
            Dictionary<int, Author>list=AuthorRepository.GetAuthorDictionay();
            Author author = null;
            if (list != null)
            {
                author=list.FirstOrDefault(x=>(x.Key==Id)).Value;
            }
            return author;
        }
        public static void UpdateAuthorToFile(Author pauthor)
        {
            String fName = @"C:\temp\Author.csv";
            Dictionary<int, Author>list = AuthorRepository.GetAuthorDictionay();
            string strAuthor=String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.Id != pauthor.Id)
                        strAuthor = $"{author.Id},{author.AuthorName},{author.RoyaltyCompany},{author.NumberofBooks}";
                    else
                        strAuthor = $"{pauthor.Id},{pauthor.AuthorName},{pauthor.RoyaltyCompany},{pauthor.NumberofBooks}";
                    sw.WriteLine(strAuthor);
                }
            }
        }
        public static void RemoveAuthor(int Id)
        {
            String fName = @"C:\temp\Author.txt";
            Dictionary<int, Author>list= AuthorRepository.GetAuthorDictionay();
            StringBuilder sbAuthors=new StringBuilder(list.Count+100);

            foreach(Author author in list.Values)
            {
                if (author.Id != Id)
                {
                    sbAuthors.Append($"{author.Id},{author.AuthorName},{author.RoyaltyCompany},{author.NumberofBooks}"+
                        $"{author.AuthorName}{Environment.NewLine}");
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
        public static  void SaveToFile(Author pAuthor)
        {
            String fName = @"C:\temp\Author.csv";
            string strAuthor = $"{pAuthor.Id},{pAuthor.AuthorName},{pAuthor.RoyaltyCompany},{pAuthor.NumberofBooks}";
            using (StreamWriter sw= new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        } 
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.Id = int.Parse(data[0]);
            author.NumberofBooks = float.Parse(data[1]);
            author.AuthorName = data[2];
            author.RoyaltyCompany = data[3];
            author.AuthorDob = DateOnly.Parse(data[4]);
            return author;
        }
        public static void DeleteAuthor (int id) { }
        public static void SaveAllAuthorToFile(Dictionary<int, Author> authorDic)
        {
            string fName = @"C:\temp\Author.csv";
            string strauthor = $"";
        }
        }
    }
