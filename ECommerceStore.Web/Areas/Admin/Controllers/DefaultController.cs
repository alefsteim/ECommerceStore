using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceStore.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceStore.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        private ECommerceStoreDbContext context;
        public DefaultController(ECommerceStoreDbContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            return View(context.Products);
        }    
    }
}
