namespace VinisLab.EMail;

public static class StringEMailExtensionMethods
{
    /// <summary>
    /// Returns an EMail object.
    /// Throws EMailInvalidFormatException if the email is invalid or string is null.
    /// </summary>
    /// <param name="s">The string containing an email</param>
    /// <returns>Validated EMail object</returns>
    public static EMail ToEMail(this string s)
    {
        return new EMail(s);
    }
}