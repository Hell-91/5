//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCRSN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Event
    {
        public int Event_Id { get; set; }
        public string Event_Title { get; set; }
        public string Event_Description { get; set; }
        public int Event_Moderator { get; set; }
        public int Event_Club_Id { get; set; }
        public decimal Event_Likes { get; set; }
        public decimal Event_Dislikes { get; set; }
        public string Event_Venue { get; set; }
        public System.DateTime Event_Date { get; set; }

        [ForeignKey("Club_Id")]
        public virtual Clubs Clubs { get; set; }
    }
}
