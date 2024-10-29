namespace Application.Web.Models
{
    public class VehicleService
    {
        public int ServiceId { get; set; }
        public string ServiceCategory { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
