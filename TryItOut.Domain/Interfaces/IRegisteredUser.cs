namespace TryItOut.Domain
{
    public interface IRegisteredUser
    {
        int Identifier { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Password { get; set; }
        string Username { get; set; }
        string IsActive { get; set; }
        string LastLoggedIn { get; set; }
    }
}