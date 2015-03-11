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
        public void StartUpcomingServiceNotification()
        {
            _mailManager.SendEmail("test", "test", "branko.bauk@gmail.com", "branko@bauk.si");
        }
    }
}
