using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Layer
{
    public class Class1
    {
        public static List<Customers> GetList(string listType)
        {
            using (var context = new UWPC_TestEntities())
            {
                // setting parameter to pass to store procedure
                var listTypeParameter = new SqlParameter("@ListType", listType);

                
                // Storing results of store procedure
                var result = context.Database.SqlQuery<Customers>("splocal_ReturnCustomerList @ListType", listTypeParameter).ToList();

                return result;
            }
        }

    }

        #region Model
        public class Customers
        {
            public int id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string EmailAddress { get; set; }
            public int frid01 { get; set; }
            public int frid02 { get; set; }
            public string EmailType { get; set; }
            public string EmailTypeName { get; set; }
            public int EmailId { get; set; }
            public string Salutation { get; set; }
        }
    }
    #endregion 


