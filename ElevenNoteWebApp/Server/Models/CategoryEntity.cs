using System;
using System.ComponentModel.DataAnnotations;

//category stuff goes here
namespace ElevenNoteWebApp.Server.Models
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

