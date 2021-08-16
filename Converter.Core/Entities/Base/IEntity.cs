using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Core.Entities.Base
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
