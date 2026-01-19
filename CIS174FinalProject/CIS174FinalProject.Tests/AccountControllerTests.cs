using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using CIS174FinalProject.Controllers;
using CIS174FinalProject.Models;

namespace CIS174FinalProject.Tests;

[TestClass]
public class AccountControllerTests
{
    [TestMethod]
    public void Login_Get_ReturnsViewResult()
    {
        // Arrange
        var controller = CreateAccountController();

        // Act
        var result = controller.Login();

        // Assert
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Register_Get_ReturnsViewResult()
    {
        // Arrange
        var controller = CreateAccountController();

        // Act
        var result = controller.Register();

        // Assert
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public async Task Register_Post_InvalidModel_ReturnsViewWithModel()
    {
        // Arrange
        var controller = CreateAccountController();
        controller.ModelState.AddModelError("Error", "Sample error");
        var model = new RegisterViewModel
        {
            Username = "testuser",
            Password = "Test@123",
            ConfirmPassword = "Test@123"
        };

        // Act
        var result = await controller.Register(model);

        // Assert
        Assert.IsInstanceOfType(result, typeof(ViewResult));
        var viewResult = result as ViewResult;
        Assert.IsNotNull(viewResult);
        Assert.AreEqual(model, viewResult.Model);
    }

    [TestMethod]
    public async Task Login_Post_InvalidModel_ReturnsViewWithModel()
    {
        // Arrange
        var controller = CreateAccountController();
        controller.ModelState.AddModelError("Error", "Sample error");
        var model = new LoginViewModel
        {
            Username = "testuser",
            Password = "Test@123"
        };

        // Act
        var result = await controller.Login(model);

        // Assert
        Assert.IsInstanceOfType(result, typeof(ViewResult));
        var viewResult = result as ViewResult;
        Assert.IsNotNull(viewResult);
        Assert.AreEqual(model, viewResult.Model);
    }

    [TestMethod]
    public void LoginViewModel_HasRequiredProperties()
    {
        // Arrange & Act
        var model = new LoginViewModel
        {
            Username = "testuser",
            Password = "Test@123",
            RememberMe = true
        };

        // Assert
        Assert.AreEqual("testuser", model.Username);
        Assert.AreEqual("Test@123", model.Password);
        Assert.IsTrue(model.RememberMe);
    }

    [TestMethod]
    public void RegisterViewModel_HasRequiredProperties()
    {
        // Arrange & Act
        var model = new RegisterViewModel
        {
            Username = "testuser",
            Password = "Test@123",
            ConfirmPassword = "Test@123"
        };

        // Assert
        Assert.AreEqual("testuser", model.Username);
        Assert.AreEqual("Test@123", model.Password);
        Assert.AreEqual("Test@123", model.ConfirmPassword);
    }

    [TestMethod]
    public void User_InheritsFromIdentityUser()
    {
        // Arrange & Act
        var user = new User();

        // Assert
        Assert.IsInstanceOfType(user, typeof(IdentityUser));
    }

    private AccountController CreateAccountController()
    {
        var userStoreMock = new Mock<IUserStore<User>>();
        var userManager = new Mock<UserManager<User>>(
            userStoreMock.Object, null!, null!, null!, null!, null!, null!, null!, null!);

        var signInManager = new Mock<SignInManager<User>>(
            userManager.Object,
            Mock.Of<Microsoft.AspNetCore.Http.IHttpContextAccessor>(),
            Mock.Of<IUserClaimsPrincipalFactory<User>>(),
            null!, null!, null!, null!);

        return new AccountController(userManager.Object, signInManager.Object);
    }
}
