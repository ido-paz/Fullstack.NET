class Program
{
    static void Main()
    {
        // Demo1();
        // Demo2();
        Demo3();
    }

    static void Demo3()
    {
        MusicPlayer[] mps = new MusicPlayer[]
        {
             new IPOD(),
             new MusicPlayer(),
             new IPOD(),
             new Spotify()
        };
        foreach (var item in mps)
        {
            item.Play();
        }
    }
    static void Demo2()
    {
        MusicPlayer mp = new MusicPlayer();
        MusicPlayer ipod = new IPOD();
        MusicPlayer sp = new Spotify();
        //
        mp.Play();
        ipod.Play();
        sp.Play();
    }
    static void Demo1()
    {
        MusicPlayer mp = new MusicPlayer();
        Spotify sp = new Spotify();
        IPOD ipod = new IPOD();
        //
        mp.Play();
        sp.Play();
        ipod.Play();
    }
}

