# CIS174 Final Project Requirements Checklist

## Project Overview
This checklist tracks the implementation of all requirements for the CIS174 Advanced C# Programming final project.

**Total Points: 150**

---

## Requirements Status

### 1. Routing Techniques (10 points)
**Status:** Partially Implemented ⚠️

**Requirements:**
- [x] Implement proper route templates for website
- [ ] Implement attribute routing for Web API
- [x] Basic default routing configured in Program.cs

**Implementation Notes:**
- ✅ DONE: Default MVC routing pattern configured (`{controller=Home}/{action=Index}/{id?}`)
- ✅ DONE: Route templates working for all controllers (Home, Book, Author)
- TODO: Create Web API controllers with attribute routing (if needed for full points)

**Files Modified:**
- ✅ `/CIS174FinalProject/Program.cs` - Default routing configured (line 58-60)

**Files to Create:**
- `/CIS174FinalProject/Controllers/Api/[ApiController].cs` - Create API controller with attribute routing for full credit

---

### 2. Binding Models and Validation (20 points)
**Status:** Implemented ✅

**Requirements:**
- [x] Create binding models for user input
- [x] Implement comprehensive validation using data annotations
- [x] Provide meaningful validation messages
- [x] Ensure all user input is validated
- [x] Create a good user experience with client-side and server-side validation

**Implementation Notes:**
- ✅ DONE: Models created with comprehensive validation attributes
  - Book model: [Required], [MaxLength(17)] for ISBN, [MaxLength(200)] for Title, [ForeignKey] attributes
  - Author model: [Required], [MaxLength(50)] for FirstName and LastName
  - Genre model: [Required], [MaxLength(50)] for Description
- ✅ DONE: ModelState.IsValid validation in all POST actions (BookController.Create, BookController.Edit, AuthorController.Create)
- ✅ DONE: Client-side validation enabled with _ValidationScriptsPartial
- ✅ DONE: Validation messages displayed using asp-validation-for tag helpers
- ✅ DONE: [ValidateAntiForgeryToken] attribute used on POST actions for security

**Files Implemented:**
- ✅ `/CIS174FinalProject/Models/Book.cs` - Full validation with data annotations
- ✅ `/CIS174FinalProject/Models/Author.cs` - Full validation with data annotations
- ✅ `/CIS174FinalProject/Models/Genre.cs` - Full validation with data annotations
- ✅ `/CIS174FinalProject/Controllers/BookController.cs` - ModelState validation in Create and Edit
- ✅ `/CIS174FinalProject/Controllers/AuthorController.cs` - ModelState validation in Create
- ✅ `/CIS174FinalProject/Views/Book/Edit.cshtml` - Validation displays
- ✅ `/CIS174FinalProject/Views/Author/Create.cshtml` - Validation displays

---

### 3. Tag Helpers for Forms (10 points)
**Status:** Implemented ✅

**Requirements:**
- [x] Use Tag Helpers throughout forms (asp-for, asp-action, asp-controller)
- [x] Implement validation Tag Helpers (asp-validation-for, asp-validation-summary)
- [x] Create user-friendly form experiences

**Implementation Notes:**
- ✅ DONE: Tag Helpers infrastructure configured in _ViewImports.cshtml
- ✅ DONE: Forms extensively use Tag Helpers:
  - asp-for for input binding (ISBN, Title, Year, AuthorId, GenreId, FirstName, LastName)
  - asp-action and asp-controller for navigation links
  - asp-route-id for passing route parameters
  - asp-items for dropdown lists (Authors, Genres)
  - asp-validation-for for field-level validation messages
  - asp-validation-summary for form-level validation
- ✅ DONE: User-friendly features like "Add Author" button during book creation
- ✅ DONE: Bootstrap styling integrated with form controls

**Files Implemented:**
- ✅ `/CIS174FinalProject/Views/_ViewImports.cshtml` - Tag Helpers enabled
- ✅ `/CIS174FinalProject/Views/Book/Edit.cshtml` - Extensive Tag Helper usage for create/edit
- ✅ `/CIS174FinalProject/Views/Book/Delete.cshtml` - Tag Helper usage for delete confirmation
- ✅ `/CIS174FinalProject/Views/Author/Create.cshtml` - Tag Helper usage for author creation
- ✅ `/CIS174FinalProject/Views/Home/Index.cshtml` - Tag Helpers in navigation links
- ✅ `/CIS174FinalProject/Views/Shared/_ValidationScriptsPartial.cshtml` - Client-side validation

