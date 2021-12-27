using System;

namespace Test6
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl1 = new Client("Jon");
            var cl2 = new Client("Bob");
            var cl3 = new Client("Whill");
            var cl4 = new Client("Mary");
            var cl5 = new Client("Brook");

            var base1 = new ClientBase<Client>();

            base1.Create(cl1);
            base1.Create(cl2);
            base1.Create(cl3);

            base1.Update("Jon");

            var a = base1.Read("Bob");

            base1.Delete("Whill");

            base1.Save();

            base1.Read();
        }
    }
}
