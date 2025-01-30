using System;

class Program
{
    static void Main(string[] args)
    {
   
        List<Video> _videos = new List<Video>();

        
        Comment c1 = new Comment();
        c1._text = "I love this video!";
        c1._commentorName = "RapidLearner";

        Comment c2 = new Comment();
        c2._text = "Thank you for the directions! It made my project so much easier.";
        c2._commentorName = "pie2quared";

        Comment c3 = new Comment();
        c3._text = "I don't know what you people are so excited about- I didn't understand anything in this video";
        c3._commentorName = "me2";

        Comment c4 = new Comment();
        c4._text = "Thank you. Can you go into more details for step 3?";
        c4._commentorName = "MNEmouse";

        Video v1 = new Video();
        v1._title = "DIY Paint Kitchen Cabinets";
        v1._author = "DIY DOROTHY";
        v1._length = 516;

        v1._comments.Add(c1);
        v1._comments.Add(c2);
        v1._comments.Add(c3);
        v1._comments.Add(c4);

        //v1.DisplayVideo();
        _videos.Add(v1);



        Comment c11 = new Comment();
        c11._text = "Aaaawwwweee- poor little thing! Why are you being so mean?";
        c11._commentorName = "flwrpwr";

        Comment c22 = new Comment();
        c22._text = "Hahahahaha! Do it again!";
        c22._commentorName = "boybrn";

        Comment c33 = new Comment();
        c33._text = "Wow, I can't believe I just wasted 4 min of my life watching that...";
        c33._commentorName = "Dan";

        Comment c44 = new Comment();
        c44._text = "That thing really thought he was free! Seriously, how many times is he going to try to get under the couch??";
        c44._commentorName = "mistermn";

        Video v2 = new Video();
        v2._title = "Hamster's First Time in Ball";
        v2._author = "Teeny Tim";
        v2._length = 252;

        v2._comments.Add(c11);
        v2._comments.Add(c22);
        v2._comments.Add(c33);
        v2._comments.Add(c44);

        //v2.DisplayVideo();
        _videos.Add(v2);



        Comment c51 = new Comment();
        c51._text = "I've wanted to go to Ireland since I was a kid. This just makes me want to go more.";
        c51._commentorName = "daviddrmr";

        Comment c52 = new Comment();
        c52._text = "I am surprising my wife with a trip to Ireland for our anniversary. Thank you for the itinerary and ideas! We will use them!";
        c52._commentorName = "Chad B.";

        Comment c53 = new Comment();
        c53._text = "Anybody else notice the guy in the background during the Dublin excerpt?? What EXACTLY was he doin'?";
        c53._commentorName = "Mattie";

        Video v3 = new Video();
        v3._title = "Touring: Ireland";
        v3._author = "Tyler's Travel Agency";
        v3._length = 767;

        v3._comments.Add(c51);
        v3._comments.Add(c52);
        v3._comments.Add(c53);
    
        //v3.DisplayVideo();
        _videos.Add(v3);

        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }



        
        // Video v3 = new Video();
        // Video v4 = new Video();

        

        //iterate through list of videos, foreach video: display title author
           //length number of comments(from method) and list out comments
    }
}