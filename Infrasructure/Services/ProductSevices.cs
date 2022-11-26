using System.Data;
using Domain.Dtos;
using Npgsql;
using Dapper;

public class ProductSevices
{
    
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=Exam;User Id=postgres;Password=2005;";

    public List<Product> GetInfoProduct()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from products";
            
            return conn.Query<Product>(sql).ToList();
        }
    }
       public int InsertProduct(Product  product)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql =
                    $"insert into products (productname, company, productcount, price) VALUES " +
                    $"('{product.productname}', " +
                    $"'{product.company}', " +
                    $"'{product.productcount}', " +
                    $"'{product.price}')";
                var result = conn.Execute(sql);

                return result;
            }
        }

         public int UpdateProduct(Product product)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = 
                    $"UPDATE products SET " +
                    $"productname = '{product.productname}', " +
                    $"company = '{product.company}', " +
                    $"productcount = '{product.productcount}', " +
                    $"price = '{product.price}'" +
                    $"WHERE Id = {product.Id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

          public int Deleteproduct(int id)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                var sql = $"DELETE FROM products WHERE id = {id}";

                var result = conn.Execute(sql);

                return result;
            }
        }

}