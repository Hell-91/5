using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCRSN.Models
{
    public class EventLikesDislikes
    {
        [Key]
        public int eventLikesDislike_Id { get; set; }

        public int eventLikesDislike_EventId { get; set; }

        public int eventLikesDislike_UserId { get; set; }

        public int eventLikesDislike_Value { get; set; }

        public EventLikesDislikes()
        {
            eventLikesDislike_Value = -1;
        }
    }
}