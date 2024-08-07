﻿using System.Reflection.Metadata;

namespace Core.Entities.Identity
{
    public class Location: BaseEntity
    {
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public float[] Bbox { get; set; } = new float[4];
        public string MapBoxId { get; set; }
    }
}