using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Hjemmeside.Pages
{
    public class AboutModel : PageModel
    {
        public List<dataInfo> listdata = new List<dataInfo>();
        public void OnGet(dataInfo drink)
        {
            try
            {
                string connectionstring = "Data Source=.\\LUCASQL;Initial Catalog=Drink;Integrated Security=True;Pooling=False";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Drink";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("RØV 1");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("RØV 2");
                            while (reader.Read())
                            {
                                dataInfo drinks = new dataInfo();
                                drinks.nummer = reader.GetInt32(0);
                                drinks.gin = reader.GetInt32(1);
                                drinks.vodka = reader.GetInt32(2);
                                drinks.rom = reader.GetInt32(3);
                                drinks.jager = reader.GetInt32(4);
                                drinks.cola = reader.GetInt32(5);
                                drinks.pris = reader.GetDecimal(6);
                                Console.WriteLine("RØV 3");

                                listdata.Add(drinks);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class dataInfo
    {
        public int nummer;
        public int gin;
        public int vodka;
        public int rom;
        public int jager;
        public int cola;
        public decimal pris;    

    }
}
