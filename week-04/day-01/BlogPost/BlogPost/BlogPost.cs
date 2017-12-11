using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class BlogPost
    {
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; }

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            AuthorName = authorName;
            Title = title;
            Text = text;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            return "[AuthorName] = " + AuthorName + " [Title] = " + Title + " [Text] = " + Text + " [PublicationDate] = " + PublicationDate;
        }
    }
}
