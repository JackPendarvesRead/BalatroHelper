using BalatroHelper.Logic.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalatroHelper.Logic.Entities
{
    public interface ICard : IEvaluatable
    {
        CardValue Value { get; set; }

        Suit Suit { get; set; }
    }
}
