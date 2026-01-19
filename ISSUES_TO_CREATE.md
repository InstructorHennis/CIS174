# GitHub Issues to Create for CIS174 Final Project

This document contains all the issues that need to be created for the final project requirements. Each section below represents one issue with its title, description, and acceptance criteria.

---

## Issue 1: Implement Proper Routing Techniques (10 points)

### Description
Implement proper routing techniques including route templates for the website and attribute routing for Web API endpoints.

### Point Value
10 points

### Acceptance Criteria
- [ ] Implement route templates for website navigation
- [ ] Implement attribute routing for Web API endpoints
- [ ] Follow best practices from Murach's ASP.NET Core MVC
- [ ] Ensure routing is clean and follows RESTful conventions
- [ ] Document routing patterns used in the application

### Labels
`enhancement`, `routing`, `10-points`

---

## Issue 2: Implement Binding Models and Input Validation (20 points)

### Description
Use binding models and validate all user input in a logical manner to provide users with a good experience and keep the application safe.

### Point Value
20 points

### Acceptance Criteria
- [ ] Create appropriate binding models for all forms
- [ ] Implement data annotations for validation (e.g., [Required], [StringLength], [Range])
- [ ] Use ModelState.IsValid checks in controllers
- [ ] Display validation errors to users in a user-friendly manner
- [ ] Implement both client-side and server-side validation
- [ ] Protect against common security vulnerabilities (XSS, SQL injection, etc.)
- [ ] Follow validation patterns from Murach's ASP.NET Core MVC

### Labels
`enhancement`, `validation`, `security`, `20-points`

---

## Issue 3: Implement Tag Helpers for Forms (10 points)

### Description
Use tag helpers to create forms in the web application for a nice user experience.

### Point Value
10 points

### Acceptance Criteria
- [ ] Use Tag Helpers for form elements (asp-for, asp-action, asp-controller)
- [ ] Implement asp-validation-for and asp-validation-summary for error display
- [ ] Follow Murach's Tag Helper conventions
- [ ] Ensure forms are accessible and user-friendly
- [ ] Use Bootstrap styling as demonstrated in Murach's examples

### Labels
`enhancement`, `ui`, `tag-helpers`, `10-points`

---

## Issue 4: Create SQL Server Database with Entity Framework Core (20 points)

### Description
Create and utilize a SQL Server database using at least one data context and Entity Framework Core to access the database. Perform all database interactions in services with examples of CRUD operations.

### Point Value
20 points

### Acceptance Criteria
- [ ] Set up SQL Server database connection
- [ ] Create at least one DbContext class following Murach's patterns
- [ ] Implement Entity Framework Core models with proper data annotations
- [ ] Create service classes for all database interactions
- [ ] Implement Create operations in services
- [ ] Implement Read operations in services
- [ ] Implement Update operations in services
- [ ] Implement Delete operations in services
- [ ] Use Code First approach with migrations
- [ ] Use LINQ for queries as shown in Murach's examples
- [ ] Register services in Program.cs with appropriate lifetime

### Labels
`enhancement`, `database`, `entity-framework`, `20-points`

---

## Issue 5: Use MVC Filters to Remove Code Redundancy (10 points)

### Description
Use MVC filters to clean up code and remove code redundancy. Controllers and actions should not have repetitious code.

### Point Value
10 points

### Acceptance Criteria
- [ ] Identify repetitious code in controllers/actions
- [ ] Create appropriate MVC filters (Action Filters, Result Filters, Authorization Filters, etc.)
- [ ] Apply filters using attributes or globally as appropriate
- [ ] Remove duplicate code from controllers
- [ ] Follow best practices from Murach's ASP.NET Core MVC
- [ ] Document the purpose of each custom filter

### Labels
`enhancement`, `filters`, `code-quality`, `10-points`

---

## Issue 6: Implement User Accounts with Identity (10 points)

### Description
Implement user accounts, registration, and login functionality using ASP.NET Core Identity.

### Point Value
10 points

### Acceptance Criteria
- [ ] Install and configure ASP.NET Core Identity
- [ ] Create user registration functionality
- [ ] Create login functionality
- [ ] Create logout functionality
- [ ] Implement password requirements and validation
- [ ] Create appropriate views for authentication pages
- [ ] Follow Identity implementation patterns from Murach's ASP.NET Core MVC
- [ ] Store user data securely in the database

