using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using myCalender.Models;
using System;


namespace myCalender.Controllers
{
    public class ApiController : Controller
    {
        //API
        public IActionResult Tasks()
        {
            var list = new List<Task>(); //objects use var

            var t1 = new Task();
            t1.Id = 1;
            t1.Title = "First Task";
            t1.Notes = "This is my first tasks on my super calendar system";
            t1.Important = true;
            t1.Date = DateTime.Now;
            t1.User = "Zachary";

            list.Add(t1);

            var t2 = new Task()
            {
                Id = 2,
                Title = "Study",
                Important = true,
                Notes = "This is for class",
                User = "Zachary"
            };
            list.Add(t2);

            var t3 = new Task()
            {
                Id = 3,
                Title = "Car registraion",
                Important = true,
                Notes = "Get this done before November",
                User = "Zachary"

            };

            list.Add(t3);

            var t4 = new Task() 
            {
                Id = 4,
                Title = "Drivers License",
                Notes = "Expires in November",
                Date = DateTime.Today.AddDays(30),
                User = "Zachary"

            };

            list.Add(t4);
            return Json(list);
        }

    }
}