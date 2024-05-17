public static class ConnectionStringHelper
{
    public static string server_name = "DESKTOP-BC6SQGP";
    public static string database_name = "UniversityLibrary";
    public static string ConnectionString { get; } = "Data Source="+server_name+";Initial Catalog=" + database_name + ";Integrated Security=True";
}
