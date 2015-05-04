using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2000)]
        public string Title { get; set; }

        public Category Category { get; set; }


    }
}
