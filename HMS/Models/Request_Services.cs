//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Request_Services
    {
        public int Id { get; set; }
        [Required]
        [Range(1000, 2000, ErrorMessage = "Member Id should be withween Zero to Fifteen Thousand")]
        public int member_ID { get; set; }
        public string Service_Type { get; set; }
        public string Status { get; set; }
    }
}
