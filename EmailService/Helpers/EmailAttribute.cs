using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmailService.Helpers
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute() 
            : base(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}")
        {
            this.ErrorMessage = "Please provide a valid Email Address";
        }
    }
}
