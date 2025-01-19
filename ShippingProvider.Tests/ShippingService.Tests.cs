using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using ShippingProvider.Business.Interfaces;
using ShippingProvider.Business.Models;

namespace ShippingProvider.Tests
{

    public class ShippingService
    {
        //Pre tests setup

        Mock<IShippingService> shippingServiceMock = new Mock<IShippingService>();
        Mock<IApiHandler> apiHandlerMock = new Mock<IApiHandler>();

        ShippingCompany shippingCompany1 = new ShippingCompany()
        {
            ApiUrl = "TestUrl1",
            ApiKey = "TestKey1",
            CompanyName = "TestCompany1",
        };

        ShippingCompany shippingCompany2 = new ShippingCompany()
        {
            ApiUrl = "TestUrl2",
            ApiKey = "TestKey2",
            CompanyName = "TestCompany2",
        };

        ShippingOption testOption1 = new ShippingOption()
        {
            ShippingCost = 599,
            ShippingType = "pickup",
            CompanyName = "GHL",
            ExpectedArrival = "2025/04/03",
        };

        ShippingOption testOption2 = new ShippingOption()
        {
            ShippingCost = 69,
            ShippingType = "to door",
            CompanyName = "Bäst",
            ExpectedArrival = "2025/03/03/16:30",
        };

        Product testProduct1 = new()
        {
            Id = "testID1",
            ProductName = "testProduct",
            ProductPrice = 125,
            productWeight = 1900,
        };

        Product testProduct2 = new()
        {
            Id = "testID2",
            ProductName = "testProduct",
            ProductPrice = 99,
            productWeight = 22900,
        };

        ResponseResult testSuccessResult = new ResponseResult()
        {
            Success = true,
            Content = "APIresult",
            Message = "message",
            statusCode = 200,
        };

        ResponseResult testFailResult = new ResponseResult()
        {
            Success = false,
            Content = "APIresult",
            Message = "message",
            statusCode = 500,
        };

        [Fact]

        public void GetOffers__ShouldReturnResponseResult_Where_SuccessIsTrue()
        {
            //Arrange

            int testWeight = 200;

            shippingServiceMock.Setup(ShippingService => ShippingService.GetOffers(testWeight)).Returns(testSuccessResult);


            //Act

            ResponseResult result = shippingServiceMock.Object.GetOffers(testWeight);

            //Assert

            Assert.True(result.Success);
        }

        [Fact]

        public void CallApi__ShouldReturnResponseResult_Where_SuccessIsTrue()
        {
            // Arrange
            int testWeight = 300;

            apiHandlerMock.Setup(IApiHandler => IApiHandler.CallApi(shippingCompany1.ApiKey, shippingCompany1.ApiUrl, testWeight.ToString())).Returns(testSuccessResult);

            //Act

            ResponseResult result = apiHandlerMock.Object.CallApi(shippingCompany1.ApiKey, shippingCompany1.ApiUrl, testWeight.ToString());

            //Assert

            Assert.True(result.Success);
        }

        [Fact] 

        public void GetShippingOptions__ShouldReturnAllShippingOptions()
        {
            // Arrange

            List < ShippingOption > testList = new();
            testList.Add(testOption2);
            testList.Add(testOption1);

            shippingServiceMock.Setup(ShippingService => ShippingService.GetShippingOptions()).Returns(testList);

            // Act

            var mockList = shippingServiceMock.Object.GetShippingOptions();

            // Assert

            Assert.Equal(mockList, testList);

        }
    }
}
