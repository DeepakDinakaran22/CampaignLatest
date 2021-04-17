﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Campaign.UI.Models;

namespace Campaign.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.datasource = this.generateEvents();

            //List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
            //categories.Add(new ResourceDataSourceModel { text = "Started", id = 1, groupId = 1, color = "#df5286" });
            //categories.Add(new ResourceDataSourceModel { text = "Paused", id = 2, groupId = 1, color = "#7fa900" });
            //categories.Add(new ResourceDataSourceModel { text = "Ended", id = 3, groupId = 2, color = "#ea7a57" });
            ////categories.Add(new ResourceDataSourceModel { text = "Smith", id = 4, groupId = 2, color = "#5978ee" });
            ////categories.Add(new ResourceDataSourceModel { text = "Micheal", id = 5, groupId = 3, color = "#df5286" });
            ////categories.Add(new ResourceDataSourceModel { text = "Root", id = 6, groupId = 3, color = "#00bdae" });
            //ViewBag.Categories = categories;

            //ViewBag.Resources = new string[] { "Categories" };
            return View();
        }

        //private List<EventsData> generateEvents()
        //{
        //    List<EventsData> dateCollections = new List<EventsData>();
        //    var names = new string[]
        //    { "Bering Sea Gold", "Technology", "Maintenance", "Meeting", "Travelling", "Annual Conference", "Birthday Celebration",
        //    "Farewell Celebration", "Wedding Aniversary", "Alaska: The Last Frontier", "Deadest Catch", "Sports Day",
        //    "MoonShiners", "Close Encounters", "HighWay Thru Hell", "Daily Planet", "Cash Cab", "Basketball Practice",
        //    "Rugby Match", "Guitar Class", "Music Lessons", "Doctor checkup", "Brazil - Mexico", "Opening ceremony", "Final presentation"
        //    };
        //    var colors = new string[] { "#ff8787", "#9775fa", "#748ffc", "#3bc9db", "#69db7c",
        //   "#fdd835", "#748ffc", "#9775fa", "#df5286", "#7fa900",
        //   "#fec200", "#5978ee", "#00bdae", "#ea80fc"};
        //    DateTime YearStart = new DateTime(DateTime.Now.Year - 2, 1, 1);
        //    for (var index = 0; index < 5; index++)
        //    {
        //        for (int a = 0, id = 1; a < 60; a++)
        //        {

        //            Random random = new Random();
        //            int Month = random.Next(1, 13);
        //            int Date = random.Next(1, 28);
        //            int Hour = random.Next(1, 24);
        //            int Minutes = random.Next(1, 60);
        //            DateTime start = new DateTime(YearStart.Year + index, Month, Date, Hour, Minutes, 0);
        //            DateTime end = new DateTime(start.Ticks);
        //            end = end.AddHours(2);
        //            dateCollections.Add(new EventsData
        //            {
        //                Id = id,
        //                Subject = names[random.Next(1, 24)],
        //                StartTime = new DateTime(start.Ticks),
        //                EndTime = new DateTime(end.Ticks),
        //                IsAllDay = (id % 10 == 0) ? true : false,
        //                CategoryColor = colors[random.Next(1, 13)],
        //                TaskId = (id % 6) + 1,
        //            });
        //            id++;
        //        }
        //    }
        //    return dateCollections;
        //}



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    //internal class EventsData
    //{
    //    public int Id { get; set; }
    //    public string Subject { get; set; }
    //    public DateTime StartTime { get; set; }
    //    public DateTime EndTime { get; set; }
    //    public bool IsAllDay { get; set; }
    //    public string CategoryColor { get; set; }
    //    public int TaskId { get; set; }
    //}

    //public class ResourceDataSourceModel
    //{
    //    public string text { set; get; }
    //    public int id { set; get; }
    //    public string color { set; get; }
    //    public int groupId { set; get; }
    //}
}
