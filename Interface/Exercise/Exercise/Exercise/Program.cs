using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(new BuildWorkflow());
            workflowEngine.Run(new UploadWorkflow());
        }
    }
    class BuildWorkflow : IWorkflow {
        public void Execute() => Console.WriteLine("Building Project");
    }

    class UploadWorkflow : IWorkflow {
        public void Execute() => Console.WriteLine("Uploading Project");
    }

}
