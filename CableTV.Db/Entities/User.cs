namespace CableTV.Db
{
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public Address Address { get; set; }
    }
}
