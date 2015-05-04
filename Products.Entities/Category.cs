using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public enum Category
    {
                                            Books,
        [Display(Name = "Video Games")]     VideoGames,
        [Display(Name = "Health & Beauty")] HealthAndBeauty
    }
}
