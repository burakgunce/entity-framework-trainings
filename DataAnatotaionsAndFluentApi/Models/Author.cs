using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnatotaionsAndFluentApi.Models
{
    [Table("AuthorTable")]
    public class Author
    {
        [Key] // bu attrıbute u ekledıgınde artık alttakının prımary key oldugunu anlayabılcek mıgrate ederken
        [Column(name: "AuthorId", Order = 1)]
        public int AuthorKey { get; set; }

        [Column(Order = 2)]
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column(Order = 3)]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string AuthorName => $"{FirstName } {LastName}";

        [Column(Order = 4)]
        [Required]
        [MaxLength(500)]
        public string Biography { get; set; }
        
        
        public ICollection<Book> Books { get; set; }
    }
}
