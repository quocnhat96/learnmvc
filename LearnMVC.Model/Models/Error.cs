﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnMVC.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int Id { get; set; }
        
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
