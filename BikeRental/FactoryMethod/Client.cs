using Domain.FactoryMethod;
using System;

namespace FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with ConcreteCreator1.");
            ClientMethod(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientMethod(new ConcreteCreator2());
        }

        public void ClientMethod(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n"
                              + creator.SomeOperation());
            // ...
        }
    }
}
