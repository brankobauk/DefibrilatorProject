using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefibrilatorProject.BusinessLogic.Maintenances;

namespace DefibrilatorProject.BusinessLogic.Workers
{
    public class WorkerHandler
    {
        private readonly WorkerManager _workerManager = new WorkerManager();
        private readonly MaintenanceManager _maintenanceManager = new MaintenanceManager();
        public void StartUpcomingServiceNotification()
        {
            const string subject = "Defibrilator Project Upcoming Maintenance";
            string text = "Dears, <br><br>The Following Items Must BE Inspected!";
            text += GetMaintenanceTable();
            _workerManager.StartUpcomingServiceNotification(subject, text, "noreply@star2000.si", "branko@bauk.si");
        }

        private string GetMaintenanceTable()
        { 
            var table = "style=\"border:1px solid #000;border-width:1px 1px 0px 0px;text-align:left;\"";
            var th = "style=\"border:1px solid #000;border-width:0px 0px 2px 1px;text-align:left;background-color:#7ac0da;padding:2px\"";
            var td = "style=\"border:1px solid #000;border-width:0px 0px 1px 1px;text-align:left;padding:2px\"";

            var text = "<table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\" " + table + ">";
            text += "<tr>";
            text += "<th " + th + ">Company</th>";
            text += "<th " + th + ">Location</th>";
            text += "<th " + th + ">Product</th>";
            text += "<th " + th + ">Property</th>";
            text += "<th " + th + ">Maintenance</th>";
            text += "<th " + th + ">Next Maintenance</th>";
            text += "<th " + th + ">Notes</th>";
            text += "</tr>";
            var items = _maintenanceManager.GetItemsToService();
            foreach (var item in items)
            {
                text += "<tr>";
                text += "<td " + td + ">" + item.SoldProduct.Company.Name + "</td>";
                text += "<td " + td + ">" + item.SoldProduct.Location + "</td>";
                text += "<td " + td + ">" + item.SoldProduct.Product.Name + "</td>";
                text += "<td " + td + ">" + item.ProductProperty.Name + "</td>";
                text += "<td " + td + ">" + item.DateOfMainenance + "</td>";
                text += "<td " + td + ">" + item.DateOfMainenance.AddMonths(item.ProductProperty.ServiceRate).ToShortDateString() + "</td>";
                text += "<td " + td + ">" + item.Notes + "</td>";
                text += "</tr>";
            }
            
            text += "</table>";
            return text;
        }
    }
}
