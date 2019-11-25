using System;
using GroceryBama.MySqlScripts;
using GroceryBama.Entities;
using GroceryBama.Exceptions;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace GroceryBamaSQLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                UsersScript usersScript = new UsersScript();
                User user = usersScript.GetUser("jSmith", "123456 999");
                Console.WriteLine(JsonSerializer.Serialize(user));
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 5002) Console.WriteLine("Incorrect username or password");
                else Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
