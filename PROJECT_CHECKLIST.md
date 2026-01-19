# CIS174 Final Project Requirements Checklist

## Project Overview
This checklist tracks the implementation of all requirements for the CIS174 Advanced C# Programming final project.

**Total Points: 150**

---

## Requirements Status

### 1. Routing Techniques (10 points)
**Status:** Partially Implemented ⚠️

**Requirements:**
- [ ] Implement proper route templates for website
- [ ] Implement attribute routing for Web API
- [x] Basic default routing configured in Program.cs

**Implementation Notes:**
- Current: Default MVC routing pattern configured (`{controller=Home}/{action=Index}/{id?}`)
- TODO: Add custom route templates for specific scenarios
- TODO: Create Web API controllers with attribute routing

**Files to Modify/Create:**
- `/CIS174FinalProject/Program.cs` - Add custom routes
- `/CIS174FinalProject/Controllers/[NewApiController].cs` - Create API controller with attribute routing

---

### 2. Binding Models and Validation (20 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Create binding models for user input
- [ ] Implement comprehensive validation using data annotations
- [ ] Provide meaningful validation messages
- [ ] Ensure all user input is validated
- [ ] Create a good user experience with client-side and server-side validation

**Implementation Notes:**
- TODO: Create ViewModels/DTOs for forms
- TODO: Add validation attributes ([Required], [StringLength], [Range], [EmailAddress], etc.)
- TODO: Implement ModelState validation in controllers
- TODO: Add client-side validation scripts

**Files to Modify/Create:**
- `/CIS174FinalProject/Models/[EntityModels].cs` - Create models with validation
- `/CIS174FinalProject/Controllers/` - Add validation logic in POST actions
- `/CIS174FinalProject/Views/` - Add validation message displays

---

### 3. Tag Helpers for Forms (10 points)
**Status:** Partially Implemented ⚠️

**Requirements:**
- [ ] Use Tag Helpers throughout forms (asp-for, asp-action, asp-controller)
- [ ] Implement validation Tag Helpers (asp-validation-for, asp-validation-summary)
- [ ] Create user-friendly form experiences

**Implementation Notes:**
- Current: Basic Tag Helpers infrastructure in place (_ViewImports.cshtml)
- TODO: Create forms using Tag Helpers
- TODO: Add validation Tag Helpers to forms

**Files to Modify/Create:**
- `/CIS174FinalProject/Views/[Controllers]/[Actions].cshtml` - Create form views with Tag Helpers
- `/CIS174FinalProject/Views/Shared/_ValidationScriptsPartial.cshtml` - Already exists

---

### 4. SQL Server Database with Entity Framework Core (20 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Create at least one DbContext
- [ ] Design entity models
- [ ] Configure Entity Framework Core
- [ ] Implement database interactions in services (not controllers)
- [ ] Demonstrate CREATE operations
- [ ] Demonstrate READ operations
- [ ] Demonstrate UPDATE operations
- [ ] Demonstrate DELETE operations
- [ ] Use migrations to manage database schema

**Implementation Notes:**
- TODO: Install EF Core NuGet packages (Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools)
- TODO: Create Data/ApplicationDbContext.cs
- TODO: Create entity models
- TODO: Create service layer for data access
- TODO: Configure connection string in appsettings.json
- TODO: Create and apply migrations

**Files to Modify/Create:**
- `/CIS174FinalProject/Data/ApplicationDbContext.cs` - Create DbContext
- `/CIS174FinalProject/Models/[Entities].cs` - Create entity models
- `/CIS174FinalProject/Services/[EntityService].cs` - Create service classes
- `/CIS174FinalProject/appsettings.json` - Add connection string
- `/CIS174FinalProject/Program.cs` - Register DbContext and services

---

### 5. MVC Filters (10 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Create and implement MVC filters
- [ ] Remove code redundancy from controllers
- [ ] Ensure no repetitious code in controllers/actions

**Implementation Notes:**
- TODO: Identify repetitive code patterns in controllers
- TODO: Create custom action filters, result filters, or authorization filters
- TODO: Apply filters globally, to controllers, or to specific actions

**Files to Modify/Create:**
- `/CIS174FinalProject/Filters/[CustomFilter].cs` - Create custom filters
- `/CIS174FinalProject/Program.cs` - Register global filters if needed
- `/CIS174FinalProject/Controllers/` - Apply filters with attributes

---

### 6. User Accounts and Identity (10 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Implement ASP.NET Core Identity
- [ ] Create user registration functionality
- [ ] Create user login functionality
- [ ] Configure Identity services

**Implementation Notes:**
- TODO: Install Microsoft.AspNetCore.Identity.EntityFrameworkCore
- TODO: Update DbContext to inherit from IdentityDbContext
- TODO: Configure Identity in Program.cs
- TODO: Create Account controller with Register and Login actions
- TODO: Create registration and login views
- TODO: Add user management functionality

**Files to Modify/Create:**
- `/CIS174FinalProject/Data/ApplicationDbContext.cs` - Update to IdentityDbContext
- `/CIS174FinalProject/Controllers/AccountController.cs` - Create account management
- `/CIS174FinalProject/Models/[AccountViewModels].cs` - Create ViewModels for registration/login
- `/CIS174FinalProject/Views/Account/` - Create registration and login views
- `/CIS174FinalProject/Program.cs` - Configure Identity services

---

### 7. Authorization (10 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Implement authorization to restrict access to parts of the application
- [ ] Use [Authorize] attribute on controllers/actions
- [ ] Show/hide Razor elements based on authorization
- [ ] Implement role-based or policy-based authorization

**Implementation Notes:**
- TODO: Apply [Authorize] attributes to protected controllers/actions
- TODO: Use @if (User.Identity.IsAuthenticated) in views
- TODO: Create different user roles if needed
- TODO: Implement authorization policies if needed

