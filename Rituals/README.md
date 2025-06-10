## Gollumeo.Acherus.Rituals

> 🪄 A lightweight bootstrapping layer for .NET Web APIs.
> Built with intent. Driven by convention. Forged by runes.

---

### 🧠 What is this?

**Rituals** is a bootstrapping system inspired by Laravel’s `ServiceProvider` and Clean Architecture principles.

It gives you:

* A **modular way** to organize your boot logic (DI, middlewares, routing).
* A **clear entrypoint** (`Runeforge`) instead of a cluttered `Program.cs`.
* A system of `Rune`s, each handling one concern.

---

### ⚙️ How does it work?

You create a class that inherits from `DormantRuneforge` and override `Frostmourne()`:

```csharp
public class MyRuneforge : DormantRuneforge
{
    protected override IEnumerable<IRune> Frostmourne()
    {
        yield return new MyCustomRune();
    }
}
```

Each `IRune` exposes:

```csharp
void Extract(IServiceCollection services, IConfiguration config);
void CarveWith(WebApplication app);
```

> Think of them as your dependency injection & middleware rituals.

Base class automatically loads:

* `HttpRune` (adds controllers)
* `OpenApiRune` (adds Swagger)

---

### ✨ Why use this?

* You want to keep `Program.cs` clean and focused.
* You want modular, reusable DI/infra logic.
* You like to **compose** your startup logic like building blocks.

And because you're tired of gluing code in the wrong layer.

---

### 📦 Installation

```bash
dotnet add package Gollumeo.Acherus.Rituals
```

---

### 🧪 Sample

```csharp
public class MyRuneforge : DormantRuneforge
{
    protected override IEnumerable<IRune> Frostmourne()
    {
        yield return new AuthRune();
        yield return new HealthCheckRune();
    }
}
```

Then in your `Program.cs`:

```csharp
await new MyRuneforge().Inscribe(args);
```

---

### 🧙️‍♂️ Lore

> "Runes are not features. They are intentions, crystallized."
> — *DormantRuneforge, Book I: The Binding*

---

### 🛠️ TODO

* Add `CorsRune`, `LoggingRune`, `HealthCheckRune`
* Write docs for rune authoring
* Release `Gollumeo.Acherus.Result`
