using modul6_103022330138;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Raffa");

        SayaTubeVideo vid1 = new SayaTubeVideo("Review Film Interstellar oleh Raffa");
        SayaTubeVideo vid2 = new SayaTubeVideo("Review Film Midsomar oleh Raffa");
        SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Hereditary oleh Raffa");
        SayaTubeVideo vid4 = new SayaTubeVideo("Review Film El Camino oleh Raffa");
        SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Parasite oleh Raffa");
        SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Arrival oleh Raffa");
        SayaTubeVideo vid7 = new SayaTubeVideo("Review Film Minecraft oleh Raffa");
        SayaTubeVideo vid8 = new SayaTubeVideo("Review Film NOPE oleh Raffa");
        SayaTubeVideo vid9 = new SayaTubeVideo("Review Film Get Out oleh Raffa");
        SayaTubeVideo vid10 = new SayaTubeVideo("Review Film US oleh Raffa");

        vid1.IncreasePlayCount(17823);
        vid2.IncreasePlayCount(91237);
        vid3.IncreasePlayCount(73843);
        vid4.IncreasePlayCount(89123);
        vid5.IncreasePlayCount(42376);
        vid6.IncreasePlayCount(37262);
        vid7.IncreasePlayCount(29239);
        vid8.IncreasePlayCount(59123);
        vid9.IncreasePlayCount(65142);
        vid10.IncreasePlayCount(11111);

        Console.WriteLine("Pengetesan method PrintVideoDetails()");
        vid6.PrintVideoDetails();

        user.AddVideo(vid1);
        user.AddVideo(vid2);
        user.AddVideo(vid3);
        user.AddVideo(vid4);
        user.AddVideo(vid5);
        user.AddVideo(vid6);
        user.AddVideo(vid7);
        user.AddVideo(vid8);
        user.AddVideo(vid9);
        user.AddVideo(vid10);

        Console.WriteLine("\nPengetesan method GetTotalVideoPlayCount()");
        Console.WriteLine("Total views : " + user.GetTotalVideoPlayCount());

        Console.WriteLine("\nPengetesan method PrintAllVideoPlaycount()");
        user.PrintAllVideoPlaycount();
    }
}