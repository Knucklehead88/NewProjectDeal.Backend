﻿using Core.Entities.OrderAggregate;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace Core.Entities.Identity
{
    public class BusinessInfo
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public List<BusinessInfoTrade> Trades { get; set; } = [];
        public string HourlyRate { get; set; }
        public string DailyRate { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string VideoPresentation { get; set; }
        public string Projects { get; set; }
        public List<BusinessInfoLocation> Locations { get; set; }
        public List<BusinessInfoLanguage> SpokenLanguages { get; set; } = [];
        public long StartDateOfWork { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}