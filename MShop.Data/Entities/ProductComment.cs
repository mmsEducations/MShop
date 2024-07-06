﻿namespace MShop.Data.Entities
{
    public class ProductComment
    {
        public int ProductCommentId { get; set; }
        public int ProductId { get; set; }
        public short Rating { get; set; }
        public string? Comment { get; set; }
        public required string CommenterName { get; set; }
        public required string CommenterEmail { get; set; }
        public required Product Product { get; set; }
    }

}


