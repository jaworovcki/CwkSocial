namespace CwkSocial.Api;
public class ApiRoutes
{
    public const string BASEROUTE = "api/v{version:apiVersion}/[controller]";

    public class UserPrrofiles
    {
        public const string GETBYID = "{id}";
    }

    public class Posts
    {
        public const string GETBYID = "{id}";
    }

}