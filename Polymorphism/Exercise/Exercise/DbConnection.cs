using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    public abstract class DbConnection {
        public string ConnectionString {
            get;
            set;

        }

        public TimeSpan TimeOut {
            get;
            set;

        }

        protected ConnectionState ConnectionState {
            get;
            set;
        }

        public abstract void Open();

        public abstract void Close();
    }
}