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
    
    public partial class EventLikeDislike
    {
        public EventLikeDislike()
        {
            this.EventLikeDislike_Like = -1m;
        }
    
        public int EventLikeDislike_Id { get; set; }
        public int EventLikeDislike_Event_Id { get; set; }
        public int EventLikeDislike_User_Id { get; set; }
        public decimal EventLikeDislike_Like { get; set; }
    }
}