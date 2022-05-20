namespace ProjectManagementClasses
{
    public class Projects
    {
        public static int Id { get; set; } = 0;
        public static string Description { get; set; } = string.Empty;
        public static int EstimatedHours { get; set; } = 0;
        public static int ActualHours { get; set; } = 0;
        public static string Status { get; set; } = "New";

    }
}