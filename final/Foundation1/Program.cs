using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        // the videos:
        Video video1 = new Video("Tesla Cybertruck Review: Already Iconic?", "Marques Brownlee", 1643);
        video1.AddComment("@bigBlitz2001", "Being iconic doesn't require it to be rare.");
        video1.AddComment("@xX.nerd.Xx", "Imagine going on the highway and seeing an unrendered car");
        video1.AddComment("@roseyournose", "Marques wearing an official German frisbee team jersey at 15:16 was the most random thing ever");
        videos.Add(video1);

        Video video2 = new Video("Moist Meter | Godzilla x Kong New Empire", "penguinz0", 588);
        video2.AddComment("@rickyrackey7930", "Godzilla has to be the most versatile character in fiction.");
        video2.AddComment("@JitteryJackanape", "Godzilla busting out a literal suplex was the most hype **** ever");
        video2.AddComment("@omega5159", "Japan : Godzilla Minus One --- Hollywood: Godzilla Plus One");
        videos.Add(video2);

        Video video3 = new Video("BOOM BEATS BRAIN IT ON (TIK TOK STREAM)", "Boomgonza", 4549);
        video3.AddComment("@mikewazowski6292", "“A little duckling of fluff and victory.” -boomghandi");
        video3.AddComment("@Blueglaive", "Boom didn't said the wrong game, he was speaking on behalf of his future self.");
        video3.AddComment("@aBowlofbeans", "Einstein wishes he was him");
        videos.Add(video3);


        foreach (var video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"   {comment.Name}: '{comment.Text}'");
            }
            Console.WriteLine();
        }
    }

}