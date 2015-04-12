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
        private readonly WorkerHandler _workerHandler = new WorkerHandler();
        public void Execute(IJobExecutionContext context)
        {
            _workerHandler.StartUpcomingServiceNotification();
        }

        public void Start()
        {
            _workerHandler.StartUpcomingServiceNotification();
            //var sfc = 1;
        }
    }
}
