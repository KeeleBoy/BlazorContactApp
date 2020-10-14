using System;

// Here was the first attempt to make the contact object
// decided to click project and make new class contactObj.cs
//leaving this for now in case it's needed to be referenced

public class contactObj
{
    public Guid Id { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}

// List ContactList = new List<ContactObj> {};
// attempted to make list of contact object here and failed