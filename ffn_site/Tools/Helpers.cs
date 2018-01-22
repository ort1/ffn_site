using System;
using System.Linq;

namespace ffn_site.Tools
{
    public class Helpers
    {

        /// <summary>
        /// Fonction qui hash et chiffre une string en SHA512
        /// </summary>
        /// <param name="input">La string à chiffrer et hasher</param>
        /// <returns>La string chiffrée et hashée</returns>
        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString().ToLower();
            }
        }

        public static string RandomString(int length)
        {
            Random rand = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[rand.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }
    }
}