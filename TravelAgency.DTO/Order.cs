namespace TravelAgency.DTO
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TouristID { get; set; }
        public int TourID { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreateDate { get; set; } 
        public DateTime? UpdateDate {get;set;} 
    }
}
