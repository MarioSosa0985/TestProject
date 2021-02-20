using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Users myUser = new Users();
            myUser.Password = "Password";
            myUser.UserName = "Mario";
            myUser.UserId = 1;

            Console.WriteLine(myUser.Password);
            Console.WriteLine(myUser.UserName);
            Console.WriteLine(myUser.UserId);
        }
    }
}

public class Users
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}

public class Roles
{
    public string RoleName { get; set; }
}

public class Images
{
    public string ImagePath { get; set; }
}

public class Posts
{
    public string TheActualPost { get; set; }
}

public class Comments
{
    public string TheComment { get; set; }
}