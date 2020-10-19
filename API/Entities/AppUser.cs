namespace Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        private string UserName;
        public string MyProperty
        {
            get { return UserName; }
            set { UserName = value; }
        }
        

    }
}