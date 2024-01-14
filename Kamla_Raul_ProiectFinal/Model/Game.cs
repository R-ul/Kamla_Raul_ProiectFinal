using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Kamla_Raul_ProiectFinal.Model
{
    public class Game
    {
        public int Id { get; set; }

        [Display(Name = "Game Title")]
        public string Title { get; set; }
        [Display(Name = "Game Genre")]
        public string Genre { get; set; }
        [Column("Price", TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }

        public int? ProviderId { get; set; }
        public Provider? Provider { get; set; }
    }
}
