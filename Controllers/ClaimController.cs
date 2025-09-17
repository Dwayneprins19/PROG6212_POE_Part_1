using Microsoft.AspNetCore.Mvc;
using CMCSProject.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CMCSProject.Controllers
{
	public class ClaimController : Controller
	{

		private static Claim currentClaim = null;
		public IActionResult Index()
		{
			return View(currentClaim);
		}

		[HttpPost]
		public IActionResult Submit(Claim claim, IFormFile document)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", claim);
			}

			if (document != null)
			{
				var fileName = Path.GetFileName(document.FileName);
				claim.UploadedDocument = fileName;	
			}

			claim.Status = "Submitted";
			currentClaim = claim;

			return RedirectToAction("Index");
		}

		public IActionResult Verify()
		{
			if (currentClaim != null)
			{
				currentClaim.Status = "Verfied by Coordinator";
			}

			return RedirectToAction("Index");
		}

		public IActionResult Approve()
		{
			if (currentClaim != null)
			{
				currentClaim.Status = "Approved by Manager";
			}
			return RedirectToAction("Index");
		}
	}
}
