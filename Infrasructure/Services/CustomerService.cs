using System.Data;
using Domain.Dtos;
using Npgsql;
using Dapper;

public class CustomerSevices
{
    
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Exam;User Id=postgres;Password=2005;";

    public List<Customer> GetInfoCustomer()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from Customers";
            
            return conn.Query<Customer>(sql).ToList();
        }
    }
       public int InsertCustomer(Customer  Customer)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into Customers (firstname) VALUES " +
                    $"('{Customer.firstname}' " ;

                var result = conn.Execute(sql);

                return result;
            }
        }

         public int UpdateCustomer(Customer Customer)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE Customers SET " +
                    $"firstname = '{Customer.firstname}'";


                var result = conn.Execute(sql);

                return result;
            }
        }

          public int DeleteCustomer(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM Customers WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

}