using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SoftwarePresentation.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareDeveloperTest.Tests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        [TestMethod]
        public async Task TestGetEmployeesAsync()
        {
            //// Arrange
            //string employeeJson = "{\"data\":[{\"id\":1,\"employee_name\":\"John\",\"employee_salary\":1000,\"employee_age\":30,\"profile_image\":\"\"}]}";

            //// Mock EmployeeDAO
            //var employeeDaoMock = new Mock<EmployeeDAO>();
            //employeeDaoMock.Setup(e => e.GetEmployeesRest()).Returns(employeeJson);

            //var employeeService = new EmployeeService(employeeDaoMock.Object);

            //// Act
            //var result = await employeeService.GetEmployeesAsync();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(1, result.Count); // Replace YourExpectedCount with the expected count of items

            //// You can further perform assertions on individual items in the result list
            //// Assert.AreEqual(ExpectedId, result[0].Id);
            //// Assert.AreEqual(ExpectedName, result[0].EmployeeName);
            //// ... and so on
        }
    }
}
