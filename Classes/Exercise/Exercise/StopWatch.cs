using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    public class StopWatch {
        private bool IsRunning = false;
        private DateTime StartTime = new DateTime();

        public event EventHandler OnStart;
        public event EventHandler OnStop;

        public StopWatch() {

        }

        ~StopWatch() {
            
        }

        public TimeSpan Duration {
            get;
            set;
            
        }

        public void Start() {
            if (IsRunning) {
                throw new InvalidOperationException("StopWatch is already running!");
            } else {
                StartTime = DateTime.Now;
                IsRunning = true;
            }         
        }

        public void Stop() {
            if (!IsRunning) {
                throw new InvalidOperationException("StopWatch is not running!");
            }else {
                IsRunning = false;
                Duration = TimeSpan.FromTicks((DateTime.Now - StartTime).Ticks);
            }
        }

        public void Reset() {
            if (IsRunning) {
                IsRunning = false;
            }
            Duration = TimeSpan.Zero;
        }

    }
}