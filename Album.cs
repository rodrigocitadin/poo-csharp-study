class Album
{
    public Album(string name, List<Music> musics)
    {
       Name = name;
       Musics = musics;
    } 

    public string Name { get; }
    public List<Music> Musics { get; }
    public int DurationInSeconds => Musics.Sum(m => m.DurationInSeconds);
    public Band Band => Musics[0].Band;
}
