using System;
using GroceryBama.MySqlScripts;
using GroceryBama.Entities;
using GroceryBama.Exceptions;
using System.Text.Json;

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
                user = usersScript.GetUser("jSmith", "123456");
            }
            catch (UserCredentialNotMatchException)
            {
                Console.WriteLine("User Credential Not Match");
            }
            catch (MutipleUsersFoundException)
            {
                Console.WriteLine("Found mutiple users");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(JsonSerializer.Serialize(user));
        }
    }
}
