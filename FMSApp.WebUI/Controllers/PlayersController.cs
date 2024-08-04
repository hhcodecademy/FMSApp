using FMSApp.DAL.Models;
using FMSApp.DAL.Repository.Interface;
using FMSApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FMSApp.WebUI.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IGenericRepository<Player> _playerRepository;
        private readonly IGenericRepository<Team> _teamRepository;
        public PlayersController(IGenericRepository<Player> playerRepository, IGenericRepository<Team> teamRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
        }


        public async Task<IActionResult> Index(int? teamId)
        {
            var itemsTask = await _playerRepository.GetAll();
            var players=itemsTask.Where(x=>x.TeamId==teamId).ToList();
            List<PlayerViewModel> list = new List<PlayerViewModel>();
            foreach (var item in players)
            {
                list.Add(new PlayerViewModel
                {
                    Id = item.Id,
                    TeamId = item.TeamId,
                    FullName = item.FullName,
                    Number= item.Number,
                    TeamName=_teamRepository.Get(item.TeamId).Result.Name,
                });
            }
            return View(list);
        }

        public async Task<IActionResult> Create(int teamId)
        {
            Player model = new Player()
            {
                TeamId = teamId,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Player model)
        {
            await _playerRepository.Add(model);
            return RedirectToAction("Index",new { teamId=model.TeamId});
        }
    }
}
