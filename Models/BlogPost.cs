using System;
namespace ChefsBlog.Models
{
    public class BlogPost
    {
        public string Title
        { get; set; }

        public DateTime Date
        { get; set; }

        public string Body
        { get; set; }

        public BlogPost(string title, DateTime date, string body)
        {
            Title = title;
            Date = date;
            Body = body;
        }
    }
}