### Labels
`enhancement`, `authentication`, `identity`, `10-points`

---

## Issue 7: Implement Authorization and Access Control (10 points)

### Description
Use authorization to limit access to parts of the application for users without proper permissions. Include Razor elements that are shown or hidden based on authorization.

### Point Value
10 points

### Acceptance Criteria
- [ ] Implement [Authorize] attributes on controllers/actions as needed
- [ ] Create role-based or policy-based authorization
- [ ] Use @if (User.IsInRole()) or similar in Razor views to show/hide elements
- [ ] Implement proper authorization checks following Murach's patterns
- [ ] Redirect unauthorized users appropriately
- [ ] Test authorization with different user roles/permissions

### Labels
`enhancement`, `authorization`, `security`, `10-points`

---

## Issue 8: Implement State Management with Sessions or Cookies (10 points)

### Description
Create and utilize state management through Sessions or Cookies.

### Point Value
10 points

### Acceptance Criteria
- [ ] Configure session or cookie middleware in Program.cs
- [ ] Implement state management for at least one feature (e.g., shopping cart, user preferences)
- [ ] Use session/cookie data appropriately in controllers
- [ ] Follow state management patterns from Murach's ASP.NET Core MVC
- [ ] Handle session expiration gracefully
- [ ] Ensure secure cookie settings if using cookies

### Labels
`enhancement`, `state-management`, `10-points`

---

## Issue 9: Implement Custom Error Handling (10 points)

### Description
Create and utilize proper error handling techniques including a custom error handling view.

### Point Value
10 points

### Acceptance Criteria
- [ ] Create custom error view(s)
- [ ] Configure UseExceptionHandler middleware
- [ ] Implement different error handling for Development vs Production
- [ ] Log errors appropriately
- [ ] Handle 404 and other common HTTP errors
- [ ] Follow error handling patterns from Murach's ASP.NET Core MVC
- [ ] Display user-friendly error messages
- [ ] Ensure sensitive information is not exposed in error messages

### Labels
`enhancement`, `error-handling`, `10-points`

---

## Issue 10: Implement Unit Tests with 100% Business Logic Coverage (20 points)

### Description
Unit test all business logic with 100% coverage. All code in services should be tested since the application is relatively small.

### Point Value
20 points

### Acceptance Criteria
- [ ] Create unit tests for all service classes
- [ ] Achieve 100% code coverage on business logic
- [ ] Follow AAA pattern (Arrange, Act, Assert) in tests
- [ ] Use appropriate mocking for dependencies
- [ ] Test both success and failure scenarios
- [ ] Test edge cases and boundary conditions
- [ ] Use xUnit, NUnit, or MSTest consistently
- [ ] Include test assertions that validate expected behavior
- [ ] Generate code coverage reports to verify 100% coverage

### Labels
`enhancement`, `testing`, `unit-tests`, `20-points`

---

## Issue 11: Deploy to Azure (20 points)

### Description
Deploy the application to Azure and ensure it works properly in the cloud environment.

### Point Value
20 points

### Acceptance Criteria
- [ ] Create Azure account and necessary resources
- [ ] Configure Azure SQL Database
- [ ] Deploy ASP.NET Core application to Azure App Service
- [ ] Update connection strings for Azure environment
- [ ] Verify all features work in Azure (database, authentication, etc.)
- [ ] Configure appropriate Azure settings (environment variables, security, etc.)
- [ ] Document deployment process
- [ ] Ensure application is accessible via HTTPS
- [ ] Test the deployed application thoroughly

### Labels
`enhancement`, `deployment`, `azure`, `20-points`

---

## Summary

Total Points: 150 points

- Routing: 10 points
- Validation: 20 points
- Tag Helpers: 10 points
- Database/EF Core: 20 points
- MVC Filters: 10 points
- Identity: 10 points
- Authorization: 10 points
- State Management: 10 points
- Error Handling: 10 points
- Unit Tests: 20 points
- Azure Deployment: 20 points

## Notes

These issues should be created in the GitHub repository for the CIS174 Final Project. Each issue represents a requirement from the final project specification and should be completed to demonstrate proficiency in ASP.NET Core MVC development following the principles from Murach's ASP.NET Core MVC textbook.
