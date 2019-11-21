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
            UsersScript usersScript = new UsersScript();
            User user = null;
            try
            {
                user = usersScript.GetUser("jSmith", "123456 999");
                Console.WriteLine(JsonSerializer.Serialize(user));
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1002) Console.WriteLine("Incorrect username or password");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
