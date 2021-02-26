using AutoMapper;
using BL.DTO;
using BLl.DbConnect;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VitruviTest.ViewModels;

namespace VitruviTest.Controllers
{
    public class HomeController : Controller
    {
        private IDbConnector _dbConnector;
        private IMapper _mapper;

        public HomeController(IDbConnector dbConnector, IMapper mapper)
        {
            _dbConnector = dbConnector;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            ProviderGroupDto providerGroupDto = await _dbConnector.GetProviderGroupsAsync();
            ProviderGroupModel providerGroup = _mapper.Map<ProviderGroupModel>(providerGroupDto);

            return View(providerGroup);
        }
    }
}
