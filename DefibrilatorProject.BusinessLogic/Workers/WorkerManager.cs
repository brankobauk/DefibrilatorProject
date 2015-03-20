using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Mails;

namespace DefibrilatorProject.BusinessLogic.Workers
{
    public class WorkerManager
    {
        private readonly MailManager _mailManager = new MailManager();
        public void StartUpcomingServiceNotification(string subject, string body, string from, string to)
        {
            _mailManager.SendEmail(subject, body, from, to);
        }
    }
}
