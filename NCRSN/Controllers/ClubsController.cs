using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NCRSN.Models;
using NCRSN.ViewModels;


namespace NCRSN.Controllers
{
    public class ClubsController : Controller
    {
        //
        // GET: /Clubs/
        private NCRSNContainer conn = new NCRSNContainer();

        public string Index()
        {
            var User = new Users
            {
                User_Id = 2
            };

            var Club = new Clubs {
                Club_Id=2,
                Club_Name="Sports",
                Club_Description="This is sports club",
                Club_Moderator=2
                
            };

            foreach(var c in conn.Clubs) {
                if(c.Club_Id == 2) {
                    Club = c;
                }
            }

            var Event = new Event {
                Event_Id=2,
                Event_Club_Id=3,
                Event_Title="Sports day",
                Event_Likes=20,
                Event_Dislikes=10,
                Event_Description="Lets have sports day!",
                Event_Moderator=2,
                Event_Venue="6th Floor",
                Event_Date=new DateTime(2013, 12, 25, 21, 20, 0),
                Clubs = conn.Clubs.Single(c => c.Club_Id == 3)
            };


            conn.Users.Add(User);
            conn.SaveChanges(); conn.Clubs.Add(Club);
            conn.SaveChanges(); conn.Events.Add(Event);
            conn.SaveChanges();
            return conn.Clubs.Count().ToString();
        }

        public ActionResult Sports(String eventId)
        {
            var ClubDetails = new Clubs {
               Club_Name="Sports",
               Club_Description = "This  is sports club!"
            };

            var Events = new List<Events> {
                new Events {
                    event_Title = "Cricket on 25th Dec",
                    event_Description = "This is a long description",
                    event_Moderator = "Prasad E",
                    event_Venue = "Parade Grounds"
                },

                new Events {
                    event_Title = "Cricket on 30th Dec",
                    event_Description = "This is a long description",
                    event_Moderator = "Prasad E",
                    event_Venue = "Parade Grounds"
                }
            };

            var ClubDetails1 = conn.Clubs.ToList();
            var Events1 = conn.Events.ToList();
            var c = new Clubs();

            foreach (var club in ClubDetails1)
            {
                if (club.Club_Name == "Sports") {
                    c = club;
                }
            }

            var e = new List<Event>();

            foreach (var evenT in Events1) {
                if (evenT.Clubs.Club_Name == "Sports") {
                    e.Add(evenT);
                }
            }

            var sportsEvents = new SportsViewModel {
                Club = c,
                Events = e
            };

            conn.Clubs.Add(ClubDetails);
            return View(sportsEvents);
        }

        public string Music(String eventId)
        {
            return "This is Music page! \nEventID: " + eventId;
        }

    }
}
