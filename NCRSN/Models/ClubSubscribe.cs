using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCRSN.Models
{
    public class ClubSubscribe
    {
        [Key]
        public int clubSubscribe_Id { get; set; }

        public int club_Id { get; set; }

        [ForeignKey("club_Id")]
        public virtual Clubs Clubs { get; set; }

        public int clubSubscribe_UserId { get; set; }

    }
}