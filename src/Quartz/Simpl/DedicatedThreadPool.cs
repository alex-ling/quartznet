﻿using System.Threading.Tasks;
using Quartz.Util;

namespace Quartz.Simpl
{
    public class DedicatedThreadPool : TaskSchedulingThreadPool
    {
        protected override TaskScheduler GetDefaultScheduler()
        {
            return new QueuedTaskScheduler(MaxConcurency);
        }
    }
}
