﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]//Does not allow NULL
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }
        public DateTime DateTimeItemReleased { get; set; }
    }
}
