﻿namespace MShop.Data.Entities
{
    public class ProductComment : BaseEntity
    {
        public int ProductCommentId { get; set; }
        public int ProductId { get; set; }
        public short Rating { get; set; }
        public string? Comment { get; set; }
        public required string CommenterName { get; set; }
        public required string CommenterEmail { get; set; }
        public Product Product { get; set; }
    }

}


