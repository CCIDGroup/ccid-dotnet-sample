using System;
using System.Security.Cryptography;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // BAD: Password is generated using a cryptographically insecure RNG
            Random gen = new Random();
            string password = "mypassword" + gen.Next();
            Console.WriteLine(password);
            // GOOD: Password is generated using a cryptographically secure RNG
            using (var crypto = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[sizeof(int)];
                crypto.GetBytes(randomBytes);
                password = "mypassword" + BitConverter.ToInt32(randomBytes);
            }
            Console.WriteLine(password);

        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string getUser(){
            return this.Name;
        }
    }
}
