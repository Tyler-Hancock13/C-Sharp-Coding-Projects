using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class InsureeVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Quote { get; set; }
    }
}