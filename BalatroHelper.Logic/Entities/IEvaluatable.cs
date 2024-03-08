using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatroHelper.Logic.Entities
{
    public interface IEvaluatable
    {
        int Chips { get; set; }

        int Mult { get; set; }

        float MultMultiplier { get; set; }

        abstract int Evaluate();
    }
}
