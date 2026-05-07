# Online Book Store - ASP.NET Core MVC Application

This project is a full-featured Online Book Store application developed using ASP.NET Core MVC and Razor Pages as part of the Wipro NGA .NET Cohort Assignment.

The application demonstrates advanced ASP.NET Core concepts including:

- MVC Architecture
- Razor Pages
- Session Management
- Authentication & Authorization
- Custom Validation Attributes
- MVC Filters
- Routing
- Dependency Injection
- Repository Pattern
- Shopping Cart System
- Error Handling

---

# Features

## User Authentication
- Login system with User/Admin roles
- Session management using ASP.NET Core Session

## Book Management
- Add new books
- View all books
- View detailed information of books
- ISBN and Price validation

## Shopping Cart
- Add selected books to cart
- View cart contents

## MVC Filters
- Logging Filter
- Authorization Filter
- Error Handling Filter

## Routing
- Custom route for Book Details

## Validation
- Custom ISBN Validation
- Custom Price Validation

---

# Technologies Used

- ASP.NET Core MVC
- Razor Pages
- C#
- Session State
- Dependency Injection
- Repository Pattern
- Custom Filters
- Data Annotations

---

# Project Structure

```text
Controllers/
Models/
Views/
Filters/
Repositories/
Validation/
Pages/
Program.cs
```

---

# Application Flow

```text
Login
 ↓
Dashboard
 ↓
Add New Book
 ↓
View Books
 ↓
View Details
 ↓
Add To Cart
 ↓
Shopping Cart
```

---

# Sample Outputs

## Login Page

```text
Username: Giridhar
Role: Admin
```

---

## Dashboard

```text
Add New Book
View Books
Shopping Cart
Test Error Filter
```

---

## Add Book

```text
Title: Atomic Habits
Author: James Clear
ISBN: 1234567890123
Price: 599
```

---

## Book List

```text
Atomic Habits
Author: James Clear
Price: ₹599
View Details
```

---

## Book Details

```text
Title: Atomic Habits
Author: James Clear
ISBN: 1234567890123
Price: ₹599
Add To Cart
```

---

## Shopping Cart

```text
Atomic Habits
Author: James Clear
Price: ₹599
```

---

## Authorization Test

```text
Only Admin Can Access This Page
```

---

## Error Handling

```text
Something went wrong!
```

---

# Concepts Implemented

| Feature | Implemented |
|---|---|
| MVC | ✅ |
| Razor Pages | ✅ |
| Authentication | ✅ |
| Authorization | ✅ |
| Session Management | ✅ |
| Shopping Cart | ✅ |
| Routing | ✅ |
| Dependency Injection | ✅ |
| Repository Pattern | ✅ |
| Filters | ✅ |
| Error Handling | ✅ |
| Custom Validation | ✅ |

---

# Learning Outcomes

- Understanding ASP.NET Core MVC Architecture
- Implementing Razor Pages with MVC
- Applying Custom Validation
- Managing Sessions
- Implementing Filters
- Using Repository Pattern
- Applying Dependency Injection
- Handling Authorization and Authentication

---

# Author

Giridhar Gopal
