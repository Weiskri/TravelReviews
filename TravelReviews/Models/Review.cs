using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class Review
    {
        // properties
        [Key]
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        [Display(Name = "Comments")]
        public string Content { get; set; }
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PublishedDate { get; set; }
        [Display(Name = "Would Recommend")]
        public bool Recommended { get; set; }

        // foreign keys and navigation properties
        [ForeignKey("Category"), Display(Name = "Category")] // changing foreignkey display to "Category" instead of CategoryID
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}