using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace VinisLab.EMail;

/// <summary>
/// EMail is a type that represents e-mails validated over RFCs 5322 and 6854
/// </summary>
[Serializable]
public partial struct EMail
{
    /// <summary>
    /// Returns the e-mail address local part.
    /// </summary>
    public string LocalPart => _email.Split('@')[0];
    
    /// <summary>
    /// Returns the e-mail address domain.
    /// </summary>
    public string Domain => _email.Split('@')[1];
    
    private readonly string _email;
    
    private const string EmailValidationRegex = 
        @"^(?:[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*|\""(?:\\[\x00-\x7F]|[^\\\""])*\"")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}|(?:\[(?:(?:IPv6:[a-fA-F0-9:.]+)|(?:[0-9]{1,3}\.){3}[0-9]{1,3})\]))$";
    
    [GeneratedRegex(EmailValidationRegex, RegexOptions.Compiled | RegexOptions.NonBacktracking, "en-US")]
    private static partial Regex RegexEMailValidator();
    
    /// <summary>
    /// Constructs an EMail from a <see cref="string"/> containing a valid e-mail.
    /// </summary>
    /// <remarks>
    /// The constructor will throw an exception if the format is invalid.
    /// Use EMail.TryParse() if safe conversion is desired.
    /// </remarks>
    /// <param name="email">input string you want to convert</param>
    /// <exception cref="ArgumentNullException">Exception if the string is null</exception>
    /// <exception cref="EMailInvalidFormatException">Exception if the format is invalid</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EMail(string? email)
    {
        ArgumentNullException.ThrowIfNull(email);
        
        if (!Validate(email))
            throw new EMailInvalidFormatException();
        
        _email = email;
    }
    
    /// <summary>
    /// Constructs an EMail from a <see cref="ReadOnlySpan{T}"/> of char containing a valid e-mail.
    /// </summary>
    /// <remarks>
    /// The constructor will throw an exception if the format is invalid.
    /// Use EMail.TryParse() if safe conversion is desired.
    /// </remarks>
    /// <param name="email">input Span of char you want to convert</param>
    /// <exception cref="EMailInvalidFormatException">Exception if the format is invalid</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public EMail(ReadOnlySpan<char> email)
    {
        if (!Validate(email))
            throw new EMailInvalidFormatException();
        
        _email = email.ToString();
    }
    
    /// <summary>
    /// Validates if a <see cref="ReadOnlySpan{T}"/> of char contains a valid e-mail
    /// </summary>
    /// <param name="email">input to be validated</param>
    /// <returns>True if is a valid email.</returns>
    public static bool Validate(ReadOnlySpan<char> email)
    {
        return RegexEMailValidator().IsMatch(email);
    }
    
    /// <summary>
    /// Validates if a <see cref="string"/> of char contains a valid e-mail
    /// </summary>
    /// <param name="email">input to be validated</param>
    /// <returns>True if is a valid email.</returns>
    public static bool Validate(string? email)
    {
        return email is not null && RegexEMailValidator().IsMatch(email);
    }

    public static bool TryParse(string input, out EMail? output)
    {
        try
        {
            output = new EMail(input);
            return true;
        }
        catch (ArgumentNullException)
        {
            output = default;
            return false;
        }
        catch (EMailInvalidFormatException)
        {
            output = default;
            return false;
        }
    }
    
    public static bool TryParse(Span<char> input, out EMail? output)
    {
        try
        {
            output = new EMail(input);
            return true;
        }
        catch (EMailInvalidFormatException)
        {
            output = default;
            return false;
        }
    }

    /// <summary>
    /// Returns the e-mail as a <see cref="ReadOnlySpan{T}"/>
    /// </summary>
    /// <returns></returns>
    public ReadOnlySpan<char> AsSpan()
    {
        return _email.AsSpan();
    }
    
    /// <summary>
    /// Returns a <see cref="string"/> representing the e-email.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return _email;
    }
    
    public override int GetHashCode()
    {
        return _email.GetHashCode();
    }
}