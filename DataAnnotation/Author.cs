using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation
{
    public class Author
    {
        //[Required(ErrorMessage = "{0} is required")]
        //[StringLength(50, MinimumLength = 3,
        //ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        //[DataType(DataType.Text)]
        //public string FirstName { get; set; }


        //[Required(ErrorMessage = "{0} is required")]
        //[StringLength(50, MinimumLength = 3,
        //ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        //[DataType(DataType.Text)]
        //public string LastName { get; set; }


        [IsEmpty(ErrorMessage = "{0} Should not be null or empty.")]
        public string FirstName { get; set; }


        [IsEmpty(ErrorMessage = "{0} Should not be null or empty.")]
        public string LastName { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
