using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List <Client> all Clients = Clients.GetAll();
      return View(allClients);
    }

    [HttpGet("/Client/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Client")]
    public ActionResult Create()
    {
      Client newClient = new Client(Request.Form["name"], Request.Form["email"], Request.Form["phoneNumber"], Request.Form["prefferedStylist"]);
      List <Client> allClient = Client.GetAll();
      return View("Index");
    }

    [HttpPost("Client/clear")]
    public ActionResult Clear()
    {
      Client.ClearAll();
      return View();
    }
  }
}
