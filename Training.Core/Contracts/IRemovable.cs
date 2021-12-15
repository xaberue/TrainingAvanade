using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Contracts
{
    public interface IRemovable
    {
        bool IsDeleted { get; set; }
    }
}
