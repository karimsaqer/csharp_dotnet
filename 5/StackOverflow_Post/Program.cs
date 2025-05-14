using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class StackOverflowPost
    {
        private string _title;
        private string _description;
        private DateTime _dateCreated;
        private int _votes;

        public string Title
        {
            get { return _title; }
            private set { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title is emppty");
                _title = value;
            }
        }
        public string Description
        {
            get { return _description; }
            private set { _description = value; }
        }
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            private set { _dateCreated = value; }
        }
        public int Votes
        {
            get { return _votes; }
            private set { _votes = value; }
        }
        public StackOverflowPost(string title, string description)
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
            Votes = 0;
        }
        public void Upvote()
        {
            Votes++;
        }
        public void Downvote()
        {
            Votes--;
        }
        public int GetCurrentVotes()
        {
            return Votes;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOverflowPost post = new StackOverflowPost("Classes C#", "hello!");
            do
            {
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Description: {post.Description}");
                Console.WriteLine($"Date Created: {post.DateCreated}");
                Console.WriteLine($"Current Votes: {post.GetCurrentVotes()}");
                Console.WriteLine("for Upvote press 1");
                Console.WriteLine("for Downvote press 2");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    post.Upvote();
                }
                else if (x == 2)
                {
                    post.Downvote();
                }
                else
                {
                    return;
                }
                Console.Clear();
            } while (true);
        }
    }
}
