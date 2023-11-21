using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnatotaionsAndFluentApi.Models
{
    [Table("BookTable")]
    public class Book
    {
        [Key]
        [Column("BookId")]
        public int BookKey { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("BookTitle",TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        public Author Author { get; set; }

        [ForeignKey("Author")]
        //[DisplayName("AuthorId")]
        public int AuthorFK { get; set; } 
    }
}
