using System;
using System.Text;

namespace UrlShort.Domain.UrlShortLogic
{
    public class UrlShorterProcessor
    {
        private string urlTemplate = "www.shortUrl.com/";
        private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        private Random _random = new Random();

        public string ShortUrl()
        {
            StringBuilder shortUrl = new StringBuilder(7);

            for (int i = 0; i < 7; i++)
            {
                var character = _alphabet[_random.Next(0, _alphabet.Length - 1)];
                shortUrl.Append(character);
            }

            return urlTemplate + shortUrl.ToString();
        }
    }
}