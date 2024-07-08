namespace BookApp.DataLayer.Models;


public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }


    //> Navegational Properties:
    public ICollection<BookAuthor> BooksLink { get; set; }  
}