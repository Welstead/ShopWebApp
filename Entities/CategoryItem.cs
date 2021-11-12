using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Entities
{
    public class CategoryItem
    {
        private DateTime _releaseDate = DateTime.MinValue;
        public int Id { get; set; }
        [Required]//Does not allow NULL
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please select a valid item from the '{0}' dropdown list")]
        [Display(Name = "Media Type")]
        public int MediaTypeId { get; set; }
        [NotMapped]//Won't update the property to the db migration
        public virtual ICollection<SelectListItem> MediaTypes { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Release date")]
        public DateTime DateTimeItemReleased { get { return (_releaseDate == DateTime.MinValue) ? DateTime.Now : _releaseDate; } set { _releaseDate = value; } }
        [NotMapped]
        public int ContentId { get; set; }
    }
}
