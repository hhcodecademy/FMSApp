using FMSApp.DAL.Models;
using FMSApp.DAL.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace FMSApp.WebUI.Controllers
{
    public class TeamsController : Controller
    {
        private readonly IGenericRepository<Team> _teamRepository;

        public TeamsController(IGenericRepository<Team> teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<IActionResult> Index()
        {
            var teamsTask= await _teamRepository.GetAll();
            return View(teamsTask.ToList());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Team model)
        {
            await _teamRepository.Add(model);
            return RedirectToAction("Index");
        }
    }
}
