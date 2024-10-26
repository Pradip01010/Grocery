﻿using System.ComponentModel.DataAnnotations;

namespace Online_Grocery.Models
{
    public class Category
    {
        [Key] 
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
    }
}
