Band band = new Band("band name");

Music music = new Music("music name", 217, band);

Album album = new Album("album name", new List<Music>() { music });
