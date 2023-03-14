using Microsoft.AspNetCore.Mvc;

namespace NguyenThanhTuan_ThucTapTotNghiep.Controllers
{
	public class ContentController : Controller
	{
		public IActionResult Content()
		{
			return View();
		}
	}
}
