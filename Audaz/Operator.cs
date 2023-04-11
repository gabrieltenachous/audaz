using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audaz
{
    public class Operator : IModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Code { get; set; }

    }
}
