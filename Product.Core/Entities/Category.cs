using Product.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities
{
    public class Category : IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public virtual ICollection<Xavchik> Products { get; set; } = new HashSet<Xavchik>();
    }
}
