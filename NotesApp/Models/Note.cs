using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        public int Id { get; set; } // Unique identifier (primary key)
        int size = 30; //previewText length
        [Required] // Title is required
        [StringLength(50)] // Limit the title to 100 characters
        public string Title { get; set; }

        [Required] // Content is required
        public string Content { get; set; }

        public string PreviewText
        {
            get{
                if (Content.Length > size)
                {
                    return Content.Substring(0,size) + "...";
                }
                else 
                { 
                    return Content; 
                }
            }
        }
    }
}
