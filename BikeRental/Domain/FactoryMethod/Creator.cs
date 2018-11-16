namespace Domain.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: The same's creator code has just worked with" + product.Operation();

            return result;
        }
    }
}
