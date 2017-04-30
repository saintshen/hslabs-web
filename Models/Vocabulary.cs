using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class Vocabulary
    {
        public int Id{get;set;}
        public string Name {get;set;}
        public DateTime LastUpdated {get;set;}
        public List<Word> Words {get;set;}
    }

}