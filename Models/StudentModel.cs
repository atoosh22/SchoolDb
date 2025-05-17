namespace dashboard.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Tell { get; set; }
        public required string Address { get; set; }
        public int GuardianTell { get; set; }
        public required string Mother { get; set; }
        public double Fee { get; set; }


        public int Classid { get; set; }
        public class ClassesModel { }
    }
}