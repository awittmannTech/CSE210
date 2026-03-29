using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("How to make a sandwich pt 1/3", "Sandwich Master", 90);
        Video vid2 = new Video("How to make a sandwich pt 2/3", "Sandwich Master", 60);
        Video vid3 = new Video("How to make a sandwich pt 3/3", "Sandwich Master", 60);

        Comment comment1 = new Comment("Confused Guy", "I am confused...");
        Comment comment2 = new Comment("Confused Guy", "I still don't understand...");
        Comment comment3 = new Comment("Confused Guy", "I got it! Thank you so much!");
        vid1.AddComment(comment1);
        vid1.AddComment(comment2);
        vid1.AddComment(comment3);

        Comment comment4 = new Comment("Home Cook", "This step-by-step is super clear.");
        Comment comment5 = new Comment("Home Cook", "I added cheese and it was awesome.");
        Comment comment6 = new Comment("Home Cook", "Toasting tip made a huge difference.");
        vid2.AddComment(comment4);
        vid2.AddComment(comment5);
        vid2.AddComment(comment6);

        Comment comment7 = new Comment("Student", "Final result looked delicious.");
        Comment comment8 = new Comment("Student", "Made this for lunch and loved it.");
        Comment comment9 = new Comment("Student", "Thanks for the full series!");
        vid3.AddComment(comment7);
        vid3.AddComment(comment8);
        vid3.AddComment(comment9);

        List<Video> videos = new List<Video> { vid1, vid2, vid3 };

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                comment.Display();
            }

            Console.WriteLine();
        }
    }
}