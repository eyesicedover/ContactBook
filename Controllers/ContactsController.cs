using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ContactBook.Models;

namespace ContactBook.Controllers
{
    public class ContactsController : Controller
    {
      [HttpGet("/contacts")]
      public ActionResult Index()
      {
        List<Contact> allContacts = Contact.GetAll();
        return View(allContacts);
      }

      [HttpPost("/contacts")]
      public ActionResult Create()
      {
          string firstName = Request.Form["firstName"];
          string lastName = Request.Form["lastName"];
          lastName = " " + lastName.Trim();
          string fullName = string.Concat(firstName, lastName);

          string phone = Request.Form["phone"];

          string address = Request.Form["address"];
          string city = Request.Form["city"];
          string state = Request.Form["state"];
          string zip = Request.Form["zip"];
          city = ", " + city.Trim();
          state = ", " + state.Trim();
          zip = " " + zip.Trim();
          string fullAddress = string.Concat(string.Concat(string.Concat(address, city), state), zip);

          Contact newContact = new Contact(fullName, phone, fullAddress);
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
      }

      [HttpGet("/contacts/new")]
      public ActionResult NewContactForm()
      {
          return View();
      }

      [HttpGet("/contacts/{id}")]
      public ActionResult Details(int id)
      {
          Contact chosenContact = Contact.FindById(id);
          return View(chosenContact);
      }

      [HttpPost("/contacts/clear")]
      public ActionResult Clear()
      {
          Contact.ClearAll();
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
      }
    }
}
