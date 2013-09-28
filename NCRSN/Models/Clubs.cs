using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCRSN.Models
{
    public class Clubs
    {
        [Key]
        public int club_Id { get; set; }

        public string club_Name { get; set; }

        public string club_Description { get; set; }

        public string club_Moderator { get; set; }

        public DateTime club_CreatedDate { get; set; }

        public DateTime club_UpdatedDate { get; set; }

    }
}