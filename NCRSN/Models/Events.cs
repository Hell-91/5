using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCRSN.Models
{
    public class Events
    {
        [Key]
        public int event_Id { get; set; }

        public string event_Title { get; set; }

        public string event_Description { get; set; }

        public int club_Id { get; set; }

        [ForeignKey("club_Id")]
        public virtual Clubs Clubs { get; set; }

        public string event_Moderator { get; set; }

        public int event_Likes { get; set; }

        public int  event_DisLikes { get; set; }

        public DateTime event_DateTime { get; set; }

        public string event_Venue { get; set; }

        public DateTime event_CreatedDate { get; set; }

        public DateTime event_UpdatedDate { get; set; }
    }
}