namespace MShop.Data.Entities
{
    //[Table("Categories")]
    public class Category
    {
        //[Key]
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }

        //[Required]
        //[MaxLength(100)]
        public required string CategoryName { get; set; }

        public string? Image { get; set; }

        public int? Order { get; set; }
    }
}


