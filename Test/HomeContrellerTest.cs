using AutoMapper;
using BL.DbConnect;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using VitruviTest.Controllers;
using VitruviTest.Models;
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

            var mockDbResult = mockDbConnector.Setup(db => db.GetProviderGroupsAsync());
            var mockMapperResult = mockMapper.Setup(
                mapper => mapper.Map<ProviderGroupModel>(mockDbResult));

            HomeController controller = new HomeController(mockDbConnector.Object, mockMapper.Object);

            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<ProviderGroupModel>(viewResult.Model);

            Assert.Equal(GetProviderGroupModel().groupNames.Count,
                model.groupNames.Count);
            Assert.Equal(GetProviderGroupModel().providerNames.Count,
                model.providerNames.Count);
        }

        private ProviderGroupModel GetProviderGroupModel()
        {
            var pGroup = new ProviderGroupModel();

            pGroup.groupNames = new List<GroupModel>()
                {
                    new GroupModel(),
                    new GroupModel(),
                    new GroupModel(),
                    new GroupModel(),
                    new GroupModel(),
                };

            pGroup.providerNames = new List<ProviderModel>()
                {
                    new ProviderModel(),
                    new ProviderModel(),
                    new ProviderModel(),
                    new ProviderModel(),
                    new ProviderModel(),
                    new ProviderModel(),
                };

            return pGroup;
        }
    }
}

