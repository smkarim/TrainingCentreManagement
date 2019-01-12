﻿using System;
using TrainingCentreManagement.Models.Contracts;

namespace TrainingCentreManagement.Models.EntityModels.Location
{
    class Thana:IEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string EntityDescription { get; set; }
    }
}
