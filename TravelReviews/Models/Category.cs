using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class Category
    {
        // properties
        [Key]

        public int ID { get; set; }

        [Display(Name="Category")]
        public string Name { get; set; }

        // navigation property
        public virtual ICollection<Review> Reviews { get; set; }
    }
}