---

### 4. SQL Server Database with Entity Framework Core (20 points)
**Status:** Implemented ✅

**Requirements:**
- [x] Create at least one DbContext
- [x] Design entity models
- [x] Configure Entity Framework Core
- [x] Implement database interactions in services (not controllers)
- [x] Demonstrate CREATE operations
- [x] Demonstrate READ operations
- [x] Demonstrate UPDATE operations
- [x] Demonstrate DELETE operations
- [x] Use migrations to manage database schema

**Implementation Notes:**
- ✅ DONE: LibraryContext DbContext created with proper configuration
- ✅ DONE: Three entity models: Book, Author, Genre with navigation properties
- ✅ DONE: EF Core configured in Program.cs with dual database support:
  - SQLite for development (library.db)
  - SQL Server for production (configured in appsettings.json)
- ✅ DONE: Full CRUD operations implemented:
  - CREATE: BookController.Create, AuthorController.Create
  - READ: HomeController.Index (with Include for related data)
  - UPDATE: BookController.Edit
  - DELETE: BookController.Delete
- ✅ DONE: Initial migration created (20260119172407_Initial.cs)
- ✅ DONE: Seed data for 10 famous books, 10 authors, and 5 genres
- ✅ DONE: Database.EnsureCreated() used in Program.cs for automatic database setup
- ⚠️ NOTE: Direct DbContext usage in controllers instead of separate service layer - works but could be refactored for better architecture

**Files Implemented:**
- ✅ `/CIS174FinalProject/Data/` or `/Models/LibraryContext.cs` - DbContext with seed data
- ✅ `/CIS174FinalProject/Models/Book.cs` - Entity with navigation properties
- ✅ `/CIS174FinalProject/Models/Author.cs` - Entity with navigation properties
- ✅ `/CIS174FinalProject/Models/Genre.cs` - Entity model
- ✅ `/CIS174FinalProject/appsettings.json` - Connection string configured
- ✅ `/CIS174FinalProject/Program.cs` - DbContext registration and configuration
- ✅ `/CIS174FinalProject/Migrations/20260119172407_Initial.cs` - Initial migration
- ✅ `/CIS174FinalProject/Controllers/BookController.cs` - CRUD operations
- ✅ `/CIS174FinalProject/Controllers/AuthorController.cs` - Create operation
- ✅ `/CIS174FinalProject/Controllers/HomeController.cs` - Read operation with Include

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
**Status:** Partially Implemented ⚠️

**Requirements:**
- [x] Implement Sessions OR Cookies for state management
- [ ] Demonstrate proper usage throughout the application

**Implementation Notes:**
- ✅ DONE: Session services configured in Program.cs (lines 25-30)
  - IdleTimeout set to 30 minutes
  - HttpOnly and IsEssential cookies configured
- ✅ DONE: Session middleware enabled (UseSession in Program.cs line 54)
- TODO: Actually use session state in controllers/views (e.g., shopping cart, user preferences, last viewed books)

**Files Implemented:**
- ✅ `/CIS174FinalProject/Program.cs` - Session services configured and middleware enabled

**Files to Modify:**
- `/CIS174FinalProject/Controllers/` - Add session usage (e.g., HttpContext.Session.SetString, GetString)
- `/CIS174FinalProject/Views/` - Display session-based data

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
- [x] Create unit tests for all business logic
- [ ] Test all service layer code
- [ ] Achieve 100% coverage on business logic
- [x] Use proper testing patterns (AAA - Arrange, Act, Assert)

**Implementation Notes:**
- ✅ DONE: Test project created (CIS174FinalProject.Tests)
- ✅ DONE: MSTest framework configured
- ✅ DONE: Tests created for:
  - LibraryContext creation and DbSets
  - Book model properties
  - Author model properties
  - Genre model properties
  - HomeController basic functionality
- ✅ DONE: In-memory database used for context testing
- ✅ DONE: AAA pattern followed in all tests
- TODO: Create tests for controller CRUD operations
- TODO: Add mocking framework (Moq) for dependency injection
- TODO: Achieve 100% coverage on business logic
- TODO: Test validation scenarios

**Files Implemented:**
- ✅ `/CIS174FinalProject.Tests/CIS174FinalProject.Tests.csproj` - Test project with MSTest
- ✅ `/CIS174FinalProject.Tests/LibraryContextTests.cs` - Context and model tests (5 tests)
- ✅ `/CIS174FinalProject.Tests/HomeControllerTests.cs` - Controller tests
- ✅ `/CIS174FinalProject.Tests/MSTestSettings.cs` - Test configuration

