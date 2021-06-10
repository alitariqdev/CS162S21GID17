using RestaurantManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestaurantManagementSystem.Controllers
{
    public class RestaurantAPIController : ApiController
    {


        [HttpPost]
        public bool AddBranch(Branch obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("Files/branches.txt", true);
                writer.WriteLine(obj.Name + ",");
                //+"," + obj.DateOfBirth
                writer.Flush();
                writer.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Exception");
                return false;
            }
        }
        [HttpGet]
        public List<Branch> ListOfBranches()
        {

            List<Branch> data = new List<Branch>();

            StreamReader reader = new StreamReader("Files/branches.txt");

            String line = reader.ReadLine();

            while (!String.IsNullOrEmpty(line))
            {
                String[] arr = line.Split(',');
               Branch s = new Branch();
                s.Name = arr[0];
                //s.RegistrationNumber = arr[1];
                //s.DateOfBirth = DateTime.Parse(arr[2]);
                data.Add(s);

                line = reader.ReadLine();
            }
            return data;
        }




    }
}
