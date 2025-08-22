namespace TravelAgency.DTO
{
    public class Position
    {
        public int PositionID { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
