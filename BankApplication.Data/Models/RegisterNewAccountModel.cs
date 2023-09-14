using BankApplication.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Data.Models
{
    public class RegisterNewAccountModel
    {

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string AccountName { get; set; }
        [StringLength(11, ErrorMessage = "Phone number must not exceed 11 characters.")]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        //public string CurrentAccountBalance { get; set; }
        public AccountType AccountType { get; set; }
        //public string AccountNumberGenerated { get; set; }
        //public byte[] PinHash { get; set; }
        //public byte[] PinSalt { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpdated { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Pin must not be more than 4 digits")] // It should be a 4-digit string
        public string Pin { get; set; }
        [Required]
        [Compare("Pin", ErrorMessage = "Pins do not match")]
        public string ConfirmPin { get; set; }
    }
}
