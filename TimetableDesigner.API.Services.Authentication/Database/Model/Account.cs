﻿namespace TimetableDesigner.API.Services.Authentication.Database.Model;

public class Account
{
    public long Id { get; set; }
    public string Email { get; set; } = null!;
    public byte[] Password { get; set; } = null!;
    public string PasswordSaltLeft { get; set; } = null!;
    public string PasswordSaltRight { get; set; } = null!;
    public uint Version { get; set; }
    
    public virtual IEnumerable<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}