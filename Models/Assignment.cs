namespace Final_thesis_api.Models
{
    public class Assignment
    {
        public int IdWorker { get; set; }
        public int IdOrder { get; set; }
        public bool OrderLeader { get; set; }
        public double? HoursWorked { get; set; }

        public Worker Worker { get; set; }
        public Order Order { get; set; }
    }
}
