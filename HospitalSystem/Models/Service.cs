﻿namespace HospitalSystem.Models
{
    public class Service
    {

        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }

        public string? Description { get; set; }

        public string? Price { get; set; }
        public string? ImageURL { get; set; }

    }
}
