namespace TravelAgency.DTO
{
    public class Tour
    {
        public int TourID { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public double TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
