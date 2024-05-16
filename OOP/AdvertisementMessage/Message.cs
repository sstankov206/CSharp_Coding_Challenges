using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class Message
    {
        //properties:
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Author { get; set; }
        public string Cities { get; set; }

        //constructor:
        public Message(string phrases, string events, string authors, string cities)
        {
            this.Phrases = phrases;
            this.Events = events;
            this.Author = authors;
            this.Cities = cities;
        }

        public override string ToString()
        {
            return $"{this.Phrases} {this.Events} {this.Author} – {this.Cities}"; 
        }
    }
}
