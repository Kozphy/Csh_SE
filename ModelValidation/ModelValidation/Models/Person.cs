﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidation.CustomValidators;

namespace ModelValidation.Models
{
    public class Person
    {
        [Display(Name = "Person Name")]
        [Required(ErrorMessage = "{0} can't be empty or null")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between" +
                                                            "{2} and {1} characters longs")]
        [RegularExpression("^[A-Za-z .]$", ErrorMessage = "{0} should contain only alphabets, " +
                                                          "space and dot (.)") ]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [EmailAddress(ErrorMessage = "{0} should be a proper email address." )]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "{0} should contain 10 digits")]
        [ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage =  "{0} should be between ${1} and ${2}")]
        public double? Price { get; set; }

        [MinimumYearValidatorAttribute(2000, ErrorMessage = "Date of Birth should not be" +
                                                   " smaller than Jan 01, {0}")]
        //[MinimumYearValidator(2005)]
        [BindNever]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }
        [DateRangeValidator("FromDate", ErrorMessage="From Date should be older than or equal to 'To date'")]
        public DateTime ToDate { get; set; }

        public override string ToString()
        {
            return @$"Person object - Person name: {PersonName},
                      Email: {Email},
                      Phone: {Phone},
                      Password: {Password},
                      ComfirmPassword: {ConfirmPassword},
                      Price: {Price},
                      DateOfBirth: {DateOfBirth}";
        }
    }
}
