using System.Security.Cryptography;
using System.Text;


namespace CustomDrink.Common.Generators
{
    public static class HashGenerator
    {
        public static string GenerateHash(this string plainText)
        {

            HashAlgorithm algorithm = SHA512.Create();

            var hash =
                algorithm.ComputeHash(Encoding.UTF8.GetBytes(plainText));

            return Convert.ToBase64String(hash);
        }
    }
}
