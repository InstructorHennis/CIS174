# Branch Protection Setup

## Overview
This repository uses GitHub Actions to protect the `main` branch by enforcing Continuous Integration (CI) checks on all pull requests and pushes to the main branch.

## CI Workflow

The CI workflow (`.github/workflows/ci.yml`) automatically runs on:
- All pull requests targeting the `main` branch
- All pushes to the `main` branch

### What the CI Workflow Does

1. **Setup Environment**: Checks out the code and sets up .NET 10.0
2. **Restore Dependencies**: Runs `dotnet restore` to download all required NuGet packages
3. **Build**: Compiles the project in Release configuration
4. **Test**: Runs all unit tests (if any exist)

### Required Status Checks

To fully protect the main branch, repository administrators should configure the following settings in GitHub:

1. Go to **Settings** → **Branches** → **Branch protection rules**
2. Add a rule for the `main` branch
3. Enable the following settings:
   - ✅ Require a pull request before merging
   - ✅ Require status checks to pass before merging
     - Select the `build` job from the CI workflow
   - ✅ Require conversation resolution before merging
   - ✅ Do not allow bypassing the above settings

### Benefits

- **Code Quality**: Ensures all code is buildable before being merged
- **Early Detection**: Catches build errors and test failures before they reach main
- **Collaboration**: Enforces code review through pull requests
- **Documentation**: Creates a history of changes through PRs

### Local Testing

Before pushing code, you can verify it will pass CI checks by running:

```bash
# Restore dependencies
dotnet restore Week1/CIS174FinalProject/CIS174FinalProject.csproj

# Build the project
dotnet build Week1/CIS174FinalProject/CIS174FinalProject.csproj --configuration Release

# Run tests
dotnet test Week1/CIS174FinalProject/CIS174FinalProject.csproj --configuration Release
```

### Future Enhancements

Consider adding these additional protections:
- Code coverage requirements
- Code style/linting checks with dotnet format
- Security scanning
- Dependency vulnerability checks
