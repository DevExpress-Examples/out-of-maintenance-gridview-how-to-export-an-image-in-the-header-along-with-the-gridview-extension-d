using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;

namespace CS.Model {
    public class MyModel {
        public static DataTable GetCategories() {
            DataTable dataTableCategories = new DataTable();
            
            using(OleDbConnection connection = GetConnection()) {
                OleDbDataAdapter adapter = new OleDbDataAdapter(string.Empty, connection);
                adapter.SelectCommand.CommandText = "SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]";
                adapter.Fill(dataTableCategories);
            }

            return dataTableCategories;
        }

        static OleDbConnection GetConnection() {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;

            return connection;
        }
    }

    public class MyViewModel {
        public DataTable Categories { get; set; }
        public DataTable Products { get; set; }
    }
}