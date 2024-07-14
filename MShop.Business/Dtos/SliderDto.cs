namespace MShop.Business.Dtos
{
    public class SliderDto//SliderModel
    {
        public int SliderId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        public required string Sliderposition { get; set; }//Main,Right,Bottom
        public int? Order { get; set; }
    }
}
