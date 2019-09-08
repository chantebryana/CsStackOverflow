using System;

namespace CsStackOverflow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public void Howdy()
        {
            Console.WriteLine("Howdy from the class.");
        }
    }

    class Program
    {
        static void Main()
        {
            var post = new Post();
            post.Howdy();
            post.Title = "Title 01";
            post.Description = "An insightful portrait of a developer as a young woman.";
            post.Created = DateTime.Now;
            Console.WriteLine("{0}: {1} - Created {2}", post.Title, post.Description, post.Created);

        }
    }
}
