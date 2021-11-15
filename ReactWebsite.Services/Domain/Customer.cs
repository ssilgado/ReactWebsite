namespace ReactWebsite.Services.Domain
{
    public class Customer : Entity
    {
        public char Type { get; set; }
        public Person PrimaryContact { get; set; }
    }
}