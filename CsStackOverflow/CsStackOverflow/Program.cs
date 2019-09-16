using System;

namespace CsStackOverflow
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes;

        public Post()
        {
        }

        public void NewPost (string titulo, string body)
        {
            _title = titulo;
            _description = body;
            _created = DateTime.Now;
        }
        public void printPost()
        {
            Console.WriteLine("\n{0}:\n{1}\n- Created: {2}", _title, _description, _created);
        }
        public void printVote()
        {
            Console.WriteLine("Current Vote Value: {0}\n", _votes);
        }
        public void Vote(Boolean upVote)
        {
            if (upVote == true)
            {
                _votes++;
            }
            else if (upVote == false)
            {
                _votes--;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var post = new Post();
            Console.WriteLine("Enter Post Title: ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter Post Description: ");
            var b = Console.ReadLine();
            post.NewPost(a, b);
            post.printPost();
            Console.WriteLine("\n");
            while (true) {
                Console.WriteLine("Type 'upvote', 'downvote', 'print', or 'close':");
                var userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "upvote")
                {
                    post.Vote(true);
                }
                else if (userInput == "downvote")
                {
                    post.Vote(false);
                }
                else if (userInput == "close")
                {
                    Console.WriteLine("Closing...\n");
                    break;
                }
                else if (userInput == "print")
                {
                    post.printPost();
                    post.printVote();
                }
                else
                {
                    Console.WriteLine("'{0}' is an invalid selection. Try again.\n", userInput);
                }
            }
        }
    }
}
