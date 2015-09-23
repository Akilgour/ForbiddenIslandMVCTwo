using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class ValidationResults
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }
}