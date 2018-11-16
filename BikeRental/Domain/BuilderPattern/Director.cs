namespace Domain.BuilderPattern
{
    public class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void buildMinimalViableProduct()
        {
            builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
