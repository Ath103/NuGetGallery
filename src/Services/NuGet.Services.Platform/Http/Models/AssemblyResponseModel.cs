﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuGet.Services.Http.Models
{
    public class AssemblyResponseModel
    {
        public string FullName { get; set; }
        public string BuildBranch { get; set; }
        public string BuildCommit { get; set; }
        public DateTimeOffset BuildDate { get; set; }
        public Uri SourceCodeRepository { get; set; }

        public AssemblyResponseModel() { }
        public AssemblyResponseModel(AssemblyInformation info)
        {
            FullName = info.FullName.ToString();
            BuildBranch = info.BuildBranch;
            BuildCommit = info.BuildCommit;
            BuildDate = info.BuildDate;
            SourceCodeRepository = info.SourceCodeRepository;
        }
    }
}