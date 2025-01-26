using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    internal class Company
    {
        public string Title { get; set; }
        public string Language { get; set; }

        public Company(string title, string language)
        {
            Title = title;
            Language = language;
        }
    }
}
