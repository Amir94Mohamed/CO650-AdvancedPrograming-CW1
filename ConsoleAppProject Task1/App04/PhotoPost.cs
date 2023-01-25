using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Amir Mohamed
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {

        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   
        

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// The username of the author of this post.
        /// </param>
        /// A caption for the image.
        /// </param>
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;

        }

        /// <summary>
        /// This method overrides the display method to ensure its the correct one for a photo or a message post.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("PhotoPost Display Method");
            Console.WriteLine($" Filename: {Filename}");
            Console.WriteLine($" Caption: {Caption}");

            base.Display();
        }

    }
}
