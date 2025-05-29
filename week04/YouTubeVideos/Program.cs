using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video = new Video();
        Video video1 = new Video();
        Video video2 = new Video();

        video.setComments("hi i like to code", "bob", "hello", "steve", "whats up", "joe");
        video1.setComments("i love spanish", "bob", "hello", "steve", "whats up", "joe");
        video2.setComments("minecraft is awesome", "bob", "hello", "steve", "whats up", "joe");

        video.setVideoDetails("robert", "how to write code", 120);
        video1.setVideoDetails("joseph", "why you should learn spanish", 20);
        video2.setVideoDetails("bryce", "minecraft movie", 160);

        video.displayVideo();
        video1.displayVideo();
        video2.displayVideo();

    }
}