namespace TravelAgency.DTO
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; } = null!;
        public int Stars { get; set; }
        public Double PerNightPrice { get; set; }
        public bool Dining { get; set; }
        public string? AdditionalServices { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
