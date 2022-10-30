class MusicPlayer
{
    public virtual void Play()
    {
        System.Console.WriteLine("MusicPlayer Play");
    }
}
class IPOD : MusicPlayer
{
    public override void Play()
    {
        System.Console.WriteLine("IPOD Play");
    }
}
class Spotify : MusicPlayer
{
    public new void Play()
    {
        System.Console.WriteLine("Spotify Play");
    }
}