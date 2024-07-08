namespace BookApp.DataLayer.Models;


public class Tag
{
    public string TagId { get; set; }

    public ICollection<Book> Books { get; set; }    
}