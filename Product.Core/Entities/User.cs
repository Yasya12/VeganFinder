using Product.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Entities
{
    public class User : IEntity<Guid>
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string password { get; set; }
        public char power { get; set; }
    }
}
