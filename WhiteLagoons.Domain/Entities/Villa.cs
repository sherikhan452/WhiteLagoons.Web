using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoons.Domain.Entities
{
    public class Villa
    {
       
        public int Id { get; set; }

        [MaxLength(20,ErrorMessage ="Max Lenght is 20 Charactors")]
        public string Name { get; set; }

        [Range(1,50)]
        public int SqFt { get; set; }

        [Range(10000, 100000)]
       
        public float price { get; set; }

        [Required]
        public string Occupancy { get; set; }

        public string ImgUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}


