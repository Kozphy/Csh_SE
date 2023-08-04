namespace jwt_test.Lab
{
    public record class JwtOptions (
        string Issuer,
        string Audience,
        string SigningKey,
        int ExpirationSeconds
    );
}
