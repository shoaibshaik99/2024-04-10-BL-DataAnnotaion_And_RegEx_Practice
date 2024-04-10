using System.ComponentModel.DataAnnotations;

namespace DataAnnotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author
            {
                FirstName = "Joydip",
                LastName = "",
                PhoneNumber = "1234567890",
                Email = "joydipkanjilal@yahoo.com"
            };

            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
        }
    }
}
