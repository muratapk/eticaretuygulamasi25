﻿using System.ComponentModel.DataAnnotations;

namespace eticaretuygulamasi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductNumber { get; set; }
        public float ProductPrice { get; set; }
        public string  ProductPicture { get; set; }
        public  int  CategoryId  { get; set; }
        public virtual Category Category { get; set; }
    }
}
