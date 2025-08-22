namespace TravelAgency.DTO
{
    public class TourStop
    {
        public int TourStopID { get; set; }
        public int TourID { get; set; }
        public int CityID { get; set; }
        public int DaysSpent { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
