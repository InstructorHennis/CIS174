# Copilot Instructions for CIS174 - Advanced C# Programming

## Project Context
This repository is for CIS174 Advanced C# Programming coursework, focusing on ASP.NET Core MVC development. All code and examples should align with principles and practices from **Murach's ASP.NET Core MVC** textbook.

## Coding Standards and Practices

### ASP.NET Core MVC Architecture
- Follow the Model-View-Controller (MVC) pattern as outlined in Murach's ASP.NET Core MVC
- Keep controllers thin - business logic belongs in models or separate service classes
- Use ViewModels when views require data from multiple models
- Follow Murach's naming conventions for controllers, actions, and views

### Models
- Use data annotations for validation (e.g., `[Required]`, `[StringLength]`, `[Range]`)
- Implement proper validation attributes as shown in Murach's examples
- Use Entity Framework Core for data access following Murach's repository pattern when applicable
- Include navigation properties for related entities

### Views
- Use Razor syntax following Murach's conventions
- Leverage Tag Helpers (e.g., `asp-for`, `asp-action`, `asp-controller`)
- Include proper validation messages using `asp-validation-for` and `asp-validation-summary`
- Use Layout pages and ViewStart for consistent structure
- Apply Bootstrap for styling as demonstrated in Murach's examples

### Controllers
- Use attribute routing when appropriate
- Implement proper HTTP verb attributes (`[HttpGet]`, `[HttpPost]`)
- Follow POST-Redirect-GET (PRG) pattern for form submissions
- Return appropriate action results (ViewResult, RedirectToActionResult, etc.)
- Use ModelState.IsValid for validation checks

### Dependency Injection
- Register services in Program.cs (or Startup.cs for older versions)
- Use constructor injection in controllers
- Follow Murach's service lifetime guidelines (Transient, Scoped, Singleton)

### Error Handling
- Implement proper exception handling
- Use custom error pages in production
- Log errors appropriately
- Follow Murach's error handling patterns

### Database and Entity Framework Core
- Use Code First approach with migrations
- Implement DbContext classes following Murach's patterns
- Use LINQ for queries as shown in Murach's examples
- Apply proper database context configuration

### Code Style
- Use meaningful variable and method names
- Follow C# naming conventions (PascalCase for public members, camelCase for local variables)
- Include XML documentation comments for public APIs
- Keep methods focused and concise

### Testing
- Write unit tests for business logic
- Test controller actions with appropriate test data
- Follow AAA pattern (Arrange, Act, Assert)

## Project-Specific Guidelines
- This is a learning repository for exploring AI-assisted development
- Code should be educational and well-commented where complexity exists
- Prioritize clarity and adherence to Murach's textbook patterns over optimization
- Include summary comments for complex logic to aid learning

## Additional Notes
- When generating code examples, reference specific Murach's ASP.NET Core MVC chapters or patterns when applicable
- Ensure all code is compatible with .NET 8 unless otherwise specified
- Follow security best practices, especially for authentication and authorization features
