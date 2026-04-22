namespace Car_Rental.Models
{
    public class Renter
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int BirthYear { get; set; }
        public int LicenceYear { get; set; }
    }
}
