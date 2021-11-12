﻿using ShopWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Entities
{
    public class MediaType : IPrimaryPoperties
    {
        public int Id { get; set; }
        [Required]//Does not allow NULL
        [StringLength(200, MinimumLength = 2)]

        public string Title { get; set; }

        [Required]
        [Display(Name = "Thumbnail Image Path")]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
