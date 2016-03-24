using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Models
{
    public class OrderService
    {
        /// <summary>
        /// 取得DB連線字串
        /// </summary>
        /// <returns></returns>
        private string GetDBConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }
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
        public Models.Order GetOrderById(string orderId)
        {
            DataTable dt = new DataTable();
            string sql = @"SELECT 
	                        O.OrderID, O.CustomerID, C.CompanyName, 
	                        O.EmployeeID, E.LastName + E.FirstName AS EmpName, 
	                        O.OrderDate, O.RequiredDate, O.ShippedDate, 
	                        O.ShipperID, S.CompanyName, O.Freight, 
	                        O.ShipName, O.ShipAddress, O.ShipCity, O.ShipRegion, O.ShipPostalCode, O.ShipCountry
                        FROM Sales.Orders AS O 
	                        INNER JOIN Sales.Customers AS C ON O.CustomerID = C.CustomerID
	                        INNER JOIN HR.Employees AS E ON O.EmployeeID = E.EmployeeID
	                        INNER JOIN Sales.Shippers AS S ON O.ShipperID = S.ShipperID
                        WHERE O.OrderID = @OrderId";
            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@OrderId", orderId));

                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }
            return this.MapOrderDataToList(dt).FirstOrDefault();
            /*Models.Order result = new Order();
            result.CustId = "1102137103";
            result.CustName = "阿涵";
            return result;*/
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

        private List<Models.Order> MapOrderDataToList(DataTable orderData)
        {
            List<Models.Order> result = new List<Order>();

            foreach (DataRow row in orderData.Rows)
            {
                result.Add(new Order()
                {

                });
            }
            return result;
        }
    }
}