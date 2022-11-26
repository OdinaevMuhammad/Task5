using System.Data;
using Domain.Dtos;
using Npgsql;
using Dapper;

public class OrderSevices
{
    
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Exam;User Id=postgres;Password=2005;";

    public List<Orders> GetInfoOrders()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from Orders";
            
            return conn.Query<Orders>(sql).ToList();
        }
    }
       public int InsertOrders(Orders  Orders)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Orders (Ordersname, company, Orderscount, price) VALUES " +
                    $"('{Orders.Id}', " +
                    $"'{Orders.customerid}', " +
                    $"'{Orders.price}', " +
                    $"'{Orders.productcount}')" +
                    $"'{Orders.productid}')";
                var result = conn.Execute(sql);

                return result;
            }
        }

         public int UpdateOrders(Orders Orders)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE Orderss SET " +
                    $"Ordersname = '{Orders.Id}', " +
                    $"company = '{Orders.customerid}', " +
                    $"Orderscount = '{Orders.price}', " +
                    $"price = '{Orders.productcount}'" +
                    $"WHERE Id = {Orders.productid}";

                var result = conn.Execute(sql);

                return result;
            }
        }

          public int DeleteOrders(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Orders WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

}