**Files to Modify/Create:**
- `/CIS174FinalProject/Controllers/` - Add [Authorize] attributes
- `/CIS174FinalProject/Views/Shared/_Layout.cshtml` - Add conditional UI elements
- `/CIS174FinalProject/Program.cs` - Configure authorization policies if needed

---

### 8. State Management (10 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Implement Sessions OR Cookies for state management
- [ ] Demonstrate proper usage throughout the application

**Implementation Notes:**
- TODO: Configure session services in Program.cs
- TODO: Implement session/cookie usage in controllers
- TODO: Use state management for shopping cart, user preferences, or similar features

**Files to Modify/Create:**
- `/CIS174FinalProject/Program.cs` - Configure session services
- `/CIS174FinalProject/Controllers/` - Implement session/cookie usage

---

### 9. Error Handling (10 points)
**Status:** Partially Implemented ⚠️

**Requirements:**
- [ ] Implement proper error handling techniques
- [ ] Create custom error handling view
- [ ] Configure error handling middleware
- [ ] Handle different error scenarios (404, 500, etc.)

**Implementation Notes:**
- Current: Basic error handler configured (`/Home/Error`)
- Current: Error view exists in Views/Shared/Error.cshtml
- TODO: Enhance error view to be more user-friendly
- TODO: Add status code pages middleware for 404 errors
- TODO: Implement global exception handling
- TODO: Add logging for errors

**Files to Modify/Create:**
- `/CIS174FinalProject/Program.cs` - Add status code pages middleware
- `/CIS174FinalProject/Views/Shared/Error.cshtml` - Already exists, may need enhancement
- `/CIS174FinalProject/Controllers/ErrorController.cs` - Create for handling status codes

---

### 10. Unit Testing (20 points)
**Status:** Partially Implemented ⚠️

**Requirements:**
- [ ] Create unit tests for all business logic
- [ ] Test all service layer code
- [ ] Achieve 100% coverage on business logic
- [ ] Use proper testing patterns (AAA - Arrange, Act, Assert)

**Implementation Notes:**
- Current: Test project exists with basic HomeController test
- TODO: Create tests for all service classes
- TODO: Create tests for all business logic
- TODO: Use mocking for dependencies (Moq framework)
- TODO: Verify 100% code coverage on services

**Files to Modify/Create:**
- `/CIS174FinalProject.Tests/Services/[ServiceTests].cs` - Create service tests
- `/CIS174FinalProject.Tests/CIS174FinalProject.Tests.csproj` - Add Moq package
- Set up code coverage reporting

---

### 11. Azure Deployment (20 points)
**Status:** Not Implemented ❌

**Requirements:**
- [ ] Deploy application to Azure
- [ ] Configure Azure App Service
- [ ] Configure Azure SQL Database
- [ ] Verify application works in production

**Implementation Notes:**
- TODO: Create Azure App Service
- TODO: Create Azure SQL Database
- TODO: Configure deployment pipeline
- TODO: Update connection strings for production
- TODO: Test deployed application

**Files to Modify/Create:**
- `/CIS174FinalProject/appsettings.json` - Production connection strings
- Azure portal configuration
- CI/CD pipeline configuration (if using GitHub Actions or Azure DevOps)

---

## Implementation Strategy

### Phase 1: Database and Data Access (30 points)
1. Set up Entity Framework Core and SQL Server
2. Create entity models with validation
3. Implement service layer with CRUD operations
4. Add unit tests for services

### Phase 2: Authentication and Authorization (20 points)
1. Implement ASP.NET Core Identity
2. Create registration and login functionality
3. Add authorization to protect resources
4. Update UI based on authentication state

### Phase 3: Forms and User Experience (40 points)
1. Create forms with Tag Helpers
2. Implement comprehensive validation
3. Add custom routing (MVC and API)
4. Implement state management (sessions/cookies)

### Phase 4: Code Quality and Deployment (40 points)
1. Implement MVC filters to reduce redundancy
2. Enhance error handling with custom views
3. Complete unit test coverage (100%)
4. Deploy to Azure

### Phase 5: Final Testing and Verification (20 points)
1. Verify all requirements are met
2. Test all functionality end-to-end
3. Verify Azure deployment
4. Code review and cleanup

---

## Current Status Summary

| Requirement | Points | Status | Completion % |
|-------------|--------|--------|--------------|
| 1. Routing | 10 | ⚠️ Partial | 30% |
| 2. Binding & Validation | 20 | ❌ Not Started | 0% |
| 3. Tag Helpers | 10 | ⚠️ Partial | 20% |
| 4. EF Core & Database | 20 | ❌ Not Started | 0% |
| 5. MVC Filters | 10 | ❌ Not Started | 0% |
| 6. Identity | 10 | ❌ Not Started | 0% |
| 7. Authorization | 10 | ❌ Not Started | 0% |
| 8. State Management | 10 | ❌ Not Started | 0% |
| 9. Error Handling | 10 | ⚠️ Partial | 40% |
| 10. Unit Testing | 20 | ⚠️ Partial | 10% |
| 11. Azure Deployment | 20 | ❌ Not Started | 0% |
| **TOTAL** | **150** | | **~9%** |

---

## Notes
- This project uses .NET 8.0 and ASP.NET Core MVC
- Following Murach's ASP.NET Core MVC best practices
- Test framework: MSTest
- Current database: None (needs to be implemented)
- Current authentication: None (needs to be implemented)

---

## Next Actions
1. Install Entity Framework Core packages
2. Design database schema and entity models
3. Create DbContext and configure EF Core
4. Implement service layer for data access
5. Add comprehensive unit tests for services

---

**Last Updated:** 2026-01-19
