class Program
{
    static void Main()
    {
        IPlayer[] players = new IPlayer[]{
            new Spotify(),
            new Video(),
            new CD()
        };
        // foreach (var player in players)
        // {
        //     player.Start();
        //     player.Stop();
        // }

        StartAll(players);
        StopAll(players);
    }

    static void StartAll(IPlayer[] ps)
    {
        foreach (var item in ps)
        {
            if(item is IPower)
            {
                ((IPower)item).On();
            }
            item.Start();
        }
    }

    static void StopAll(IPlayer[] ps)
    {
        foreach (var item in ps)
        {
            item.Stop();
        }
    }
}

interface IPlayer
{
    void Start();
    void Stop();
}

interface IPower
{
    void On();
    void Off();
}

class Spotify : IPlayer, IPower
{
    public void Start()
    {
        System.Console.WriteLine("Spotify start");
    }
    public void Stop()
    {
        System.Console.WriteLine("Spotify stop");
    }

    public void On()
    {
        System.Console.WriteLine("Spotify On");
    }
    public void Off()
    {
        System.Console.WriteLine("Spotify Off");
    }
}


class CD : IPlayer
{
    public void Start()
    {
        System.Console.WriteLine("CD start");
    }
    public void Stop()
    {
        System.Console.WriteLine("CD stop");
    }
}


class Video : IPlayer
{
    public void Start()
    {
        System.Console.WriteLine("Video start");
    }
    public void Stop()
    {
        System.Console.WriteLine("Video stop");
    }
}