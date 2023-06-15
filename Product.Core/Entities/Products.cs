using Product.Core.Common;
using Product.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities
{
    public class Xavchik: IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string ingredients { get; set; }
        public float price { get; set; }
        public string review { get; set; }
        public char verify { get; set; }
        public Company company { get; set; }
        public Guid companyId { get; set; }
        public Category category { get; set; }
        public Guid categoryId { get; set; }

    }
}
