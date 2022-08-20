using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShortUrlMVC.BLL.Interfaces;
using ShortUrlMVC.BLL.Models;
using ShortUrlMVC.PL.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ShortUrlMVC.DAL.Models;

namespace ShortUrlMVC.PL.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IShortURLService _shortService;
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;


        public HomeController(IShortURLService shortService,
            IMapper mapper,
            UserManager<UserEntity> userManager
            )
        {
            _shortService = shortService;
            _mapper = mapper;
            _userManager = userManager;

        }

        [AllowAnonymous]
        public async Task<ActionResult> Index()
        {
            var topic = await _shortService.GetAllAsync();

            return View(_mapper.Map<IEnumerable<ShortURL>, IEnumerable<ShortURLViewModel>>(topic));
        }

        [HttpGet("Home/Detail/{id}")]
        public async Task<ActionResult> Details(string id)
        {
            var topic = await _shortService.GetAsync(id);

            return View(_mapper.Map<ShortURL, ShortURLViewModel>(topic));
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new ShortURLViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public async  Task<ActionResult> CreateAsync(ShortURLViewModel requestVm)
        {
            var id = requestVm.OrginalURLId;

            requestVm.OwnerId = (await _userManager.GetUserAsync(HttpContext.User)).UserName;

            var request = _mapper.Map<ShortURLViewModel, ShortURL>(requestVm);

            if (await _shortService.CreateAsync(request))
            {
                return Redirect("~/Home/Detail/" + id);
            }
            else 
            {
                return Redirect("~/Home/Error}");
            }
        }

        [ValidateAntiForgeryToken]
        public IActionResult Delete(string id)
        {
            _shortService.DeleteAsync(id);

            return Redirect("~/Home/Index");
        }


        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}
