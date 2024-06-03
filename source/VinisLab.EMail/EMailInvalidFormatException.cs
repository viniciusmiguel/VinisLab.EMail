namespace VinisLab.EMail;

public class EMailInvalidFormatException : Exception
{
    public override string Message => "The E-Mail provided has an invalid format.";
}