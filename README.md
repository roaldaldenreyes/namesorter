# Name Sorter

Simple .NET 6 console app that sorts names by last name, then given names.

Build & Run

1. Build

```powershell
dotnet build src/NameSorter
```

2. Run

```powershell
dotnet run --project src/NameSorter -- <path-to-input-file>
```

Example creates or overwrites `sorted-names-list.txt` in the current working directory and prints sorted names to console.

Tests

```powershell
dotnet test tests/NameSorter.Tests
```

Continuous Integration

This repository includes an `appveyor.yml` configuration to run builds and tests on AppVeyor (Windows).

