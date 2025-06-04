using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Students_MVVM.Model
{
    class DBHelper
    {
        static MySqlConnection conn;

        static DBHelper()
        {
            string connStr = "server=127.0.0.1;port=3306;username=root;password=root;database=Students";
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch(Exception e)
            {
                conn = null;
            }
        }

        List<Student> LoadData()
        {
            try
            {
                var students = new List<Student>();
                return students;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
