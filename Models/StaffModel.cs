namespace dashboard.Models
{
    public class StaffModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Tell { get; set; }
        public required string Address { get; set; }


        public int DegreeId { get; set; }
        public class DegreeModel { }

        public int TitleId { get; set; }
        public class TittlesModel { }

    }
}