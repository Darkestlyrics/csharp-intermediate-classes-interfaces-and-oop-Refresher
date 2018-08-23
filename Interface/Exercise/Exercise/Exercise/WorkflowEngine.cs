using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise {
    public class WorkflowEngine {
        private int IsRunning;

        public WorkflowEngine() {
        
        }

        ~WorkflowEngine() {

        }

        public void Run(IWorkflow workflow) {
            workflow.Execute();
        }
    }
}