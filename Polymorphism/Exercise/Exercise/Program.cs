using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            DbCommand command = new DbCommand() {
                Command = "Select * from TableName",
                Connection = new SqlConnection() {
                    ConnectionString = "Connection String here",
                    TimeOut = new TimeSpan(1000)
                }
            };
            command.Execute();
        }
    }
}
