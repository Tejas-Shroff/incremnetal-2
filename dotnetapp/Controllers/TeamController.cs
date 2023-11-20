using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
 
namespace dotnetapp.Controllers
{
   
    public class TeamController : Controller
    {
       
        private readonly ApplicationDbContext context;
 
        public TeamController(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var data=context.Teams.ToList();
            return View(data);
        }
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
 
        public IActionResult Create(Team t)
        {
            context.Teams.Add(t);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Delete(Team t)
        {
            var data=context.Teams.Find(t.TeamId);
            context.Teams.Remove(data);
            context.SaveChanges();
            return RedirectToAction();
        }
 
 
       
    }
}