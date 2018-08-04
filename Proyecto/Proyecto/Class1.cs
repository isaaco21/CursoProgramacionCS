using System;
using System.Collections.Generic;


class AddressBook
{
    List<Address> addresses;

    public AddressBook()
    {
        addresses = new List<Address>();
    }

    public bool add(string name, string phone, string mail)
    {
        Address addr = new Address(name, phone, mail);
        Address result = find(name);

        if (result == null)
        {
            addresses.Add(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool remove(string name)
    {
        Address addr = find(name);

        if (addr != null)
        {
            addresses.Remove(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void list(Action<Address> action)
    {
        addresses.ForEach(action);
    }

    public bool isEmpty()
    {
        return (addresses.Count == 0);
    }

    public Address find(string name)
    {
        Address addr = addresses.Find(
          delegate (Address a) {
              return a.name == name;
          }
        );
        return addr;
    }
}
