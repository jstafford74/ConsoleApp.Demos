using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.utils
{
    public static class PersonHelper
    {
        public static string GenerateIdNumber(string prefix)
        {
            var randomNumber = RandomNumberGenerator
                .GetInt32(1000000, 9999999)
                .ToString();

            return $"{prefix}-{randomNumber}";
        }
    }
}
