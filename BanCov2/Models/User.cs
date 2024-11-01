namespace BanCov2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Chú ý, nên mã hóa mật khẩu!
        public string Email { get; set; }
    }
}
