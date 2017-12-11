using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost1 = new BlogPost("John Doe", "Lorem ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            var blogPost2 = new BlogPost("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            var blogPost3 = new BlogPost("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM.", "2017.03.28.");

            Console.WriteLine(blogPost3.ToString());
            Console.ReadLine();
        }
    }
}
