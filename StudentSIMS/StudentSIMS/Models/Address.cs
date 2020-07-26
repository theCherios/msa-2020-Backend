using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// namespace contains the collections of symbols/methods so each is uniquely identified
// here the class Student belongs to the namespace StudentSIMS.Models, you can use access
// the Student class from other files withusing StudentSIMS.Models
namespace StudentSIMS.Models
{
    public class Address
    {
        // annotate studentId to be the unique identifier of the Model which maps
        // to the primary key of the database
        [Key]
        // DatabaseGenerated can be assigned so that a value of an attribute is automatically generated
        // in this case, the studentId. DatabaseGeneratedOption.Identity means the value will only be
        // generated once when the row is first created, and it cannot be updated
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        // firstName is required when adding a Student to the database, and it will have 100 characters max
        [Required]
        public int streetNumber { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }

        public string Country { get; set; }
    }
}