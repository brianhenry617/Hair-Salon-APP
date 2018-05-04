using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Stylist.Models;

namespace Client.Models
{
  public class Client
  {
    private static List<Client> _instances = new List<Client> {};
    private string _name;
    private string _email;
    private int _phoneNumber;
    private string _prefferedStylist;

    public Client (string name, string email, string phoneNumber, string prefferedStylist)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
      _prefferedStylist = prefferedStylist;
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
    public string GetPrefferedStylist()
    {
      return _prefferedStylist;
    }
    public void SetPrefferedStylist(string newPrefferedStylist)
    {
      _prefferedStylist = newPrefferedStylist;
    }
    public static List<Client> GetAll()
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
