using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NCRSN.Models;

namespace NCRSN.ViewModels
{
    public class SportsViewModel
    {
        public Clubs Club { get; set; }
        public List<Event> Events{ get; set; }
    }
}