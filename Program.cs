Band band = new Band("band name");

Music music = new Music("music name", 217);

Album album = new Album("album name", new List<Music>() { music });

System.Console.WriteLine($"{album.Musics.Count}");
System.Console.WriteLine($"{album.DurationInSeconds}");

Music otherMusic = new Music("other music", 309);

album.AddMusic(otherMusic);

System.Console.WriteLine($"{album.Musics.Count}");
System.Console.WriteLine($"{album.DurationInSeconds}");
