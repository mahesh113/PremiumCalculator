using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TAL_Challenge2.Common;

namespace TAL_Challenge2.Pages
{
    public class CustomerModel : PageModel
    {

        public string Name { get; set; }
        public int Occupation { get; set; }
        public SelectList OccupationList
        {
            get
            {
                return new SelectList(Enum.GetValues(typeof(OccupationType)));
            }
        }
        public int Age { get; set; }
        public int InsuredAmount { get; set; }
        public DateTime DOB { get; set; }
        public float FinalPremium { get; set; }
        public float Factor { get; set; }
    }
}
