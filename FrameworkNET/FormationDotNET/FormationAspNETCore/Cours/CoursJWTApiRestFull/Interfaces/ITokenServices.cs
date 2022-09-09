namespace CoursJWTApiRestFull.Interfaces
{
    public interface ITokenServices
    {
        public string Authenticate(string username, string password);
    }
}
