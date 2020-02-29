using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string page = "https://www.pja.edu.pl";
            var hc = new HttpClient();
            var res = await hc.GetAsync(page);
            if (res.IsSuccessStatusCode)
            {
                string html = await res.Content.ReadAsStringAsync();
                Regex re = new Regex("[a-z][0-9a-z]*@[0-9a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);
                MatchCollection m = re.Matches(html);
            }
            Console.WriteLine("Done");
        }
    }
}
