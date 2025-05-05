using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookies
{
    internal class Program
    {
        class MyCookieCollection
        {
            private Dictionary<string, string> cookies = new Dictionary<string, string>();
            public string this[string key]
            {
                get
                {
                    if (cookies.ContainsKey(key))
                        return cookies[key];
                    else
                        throw new KeyNotFoundException($"Cookie with key '{key}' not found.");
                }
                set
                {
                    cookies[key] = value;
                }
            }
            public void PrintAllCookies()
            {
                foreach (var cookie in cookies)
                {
                    Console.WriteLine($"{cookie.Key}: {cookie.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            MyCookieCollection cookies = new MyCookieCollection();
            // Set a cookie
            cookies["username"] = "Mai";
            cookies["password"] = "123456";

            // Get a cookie
            Console.WriteLine("Username: " + cookies["username"]);
            Console.WriteLine("Password: " + cookies["password"]);

            // Print all cookies
            Console.WriteLine("All cookies:");
            cookies.PrintAllCookies();

        }
    }
}
