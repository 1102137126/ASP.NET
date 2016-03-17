using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder(Models.Order order)
        {
        }
        /// <summary>
        /// 刪除訂單 By Id
        /// </summary>
        public void DeleteOrderById(String id)
        {
        }
        /// <summary>
        /// 修改訂單
        /// </summary>
        public void UpdateOrder()
        {
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "1102137103";
            result.CustName = "阿涵";
            return result;
            //return new Models.Order();
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}