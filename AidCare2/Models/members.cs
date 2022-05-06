namespace AidCare2.Models
{
    public class members
    {
        public int membersId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        public ICollection<donations> donations { get; set; }
    }
}
