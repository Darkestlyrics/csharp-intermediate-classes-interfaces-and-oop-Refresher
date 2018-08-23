using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    sealed class DbCommand {
        public DbCommand() {

        }

        ~DbCommand() {

        }

        public DbConnection Connection {
            get;
            set; 
            
        }

        public string Command {
            get;
            set;
        }

        public void Execute() {
            Connection.Open();
            Console.WriteLine($"Executing Command \n {Command}");
            Connection.Close();
        }
    }
}