using System;

public class MusicNode
{
    public string SongTitle { get; set; }
    public MusicNode Next { get; set; }

    public MusicNode(string songTitle)
    {
        SongTitle = songTitle;
        Next = null;
    }
}

public class MusicList
{
    private MusicNode _head;

    public void AddSongToPlaylist(string songTitle)
    {
        if (_head == null)
            _head = new MusicNode(songTitle);
        else
        {
            var current = _head;
            while (current.Next != null)
                current = current.Next;
            current.Next = new MusicNode(songTitle);
        }
    }

    public void PrintPlaylist()
    {
        if (_head == null)
            return;

        var current = _head;
        while (current != null)
        {
            Console.WriteLine($"{current.SongTitle}");
            current = current.Next;
        }
    }

    public static void Main(string[] args)
    {
        var musicList = new MusicList();
        musicList.AddSongToPlaylist("Track 1");
        musicList.AddSongToPlaylist("Track 2");
        musicList.AddSongToPlaylist("Track 3");
        musicList.PrintPlaylist();
    }
}