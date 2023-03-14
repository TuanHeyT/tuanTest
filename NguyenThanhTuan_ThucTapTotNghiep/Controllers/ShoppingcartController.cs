using Microsoft.AspNetCore.Mvc;

namespace NguyenThanhTuan_ThucTapTotNghiep.Controllers
{
	public class ShoppingcartController : Controller
	{
		public IActionResult ShoppingCart()
		{
			return View();
		}
	}
}
