namespace TravelAgency.DTO
{
    public class Tourist
    {
        public int TouristID { get; set; }
        public int TourID { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string ContactPhone { get; set; } = null!;
        public DateTime CreateDate { get; set; }

    }
}
