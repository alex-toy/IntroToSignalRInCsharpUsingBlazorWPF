using ChatApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace ChatApp.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<AppUser> _userManager;

		public HomeController(ApplicationDbContext context, UserManager<AppUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			AppUser currentUser = await _userManager.GetUserAsync(User);
			if (User.Identity.IsAuthenticated)
			{
				ViewBag.CurrentUserName = currentUser.UserName;
			}
			List<Message> messages = await _context.Messages.ToListAsync();
			return View();
		}

		public async Task<IActionResult> Create(Message message)
		{
			if (ModelState.IsValid)
			{
				message.UserName = User.Identity.Name;
				AppUser sender = await _userManager.GetUserAsync(User);
				message.UserId = sender.Id;
				await _context.AddAsync(message);
				await _context.SaveChangesAsync();
				return Ok();
			}
			return Error();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
