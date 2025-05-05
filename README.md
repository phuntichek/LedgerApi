# Ledger API

A minimalistic, in-memory ledger Web API built with ASP.NET Core (.NET 8).  
Designed to track basic monetary movements (deposits and withdrawals), view current balance, and access transaction history.  
This project is intended for evaluation and demonstration purposes, without external dependencies or persistent storage.

---

## Features

- ✅ Record deposits and withdrawals
- ✅ Get current balance
- ✅ Retrieve transaction history
- ✅ Stateless and in-memory (no database)
- ✅ Self-contained and easy to run

---

## Technologies

- .NET 8 (ASP.NET Core)
- C#
- Minimal API (no MVC or Controllers)
- In-memory data store
- RESTful endpoints

---

## How to Run

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed

### Running Locally

```bash
dotnet run --project LedgerApi
