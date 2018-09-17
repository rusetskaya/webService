using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadgets.Contract
{
    public interface IGadgetBO
    {
        int Id { get; set; }
        string Name { get; set; }

        string Brand { get; set; }

        bool IsFavorite { get; set; }
        bool Save();
    }
}
