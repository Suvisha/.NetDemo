using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adosample
{
    class Customer
    {
        public int Id { get; set; }
        public string first_name{get;set;}
        public string last_name { get; set;}
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
    }
    class Program
    {
        static string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=SampleSql;Integrated Security=true";
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("1. Print Customers");
                Console.WriteLine("2. Insert Customer");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Update Customer");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Choice : ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1: PrintCustomers();
                        Console.ReadLine();
                        break;
                    case 2: Customer cu = new Customer();
                        Console.WriteLine("Enter the first Name:");
                        cu.first_name = Console.ReadLine();
                        Console.WriteLine("Enter the last Name:");
                        cu.last_name = Console.ReadLine();
                        Console.WriteLine("Enter the Email:");
                        cu.email = Console.ReadLine();
                        Console.WriteLine("Enter the Address:");
                        cu.address = Console.ReadLine();
                        Console.WriteLine("Enter the City:");
                        cu.city = Console.ReadLine();
                        InsertCustomer(cu);
                        break;
                    case 3: int id;
                        Console.WriteLine("Enter the Id of the Customer ");
                        id = Convert.ToInt32(Console.ReadLine());
                        DeleteCustomer(id);
                        break;

                }
            } while (n != 5);
        }
        private static void PrintCustomers()
        {
            Customer cu;
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("PrintCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                cu = new Customer();
                cu.Id = Convert.ToInt32(rd["customer_id"].ToString());
                cu.first_name = rd["first_name"].ToString();
                cu.last_name = rd["last_name"].ToString();
                cu.email = rd["email"].ToString();
                cu.address = rd["address"].ToString();
                cu.city = rd["city"].ToString();
                Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} {5} \n",cu.Id,cu.first_name,cu.last_name,cu.email,cu.address,cu.city);
            }
            rd.Close();
            con.Close();
        }
        private static void InsertCustomer(Customer custm)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("InsertCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@first_name", custm.first_name));
            cmd.Parameters.Add(new SqlParameter("@last_name", custm.last_name));
            cmd.Parameters.Add(new SqlParameter("@email", custm.email));
            cmd.Parameters.Add(new SqlParameter("@address", custm.address));
            cmd.Parameters.Add(new SqlParameter("@city", custm.city));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Insert successfully");
            con.Close();
        }
        private static void DeleteCustomer(int Id)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@c_id", Id));
            cmd.ExecuteNonQuery();
            Console.WriteLine("Customer Deleted Successfully");
            con.Close();
        }
    }
}
