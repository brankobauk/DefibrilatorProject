﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DefibrilatorProject.Worker.Jobs;
using Quartz;
using Quartz.Impl;

namespace DefibrilatorProject.Worker
{
    public class InitWorker
    {
        private readonly UpcomingServiceNotificationJob _upcommingServiceNotificationJob =
            new UpcomingServiceNotificationJob();
        public void StartWorker()
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central Europe Standard Time");
            var schedulerFactory = new StdSchedulerFactory();
            var scheduler = schedulerFactory.GetScheduler();

            //var upcomingServiceJob = JobBuilder.Create<UpcomingServiceNotificationJob>().Build();
            //var cronScheduleBuilder = CronScheduleBuilder.DailyAtHourAndMinute(13, 00).InTimeZone(timeZoneInfo);
            //var trigger = TriggerBuilder.Create().StartNow().WithSchedule(cronScheduleBuilder).Build();
            ////--var trigger = TriggerBuilder.Create().WithSimpleSchedule(x => x.WithIntervalInMinutes(5).RepeatForever()).Build();
            //scheduler.ScheduleJob(upcomingServiceJob, trigger);


            var keepAliveJob = JobBuilder.Create<KeepAliveJob>().Build();
            var keepAliveTrigger = TriggerBuilder.Create()
                .WithSimpleSchedule(x => x.WithIntervalInMinutes(5).RepeatForever())
                .Build();

            scheduler.ScheduleJob(keepAliveJob, keepAliveTrigger);

            scheduler.Start();

            var t = new Thread(StartThread);
            t.Start();        
        }

        private void StartThread()
        {
            while(true)
            {
                _upcommingServiceNotificationJob.Start();
                Thread.Sleep(7200000);
            }
        }
    }
}
