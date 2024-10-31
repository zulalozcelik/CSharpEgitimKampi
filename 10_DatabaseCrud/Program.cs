using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud= create-read-update-delete
            //Console.WriteLine("******* Menü Sipariş İşlem Paneli ********");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------");

            #region kategori ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=TARGET982\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command=new SqlCommand("insert into TblCategory (CategoyName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write(" ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write(" ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=TARGET982\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProdcut (ProductName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme 

            //SqlConnection connection = new SqlConnection("Data Source=TARGET982\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // sqlden verileri çekebilmek için bir köprü 
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün silme 

            //Console.Write("Silinecek Ürün Id:");
            //int productId= int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=TARGET982\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@productID", connection);
            //// bir sorgu yazıldığında connection bağlanır.
            //command.Parameters.AddWithValue("@productID", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion

            #region ürün güncelleme işlemi

            //Console.Write("Güncellenecek ürün ID:");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncelleneck ürün adı:");
            //string productName = Console.ReadLine();

            //Console.Write("Güncelleneck ürün fiyatı:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=TARGET982\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update  TblProduct Set ProductName= @productName, ProductPrice=@productPrice where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productID",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı");

            #endregion


            //Console.ReadLine();

        }
    }
}
