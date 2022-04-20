using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAL_Challenge2.Service
{
    public interface IPremiumCalc
    {
        float Calculate(int age, int occupation, int cover);
    }
}
