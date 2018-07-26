using System;
using NBitcoin;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! " + new Key().GetWif(Network.Main));
            // generate a random private key
            Key privateKey = new Key();
            //From the private key, we use a one-way cryptographic function, to generate a public key.
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);
            //we can easily get your bitcoin address from your public key
            // and the network on which this address should be used.
            Console.WriteLine(publicKey.GetAddress(Network.Main));
            Console.WriteLine(publicKey.GetAddress(Network.TestNet));
        }
    }
}
