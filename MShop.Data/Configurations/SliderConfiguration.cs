namespace MShop.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.ToTable("Sliders");//Table Name

            builder.HasKey(c => c.SliderId);//Key

            builder.Property(c => c.Header)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Content)
                   .IsRequired()
                   .HasMaxLength(250);

            builder.Property(c => c.Image)
                   .IsRequired();

            builder.Property(c => c.Sliderposition)//Main Right bottom
                .IsRequired()
                .HasMaxLength(10);

        }
    }
}
