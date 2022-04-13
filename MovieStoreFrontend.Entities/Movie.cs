#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreFrontend.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal RentalPrice { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
