using System;

namespace Stack_Over
{
    static void Main(string[] args)
    {
        var newPost = new Post
        {
            Title = "HELLO WORLD",
            Description = "This is some awesome hello world description."
        };

        Console.WriteLine(newPost.Title);
        Console.WriteLine(newPost.Description);
        Console.WriteLine(newPost.CreationDateTime);

        newPost.UpVote();
        newPost.UpVote();
        newPost.DownVote();

        Console.WriteLine("Number of votes: " + newPost.DisplayVotes());
    }
}
