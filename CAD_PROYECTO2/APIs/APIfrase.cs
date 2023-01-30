using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_PROYECTO2.APIs
{
    public class Contents
    {
        public List<Quote> quotes { get; set; }
    }
    public class Copyright
    {
        public int year { get; set; }
        public string url { get; set; }
    }
    public class Quote
    {
        public string quote { get; set; }
        public string length { get; set; }
        public string author { get; set; }
        public List<string> tags { get; set; }
        public string category { get; set; }
        public string language { get; set; }
        public string date { get; set; }
        public string permalink { get; set; }
        public string id { get; set; }
        public string background { get; set; }
        public string title { get; set; }
    }
    public class Root
    {
        public Success success { get; set; }
        public Contents contents { get; set; }
        public string baseurl { get; set; }
        public Copyright copyright { get; set; }
    }
    public class Success
    {
        public int total { get; set; }
    }
}
