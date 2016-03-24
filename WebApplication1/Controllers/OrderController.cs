using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        //Models.CodeService codeService = new Models.CodeService();
        // GET: Order
        /// <summary>
        /// 訂單管理系統
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            /*Models.OrderService orderService = new Models.OrderService();
            ViewBag.EmpCodeData = this.codeService.GetEmp();*/

            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrderById("11111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }
        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }
        [HttpGet()]
        public JsonResult TestJson()
        {
            var result = new Models.Order() { CustId = "1102137103", CustName = "阿涵" };
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}