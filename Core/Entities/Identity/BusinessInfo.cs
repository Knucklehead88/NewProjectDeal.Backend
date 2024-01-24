﻿using Core.Entities.OrderAggregate;
using System.Data.Common;

namespace Core.Entities.Identity
{
    public class BusinessInfo
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public List<Trade> Trades { get; set; } = new();
        public string HourlyRate { get; set; }
        public string DailyRate { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string VideoPresentation { get; set; }
        public string Projects { get; set; }
        public List<Location> Locations { get; set; } = new();
        public string[] SpokenLanguages { get; set; }
        public int YearsOfExperience { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}