using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audaz
{
    public interface IModel
    {
        Guid Id { get; set; }
        //CREATED_AT
        DateTime CreatedAt { get; set; }
    }
}
