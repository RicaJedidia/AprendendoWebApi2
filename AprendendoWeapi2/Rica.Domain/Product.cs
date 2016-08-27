using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rica.Domain
{
    public class Product
    {
        public Product()
        {
            this.Acquire = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Acquire { get; set; }
        public decimal Price { get; set; }
        public int CtegoryId { get; set; }
        public bool IsActice { get; set; }

        public virtual Category Category { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
