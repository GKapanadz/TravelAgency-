namespace TravelAgency.DTO
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; } = null!;
        public int CountryID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
