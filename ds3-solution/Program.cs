using System;

public class SongNode
{
    // Song metadata
    public string Title;
    public string Artist;

    // Left and right children nodes
    public SongNode Left;
    public SongNode Right;

    // Constructor to initialize a new song node
    public SongNode(string title, string artist)
    {
        Title = title;
        Artist = artist;
        Left = null;
        Right = null;
    }
}

public class SongBinarySearchTree
{
    private SongNode root;

    // Constructor to initialize an empty BST
    public SongBinarySearchTree()
    {
        root = null;
    }

    // Method to insert a new song into the BST
    public void Insert(string title, string artist)
    {
        root = InsertRec(root, title, artist);
    }

    // Recursive helper method to insert a new song
    private SongNode InsertRec(SongNode root, string title, string artist)
    {
        // If the tree is empty, create a new node as the root
        if (root == null)
        {
            return new SongNode(title, artist);
        }

        // Compare the title of the new song with the title of the current node
        int compareResult = string.Compare(title, root.Title);

        // If the new song title comes before the current node's title, go left
        if (compareResult < 0)
        {
            root.Left = InsertRec(root.Left, title, artist);
        }
        // If the new song title comes after the current node's title, go right
        else if (compareResult > 0)
        {
            root.Right = InsertRec(root.Right, title, artist);
        }
        // If the titles are the same (considering case sensitivity), do not insert (assuming each song is unique)
        // You may choose to handle duplicates differently based on your requirements

        // Return the modified root
        return root;
    }

    // Method to search for a song by title
    public SongNode Search(string title)
    {
        return SearchRec(root, title);
    }

    // Recursive helper method to search for a song by title
    private SongNode SearchRec(SongNode root, string title)
    {
        // If the tree is empty or the title is not found, return null
        if (root == null || root.Title == title)
        {
            return root;
        }

        // Compare the title of the song with the title of the current node
        int compareResult = string.Compare(title, root.Title);

        // If the title of the song is smaller than the current node's title, search in the left subtree
        if (compareResult < 0)
        {
            return SearchRec(root.Left, title);
        }
        // If the title of the song is greater than the current node's title, search in the right subtree
        else
        {
            return SearchRec(root.Right, title);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the SongBinarySearchTree
        SongBinarySearchTree songBST = new SongBinarySearchTree();

        // Insert some sample songs
        songBST.Insert("Bohemian Rhapsody", "Queen");
        songBST.Insert("ABC", "The Jackson 5");
        songBST.Insert("Never Gonna Give You Up", "Rick Astley");
        songBST.Insert("Storm", "Jorge Riviera");
        songBST.Insert("Yesterday", "Imagine Dragons");

        // Search for a song by title
        string searchTitle = "Storm";
        SongNode foundSong = songBST.Search(searchTitle);

        // Display the result of the search
        if (foundSong != null)
        {
            Console.WriteLine($"Found song: {foundSong.Title} by {foundSong.Artist}");
        }
        else
        {
            Console.WriteLine($"Song '{searchTitle}' not found.");
        }
    }
}
