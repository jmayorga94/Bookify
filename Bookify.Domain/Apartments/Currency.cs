﻿namespace Bookify.Domain.Apartments;

public record Currency
{
    public static readonly Currency Usd = new("USD");
    internal static readonly Currency None = new("");

    public string Code { get; init; }
    private Currency(string code) => Code = code;

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ?? throw new ApplicationException("The currency code is not valid");
    }
    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd };
}
