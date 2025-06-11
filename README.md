# Gollumeo.Acherus

![Icon.png](Rituals/Icon.png)

> Modular, intentional, and darkly architectural — a growing collection of focused packages designed for Clean Architecture in .NET.

---

## 🧱 Philosophy

**No bloated frameworks. No one-size-fits-all.**
Just sharp, composable modules — forged in real-world projects, refined for clarity, and packaged for reuse.

> What repeats gets extracted. What resists abstraction stays where it is.
> Acherus is the forge — not the fortress.

---

## 📦 Available Packages

### 🔹 [`Gollumeo.Acherus.Rituals`](https://www.nuget.org/packages/Gollumeo.Acherus.Rituals)

> Modular boot system for .NET apps
> Includes `IRune`, `AbstractRuneforge`, and a contract-first DI bootstrapping pattern.

```bash
dotnet add package Gollumeo.Acherus.Rituals
```

---

### 🔹 [`Gollumeo.Acherus.Application`](https://www.nuget.org/packages/Gollumeo.Acherus.Application)

> Primitives for the Application layer in Clean Architecture
> Includes `Result<T>`, with more building blocks to come.

```bash
dotnet add package Gollumeo.Acherus.Application
```

---

## 🛠️ What’s Coming Next?

* `Gollumeo.Acherus.Domain` → base contracts (`IAggregateRoot`, `IDomainEvent`)
* `Gollumeo.Acherus.Persistence` → explicit abstractions (no ORM lock-in)
* `Gollumeo.Acherus.Testing` → base testing DSL (result-based assertions, fakes)

---

## 🧙‍♂️ Who’s Behind This?

Crafted by [Pierre "Golluméo" Mauriello](https://github.com/gollumeo),
for devs who think architecture is a spell—not a checkbox.

---

## 📜 License

[MIT](./LICENSE)
