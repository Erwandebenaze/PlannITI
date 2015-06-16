using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plann.Core;

namespace Plann.Interface
{
    public interface IPlannContext
    {
        Period CurrentPeriod { get; }
    }
}