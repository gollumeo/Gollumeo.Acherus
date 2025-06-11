# Gollumeo.Acherus.Application

> A minimal set of primitives designed for the Application layer in Clean Architecture. Includes a battle-tested `Result<T>` pattern — with more to come.

---

## ✨ Why this package?

Because some building blocks live in **every project**.
Because Clean Architecture deserves **clean boundaries**.
Because copy-pasting from `/Shared` isn't a design strategy.

This package provides:

* `Result<T>` and `Result` → for functional success/failure semantics
* An extensible base for future additions like:

    * `Maybe<T>`
    * `IDomainEvent`
    * `IUseCase<T>`
    * and more...

It’s scoped for the **Application** layer — not your domain, not your infrastructure.

---

## 📦 Installation

```bash
# via NuGet CLI
dotnet add package Gollumeo.Acherus.Application
```

---

## ✅ Included: Result & Result<T>

### With data:

```csharp
Result<User> result = UserService.Create("email@example.com");

var response = result.Match(
    user => Ok(user),
    error => BadRequest(error)
);
```

### Without data:

```csharp
Result outcome = PaymentService.CancelInvoice(invoiceId);

if (outcome.IsFailure)
    return BadRequest(outcome.Error);

return Ok();
```

---

## 🧠 Philosophy

> "You can duplicate three times. But after that, you're not exploring anymore. You're ignoring a pattern."

This package isn’t about early abstraction. It’s about **formalizing what keeps coming back** in well-designed application services.

The Application layer should be:

* Dry, but not cryptic
* Explicit, not leaky
* Resilient, not magical

This package is a toolset for that.

---

## 📚 API Overview

### `Result<T>`

```csharp
public bool IsSuccess { get; }
public bool IsFailure => !IsSuccess;
public T Value { get; }
public string Error { get; }

public static Result<T> Success(T value);
public static Result<T> Failure(string error);

public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure);
```

### `Result`

```csharp
public static Result Success();
public static Result Failure(string error);
```

---

## 🧲 Roadmap

* [ ] Add `Maybe<T>`
* [ ] Introduce `Ensure()` style validators
* [ ] `IUseCase` and `ICommand` abstractions
* [ ] Nullable-safe helpers for ValueObjects

---

Crafted for clarity. Sharpened by repetition.
Designed to serve the Application layer — not replace it.
