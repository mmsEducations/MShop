namespace MShop.Data.Entities
{
    public class Slider : BaseEntity
    {
        public int SliderId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        //[NotMapped]
        public required string Sliderposition { get; set; }//Main,Right,Bottom
    }

}


