namespace UniEventApp
{
    public static class UserSession
    {
        public static int UserID { get; set; } = 0;
        public static string Username { get; set; } = "Guest";
        public static string Role { get; set; } = "Guest"; // 'Guest', 'Admin', 'Organizer', 'Student'
        public static int? FacultyID { get; set; } = null;

        public static bool IsLoggedIn => UserID > 0;

        public static void Logout()
        {
            UserID = 0;
            Username = "Guest";
            Role = "Guest";
            FacultyID = null;
        }
    }
}