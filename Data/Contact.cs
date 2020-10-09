using System;

public class ContactObj
{
    public Guid Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }

}

//var ContactList = new List<ContactObj> {};
// attempted to make list of contact object here and failed