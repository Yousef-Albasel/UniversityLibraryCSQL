public static class ConnectionStringHelper
{
    public static string server_name = "DESKTOP-478ABIG";
    public static string database_name = "UniversityLibrary";
    public static string ConnectionString { get; } = "Data Source="+server_name+";Initial Catalog=" + database_name + ";Integrated Security=True";
}
