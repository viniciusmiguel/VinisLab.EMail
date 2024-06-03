namespace VinisLab.EMail;

public static class SpanEMailExtensionMethods
{
    /// <summary>
    /// Returns an EMail object.
    /// Throws EMailInvalidFormatException if the email is invalid.
    /// </summary>
    /// <param name="s">The Span containing an email</param>
    /// <returns>Validated EMail object</returns>
    public static EMail ToEMail(this Span<char> s)
    {
        return new EMail(s);
    }
    
    /// <summary>
    /// Returns an EMail object.
    /// Throws EMailInvalidFormatException if the email is invalid.
    /// </summary>
    /// <param name="s">The Span containing an email</param>
    /// <returns>Validated EMail object</returns>
    public static EMail ToEMail(this ReadOnlySpan<char> s)
    {
        return new EMail(s);
    }
}