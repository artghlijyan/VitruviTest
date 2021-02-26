using AutoMapper;
using BL.DTO;
using BLl.DbConnect;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using VitruviTest.Controllers;
using VitruviTest.ViewModels;
using Xunit;

namespace Test
{
    public class HomeControllerTest
    {
        [Fact]
        public async Task IndexReturnsResultWithProviderGroupModel()
        {
            var mockDbConnector = new Mock<IDbConnector>();
            var mockMapper = new Mock<IMapper>();

            var mockDbResult = mockDbConnector.Setup(db => db.GetProviderGroupsAsync()).Returns(GetProviderGroupsAsync);

            HomeController controller = new HomeController(mockDbConnector.Object, mockMapper.Object);

            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<ProviderGroupModel>(viewResult.Model);

            Assert.Equal(GetProviderGroupsAsync().Result.groupNames.Count,
                model.groupNames.Count);
            Assert.Equal(GetProviderGroupsAsync().Result.providerNames.Count,
                model.providerNames.Count);
        }

        private async Task<ProviderGroupDto> GetProviderGroupsAsync()
        {
            var pGroup = new ProviderGroupDto();

            pGroup.groupNames = new List<GroupDto>()
                {
                    new GroupDto(),
                    new GroupDto(),
                    new GroupDto(),
                    new GroupDto(),
                    new GroupDto(),
                    new GroupDto(),

                };

            pGroup.providerNames = new List<ProviderDto>()
                {
                    new ProviderDto(),
                    new ProviderDto(),
                    new ProviderDto(),
                    new ProviderDto(),
                    new ProviderDto(),
                    new ProviderDto(),

                };

            return pGroup;
        }
    }
}

