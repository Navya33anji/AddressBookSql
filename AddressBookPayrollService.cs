using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPayrollService
{
    class AddressBookPayrollService
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public string AddressBook1FirstName { get; internal set; }
        public string AddressBook1City { get; internal set; }
        public int AddressBook1Age { get; internal set; }

        public void GetAllAdderess()
        {
            try
            {
                AddressModel AddressModel = new AddressModel();

                using (this.connection)
                {
                    string query = @"Select AddressBook1FirstName,AddressBook1LastName,Age,ModifiedDate from AddressModel";
                    this.connection.Open();
                    var cmd = new SqlCommand(query, this.connection);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            AddressModel.AddressBook1FirstName = dr.GetString(1);
                            AddressModel.AddressBook1FirstName = dr.GetString(1);
                            AddressModel.AddressBook1Age = dr.GetInt32(2);                                                      
                            AddressModel.AddressBook1City = dr.GetDateTime(6);

                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", AddressModel.AddressBook1FirstName, AddressModel.AddressBook1City, AddressModel.AddressBook1Age);
                            Console.WriteLine("\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dr.Close();



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.connection.Close();
            }
        }

        internal void GetAllAddress()
        {
            throw new NotImplementedException();
        }
    }
}
