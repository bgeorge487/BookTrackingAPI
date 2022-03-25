using BookTrackingAPI.DataObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoreDataController : ControllerBase
    {
        // GET: api/<CoreData>
        [HttpGet]
        public string SetCoreData()
        {
            try
            {
                BookTrackingContext context = new BookTrackingContext();

                Book newBook = new Book()
                {
                    ApiId = "B2qS_L7vJy4C",
                    Title = "One Shot",
                    Subtitle = "A Jack Reacher Novel",
                    PublishedDate = "2012",
                    Description = "Good story"
                };
                context.Add(newBook);

                Author author = new Author()
                {
                    ApiKey = "OL6793298A",
                    FullName = "Lee Child",
                    BirthDate = "1954"
                };
                context.Add(author);
                context.SaveChanges();
                int authorID = context.Authors.First().Id;
                int bookID = context.Books.First().Id;
                BooksAndAuthors relation = new BooksAndAuthors()
                {
                    AuthorId = authorID,
                    BookId = bookID
                };

                context.Add(relation);
                context.SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
