# GitHub Ruleset Configuration

This file defines the branch protection ruleset for the `main` branch.

## What This Ruleset Does

This ruleset enforces the following protections on the `main` branch:

### 1. Pull Request Requirement
- All changes must go through a pull request
- Requires all conversations to be resolved before merging
- Does not require approving reviews (set to 0 for learning purposes)

### 2. Required Status Checks
- The `build` job from the CI workflow must pass
- Branches must be up to date with the base branch before merging

### 3. Force Push Prevention
- Prevents force pushes to maintain commit history integrity

### 4. Creation Control
- Controls how the main branch can be created

### 5. Update Restrictions
- Prevents direct updates to the branch
- Disables fetch-and-merge updates

## How to Apply This Ruleset

### Using the GitHub UI

1. Navigate to your repository on GitHub
2. Go to **Settings** → **Rules** → **Rulesets**
3. Click **New ruleset** → **New branch ruleset**
4. Configure the ruleset with the following settings:

   **Basic Settings:**
   - Name: `Protect Main Branch`
   - Enforcement status: Active
   - Target: Branch
   - Target branches: `main`

   **Rules to enable:**
   - ✅ Require a pull request before merging
     - Required approvals: 0
     - Dismiss stale pull request approvals when new commits are pushed: No
     - Require approval of the most recent reviewable push: No
     - Require review from Code Owners: No
     - Require conversation resolution before merging: Yes
   
   - ✅ Require status checks to pass
     - Status checks that are required:
       - `build` (from GitHub Actions)
     - Require branches to be up to date before merging: Yes
   
   - ✅ Block force pushes
   
   - ✅ Restrict creations
   
   - ✅ Restrict updates

5. Click **Create**

### Using GitHub CLI (if available)

```bash
gh api \
  --method POST \
  -H "Accept: application/vnd.github+json" \
  -H "X-GitHub-Api-Version: 2022-11-28" \
  /repos/OWNER/REPO/rulesets \
  --input main-branch-ruleset.json
```

Replace `OWNER` and `REPO` with your repository owner and name.

## Notes

- The `integration_id: 15368` in the JSON refers to GitHub Actions
- The ruleset is configured with no required approvals to make it easier for learning and solo development
- You can increase `required_approving_review_count` when working in a team
- Bypass actors list is empty, meaning no users can bypass these rules (recommended for production)

## Customization

To customize this ruleset:

1. Adjust `required_approving_review_count` to require code reviews
2. Set `require_code_owner_review: true` if you have a CODEOWNERS file
3. Add bypass actors if certain users or teams need to bypass rules
4. Add additional status checks as you expand your CI pipeline

## More Information

- [GitHub Rulesets Documentation](https://docs.github.com/en/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/about-rulesets)
- [Rulesets API Reference](https://docs.github.com/en/rest/repos/rules)
