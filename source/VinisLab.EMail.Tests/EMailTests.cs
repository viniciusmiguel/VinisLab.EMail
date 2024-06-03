namespace VinisLab.EMail.Tests;

public class EMailTests
{
    [Fact]
    public void All_Valid_String_EMails_Should_Pass()
    {
        Assert.All(EMails.AllTopLevelDomains, s =>
        {
            Assert.True(EMail.Validate(s));
        });
    }

    [Fact]
    public void All_Invalid_String_EMails_Should_Not_Pass()
    {
        Assert.All(EMails.AllInvalidEMails, s =>
        {
            Assert.False(EMail.Validate(s));
        });
    }
    
    [Fact]
    public void All_Valid_Span_EMails_Should_Pass()
    {
        Assert.All(EMails.AllTopLevelDomains, s =>
        {
            Assert.True(EMail.Validate(s));
        });
    }

    [Fact]
    public void All_Invalid_Span_EMails_Should_Not_Pass()
    {
        Assert.All(EMails.AllInvalidEMails, s =>
        {
            Assert.False(EMail.Validate(s.AsSpan()));
        });
    }

    [Fact]
    public void EMail_Type_Should_Be_Created()
    {
        var email = new EMail("valid@example.com");
        Assert.NotNull(email);
        Assert.IsType<EMail>(email);
    }
    
    [Fact]
    public void EMail_Type_Should_Not_Be_Created()
    {
        Assert.Throws<EMailInvalidFormatException>(() => new EMail("invalid@example"));
    }
    
    
    [Fact]
    public void EMail_Type_Should_Be_Created_From_String_Extension()
    {
        var email = "valid@example.com".ToEMail();
        Assert.NotNull(email);
        Assert.IsType<EMail>(email);
    }
    
    [Fact]
    public void LocalPart_And_Domain_Should_Be_Valid()
    {
        var email = "valid@example.com".ToEMail();
        Assert.Equal("valid",email.LocalPart);
        Assert.Equal("example.com",email.Domain);
    }
}