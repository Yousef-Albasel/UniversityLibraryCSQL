public class UserContext
{
    private static int _userID;

    public static int UserID
    {
        get
        {
                return _userID;
        }
        set
        {
                _userID = value;
        }
    }
}
