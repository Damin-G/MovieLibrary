// CAB301 - assignment 2
// An implementation of MovieCollection ADT
// 2023


using System;

//A class that models a node of a binary search tree
//An instance of this class is a node in the binary search tree
public class BTreeNode
{
	private IMovie movie; // movie
	private BTreeNode? lchild; // reference to its left child
	private BTreeNode? rchild; // reference to its right child

	public BTreeNode(IMovie movie)
	{
		this.movie = movie;
		lchild = null;
		rchild = null;
	}

	public IMovie Movie
	{
		get { return movie; }
		set { movie = value; }
	}

	public BTreeNode? LChild
	{
		get { return lchild; }
		set { lchild = value; }
	}

	public BTreeNode? RChild
	{
		get { return rchild; }
		set { rchild = value; }
	}
}

// invariant: no duplicate movie in this movie collection
public class MovieCollection : IMovieCollection
{
    private BTreeNode? root; // the root of the binary search tree in which movies are stored 
    private int count; // the number of movies currently stored in this movie collection 

    public int Number { get { return count; } }

    // constructor - create an empty movie collection
    public MovieCollection()
    {
        root = null;
        count = 0;
    }

    public bool IsEmpty()
    {
        // Check if this movie collection is empty
        // Pre-condition: nil
        // Post-condition: return true if this movie collection is empty; otherwise,
        // return false. This movie collection remains unchanged and new
        // Number = old Number

        // Get total number of dvd's in the collection
        int num_Dvds = NoDVDs();

        if (num_Dvds == 0) { return true; }

        return false;
    }

    public bool Insert(IMovie movie)
    {
        // Check if the movie is already in the collection
        if (Search(movie.Title) != null)
        {
            return false;
        }

        // If the tree is empty, insert the movie as the root
        if (root == null)
        {
            root = new BTreeNode(movie);
            count++;
            return true;
        }

        // Otherwise, call the recursive helper method to insert the movie
        return InsertHelper(root, movie);
    }

    private bool InsertHelper(BTreeNode currentNode, IMovie movie)
    {
        int comparison = string.Compare(movie.Title, currentNode.Movie.Title);

        // If the new movie title is smaller, go left
        if (comparison < 0)
        {
            if (currentNode.LChild == null)
            {
                currentNode.LChild = new BTreeNode(movie);
                count++;
                return true;
            }
            else
            {
                return InsertHelper(currentNode.LChild, movie);
            }
        }
        // If the new movie title is larger, go right
        else if (comparison > 0)
        {
            if (currentNode.RChild == null)
            {
                currentNode.RChild = new BTreeNode(movie);
                count++;
                return true;
            }
            else
            {
                return InsertHelper(currentNode.RChild, movie);
            }
        }

        // If the movie titles are equal, the movie is already in the collection
        return false;
    }

    public bool Delete(IMovie movie)
    {
        // Call the recursive helper function to delete the movie by its title
        int initialCount = count;
        BTreeNode 
        DeleteHelper(root, movie.Title);
        return count < initialCount;
    }

    private BTreeNode? DeleteHelper(BTreeNode? currentNode, string movietitle)
    {
        // Base case: if the current node is null, the movie is not in the collection
        if (currentNode == null)
        {
            return null;
        }

        // Compare the movie title with the current node's movie title
        int comparison = string.Compare(movietitle, currentNode.Movie.Title);

        // If the movie title is smaller, search in the left subtree
        if (comparison < 0)
        {
            currentNode.LChild = DeleteHelper(currentNode.LChild, movietitle);
        }
        // If the movie title is larger, search in the right subtree
        else if (comparison > 0)
        {
            currentNode.RChild = DeleteHelper(currentNode.RChild, movietitle);
        }
        // If the movie titles are equal, the movie is found and needs to be deleted
        else
        {
            // Case 1: Node is a leaf
            if (currentNode.LChild == null && currentNode.RChild == null)
            {
                count--;
                return null;
            }

            // Case 2: Node with only one child
            if (currentNode.LChild == null)
            {
                count--;
                return currentNode.RChild;
            }
            else if (currentNode.RChild == null)
            {
                count--;
                return currentNode.LChild;
            }

            // Case 3: Node with two children
            // Get the inorder successor (smallest in the right subtree)
            currentNode.Movie = MinValue(currentNode.RChild);

            // Delete the inorder successor
            currentNode.RChild = DeleteHelper(currentNode.RChild, currentNode.Movie.Title);
        }
        return currentNode;
    }

    private IMovie MinValue(BTreeNode? node)
    {
        IMovie minValue = node.Movie;
        while (node.LChild != null)
        {
            minValue = node.LChild.Movie;
            node = node.LChild;
        }
        return minValue;
    }


    public IMovie? Search(string movietitle)
    {
        // Call the recursive helper function to search for the movie by its title
        return SearchHelper(root, movietitle);
    }

    private IMovie? SearchHelper(BTreeNode? currentNode, string movietitle)
    {
        // Base case: if the current node is null, the movie is not in the collection
        if (currentNode == null)
        {
            return null;
        }

        // Compare the movie title with the current node's movie title
        int comparison = string.Compare(movietitle, currentNode.Movie.Title);

        // If the movie title is smaller, search in the left subtree
        if (comparison < 0)
        {
            return SearchHelper(currentNode.LChild, movietitle);
        }
        // If the movie title is larger, search in the right subtree
        else if (comparison > 0)
        {
            return SearchHelper(currentNode.RChild, movietitle);
        }
        // If the movie titles are equal, the movie is found
        else
        {
            return currentNode.Movie;
        }
    }


    public int NoDVDs()
    {
        // Calculate the totall number of DVDs in this movie collection 
        // Pre-condition: nil
        // Post-condition: return the total number of DVDs in this movie collection.
        // this moive collection remains unchanged, and new Number = old Number.
        return 0;
    }

    public IMovie[] ToArray()
    {
        // Return an array that contains all the movies in this movie collection and
        // the movies in the array are sorted in the dictionary order by movie title
        // Pre-condition: nil
        // Post-condition: return an array of movies that are stored in dictionary
        // order by their titles, this movie collection remains unchanged and
        // new Number = old Number.
        return new IMovie[0];

    }

    public void Clear()
    {
        // Clear this movie collection
        // Pre-condotion: nil
        // Post-condition: all the movies in this movie collection have been removed
        // from this movie collection and new Number = 0. 

    }
}