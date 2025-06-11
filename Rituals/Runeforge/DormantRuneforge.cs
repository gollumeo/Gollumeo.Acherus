using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Rituals.Contracts;
using Rituals.Runes;

namespace Rituals.Runeforge;

public abstract class DormantRuneforge
{
    private static readonly IRune[] RunesOfTheFallenCrusader =
    [
        new HttpRune(),
        new OpenApiRune()
    ];
    
    public static async Task Inscribe(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var runes = RunesOfTheFallenCrusader.Concat(Frostmourne()).ToList();

        Console.WriteLine("🪄 Activating runes:");
        foreach (var rune in runes)
        {
            rune.Extract(builder.Services, builder.Configuration);
            Console.WriteLine($" → {rune.GetType().Name}");
        }

        var app = builder.Build();

        foreach (var rune in runes)
            rune.CarveWith(app);

        await app.RunAsync();
    }

    protected static IEnumerable<IRune> Frostmourne()
    {
        yield break;
    }
}