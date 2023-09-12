class Music
{
    public Music(string name, int durationInSeconds, Band band)
    {
        Name = name;
        DurationInSeconds = durationInSeconds;
        Band = band;
    }

    public string Name { get; }
    public int DurationInSeconds { get; }
    public Band Band { get; }
}
