using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
namespace Hjemmeside.Pages
{
    public class InformationModel : PageModel
    {
        public string mestSolgte;
        public int antalLiter;
        public int antalKroner;
        public int antalSolgte;
        public void OnGet()
        {
            try
            {
                string connectionstring = "Data Source=.\\LUCASQL;Initial Catalog=Drink;Integrated Security=True;Pooling=False";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string sqlSum = "SELECT SUM(Pris) FROM Drink";
                    using (SqlCommand commandSum = new SqlCommand(sqlSum, connection))
                    {
                        
                       
                        using (SqlDataReader reader = commandSum.ExecuteReader())
                        {
                            

                            while (reader.Read())
                            {
                                
                                antalKroner = reader.GetInt32(0);
                                    
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
    
}
