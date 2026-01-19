# Branch Protection Setup

## Overview
This repository uses GitHub Rulesets to protect the `main` branch by enforcing Continuous Integration (CI) checks and pull request requirements on all changes to the main branch.

## GitHub Ruleset

The repository includes a ruleset configuration file at `.github/main-branch-ruleset.json` that defines the protection rules for the main branch. This modern approach to branch protection offers more flexibility and can be version-controlled alongside your code.

### Ruleset Configuration

The ruleset (`.github/main-branch-ruleset.json`) enforces the following rules on the `main` branch:

1. **Pull Request Required**: All changes must go through a pull request
   - Requires conversation resolution before merging
   
2. **Required Status Checks**: The `build` job from the CI workflow must pass
   - Requires branches to be up to date before merging
   
3. **Prevent Force Pushes**: Force pushes are not allowed (non-fast-forward rule)

4. **Branch Creation**: Controls how the main branch can be created

5. **Update Restrictions**: Prevents direct updates to the branch

### Applying the Ruleset

To apply this ruleset, repository administrators should:

1. Go to **Settings** → **Rules** → **Rulesets**
2. Click **New ruleset** → **New branch ruleset**
3. Either:
   - **Option A**: Manually configure the ruleset using the settings from `.github/main-branch-ruleset.json`
   - **Option B**: Use GitHub CLI to import the ruleset (if available in your organization)

The ruleset file serves as documentation and a template for the protection rules that should be applied.

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

The ruleset is configured to require the `build` job from the CI workflow to pass before any pull request can be merged to the main branch.

### Ruleset vs. Classic Branch Protection

GitHub Rulesets offer several advantages over classic branch protection rules:

- **Version Control**: Ruleset configuration can be stored in the repository
- **Flexibility**: More granular control over who can bypass rules
- **Organization-wide**: Can be applied across multiple repositories
- **Better UI**: Improved user interface for managing rules
- **Future-proof**: GitHub's recommended approach going forward

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

Consider adding these additional protections to the ruleset:
- Required approving review count (currently set to 0)
- Code owner review requirements
- Code coverage requirements via additional CI checks
- Code style/linting checks with dotnet format
- Security scanning
- Dependency vulnerability checks
