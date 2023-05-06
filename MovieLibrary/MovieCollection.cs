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
        return true;
	}


	public bool Insert(IMovie movie)
	{
        // Insert a movie into this movie collection
        // Pre-condition: nil
        // Post-condition: if the movie was not in this movie collection,
		// the movie has been added into this movie collection,
		// new Number = old Number + 1 and return true; otherwise,
		// new Number = old Number and return false.
        return true;
    }




	public bool Delete(IMovie movie)
	{
        // Delete a movie from this movie collection
        // Pre-condition: nil
        // Post-condition: if the movie was in this movie collection,
		// the movie has been removed out of this movie collection,
		// new Number - old Number - 1 and return true; otherwise,
		// return false and this movie collection remains unchanged and
		// new Number = old Number.
        return true;
    }



	public IMovie? Search(string movietitle)
	{
        // Search for a movie by its title in this movie collection  
        // pre: nil
        // post: return the reference of the movie object if the
		//		 movie is in this movie collection;
        //	     otherwise, return null. New Number = old Number.
        return null;
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





