namespace Blog;

public static class Configuration
{
    public static string JwtKey = "minha-chave-de-teste-para-autenticacao";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "minha-chavde-de-teste-para-api";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string Username { get; set; }
        public string Password { get; set; }
    }
}