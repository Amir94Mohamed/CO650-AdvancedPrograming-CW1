using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Amir Mohamed
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        /// <summary>
        /// Using abstaction to create a public const for auther credit & private readonly list to create a list. 
        /// </summary>
        public const string AUTHOR = "Amir";

        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            Console.WriteLine();
            MessagePost post = new MessagePost(AUTHOR, "Testing posts");
            AddMessagePost(post);

            Console.WriteLine();
            PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Image 1 TESTING");
            AddPhotoPost(photoPost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            message.Id = posts.Count + 1;
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photo.Id = posts.Count + 1;
            posts.Add(photo);
        }

        /// <summary>
        /// Liking a post 
        /// </summary>
        public void LikePost(Post post)
        {
            foreach (var currentPost in posts)
            {
                if (currentPost.Id == post.Id)
                    currentPost.Like();
            }

        }

        /// <summary>
        /// Unliking a post
        /// </summary>
        public void UnlikePost(Post post)
        {
            foreach (var currentPost in posts)
            {
                if (currentPost.Id == post.Id)
                    currentPost.Unlike();
            }
        }


        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();
                Console.WriteLine();
            }
        }


        /// <summary>
        /// Gets the list of posts
        /// </summary>
        public List<Post> GetPosts()
        {
            return posts;
        }

    }

}
