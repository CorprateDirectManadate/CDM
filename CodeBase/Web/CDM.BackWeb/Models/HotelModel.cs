using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDM.BackWeb.Models
{
    public class HotelModel
    {
        public HotelModel()
        {
            States = new List<SelectListItem>();
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public string Website { get; set; }

        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string City { get; set; }

        public List<SelectListItem> States { get; set; }
        //public string CountryName { get; set; }
        public int StateId { get; set; }
        //public string Country { get; set; }
        public bool MarkAsDeleted { get; set; }
    }
}