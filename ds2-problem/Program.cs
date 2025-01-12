using System;

public class MusicNode
{
    public string SongTitle { get; }
    public MusicNode Right { get; set; }
    public MusicNode Left { get; set; }

    public MusicNode(string songTitle)
    {
        SongTitle = songTitle;
        Right = null;
        Left = null;
    }
}

public class MusicList
{
    private MusicNode _head;
    private MusicNode _tail;

    public void AddSongToPlaylist(string songTitle)
    {
        var current = new MusicNode(songTitle);
        if (_head == null)
        {
            _head = current;
            _tail = current;
        }
        else
        {
            _tail.Right = current;
            current.Left = _tail;
            _tail = current;
        }
    }

    // TODO: Implement the InsertSong method
    public void InsertSong(string songTitle, int position)
    {
        // Your implementation here
    }

    // TODO: Implement the RemoveSong method
    public void RemoveSong(string songTitle)
    {
        // Your implementation here
    }

    public void PrintPlaylist()
    {
        if (_head == null)
            return;

        var current = _head;
        while (current != null)
        {
            Console.WriteLine($"{current.SongTitle}");
            current = current.Right;
        }
    }

    public static void Main(string[] args)
    {
        var musicList = new MusicList();
        //TODO: Create at least 2 additional test cases
        musicList.AddSongToPlaylist("Track 1");
        
        
        Console.WriteLine("Current Playlist:");
        musicList.PrintPlaylist();
        
        // TODO: After you have implemented the InsertSong function uncomment the code below.
        // Console.WriteLine("Inserting a song at position 2:");
        // musicList.InsertSong("Track 4", 2);
        // musicList.PrintPlaylist();

        // TODO: After you have implemented the RemoveSong function uncomment the code below.
        // Console.WriteLine("Removing a song:");
        // musicList.RemoveSong("Track 2");
        // musicList.PrintPlaylist();
    }
}
