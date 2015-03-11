using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Workers;
using Quartz;

namespace DefibrilatorProject.Worker.Jobs
{
    
    public class UpcomingServiceNotificationJob : IJob
    {
        private readonly WorkerManager _workerManager = new WorkerManager();
        public void Execute(IJobExecutionContext context)
        {
            _workerManager.StartUpcomingServiceNotification();
        }
    }
}
