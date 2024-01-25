
var book = new Book("C#", "Андерс Хейлсберг", 2015);
System.Console.WriteLine(book.GetInfo());
System.Console.WriteLine(book. IsPublishedRecently());
public class Book
{
    public string title;
    public string author;
    public int year;

    public  Book(string lasttitle, string lastauthor, int lastyear)
    {
        title=lasttitle;
        author=lastauthor;
        year=lastyear;
    }
    public string  GetInfo()
    {
        return $"{title} {author} {year}";
    }
    public string IsPublishedRecently()
    {
        if(year>2010)
        {
           return "true";
        }
        else{
            return "false";
        }
    }
}