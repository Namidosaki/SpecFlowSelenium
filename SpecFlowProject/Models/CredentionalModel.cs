namespace GoogleLoginTest.Models
{
    public class ValidInvalid
    {
        public List<CredentionalModel> Valid { get; set; }
        public List<CredentionalModel> Invalid { get; set; }
    }
    public class CredentionalModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
