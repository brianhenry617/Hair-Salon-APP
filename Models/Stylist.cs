using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stylist.Models;
using Stylist.Models;

namespace Stylist.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist> {};
    private string _name;
    private string _email;
    private int _phoneNumber;
    private string _workSchedule;

    public Stylist (string name, string email, string phoneNumber, string workSchedule)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
      _workSchedule = workSchedule;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetWorkSchedule()
    {
      return _workSchedule;
    }
    public void SetWorkSchedule(string newWorkSchedule)
    {
      _workSchedule = newWorkSchedule;
    }
    public static List<Stylist> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
