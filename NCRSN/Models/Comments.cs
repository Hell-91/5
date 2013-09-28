using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCRSN.Models
{
    public class Comments
    {
        [Key]
        public int comment_Id { get; set; }

        public char comment_ParentType { get; set; }

        public int comment_ParentId { get; set; }

        public int comment_UserId { get; set; }

        public string comment_Comment { get; set; }
    }
}