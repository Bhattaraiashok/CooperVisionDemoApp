﻿using Core.Interfaces;
using NepFlex.Core.Entities.ResourceModels;
using NepFlex.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepFlex.Core.Services
{
    public class ReportService:IReportService
    {
        private IUnitOfWork _unitOfWork { get; set; }
        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<ReportedData> getReportedData()
        {
            return _unitOfWork.ReportRepository.getReportedData();
        }
    }
}
