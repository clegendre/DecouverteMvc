using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class ContactModel
    {
        [Display( Name = "Saisissez votre email" )]
        [DataType( DataType.EmailAddress )]
        [Required( ErrorMessage = "Merci de saisir un email !!" )]
        public string Email { get; set; }

        [DataType( "DatePicker" )]
        [MinDate( Span = "2.00:00:00" )]
        public DateTime? ContactDate { get; set; }
    }

    public class MinDateAttribute : ValidationAttribute
    {
        public string Span { get; set; }

        public override bool IsValid( object value )
        {
            if (value == null) return false;
          
            TimeSpan ts = TimeSpan.Parse( Span );
            DateTime dateValue = (DateTime)value;
            return dateValue > DateTime.UtcNow.Date.Add( ts );
        }
    }
}