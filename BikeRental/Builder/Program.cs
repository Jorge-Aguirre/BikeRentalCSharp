using BuilderPattern;
using Domain.BuilderPattern;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);

            Client client = new Client();
            client.ClientCode(director, builder);
        }
    }
}
