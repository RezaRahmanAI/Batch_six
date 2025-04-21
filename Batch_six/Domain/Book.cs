namespace Batch_six.Domain
{
    public class Book: BaseModel
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int CopiesAvailable { get; set; }
            public int TotalCopies { get; set; }
        }

    }

