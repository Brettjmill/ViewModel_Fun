public class User
{
    public string FirstName {get;set;}
    public string LastName {get;set;}

    public User(string inputFirstName, string inputLastName = null)
    {
        FirstName = inputFirstName;
        LastName = inputLastName;
    }
}

