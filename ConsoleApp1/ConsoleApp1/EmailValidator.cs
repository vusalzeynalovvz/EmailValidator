using System;

public class ShortEmailException : Exception
{
    public ShortEmailException(string message) : base(message) { }
}

public class NotAnEmailAddressException : Exception
{
    public NotAnEmailAddressException(string message) : base(message) { }
}

public class EmailValidator
{
    public bool Validate(string email)
    {
        if (email.Length < 10)
        {
            throw new ShortEmailException("Email adres çox qisadir .");
        }

        if (!email.EndsWith("@mail.com"))
        {
            throw new NotAnEmailAddressException("Düzgün e-mail deyil.");
        }

        return true;
    }
}

public class Program
{
    public static void Main()
    {
        string email = "ali.aliyevil@mail.com";
        var validator = new EmailValidator();

        try
        {
            bool isValid = validator.Validate(email);
            Console.WriteLine(isValid);
        }
        catch (ShortEmailException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotAnEmailAddressException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
