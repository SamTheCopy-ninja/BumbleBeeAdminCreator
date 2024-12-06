using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    // Console program for generating the SQL query to create an Admin for the BumbleBee Foundation app
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Admin Email:");
        string adminEmail = Console.ReadLine();

        Console.WriteLine("Enter Plaintext Password:");
        string plainPassword = Console.ReadLine();

        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        string hashedPassword = HashPassword(plainPassword);

        string sqlScript = $@"
        INSERT INTO [BumbleBeeDB].[dbo].[Users]
            ([FirstName], [LastName], [Email], [Password], [Role], [CreatedAt])
        VALUES
            ('{firstName}', '{lastName}', '{adminEmail}', '{hashedPassword}', 'Admin', GETDATE());";

        Console.WriteLine("Generated SQL Script:");
        Console.WriteLine(sqlScript);
    }

    private static string HashPassword(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes) builder.Append(b.ToString("x2"));
            return builder.ToString();
        }
    }
}

