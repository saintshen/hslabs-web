using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models
{
    public class Word
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser {get;set;}
        public int VocabularyId {get;set;}
        [ForeignKey("VocabularyForeignKey")]
        public Vocabulary Vocabulary {get;set;}
        [Timestamp]
        public byte[] Timestamp { get; set; }        
    }
}