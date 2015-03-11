using System.Net;
using Quartz;

namespace DefibrilatorProject.Worker.Jobs
{
    class KeepAliveJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (WebClient client = new WebClient())
            {
                const string applicationBaseUrl = "http://defibrilatorProject.apphb.com";
                client.DownloadString(applicationBaseUrl);
            }
        }
    }
}
