using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAL_Challenge2.Common;

namespace TAL_Challenge2.Service
{
    public class PremiumCalc : IPremiumCalc
    {
        private readonly Factors factors;
        public PremiumCalc(IOptions<Factors> _fac)
        {
            factors = _fac.Value;
        }
        public float Calculate(int age, int occupation, int cover)
        {
            float factor = GetFactor(occupation) ;
            return (cover * factor * age) / 1000 * 12;
        }

        private float GetFactor(int occupation)
        {
            if(occupation.Equals(OccupationType.Cleaner)|| occupation.Equals(OccupationType.Florist))
            {
                return factors.LightManual;
            }
            else if (occupation.Equals(OccupationType.Author))
            {
                return factors.WhiteCollar;
            }
            else if (occupation.Equals(OccupationType.Farmer) || occupation.Equals(OccupationType.Mechanic))
            {
                return factors.HeavyManual;
            }
            else //if (occupation.Equals(OccupationType.Doctor))
            {
                return factors.Professional;
            }
        }
    }
}
