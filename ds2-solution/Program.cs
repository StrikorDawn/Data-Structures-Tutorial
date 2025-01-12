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

    public void InsertSong(string songTitle, int position)
    {
        var newNode = new MusicNode(songTitle);

        if (position <= 0)
        {
            newNode.Right = _head;
            if (_head != null)
            {
                _head.Left = newNode;
            }
            _head = newNode;
            if (_tail == null)
            {
                _tail = newNode;
            }
            return;
        }

        var current = _head;
        for (int i = 0; i < position - 1 && current != null; i++)
        {
            current = current.Right;
        }

        if (current == null)
        {
            return;
        }

        newNode.Right = current.Right;
        newNode.Left = current;
        current.Right = newNode;
        if (newNode.Right != null)
        {
            newNode.Right.Left = newNode;
        }
        else
        {
            _tail = newNode;
        }
    }

    public void RemoveSong(string songTitle)
    {
        var current = _head;
        while (current != null)
        {
            if (current.SongTitle == songTitle)
            {
                if (current.Left != null)
                {
                    current.Left.Right = current.Right;
                }
                else
                {
                    _head = current.Right;
                }

                if (current.Right != null)
                {
                    current.Right.Left = current.Left;
                }
                else
                {
                    _tail = current.Left;
                }

                return;
            }
            current = current.Right;
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
            current = current.Right;
        }
    }

    public static void Main(string[] args)
    {
        var musicList = new MusicList();
        musicList.AddSongToPlaylist("Track 1");
        musicList.AddSongToPlaylist("Track 2");
        musicList.AddSongToPlaylist("Track 3");
        Console.WriteLine("Current Playlist:");
        musicList.PrintPlaylist();

        Console.WriteLine("Inserting a song at position 2:");
        musicList.InsertSong("Track 4", 2);
        musicList.PrintPlaylist();

        Console.WriteLine("Removing a song:");
        musicList.RemoveSong("Track 2");
        musicList.PrintPlaylist();
    }
}
