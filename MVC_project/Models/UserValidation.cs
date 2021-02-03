using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVC_project.Models
{
    [MetadataType(typeof(UsersMetaData))]
    public partial class User
    {

    }

    public class UsersMetaData
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-Za-z]+))$", ErrorMessage = "Please enter valid Full Name")]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [DisplayFormat(NullDisplayText ="Not specified.")]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode =true)]
        [Display(Name = "Date of birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Display(Name ="Address")]
        public string Adress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        //[RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage ="Please enter valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]

        [UIHint("OpenUrlInNewWindow")]
        [Display(Name = "Website")]
        public string WebSite { get; set; }
    }
}