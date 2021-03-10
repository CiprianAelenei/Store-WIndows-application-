using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPAW.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        void SaveProduct(Product p);
    }
    public class ProductService : IProductService
    {
        private readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cipri\Desktop\ProjectPAW\ProjectPAW\Database\gestiune_vanzari.accdb";
        private readonly OleDbConnection _Connection;
        public ProductService()
        {
            _Connection = new OleDbConnection(connectionString);
        }

        public List<Product> GetAllProducts()
        {
            //aici scrii codul care ia din baza de date toate produsele
            return new List<Product>();
        }

        public void SaveProduct(Product p)
        {
           // string insertCommandFormat = "INSERT INTO products(name...) VALUES('{0}', '{1}', '{2}', {3})";
           // OleDbCommand cmd = _Connection.CreateCommand();
           // _Connection.Open();
           //// cmd.CommandText = string.Format(insertCommandFormat, p.Name,...);
           // cmd.Connection = _Connection;
           // var rowsAffected = cmd.ExecuteNonQuery();
           // if (rowsAffected != 1)
           // {
           //     throw new Exception("Insert client failed");
           // }
           // _Connection.Close();
        }
    }
}
