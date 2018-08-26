using EmailService.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EmailService.Models
{
    public class EmailMessage
    {
        [Required]
        [Email]
        [DisplayName("To Address")]
        public string ToAddress { get; set; }

        [DisplayName("Display Name")]
        [StringLength(75, MinimumLength = 1)]
        public string DisplayName { get; set; }

        [DisplayName("From Address")]
        [Required]
        [Email]
        public string FromAddress { get; set; }

        [DisplayName("Subject")]
        [Required]
        public string Subject { get; set; }

        [DisplayName("Body")]
        [Required]
        public string Body { get; set; }

        [Required]
        [DisplayName("Use Html?")]
        public bool UseHtml { get; set; }
    }
}
