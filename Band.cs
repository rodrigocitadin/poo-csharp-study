class Band
{
    public Band(string name)
    {
        Name = name;
        Albums = new List<Album>();
    }

    public string Name { get; }
    public List<Album> Albums { get; }
}
