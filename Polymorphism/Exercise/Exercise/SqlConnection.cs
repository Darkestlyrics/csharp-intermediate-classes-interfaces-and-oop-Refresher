using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    public class SqlConnection : DbConnection {
        public SqlConnection() {

        }

        ~SqlConnection() {

        }

        public override void Close() {
            if (ConnectionState != ConnectionState.Connected) {
                throw new InvalidOperationException("Cannot close a Connection that is not open");
            } else {
                Console.WriteLine("Closing Connection");
                ConnectionState = ConnectionState.Disconnected;
                Console.WriteLine("Connection Closed");
            }
        }

        public override void Open() {
            if (string.IsNullOrEmpty(ConnectionString)) {
                throw new ArgumentException("Connection String cannot be null or empty");
            } else {
                Console.WriteLine("Initialising Connection");
                ConnectionState = ConnectionState.Connecting;
                Console.WriteLine("Opening Connection");
                ConnectionState = ConnectionState.Connected;
                Console.WriteLine("Connection Opened");
            }
        }
    }
}