using System.Security.Cryptography;

namespace Domain.Utils;

public static class Hasher
{
    private const int SaltSize   = 24;
    private const int HashSize   = 24;
    private const int Iterations = 100000;

    public static (string, string) GenerateHash(string input)
    {
        // Generate a salt
        var provider  = new RNGCryptoServiceProvider();
        var saltBytes = new byte[SaltSize];
        provider.GetBytes(saltBytes);
        var salt = Convert.ToBase64String(saltBytes);

        // Generate the hash
        var pbkdf2       = new Rfc2898DeriveBytes(input, saltBytes, Iterations);
        var passwordHash = Convert.ToBase64String(pbkdf2.GetBytes(HashSize));

        return (passwordHash, salt);
    }

    public static string GenerateHash(string input, string salt)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentNullException(input);

        if (string.IsNullOrWhiteSpace(salt))
            throw new ArgumentNullException(salt);

        var saltBytes    = Convert.FromBase64String(salt);
        var pbkdf2       = new Rfc2898DeriveBytes(input, saltBytes, Iterations);
        var passwordHash = Convert.ToBase64String(pbkdf2.GetBytes(HashSize));

        return passwordHash;
    }
}