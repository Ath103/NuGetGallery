﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NuGet.Services.Http;
using NuGet.Services.ServiceModel;

namespace NuGet.Services.Jobs
{
    public class JobsManagementService : NuGetApiService
    {
        public JobsManagementService(ServiceHost host) : base("JobsManagement", host) { }
    }
}