using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Data;

namespace PlatformDemo.Web.Controllers
{
    public class ServicePlansController : Controller
    {
        private readonly PlatformDbContext _context;

        public ServicePlansController(PlatformDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var servicePlans = await _context.ServicePlans
                .Include(sp => sp.Timesheets)
                .Select(sp => new
                {
                    sp.ServicePlanId,
                    sp.DateOfPurchase,
                    TimesheetsCount = sp.Timesheets.Count
                })
                .ToListAsync();

            return View(servicePlans);
        }
    }
}
