namespace dashboard.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public int LevelId { get; set; }
        public class LevelModel { }
    }
}