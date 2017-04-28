using System;

namespace webapp.Models
{
    public class Word
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser {get;set;}
    }
}