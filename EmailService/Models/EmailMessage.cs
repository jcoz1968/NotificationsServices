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

        [DisplayName("To Display Name")]
        [StringLength(75, MinimumLength = 1)]
        public string ToDisplayName { get; set; }

        [DisplayName("From Display Name")]
        [StringLength(75, MinimumLength = 1)]
        public string FromDisplayName { get; set; }

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
