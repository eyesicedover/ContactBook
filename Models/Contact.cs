using System.Collections.Generic;
using System;

namespace ContactBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private int _id;
        private static List<Contact> _instances = new List<Contact> {};

        public Contact (string name, string phoneNumber, string address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetPhoneNumber(string newPhone)
        {
            _phoneNumber = newPhone;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public void SetAddress(string newAddress)
        {
            _address = newAddress;
        }

        public string GetAddress()
        {
            return _address;
        }

        public void SetId(int newId)
        {
            _id = newId;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Contact> GetAll()
        {
          return _instances;
        }

        public static Contact FindById(int searchId)
        {
            return _instances[searchId-1];
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static void DeleteThisContact(int id)
        {
            _instances.RemoveAt(id-1);
        }

        public static void ReassignIds()
        {
            for (int index = 0; index < _instances.Count; index++)
            {
              _instances[index]._id = index + 1;
            }
        }
    }
}