**Files to Create:**
- `/CIS174FinalProject.Tests/Controllers/BookControllerTests.cs` - Comprehensive controller tests
- `/CIS174FinalProject.Tests/Controllers/AuthorControllerTests.cs` - Comprehensive controller tests

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

### Phase 1: Database and Data Access (30 points) - ✅ COMPLETE
1. ✅ Set up Entity Framework Core and SQL Server/SQLite
2. ✅ Create entity models with validation (Book, Author, Genre)
3. ✅ Implement CRUD operations for Books and Create for Authors
4. ⚠️ Add unit tests for models and context (basic tests done)

### Phase 2: Authentication and Authorization (20 points) - ❌ NOT STARTED
1. ❌ Implement ASP.NET Core Identity
2. ❌ Create registration and login functionality
3. ❌ Add authorization to protect resources
4. ❌ Update UI based on authentication state

### Phase 3: Forms and User Experience (40 points) - ✅ MOSTLY COMPLETE
1. ✅ Create forms with Tag Helpers
2. ✅ Implement comprehensive validation
3. ⚠️ Add custom routing (MVC done, API routing not yet implemented)
4. ⚠️ Implement state management (configured but not actively used)

### Phase 4: Code Quality and Deployment (40 points) - ❌ MOSTLY NOT STARTED
1. ❌ Implement MVC filters to reduce redundancy
2. ⚠️ Enhance error handling with custom views (basic error handling exists)
3. ⚠️ Complete unit test coverage (basic tests exist)
4. ❌ Deploy to Azure

### Phase 5: Final Testing and Verification (20 points) - ❌ NOT STARTED
1. ❌ Verify all requirements are met
2. ❌ Test all functionality end-to-end
3. ❌ Verify Azure deployment
4. ❌ Code review and cleanup

---

## Current Status Summary

| Requirement | Points | Status | Completion % |
|-------------|--------|--------|--------------|
| 1. Routing | 10 | ⚠️ Partial | 70% |
| 2. Binding & Validation | 20 | ✅ Complete | 100% |
| 3. Tag Helpers | 10 | ✅ Complete | 100% |
| 4. EF Core & Database | 20 | ✅ Complete | 100% |
| 5. MVC Filters | 10 | ❌ Not Started | 0% |
| 6. Identity | 10 | ❌ Not Started | 0% |
| 7. Authorization | 10 | ❌ Not Started | 0% |
| 8. State Management | 10 | ⚠️ Partial | 50% |
| 9. Error Handling | 10 | ⚠️ Partial | 40% |
| 10. Unit Testing | 20 | ⚠️ Partial | 30% |
| 11. Azure Deployment | 20 | ❌ Not Started | 0% |
| **TOTAL** | **150** | | **~49%** |

---

## Notes
- This project uses .NET 8.0 and ASP.NET Core MVC
- Following Murach's ASP.NET Core MVC best practices
- Test framework: MSTest
- Database: 
  - **Development:** SQLite (library.db) - automatically created
  - **Production:** SQL Server (configured in appsettings.json)
- **Implemented Features:**
  - Full CRUD operations for Books (Create, Read, Update, Delete)
  - Create operation for Authors
  - Library catalog with 10 famous books (seeded data)
  - 10 authors and 5 genres (seeded data)
  - Entity Framework Core with Code First approach
  - Comprehensive data validation with data annotations
  - Bootstrap UI styling
  - Client-side and server-side validation
  - Tag Helpers throughout
  - Session services configured (not yet actively used)
- Current authentication: None (needs to be implemented)
- Current authorization: None (needs to be implemented)

---

## Next Actions (Priority Order)
1. **Implement MVC Filters** (10 points) - Remove code redundancy from controllers
2. **Implement ASP.NET Core Identity** (10 points) - User registration and login
3. **Implement Authorization** (10 points) - Protect resources with [Authorize] attribute
4. **Complete State Management** (5 points remaining) - Actually use session state in application
5. **Add API Controller with Attribute Routing** (3 points remaining) - Complete routing requirements
6. **Enhance Unit Testing** (14 points remaining) - Add controller tests, achieve 100% coverage
7. **Enhance Error Handling** (6 points remaining) - Add status code pages, improve error views
8. **Azure Deployment** (20 points) - Deploy application to Azure with SQL Database

**Total Remaining Points:** ~76 out of 150

---

**Last Updated:** 2026-01-19 (Updated to reflect actual implementation status)
