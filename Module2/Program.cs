using System;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUser myUser = new MyUser();

            myUser.UserName = "Alex";
            myUser.TotalViews = 100;
            myUser.Likes = 100;

            myUser.Comments = new List<string>();
            myUser.Comments.Add("this is good stuff");
            myUser.Comments.Add("wow, i love it");
            myUser.Comments.Add("ehh, i've seen better");


            Console.WriteLine("The user " + myUser.UserName + " has a total view of: "+ myUser.TotalViews + ", with this many likes: "+ myUser.Likes);

            Console.WriteLine("It has the following comments:");
            foreach (var item in myUser.Comments)
            {
                Console.WriteLine(item);
            }
        }
    }
}



public class MyUser
{
    public string UserName { get; set; }
    public int TotalViews { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; }
}

