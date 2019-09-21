namespace Sample.Entities
{
    public class CustomerEntity
    {
        public CustomerEntity()
        {

        }
        public CustomerEntity(string firstname, string lastname, string gender, string phone, string address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.phone = phone;
            this.address = address;
        }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}