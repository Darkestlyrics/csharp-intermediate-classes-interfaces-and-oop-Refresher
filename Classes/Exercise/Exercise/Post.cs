using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    public class Post {
        private int Votes;

        public Post() {
            throw new System.NotImplementedException();
        }

        ~Post() {
            throw new System.NotImplementedException();
        }

        public string Title {
            get;
            set;
            
        }

        public string Description {
            get;
            set;
            
        }

        public DateTime DateCreated {
            get;
            set;
            
        }

        public int TotalVotes {
            get { return Votes; }
            set {
            }
            
        }

        public void UpVote() {
            Votes++;
        }

        public void DownVote() {
            Votes--;
        }
    }
}