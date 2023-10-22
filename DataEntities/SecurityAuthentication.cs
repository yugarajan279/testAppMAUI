namespace testapp
{
    public class SecurityAuthentication
    {
        public string UserName { get; set; }
        public string Password { get; set; }  // Note: This should ideally be a hash, not plaintext.
    }
}
