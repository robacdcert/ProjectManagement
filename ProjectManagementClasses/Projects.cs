namespace ProjectManagementClasses
{
    public class Projects
    {
        public int Id { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public int EstimatedHours { get; set; } = 0;
        public int ActualHours { get; set; } = 0;
        public string Status { get; set; } = "New";

    }
}