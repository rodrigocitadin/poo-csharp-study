class Album
{
    public Album(string name)
    {
       Name = name;
       Musics = new List<Music>();
    } 

    public string Name { get; }
    public List<Music> Musics { get; }
    // public int DurationInSeconds => Musics.Sum(m => m.DurationInSeconds);
}
